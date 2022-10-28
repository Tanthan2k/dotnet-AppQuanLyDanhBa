
namespace AppQuanLyDanhBa
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewNhomLienLac = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewChiTiet = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labSDT = new System.Windows.Forms.Label();
            this.labEmail = new System.Windows.Forms.Label();
            this.labDiaChi = new System.Windows.Forms.Label();
            this.labTenGoi = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnThemNhom = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnXoaNhom = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnThemLienLac = new System.Windows.Forms.ToolStripButton();
            this.btnXoaLienlac = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.TenNhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenGoiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chiTietNhomLienLacViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhomLienLacViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhomLienLac)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiTiet)).BeginInit();
            this.panel3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietNhomLienLacViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomLienLacViewModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewNhomLienLac);
            this.panel1.Location = new System.Drawing.Point(3, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 496);
            this.panel1.TabIndex = 2;
            // 
            // dataGridViewNhomLienLac
            // 
            this.dataGridViewNhomLienLac.AllowUserToAddRows = false;
            this.dataGridViewNhomLienLac.AllowUserToDeleteRows = false;
            this.dataGridViewNhomLienLac.AutoGenerateColumns = false;
            this.dataGridViewNhomLienLac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNhomLienLac.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.TenNhom});
            this.dataGridViewNhomLienLac.DataSource = this.nhomLienLacViewModelBindingSource;
            this.dataGridViewNhomLienLac.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewNhomLienLac.Name = "dataGridViewNhomLienLac";
            this.dataGridViewNhomLienLac.ReadOnly = true;
            this.dataGridViewNhomLienLac.RowHeadersWidth = 51;
            this.dataGridViewNhomLienLac.RowTemplate.Height = 24;
            this.dataGridViewNhomLienLac.Size = new System.Drawing.Size(365, 493);
            this.dataGridViewNhomLienLac.TabIndex = 0;
            this.dataGridViewNhomLienLac.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNhomLienLac_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewChiTiet);
            this.panel2.Location = new System.Drawing.Point(385, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(743, 250);
            this.panel2.TabIndex = 3;
            // 
            // dataGridViewChiTiet
            // 
            this.dataGridViewChiTiet.AllowUserToAddRows = false;
            this.dataGridViewChiTiet.AllowUserToDeleteRows = false;
            this.dataGridViewChiTiet.AutoGenerateColumns = false;
            this.dataGridViewChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChiTiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenGoiDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.sDTDataGridViewTextBoxColumn});
            this.dataGridViewChiTiet.DataSource = this.chiTietNhomLienLacViewModelBindingSource;
            this.dataGridViewChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewChiTiet.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewChiTiet.MultiSelect = false;
            this.dataGridViewChiTiet.Name = "dataGridViewChiTiet";
            this.dataGridViewChiTiet.ReadOnly = true;
            this.dataGridViewChiTiet.RowHeadersWidth = 51;
            this.dataGridViewChiTiet.RowTemplate.Height = 24;
            this.dataGridViewChiTiet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewChiTiet.Size = new System.Drawing.Size(743, 250);
            this.dataGridViewChiTiet.TabIndex = 3;
            this.dataGridViewChiTiet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewChiTiet_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.labSDT);
            this.panel3.Controls.Add(this.labEmail);
            this.panel3.Controls.Add(this.labDiaChi);
            this.panel3.Controls.Add(this.labTenGoi);
            this.panel3.Controls.Add(this.toolStrip1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1131, 574);
            this.panel3.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(423, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(680, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "................................................................................." +
    "................................................................................" +
    ".......";
            // 
            // labSDT
            // 
            this.labSDT.AutoSize = true;
            this.labSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSDT.Location = new System.Drawing.Point(421, 503);
            this.labSDT.Name = "labSDT";
            this.labSDT.Size = new System.Drawing.Size(132, 25);
            this.labSDT.TabIndex = 19;
            this.labSDT.Text = "Số điện thoại:";
            // 
            // labEmail
            // 
            this.labEmail.AutoSize = true;
            this.labEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labEmail.Location = new System.Drawing.Point(421, 461);
            this.labEmail.Name = "labEmail";
            this.labEmail.Size = new System.Drawing.Size(71, 25);
            this.labEmail.TabIndex = 18;
            this.labEmail.Text = "Email: ";
            // 
            // labDiaChi
            // 
            this.labDiaChi.AutoSize = true;
            this.labDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDiaChi.Location = new System.Drawing.Point(421, 421);
            this.labDiaChi.Name = "labDiaChi";
            this.labDiaChi.Size = new System.Drawing.Size(82, 25);
            this.labDiaChi.TabIndex = 17;
            this.labDiaChi.Text = "Địa chỉ: ";
            // 
            // labTenGoi
            // 
            this.labTenGoi.AutoSize = true;
            this.labTenGoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTenGoi.Location = new System.Drawing.Point(419, 347);
            this.labTenGoi.Name = "labTenGoi";
            this.labTenGoi.Size = new System.Drawing.Size(71, 38);
            this.labTenGoi.TabIndex = 16;
            this.labTenGoi.Text = "[....]";
            this.labTenGoi.Click += new System.EventHandler(this.labTenGoi_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThemNhom,
            this.toolStripSeparator2,
            this.btnXoaNhom,
            this.toolStripSeparator1,
            this.btnThemLienLac,
            this.btnXoaLienlac,
            this.toolStripTextBox1,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1131, 27);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnThemNhom
            // 
            this.btnThemNhom.Image = ((System.Drawing.Image)(resources.GetObject("btnThemNhom.Image")));
            this.btnThemNhom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThemNhom.Name = "btnThemNhom";
            this.btnThemNhom.Size = new System.Drawing.Size(112, 24);
            this.btnThemNhom.Text = "Thêm nhóm";
            this.btnThemNhom.Click += new System.EventHandler(this.btnThemNhom_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // btnXoaNhom
            // 
            this.btnXoaNhom.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaNhom.Image")));
            this.btnXoaNhom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoaNhom.Name = "btnXoaNhom";
            this.btnXoaNhom.Size = new System.Drawing.Size(101, 24);
            this.btnXoaNhom.Text = "Xóa nhóm";
            this.btnXoaNhom.Click += new System.EventHandler(this.btnXoaNhom_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // btnThemLienLac
            // 
            this.btnThemLienLac.Image = ((System.Drawing.Image)(resources.GetObject("btnThemLienLac.Image")));
            this.btnThemLienLac.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThemLienLac.Name = "btnThemLienLac";
            this.btnThemLienLac.Size = new System.Drawing.Size(121, 24);
            this.btnThemLienLac.Text = "Thêm liên lạc";
            this.btnThemLienLac.Click += new System.EventHandler(this.btnThemLienLac_Click);
            // 
            // btnXoaLienlac
            // 
            this.btnXoaLienlac.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaLienlac.Image")));
            this.btnXoaLienlac.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoaLienlac.Name = "btnXoaLienlac";
            this.btnXoaLienlac.Size = new System.Drawing.Size(110, 24);
            this.btnXoaLienlac.Text = "Xóa liên lạc";
            this.btnXoaLienlac.Click += new System.EventHandler(this.btnXoaLienlac_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(300, 27);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(119, 24);
            this.toolStripLabel1.Text = "Nhập từ cần tìm:";
            // 
            // TenNhom
            // 
            this.TenNhom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenNhom.DataPropertyName = "TenNhom";
            this.TenNhom.HeaderText = "Tên nhóm liên lạc";
            this.TenNhom.MinimumWidth = 6;
            this.TenNhom.Name = "TenNhom";
            this.TenNhom.ReadOnly = true;
            // 
            // tenGoiDataGridViewTextBoxColumn
            // 
            this.tenGoiDataGridViewTextBoxColumn.DataPropertyName = "TenGoi";
            this.tenGoiDataGridViewTextBoxColumn.HeaderText = "Tên gọi";
            this.tenGoiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenGoiDataGridViewTextBoxColumn.Name = "tenGoiDataGridViewTextBoxColumn";
            this.tenGoiDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenGoiDataGridViewTextBoxColumn.Width = 200;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 200;
            // 
            // sDTDataGridViewTextBoxColumn
            // 
            this.sDTDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sDTDataGridViewTextBoxColumn.DataPropertyName = "SDT";
            this.sDTDataGridViewTextBoxColumn.HeaderText = "Số điện thoại";
            this.sDTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sDTDataGridViewTextBoxColumn.Name = "sDTDataGridViewTextBoxColumn";
            this.sDTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // chiTietNhomLienLacViewModelBindingSource
            // 
            this.chiTietNhomLienLacViewModelBindingSource.DataSource = typeof(AppQuanLyDanhBa.ViewModel.ChiTietNhomLienLacViewModel);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nhomLienLacViewModelBindingSource
            // 
            this.nhomLienLacViewModelBindingSource.DataSource = typeof(AppQuanLyDanhBa.ViewModel.NhomLienLacViewModel);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 598);
            this.Controls.Add(this.panel3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhomLienLac)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiTiet)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietNhomLienLacViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomLienLacViewModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource chiTietNhomLienLacViewModelBindingSource;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewChiTiet;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnThemNhom;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnXoaNhom;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnThemLienLac;
        private System.Windows.Forms.ToolStripButton btnXoaLienlac;
        private System.Windows.Forms.Label labSDT;
        private System.Windows.Forms.Label labEmail;
        private System.Windows.Forms.Label labDiaChi;
        private System.Windows.Forms.Label labTenGoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.BindingSource nhomLienLacViewModelBindingSource;
        private System.Windows.Forms.DataGridView dataGridViewNhomLienLac;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhom;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenGoiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
    }
}

