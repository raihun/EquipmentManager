using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipmentManager {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            this.loadTable();
            this.serialPort.Open();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            this.serialPort.Close();
        }

        private void loadTable() {
            DBManager db = new DBManager();

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
            });
        }
        
    }
}
