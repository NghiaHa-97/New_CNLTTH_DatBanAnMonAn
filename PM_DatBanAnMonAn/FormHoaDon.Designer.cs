namespace PM_DatBanAnMonAn
{
    partial class FormHoaDon
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listViewPhieuDat = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonThanhToan = new System.Windows.Forms.Button();
            this.buttonTKPD = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.textBoxMaPD = new System.Windows.Forms.TextBox();
            this.buttonSua = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listViewHD = new System.Windows.Forms.ListView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonTKHD = new System.Windows.Forms.Button();
            this.textBoxMaHD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listViewPhieuDat);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(637, 668);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phiếu đặt chưa được thanh toán";
            // 
            // listViewPhieuDat
            // 
            this.listViewPhieuDat.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listViewPhieuDat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewPhieuDat.FullRowSelect = true;
            this.listViewPhieuDat.GridLines = true;
            this.listViewPhieuDat.HideSelection = false;
            this.listViewPhieuDat.Location = new System.Drawing.Point(3, 22);
            this.listViewPhieuDat.Name = "listViewPhieuDat";
            this.listViewPhieuDat.Size = new System.Drawing.Size(631, 464);
            this.listViewPhieuDat.TabIndex = 1;
            this.listViewPhieuDat.UseCompatibleStateImageBehavior = false;
            this.listViewPhieuDat.View = System.Windows.Forms.View.Details;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonThanhToan);
            this.groupBox2.Controls.Add(this.buttonTKPD);
            this.groupBox2.Controls.Add(this.buttonXoa);
            this.groupBox2.Controls.Add(this.textBoxMaPD);
            this.groupBox2.Controls.Add(this.buttonSua);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(3, 486);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(631, 179);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức Năng";
            // 
            // buttonThanhToan
            // 
            this.buttonThanhToan.Location = new System.Drawing.Point(486, 94);
            this.buttonThanhToan.Name = "buttonThanhToan";
            this.buttonThanhToan.Size = new System.Drawing.Size(139, 88);
            this.buttonThanhToan.TabIndex = 3;
            this.buttonThanhToan.Text = "Thanh Toán";
            this.buttonThanhToan.UseVisualStyleBackColor = true;
            this.buttonThanhToan.Click += new System.EventHandler(this.buttonThanhToan_Click);
            // 
            // buttonTKPD
            // 
            this.buttonTKPD.Location = new System.Drawing.Point(240, 137);
            this.buttonTKPD.Name = "buttonTKPD";
            this.buttonTKPD.Size = new System.Drawing.Size(85, 39);
            this.buttonTKPD.TabIndex = 2;
            this.buttonTKPD.Text = "Tìm Kiếm";
            this.buttonTKPD.UseVisualStyleBackColor = true;
            // 
            // buttonXoa
            // 
            this.buttonXoa.Location = new System.Drawing.Point(240, 25);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(85, 39);
            this.buttonXoa.TabIndex = 1;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // textBoxMaPD
            // 
            this.textBoxMaPD.Location = new System.Drawing.Point(240, 91);
            this.textBoxMaPD.Name = "textBoxMaPD";
            this.textBoxMaPD.Size = new System.Drawing.Size(178, 26);
            this.textBoxMaPD.TabIndex = 1;
            // 
            // buttonSua
            // 
            this.buttonSua.Location = new System.Drawing.Point(89, 25);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(85, 39);
            this.buttonSua.TabIndex = 0;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "TNhaajp mã cần tìm";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listViewHD);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(637, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(604, 668);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách  Phiếu đặt  đã thanh tón";
            // 
            // listViewHD
            // 
            this.listViewHD.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15});
            this.listViewHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewHD.FullRowSelect = true;
            this.listViewHD.GridLines = true;
            this.listViewHD.HideSelection = false;
            this.listViewHD.Location = new System.Drawing.Point(3, 22);
            this.listViewHD.Name = "listViewHD";
            this.listViewHD.Size = new System.Drawing.Size(598, 464);
            this.listViewHD.TabIndex = 1;
            this.listViewHD.UseCompatibleStateImageBehavior = false;
            this.listViewHD.View = System.Windows.Forms.View.Details;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonTKHD);
            this.groupBox4.Controls.Add(this.textBoxMaHD);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox4.Location = new System.Drawing.Point(3, 486);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(598, 179);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tìm Kiếm";
            // 
            // buttonTKHD
            // 
            this.buttonTKHD.Location = new System.Drawing.Point(183, 139);
            this.buttonTKHD.Name = "buttonTKHD";
            this.buttonTKHD.Size = new System.Drawing.Size(85, 39);
            this.buttonTKHD.TabIndex = 2;
            this.buttonTKHD.Text = "Tìm Kiếm";
            this.buttonTKHD.UseVisualStyleBackColor = true;
            // 
            // textBoxMaHD
            // 
            this.textBoxMaHD.Location = new System.Drawing.Point(183, 88);
            this.textBoxMaHD.Name = "textBoxMaHD";
            this.textBoxMaHD.Size = new System.Drawing.Size(178, 26);
            this.textBoxMaHD.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập mã Hóa đơn";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Phiếu đặt";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã Nhân Viên";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên Nhân Viên";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tên Khách Hàng";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tên bàn";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Ngày Lập";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Tổng Tiền";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Mã HD";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Mã Phiếu đặt";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Mã Nhân Viên";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Họ Tên NV";
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Tên KH";
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Tên Bàn";
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Ngày Lập";
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Tổng Tiền";
            // 
            // FormHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 668);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormHoaDon";
            this.Text = "FormHoaDon";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonThanhToan;
        private System.Windows.Forms.Button buttonTKPD;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.TextBox textBoxMaPD;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView listViewHD;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonTKHD;
        private System.Windows.Forms.TextBox textBoxMaHD;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ListView listViewPhieuDat;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
    }
}