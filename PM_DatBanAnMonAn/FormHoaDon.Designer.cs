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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listViewPhieuDat = new System.Windows.Forms.ListView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listViewHD = new System.Windows.Forms.ListView();
            this.buttonSua = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMaPD = new System.Windows.Forms.TextBox();
            this.buttonTKHD = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMaHD = new System.Windows.Forms.TextBox();
            this.buttonTKPD = new System.Windows.Forms.Button();
            this.buttonThanhToan = new System.Windows.Forms.Button();
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
            // listViewPhieuDat
            // 
            this.listViewPhieuDat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewPhieuDat.FullRowSelect = true;
            this.listViewPhieuDat.GridLines = true;
            this.listViewPhieuDat.Location = new System.Drawing.Point(3, 22);
            this.listViewPhieuDat.Name = "listViewPhieuDat";
            this.listViewPhieuDat.Size = new System.Drawing.Size(631, 464);
            this.listViewPhieuDat.TabIndex = 1;
            this.listViewPhieuDat.UseCompatibleStateImageBehavior = false;
            this.listViewPhieuDat.View = System.Windows.Forms.View.Details;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listViewHD);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(637, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(463, 668);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách  Phiếu đặt  đã thanh tón";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonTKHD);
            this.groupBox4.Controls.Add(this.textBoxMaHD);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox4.Location = new System.Drawing.Point(3, 486);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(457, 179);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tìm Kiếm";
            // 
            // listViewHD
            // 
            this.listViewHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewHD.FullRowSelect = true;
            this.listViewHD.GridLines = true;
            this.listViewHD.Location = new System.Drawing.Point(3, 22);
            this.listViewHD.Name = "listViewHD";
            this.listViewHD.Size = new System.Drawing.Size(457, 464);
            this.listViewHD.TabIndex = 1;
            this.listViewHD.UseCompatibleStateImageBehavior = false;
            this.listViewHD.View = System.Windows.Forms.View.Details;
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
            // textBoxMaPD
            // 
            this.textBoxMaPD.Location = new System.Drawing.Point(240, 91);
            this.textBoxMaPD.Name = "textBoxMaPD";
            this.textBoxMaPD.Size = new System.Drawing.Size(178, 26);
            this.textBoxMaPD.TabIndex = 1;
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
            // buttonXoa
            // 
            this.buttonXoa.Location = new System.Drawing.Point(240, 25);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(85, 39);
            this.buttonXoa.TabIndex = 1;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
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
            // textBoxMaHD
            // 
            this.textBoxMaHD.Location = new System.Drawing.Point(183, 88);
            this.textBoxMaHD.Name = "textBoxMaHD";
            this.textBoxMaHD.Size = new System.Drawing.Size(178, 26);
            this.textBoxMaHD.TabIndex = 1;
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
            // buttonThanhToan
            // 
            this.buttonThanhToan.Location = new System.Drawing.Point(515, 137);
            this.buttonThanhToan.Name = "buttonThanhToan";
            this.buttonThanhToan.Size = new System.Drawing.Size(110, 45);
            this.buttonThanhToan.TabIndex = 3;
            this.buttonThanhToan.Text = "Thanh Toán";
            this.buttonThanhToan.UseVisualStyleBackColor = true;
            // 
            // FormHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 668);
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
        private System.Windows.Forms.ListView listViewPhieuDat;
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
    }
}