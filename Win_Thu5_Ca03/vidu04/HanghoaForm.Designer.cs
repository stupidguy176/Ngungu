namespace vidu04
{
    partial class HanghoaForm
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
            this.nhomHanghoaDataGridView = new System.Windows.Forms.DataGridView();
            this.hanghoaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hanghoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhomHanghoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nhomHanghoaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hanghoaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hanghoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomHanghoaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nhomHanghoaDataGridView
            // 
            this.nhomHanghoaDataGridView.AutoGenerateColumns = false;
            this.nhomHanghoaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nhomHanghoaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.nhomHanghoaDataGridView.DataSource = this.nhomHanghoaBindingSource;
            this.nhomHanghoaDataGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.nhomHanghoaDataGridView.Location = new System.Drawing.Point(0, 0);
            this.nhomHanghoaDataGridView.Name = "nhomHanghoaDataGridView";
            this.nhomHanghoaDataGridView.Size = new System.Drawing.Size(247, 339);
            this.nhomHanghoaDataGridView.TabIndex = 1;
            // 
            // hanghoaDataGridView
            // 
            this.hanghoaDataGridView.AutoGenerateColumns = false;
            this.hanghoaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hanghoaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.hanghoaDataGridView.DataSource = this.hanghoaBindingSource;
            this.hanghoaDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hanghoaDataGridView.Location = new System.Drawing.Point(247, 0);
            this.hanghoaDataGridView.Name = "hanghoaDataGridView";
            this.hanghoaDataGridView.Size = new System.Drawing.Size(528, 339);
            this.hanghoaDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "HanghoaId";
            this.dataGridViewTextBoxColumn3.HeaderText = "Mã";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 50;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TenHanghoa";
            this.dataGridViewTextBoxColumn4.HeaderText = "Tên hàng";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Giaban";
            this.dataGridViewTextBoxColumn5.HeaderText = "Giá bán";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "NhomHanghoaId";
            this.dataGridViewTextBoxColumn6.HeaderText = "Nhóm";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // hanghoaBindingSource
            // 
            this.hanghoaBindingSource.DataSource = typeof(vidu04.Hanghoa);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NhomHanghoaId";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenNhom";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên nhóm";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // nhomHanghoaBindingSource
            // 
            this.nhomHanghoaBindingSource.DataSource = typeof(vidu04.NhomHanghoa);
            this.nhomHanghoaBindingSource.PositionChanged += new System.EventHandler(this.nhomHanghoaBindingSource_PositionChanged);
            // 
            // HanghoaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 339);
            this.Controls.Add(this.hanghoaDataGridView);
            this.Controls.Add(this.nhomHanghoaDataGridView);
            this.Name = "HanghoaForm";
            this.Text = "Quản lý Hàng hóa";
            this.Load += new System.EventHandler(this.HanghoaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nhomHanghoaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hanghoaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hanghoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomHanghoaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource nhomHanghoaBindingSource;
        private System.Windows.Forms.DataGridView nhomHanghoaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource hanghoaBindingSource;
        private System.Windows.Forms.DataGridView hanghoaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}

