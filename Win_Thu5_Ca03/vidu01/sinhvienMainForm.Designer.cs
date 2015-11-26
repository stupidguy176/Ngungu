namespace vidu01
{
    partial class sinhvienMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label gioitinhLabel;
            System.Windows.Forms.Label hotenLabel;
            System.Windows.Forms.Label masoLabel;
            System.Windows.Forms.Label lopIdLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lopIdComboBox = new System.Windows.Forms.ComboBox();
            this.sinhvienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.XoaButton = new System.Windows.Forms.Button();
            this.DocFileButton = new System.Windows.Forms.Button();
            this.GhiFileButton = new System.Windows.Forms.Button();
            this.ThemButton = new System.Windows.Forms.Button();
            this.gioitinhCheckBox = new System.Windows.Forms.CheckBox();
            this.hotenTextBox = new System.Windows.Forms.TextBox();
            this.masoTextBox = new System.Windows.Forms.TextBox();
            this.sinhvienDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.LopId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.DocDB = new System.Windows.Forms.Button();
            gioitinhLabel = new System.Windows.Forms.Label();
            hotenLabel = new System.Windows.Forms.Label();
            masoLabel = new System.Windows.Forms.Label();
            lopIdLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sinhvienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhvienDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gioitinhLabel
            // 
            gioitinhLabel.AutoSize = true;
            gioitinhLabel.Location = new System.Drawing.Point(12, 82);
            gioitinhLabel.Name = "gioitinhLabel";
            gioitinhLabel.Size = new System.Drawing.Size(50, 13);
            gioitinhLabel.TabIndex = 0;
            gioitinhLabel.Text = "Giới tính:";
            // 
            // hotenLabel
            // 
            hotenLabel.AutoSize = true;
            hotenLabel.Location = new System.Drawing.Point(12, 54);
            hotenLabel.Name = "hotenLabel";
            hotenLabel.Size = new System.Drawing.Size(42, 13);
            hotenLabel.TabIndex = 2;
            hotenLabel.Text = "Họ tên:";
            // 
            // masoLabel
            // 
            masoLabel.AutoSize = true;
            masoLabel.Location = new System.Drawing.Point(12, 28);
            masoLabel.Name = "masoLabel";
            masoLabel.Size = new System.Drawing.Size(39, 13);
            masoLabel.TabIndex = 6;
            masoLabel.Text = "Mã số:";
            // 
            // lopIdLabel
            // 
            lopIdLabel.AutoSize = true;
            lopIdLabel.Location = new System.Drawing.Point(22, 127);
            lopIdLabel.Name = "lopIdLabel";
            lopIdLabel.Size = new System.Drawing.Size(40, 13);
            lopIdLabel.TabIndex = 11;
            lopIdLabel.Text = "Lop Id:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DocDB);
            this.groupBox1.Controls.Add(lopIdLabel);
            this.groupBox1.Controls.Add(this.lopIdComboBox);
            this.groupBox1.Controls.Add(this.XoaButton);
            this.groupBox1.Controls.Add(this.DocFileButton);
            this.groupBox1.Controls.Add(this.GhiFileButton);
            this.groupBox1.Controls.Add(this.ThemButton);
            this.groupBox1.Controls.Add(gioitinhLabel);
            this.groupBox1.Controls.Add(this.gioitinhCheckBox);
            this.groupBox1.Controls.Add(hotenLabel);
            this.groupBox1.Controls.Add(this.hotenTextBox);
            this.groupBox1.Controls.Add(masoLabel);
            this.groupBox1.Controls.Add(this.masoTextBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(575, 174);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // lopIdComboBox
            // 
            this.lopIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sinhvienBindingSource, "LopId", true));
            this.lopIdComboBox.DataSource = this.lopBindingSource;
            this.lopIdComboBox.DisplayMember = "LopDisplay";
            this.lopIdComboBox.FormattingEnabled = true;
            this.lopIdComboBox.Location = new System.Drawing.Point(68, 124);
            this.lopIdComboBox.Name = "lopIdComboBox";
            this.lopIdComboBox.Size = new System.Drawing.Size(197, 21);
            this.lopIdComboBox.TabIndex = 12;
            this.lopIdComboBox.ValueMember = "LopId";
            // 
            // sinhvienBindingSource
            // 
            this.sinhvienBindingSource.DataSource = typeof(vidu01.Sinhvien);
            // 
            // lopBindingSource
            // 
            this.lopBindingSource.DataSource = typeof(vidu01.Lop);
            // 
            // XoaButton
            // 
            this.XoaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.XoaButton.Location = new System.Drawing.Point(489, 35);
            this.XoaButton.Name = "XoaButton";
            this.XoaButton.Size = new System.Drawing.Size(74, 24);
            this.XoaButton.TabIndex = 11;
            this.XoaButton.Text = "Xóa";
            this.XoaButton.UseVisualStyleBackColor = true;
            this.XoaButton.Click += new System.EventHandler(this.XoaButton_Click);
            // 
            // DocFileButton
            // 
            this.DocFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DocFileButton.Location = new System.Drawing.Point(409, 101);
            this.DocFileButton.Name = "DocFileButton";
            this.DocFileButton.Size = new System.Drawing.Size(74, 24);
            this.DocFileButton.TabIndex = 10;
            this.DocFileButton.Text = "Đọc File";
            this.DocFileButton.UseVisualStyleBackColor = true;
            this.DocFileButton.Click += new System.EventHandler(this.DocFileButton_Click);
            // 
            // GhiFileButton
            // 
            this.GhiFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GhiFileButton.Location = new System.Drawing.Point(489, 100);
            this.GhiFileButton.Name = "GhiFileButton";
            this.GhiFileButton.Size = new System.Drawing.Size(74, 24);
            this.GhiFileButton.TabIndex = 9;
            this.GhiFileButton.Text = "Ghi File";
            this.GhiFileButton.UseVisualStyleBackColor = true;
            this.GhiFileButton.Click += new System.EventHandler(this.GhiFileButton_Click);
            // 
            // ThemButton
            // 
            this.ThemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ThemButton.Location = new System.Drawing.Point(409, 35);
            this.ThemButton.Name = "ThemButton";
            this.ThemButton.Size = new System.Drawing.Size(74, 24);
            this.ThemButton.TabIndex = 8;
            this.ThemButton.Text = "Thêm mới";
            this.ThemButton.UseVisualStyleBackColor = true;
            this.ThemButton.Click += new System.EventHandler(this.ThemButton_Click);
            // 
            // gioitinhCheckBox
            // 
            this.gioitinhCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.sinhvienBindingSource, "Gioitinh", true));
            this.gioitinhCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sinhvienBindingSource, "GoitinhString", true));
            this.gioitinhCheckBox.Location = new System.Drawing.Point(68, 77);
            this.gioitinhCheckBox.Name = "gioitinhCheckBox";
            this.gioitinhCheckBox.Size = new System.Drawing.Size(197, 24);
            this.gioitinhCheckBox.TabIndex = 1;
            this.gioitinhCheckBox.Text = "checkBox1";
            this.gioitinhCheckBox.UseVisualStyleBackColor = true;
            // 
            // hotenTextBox
            // 
            this.hotenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sinhvienBindingSource, "Hoten", true));
            this.hotenTextBox.Location = new System.Drawing.Point(68, 51);
            this.hotenTextBox.Name = "hotenTextBox";
            this.hotenTextBox.Size = new System.Drawing.Size(197, 20);
            this.hotenTextBox.TabIndex = 3;
            // 
            // masoTextBox
            // 
            this.masoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sinhvienBindingSource, "Maso", true));
            this.masoTextBox.Location = new System.Drawing.Point(68, 25);
            this.masoTextBox.Name = "masoTextBox";
            this.masoTextBox.Size = new System.Drawing.Size(197, 20);
            this.masoTextBox.TabIndex = 7;
            // 
            // sinhvienDataGridView
            // 
            this.sinhvienDataGridView.AutoGenerateColumns = false;
            this.sinhvienDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sinhvienDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewCheckBoxColumn1,
            this.LopId});
            this.sinhvienDataGridView.DataSource = this.sinhvienBindingSource;
            this.sinhvienDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sinhvienDataGridView.Location = new System.Drawing.Point(0, 174);
            this.sinhvienDataGridView.Name = "sinhvienDataGridView";
            this.sinhvienDataGridView.Size = new System.Drawing.Size(575, 130);
            this.sinhvienDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Maso";
            this.dataGridViewTextBoxColumn2.HeaderText = "Mã số";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Hoten";
            this.dataGridViewTextBoxColumn3.HeaderText = "Họ tên";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Gioitinh";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Giới tính";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // LopId
            // 
            this.LopId.DataPropertyName = "LopId";
            this.LopId.HeaderText = "Lớp";
            this.LopId.Name = "LopId";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.DataSource = this.sinhvienBindingSource;
            // 
            // DocDB
            // 
            this.DocDB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DocDB.Location = new System.Drawing.Point(409, 131);
            this.DocDB.Name = "DocDB";
            this.DocDB.Size = new System.Drawing.Size(74, 24);
            this.DocDB.TabIndex = 13;
            this.DocDB.Text = "Đọc DB";
            this.DocDB.UseVisualStyleBackColor = true;
            this.DocDB.Click += new System.EventHandler(this.DocDB_Click);
            // 
            // sinhvienMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 304);
            this.Controls.Add(this.sinhvienDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Name = "sinhvienMainForm";
            this.Text = "Quản lý sinh viên";
            this.Load += new System.EventHandler(this.sinhvienMainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sinhvienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhvienDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox gioitinhCheckBox;
        private System.Windows.Forms.BindingSource sinhvienBindingSource;
        private System.Windows.Forms.TextBox hotenTextBox;
        private System.Windows.Forms.TextBox masoTextBox;
        private System.Windows.Forms.DataGridView sinhvienDataGridView;
        private System.Windows.Forms.Button ThemButton;
        private System.Windows.Forms.Button GhiFileButton;
        private System.Windows.Forms.Button DocFileButton;
        private System.Windows.Forms.Button XoaButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.BindingSource lopBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn LopId;
        private System.Windows.Forms.ComboBox lopIdComboBox;
        private System.Windows.Forms.Button DocDB;
    }
}

