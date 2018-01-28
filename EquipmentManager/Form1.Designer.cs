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
            this.modemNumberBox = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.equipmentTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentImage)).BeginInit();
            this.modeGroup.SuspendLayout();
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
            // 
            // code
            // 
            this.code.Frozen = true;
            this.code.HeaderText = "番号";
            this.code.Name = "code";
            this.code.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.code.Width = 55;
            // 
            // name
            // 
            this.name.Frozen = true;
            this.name.HeaderText = "名称";
            this.name.Name = "name";
            this.name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.name.Width = 250;
            // 
            // model_number
            // 
            this.model_number.Frozen = true;
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
            this.remarks.Width = 320;
            // 
            // equipmentImage
            // 
            this.equipmentImage.Image = global::EquipmentManager.Properties.Resources.noimage;
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
            // modemNumberBox
            // 
            this.modemNumberBox.Location = new System.Drawing.Point(1008, 316);
            this.modemNumberBox.Name = "modemNumberBox";
            this.modemNumberBox.Size = new System.Drawing.Size(249, 19);
            this.modemNumberBox.TabIndex = 7;
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
            this.searchButton.Location = new System.Drawing.Point(138, 18);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(60, 25);
            this.searchButton.TabIndex = 16;
            this.searchButton.Text = "検 索";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(6, 18);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(60, 25);
            this.addButton.TabIndex = 17;
            this.addButton.Text = "追 加";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // inspectionButton
            // 
            this.inspectionButton.Location = new System.Drawing.Point(204, 18);
            this.inspectionButton.Name = "inspectionButton";
            this.inspectionButton.Size = new System.Drawing.Size(60, 25);
            this.inspectionButton.TabIndex = 18;
            this.inspectionButton.Text = "検 品";
            this.inspectionButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(72, 18);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(60, 25);
            this.deleteButton.TabIndex = 19;
            this.deleteButton.Text = "削 除";
            this.deleteButton.UseVisualStyleBackColor = true;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.modeGroup);
            this.Controls.Add(this.remarksLabel);
            this.Controls.Add(this.inspectionLabel);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.remarksBox);
            this.Controls.Add(this.inspectionBox);
            this.Controls.Add(this.numberBox);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.locationBox);
            this.Controls.Add(this.modemNumberBox);
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
            this.Text = "備品管理システム";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.equipmentTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentImage)).EndInit();
            this.modeGroup.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox modemNumberBox;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn model_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn location;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn inspection;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarks;
        private System.Windows.Forms.GroupBox modeGroup;
    }
}

