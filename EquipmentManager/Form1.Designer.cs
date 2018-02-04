namespace EquipmentManager {
    partial class MainForm {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.equipmentTable = new System.Windows.Forms.DataGridView();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.model_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inspection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipmentImage = new System.Windows.Forms.PictureBox();
            this.codeLabel = new System.Windows.Forms.Label();
            this.codeBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.modemNumberLabel = new System.Windows.Forms.Label();
            this.modelNumberBox = new System.Windows.Forms.TextBox();
            this.locationBox = new System.Windows.Forms.TextBox();
            this.locationLabel = new System.Windows.Forms.Label();
            this.numberBox = new System.Windows.Forms.TextBox();
            this.inspectionBox = new System.Windows.Forms.TextBox();
            this.remarksBox = new System.Windows.Forms.TextBox();
            this.numberLabel = new System.Windows.Forms.Label();
            this.inspectionLabel = new System.Windows.Forms.Label();
            this.remarksLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.inspectionButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.modeGroup = new System.Windows.Forms.GroupBox();
            this.executeButton = new System.Windows.Forms.Button();
            this.barcodeReaderSettingGroupBox = new System.Windows.Forms.GroupBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.portBox = new System.Windows.Forms.TextBox();
            this.portLabel = new System.Windows.Forms.Label();
            this.databaseGroupBox = new System.Windows.Forms.GroupBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.inspectionGroupBox = new System.Windows.Forms.GroupBox();
            this.clearInspectionButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentImage)).BeginInit();
            this.modeGroup.SuspendLayout();
            this.barcodeReaderSettingGroupBox.SuspendLayout();
            this.databaseGroupBox.SuspendLayout();
            this.inspectionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // equipmentTable
            // 
            this.equipmentTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.equipmentTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.code,
            this.name,
            this.model_number,
            this.location,
            this.number,
            this.inspection,
            this.remarks});
            this.equipmentTable.Location = new System.Drawing.Point(1, 1);
            this.equipmentTable.Name = "equipmentTable";
            this.equipmentTable.RowTemplate.Height = 21;
            this.equipmentTable.Size = new System.Drawing.Size(950, 678);
            this.equipmentTable.TabIndex = 0;
            this.equipmentTable.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.equipmentTable_RowEnter);
            // 
            // code
            // 
            this.code.HeaderText = "番号";
            this.code.Name = "code";
            this.code.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.code.Width = 55;
            // 
            // name
            // 
            this.name.HeaderText = "名称";
            this.name.Name = "name";
            this.name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.name.Width = 250;
            // 
            // model_number
            // 
            this.model_number.HeaderText = "型番";
            this.model_number.Name = "model_number";
            this.model_number.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // location
            // 
            this.location.HeaderText = "場所";
            this.location.Name = "location";
            this.location.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.location.Width = 55;
            // 
            // number
            // 
            this.number.HeaderText = "個数";
            this.number.Name = "number";
            this.number.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.number.Width = 55;
            // 
            // inspection
            // 
            this.inspection.HeaderText = "検品数";
            this.inspection.Name = "inspection";
            this.inspection.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.inspection.Width = 65;
            // 
            // remarks
            // 
            this.remarks.HeaderText = "備考";
            this.remarks.Name = "remarks";
            this.remarks.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.remarks.Width = 330;
            // 
            // equipmentImage
            // 
            this.equipmentImage.Image = ((System.Drawing.Image)(resources.GetObject("equipmentImage.Image")));
            this.equipmentImage.Location = new System.Drawing.Point(957, 57);
            this.equipmentImage.Name = "equipmentImage";
            this.equipmentImage.Size = new System.Drawing.Size(300, 200);
            this.equipmentImage.TabIndex = 1;
            this.equipmentImage.TabStop = false;
            // 
            // codeLabel
            // 
            this.codeLabel.AutoSize = true;
            this.codeLabel.Location = new System.Drawing.Point(955, 269);
            this.codeLabel.Name = "codeLabel";
            this.codeLabel.Size = new System.Drawing.Size(47, 12);
            this.codeLabel.TabIndex = 2;
            this.codeLabel.Text = "番　　号:";
            // 
            // codeBox
            // 
            this.codeBox.Location = new System.Drawing.Point(1008, 266);
            this.codeBox.Name = "codeBox";
            this.codeBox.Size = new System.Drawing.Size(249, 19);
            this.codeBox.TabIndex = 3;
            this.codeBox.TextChanged += new System.EventHandler(this.codeBox_TextChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(955, 294);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(47, 12);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "名　　称:";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(1008, 291);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(249, 19);
            this.nameBox.TabIndex = 5;
            // 
            // modemNumberLabel
            // 
            this.modemNumberLabel.AutoSize = true;
            this.modemNumberLabel.Location = new System.Drawing.Point(955, 319);
            this.modemNumberLabel.Name = "modemNumberLabel";
            this.modemNumberLabel.Size = new System.Drawing.Size(47, 12);
            this.modemNumberLabel.TabIndex = 6;
            this.modemNumberLabel.Text = "型　　番:";
            // 
            // modelNumberBox
            // 
            this.modelNumberBox.Location = new System.Drawing.Point(1008, 316);
            this.modelNumberBox.Name = "modelNumberBox";
            this.modelNumberBox.Size = new System.Drawing.Size(249, 19);
            this.modelNumberBox.TabIndex = 7;
            // 
            // locationBox
            // 
            this.locationBox.Location = new System.Drawing.Point(1008, 341);
            this.locationBox.Name = "locationBox";
            this.locationBox.Size = new System.Drawing.Size(249, 19);
            this.locationBox.TabIndex = 8;
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(955, 344);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(47, 12);
            this.locationLabel.TabIndex = 9;
            this.locationLabel.Text = "場　　所:";
            // 
            // numberBox
            // 
            this.numberBox.Location = new System.Drawing.Point(1008, 366);
            this.numberBox.Name = "numberBox";
            this.numberBox.Size = new System.Drawing.Size(249, 19);
            this.numberBox.TabIndex = 10;
            // 
            // inspectionBox
            // 
            this.inspectionBox.Enabled = false;
            this.inspectionBox.Location = new System.Drawing.Point(1008, 391);
            this.inspectionBox.Name = "inspectionBox";
            this.inspectionBox.Size = new System.Drawing.Size(249, 19);
            this.inspectionBox.TabIndex = 11;
            // 
            // remarksBox
            // 
            this.remarksBox.Location = new System.Drawing.Point(1008, 416);
            this.remarksBox.Name = "remarksBox";
            this.remarksBox.Size = new System.Drawing.Size(249, 19);
            this.remarksBox.TabIndex = 12;
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Location = new System.Drawing.Point(955, 369);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(47, 12);
            this.numberLabel.TabIndex = 13;
            this.numberLabel.Text = "個　　数:";
            // 
            // inspectionLabel
            // 
            this.inspectionLabel.AutoSize = true;
            this.inspectionLabel.Location = new System.Drawing.Point(955, 394);
            this.inspectionLabel.Name = "inspectionLabel";
            this.inspectionLabel.Size = new System.Drawing.Size(43, 12);
            this.inspectionLabel.TabIndex = 14;
            this.inspectionLabel.Text = "検品数:";
            // 
            // remarksLabel
            // 
            this.remarksLabel.AutoSize = true;
            this.remarksLabel.Location = new System.Drawing.Point(955, 419);
            this.remarksLabel.Name = "remarksLabel";
            this.remarksLabel.Size = new System.Drawing.Size(47, 12);
            this.remarksLabel.TabIndex = 15;
            this.remarksLabel.Text = "備　　考:";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(154, 18);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(68, 25);
            this.searchButton.TabIndex = 16;
            this.searchButton.Text = "検 索";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // addButton
            // 
            this.addButton.Enabled = false;
            this.addButton.Location = new System.Drawing.Point(6, 18);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(68, 25);
            this.addButton.TabIndex = 17;
            this.addButton.Text = "追 加";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // inspectionButton
            // 
            this.inspectionButton.Location = new System.Drawing.Point(228, 18);
            this.inspectionButton.Name = "inspectionButton";
            this.inspectionButton.Size = new System.Drawing.Size(68, 25);
            this.inspectionButton.TabIndex = 18;
            this.inspectionButton.Text = "検 品";
            this.inspectionButton.UseVisualStyleBackColor = true;
            this.inspectionButton.Click += new System.EventHandler(this.inspectionButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(80, 18);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(68, 25);
            this.deleteButton.TabIndex = 19;
            this.deleteButton.Text = "削 除";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // serialPort
            // 
            this.serialPort.PortName = "COM3";
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // modeGroup
            // 
            this.modeGroup.Controls.Add(this.addButton);
            this.modeGroup.Controls.Add(this.inspectionButton);
            this.modeGroup.Controls.Add(this.deleteButton);
            this.modeGroup.Controls.Add(this.searchButton);
            this.modeGroup.Location = new System.Drawing.Point(957, 1);
            this.modeGroup.Name = "modeGroup";
            this.modeGroup.Size = new System.Drawing.Size(300, 50);
            this.modeGroup.TabIndex = 20;
            this.modeGroup.TabStop = false;
            this.modeGroup.Text = "■ 動作モード選択";
            // 
            // executeButton
            // 
            this.executeButton.Location = new System.Drawing.Point(957, 448);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(300, 40);
            this.executeButton.TabIndex = 21;
            this.executeButton.Text = "新規追加";
            this.executeButton.UseVisualStyleBackColor = true;
            this.executeButton.Click += new System.EventHandler(this.executeButton_Click);
            // 
            // barcodeReaderSettingGroupBox
            // 
            this.barcodeReaderSettingGroupBox.Controls.Add(this.connectButton);
            this.barcodeReaderSettingGroupBox.Controls.Add(this.portBox);
            this.barcodeReaderSettingGroupBox.Controls.Add(this.portLabel);
            this.barcodeReaderSettingGroupBox.Location = new System.Drawing.Point(957, 637);
            this.barcodeReaderSettingGroupBox.Name = "barcodeReaderSettingGroupBox";
            this.barcodeReaderSettingGroupBox.Size = new System.Drawing.Size(300, 42);
            this.barcodeReaderSettingGroupBox.TabIndex = 22;
            this.barcodeReaderSettingGroupBox.TabStop = false;
            this.barcodeReaderSettingGroupBox.Text = "■ バーコードリーダー 設定";
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(241, 14);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(54, 23);
            this.connectButton.TabIndex = 2;
            this.connectButton.Text = "接続";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // portBox
            // 
            this.portBox.Location = new System.Drawing.Point(73, 16);
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(55, 19);
            this.portBox.TabIndex = 1;
            this.portBox.Text = "COM1";
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(7, 19);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(60, 12);
            this.portLabel.TabIndex = 0;
            this.portLabel.Text = "COMポート:";
            // 
            // databaseGroupBox
            // 
            this.databaseGroupBox.Controls.Add(this.saveButton);
            this.databaseGroupBox.Location = new System.Drawing.Point(957, 589);
            this.databaseGroupBox.Name = "databaseGroupBox";
            this.databaseGroupBox.Size = new System.Drawing.Size(146, 42);
            this.databaseGroupBox.TabIndex = 23;
            this.databaseGroupBox.TabStop = false;
            this.databaseGroupBox.Text = "■ データベース 操作";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(6, 13);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(54, 23);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "保存";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(957, 494);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(300, 23);
            this.clearButton.TabIndex = 24;
            this.clearButton.Text = "クリア";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // inspectionGroupBox
            // 
            this.inspectionGroupBox.Controls.Add(this.clearInspectionButton);
            this.inspectionGroupBox.Location = new System.Drawing.Point(1111, 589);
            this.inspectionGroupBox.Name = "inspectionGroupBox";
            this.inspectionGroupBox.Size = new System.Drawing.Size(146, 42);
            this.inspectionGroupBox.TabIndex = 25;
            this.inspectionGroupBox.TabStop = false;
            this.inspectionGroupBox.Text = "■ 検品モード 操作";
            // 
            // clearInspectionButton
            // 
            this.clearInspectionButton.Location = new System.Drawing.Point(6, 13);
            this.clearInspectionButton.Name = "clearInspectionButton";
            this.clearInspectionButton.Size = new System.Drawing.Size(108, 23);
            this.clearInspectionButton.TabIndex = 3;
            this.clearInspectionButton.Text = "検品数0クリア";
            this.clearInspectionButton.UseVisualStyleBackColor = true;
            this.clearInspectionButton.Click += new System.EventHandler(this.clearInspectionButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.inspectionGroupBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.databaseGroupBox);
            this.Controls.Add(this.barcodeReaderSettingGroupBox);
            this.Controls.Add(this.executeButton);
            this.Controls.Add(this.modeGroup);
            this.Controls.Add(this.remarksLabel);
            this.Controls.Add(this.inspectionLabel);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.remarksBox);
            this.Controls.Add(this.inspectionBox);
            this.Controls.Add(this.numberBox);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.locationBox);
            this.Controls.Add(this.modelNumberBox);
            this.Controls.Add(this.modemNumberLabel);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.codeBox);
            this.Controls.Add(this.codeLabel);
            this.Controls.Add(this.equipmentImage);
            this.Controls.Add(this.equipmentTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "備品管理システム (v1.0.1)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.equipmentTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentImage)).EndInit();
            this.modeGroup.ResumeLayout(false);
            this.barcodeReaderSettingGroupBox.ResumeLayout(false);
            this.barcodeReaderSettingGroupBox.PerformLayout();
            this.databaseGroupBox.ResumeLayout(false);
            this.inspectionGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView equipmentTable;
        private System.Windows.Forms.PictureBox equipmentImage;
        private System.Windows.Forms.Label codeLabel;
        private System.Windows.Forms.TextBox codeBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label modemNumberLabel;
        private System.Windows.Forms.TextBox modelNumberBox;
        private System.Windows.Forms.TextBox locationBox;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.TextBox numberBox;
        private System.Windows.Forms.TextBox inspectionBox;
        private System.Windows.Forms.TextBox remarksBox;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.Label inspectionLabel;
        private System.Windows.Forms.Label remarksLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button inspectionButton;
        private System.Windows.Forms.Button deleteButton;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.GroupBox modeGroup;
        private System.Windows.Forms.Button executeButton;
        private System.Windows.Forms.GroupBox barcodeReaderSettingGroupBox;
        private System.Windows.Forms.TextBox portBox;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.GroupBox databaseGroupBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn model_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn location;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn inspection;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarks;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.GroupBox inspectionGroupBox;
        private System.Windows.Forms.Button clearInspectionButton;
    }
}

