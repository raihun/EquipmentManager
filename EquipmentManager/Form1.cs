using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data; // DataTable
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipmentManager {
    public partial class MainForm : Form {

        private DBManager db = new DBManager();
        private string mode = "add";

        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            this.loadTable();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            // データベース Close
            this.db.disconnect();

            // シリアル通信 切断
            if (this.serialPort.IsOpen) {
                this.serialPort.Close();
            }
        }

        private void loadTable() {
            this.equipmentTable.AutoGenerateColumns = false;
            this.equipmentTable.DataSource = db.load();

            // 番号(code) 列 追加
            this.equipmentTable.Columns[0].DataPropertyName = "code"; // dataTableと対応させる
            // 名称(name) 列 追加
            this.equipmentTable.Columns[1].DataPropertyName = "name"; // dataTableと対応させる
            // 型番(model_number) 列 追加
            this.equipmentTable.Columns[2].DataPropertyName = "model_number"; // dataTableと対応させる
            // 場所(location) 列 追加
            this.equipmentTable.Columns[3].DataPropertyName = "location"; // dataTableと対応させる
            // 個数(number) 列 追加
            this.equipmentTable.Columns[4].DataPropertyName = "number"; // dataTableと対応させる
            // 検品数(inspection) 列 追加
            this.equipmentTable.Columns[5].DataPropertyName = "inspection"; // dataTableと対応させる
            // 備考(remarks) 列 追加
            this.equipmentTable.Columns[6].DataPropertyName = "remarks"; // dataTableと対応させる
        }

        #region モード選択ボタン
        private void addButton_Click(object sender, EventArgs e) {
            // ボタンの有効・無効化
            this.addButton.Enabled = false;
            this.deleteButton.Enabled = true;
            this.searchButton.Enabled = true;
            this.inspectionButton.Enabled = true;

            // モード切替
            this.mode = "add";
            this.executeButton.Text = "新規追加";

            // UI切替
            this.codeBox.Enabled = true;
            this.nameBox.Enabled = true;
            this.modelNumberBox.Enabled = true;
            this.locationBox.Enabled = true;
            this.numberBox.Enabled = true;
            this.inspectionBox.Enabled = false;
            this.remarksBox.Enabled = true;
        }

        private void deleteButton_Click(object sender, EventArgs e) {
            // ボタンの有効・無効化
            this.addButton.Enabled = true;
            this.deleteButton.Enabled = false;
            this.searchButton.Enabled = true;
            this.inspectionButton.Enabled = true;

            // モード切替
            this.mode = "delete";
            this.executeButton.Text = "削除";

            // UI切替
            this.codeBox.Enabled = false;
            this.nameBox.Enabled = false;
            this.modelNumberBox.Enabled = false;
            this.locationBox.Enabled = false;
            this.numberBox.Enabled = false;
            this.inspectionBox.Enabled = false;
            this.remarksBox.Enabled = false;
        }

        private void searchButton_Click(object sender, EventArgs e) {
            MessageBox.Show("未実装", "Error");
            return;

            // ボタンの有効・無効化
            this.addButton.Enabled = true;
            this.deleteButton.Enabled = true;
            this.searchButton.Enabled = false;
            this.inspectionButton.Enabled = true;

            // モード切替
            this.mode = "search";
            this.executeButton.Text = "検索 (部分一致)";

            // UI切替
            this.codeBox.Enabled = true;
            this.nameBox.Enabled = true;
            this.modelNumberBox.Enabled = true;
            this.locationBox.Enabled = true;
            this.numberBox.Enabled = true;
            this.inspectionBox.Enabled = true;
            this.remarksBox.Enabled = true;
        }

        private void inspectionButton_Click(object sender, EventArgs e) {
            // ボタンの有効・無効化
            this.addButton.Enabled = true;
            this.deleteButton.Enabled = true;
            this.searchButton.Enabled = true;
            this.inspectionButton.Enabled = false;

            // モード切替
            this.mode = "inspection";
            this.executeButton.Text = "検品";

            // UI切替
            this.codeBox.Enabled = true;
            this.nameBox.Enabled = false;
            this.modelNumberBox.Enabled = false;
            this.locationBox.Enabled = false;
            this.numberBox.Enabled = false;
            this.inspectionBox.Enabled = true;
            this.remarksBox.Enabled = false;
        }

        #endregion

        #region 実行ボタン動作
        private void executeButton_Click(object sender, EventArgs e) {
            switch(this.mode) {
                case "add":
                    this.executeAdd();
                    break;
                case "delete":
                    this.executeDelete();
                    break;
                case "search":
                    this.executeSearch();
                    break;
                case "inspection":
                    this.executeInspection();
                    break;
            }
        }

        private void executeAdd() {
            // 必須
            DataTable dt = this.db.getDataTable();

            // フォーマットチェック
            string code = this.codeBox.Text;
            string name = this.nameBox.Text;
            string modelNumber = this.modelNumberBox.Text;
            string location = this.locationBox.Text;
            string number = this.numberBox.Text;
            string remarks = this.remarksBox.Text;

            if(code == "" || name == "" || number == "") {
                MessageBox.Show("番号、名称、個数は必須入力項目です。", "Error");
                return;
            }

            if(code.Length != 7) {
                MessageBox.Show("番号は1000000～9999999の間で入力してください。", "Error");
                return;
            }

            // 重複チェック
            if(dt.Select(String.Format("code = {0}", code)).Length > 0) {
                MessageBox.Show("同じ番号が存在します。", "Error");
                return;
            }

            // 追加
            DataRow dr = dt.NewRow();
            dr["code"] = int.Parse(code);
            dr["name"] = name;
            dr["model_number"] = modelNumber;
            dr["location"] = location;
            dr["number"] = int.Parse(number);
            dr["inspection"] = 0;
            dr["remarks"] = remarks;
            dt.Rows.Add(dr);

            // クリア
            this.clearBox(true);
        }
        private void executeDelete() {
            string code = this.codeBox.Text;
            if(code == "") {
                MessageBox.Show("削除したい行を選択してください。", "Error");
                return;
            }

            DataTable dt = this.db.getDataTable();
            DataRow[] dr = dt.Select(String.Format("code = {0}", code));
            foreach(DataRow _dr in dr) {
                _dr.Delete();
            }
        }
        private void executeSearch() {

        }
        private void executeInspection() {
            string code = this.codeBox.Text;
            int inspection = int.Parse(this.inspectionBox.Text);

            DataTable dt = this.db.getDataTable();
            DataRow[] drs = dt.Select(String.Format("code = {0}", code));
            foreach (DataRow _dr in drs) {
                _dr["inspection"] = inspection;
            }
        }

        private void codeBox_TextChanged(object sender, EventArgs e) {
            DataTable dt = this.db.getDataTable();
            string code = this.codeBox.Text;

            // 検品モード時に、コード欄の変更
            if (mode.Equals("inspection")) {
                if (code.Equals("")) return; // 空欄
                this.reflectBox(code);
            }
        }

        private void clearBox(bool code) {
            // クリア
            if (code) { // code欄も含めるか
                this.codeBox.Text = "";
            }
            this.nameBox.Text = "";
            this.modelNumberBox.Text = "";
            this.locationBox.Text = "";
            this.numberBox.Text = "";
            this.inspectionBox.Text = "";
            this.remarksBox.Text = "";
        }
        #endregion

        #region クリアボタン 操作
        private void clearButton_Click(object sender, EventArgs e) {
            this.clearBox(true);
        }
        #endregion

        #region データベース 操作
        private void saveButton_Click(object sender, EventArgs e) {
            this.db.update();
        }
        #endregion

        #region バーコードリーダー 設定
        private void connectButton_Click(object sender, EventArgs e) {
            
            if(this.serialPort.IsOpen == false) {
                // 接続
                this.serialPort.PortName = this.portBox.Text;
                try {
                    this.serialPort.Open();
                } catch(Exception ex) {
                    MessageBox.Show("シリアル通信 接続に失敗しました。", "Error");
                    return;
                }

                // UI切替
                this.connectButton.Text = "切断";
                this.portBox.Enabled = false;
            } else {
                // 切断
                this.serialPort.Close();

                // UI切替
                this.connectButton.Text = "接続";
                this.portBox.Enabled = true;
            }
            
        }


        #endregion

        #region バーコードリーダー イベント
        private void serialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e) {
            // バーコードリーダーより受信
            string receive = this.serialPort.ReadLine().ToString();

            // 改行コード除去
            receive = receive.Replace("\r", "").Replace("\n", "");

            // フォーマットチェック
            Barcode b = new Barcode();
            int code = b.checkCode(receive);
            if (code < 0) return;

            // 反映
            this.Invoke((MethodInvoker)delegate {
                this.codeBox.Text = String.Format("{0}", code);
                this.reflectBox(code);
            });
        }
        #endregion

        private void equipmentTable_RowEnter(object sender, DataGridViewCellEventArgs e) {
            if (mode.Equals("delete") || mode.Equals("inspection")) {
                int i = e.RowIndex;
                this.reflectBox(String.Format("{0}", this.equipmentTable.Rows[i].Cells[0].Value));
            }
        }

        #region 番号を基に各入力欄へ反映
        private bool reflectBox(int code) {
            return this.reflectBox(String.Format("{0}", code));
        }

        private bool reflectBox(string code) {
            bool find = false;
            if (code.Equals("")) return find; // 空欄チェック

            DataTable dt = this.db.getDataTable();
            DataRow[] drs = dt.Select(String.Format("code = {0}", code));
            foreach (DataRow _dr in drs) {
                // 反映
                this.codeBox.Text = _dr["code"].ToString();
                this.nameBox.Text = _dr["name"].ToString();
                this.modelNumberBox.Text = _dr["model_number"].ToString();
                this.locationBox.Text = _dr["location"].ToString();
                this.numberBox.Text = _dr["number"].ToString();
                this.inspectionBox.Text = _dr["inspection"].ToString();
                this.remarksBox.Text = _dr["remarks"].ToString();

                //フォーカス
                int index = dt.Rows.IndexOf(_dr);
                Console.WriteLine(index);
                this.equipmentTable.FirstDisplayedScrollingRowIndex = index;
                find = true;
                break;
            }

            if(find) {
                // equipmentTableに該当コードが存在

            } else {
                // equipmentTableに該当コードがない
                this.clearBox(false);
            }

            return find;
        }

        
        #endregion
    }
}
