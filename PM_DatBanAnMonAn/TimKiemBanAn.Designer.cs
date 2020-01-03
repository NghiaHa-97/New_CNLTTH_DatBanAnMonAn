namespace PM_DatBanAnMonAn
{
    partial class TimKiemBanAn
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownSoCho = new System.Windows.Forms.NumericUpDown();
            this.textBoxMaTimBA = new System.Windows.Forms.TextBox();
            this.comboBoxTrangThaiBA = new System.Windows.Forms.ComboBox();
            this.buttonMa = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSoCho)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxMaTimBA);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(549, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm Theo mã";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox3.Controls.Add(this.comboBoxTrangThaiBA);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 100);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(549, 232);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm Kiếm Theo  Trạng Thái";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonMa);
            this.groupBox2.Controls.Add(this.numericUpDownSoCho);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 229);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(549, 103);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Số Chỗ Ngồi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập mã";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chọn Trạng Thái";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Chọn Số Chỗ";
            // 
            // numericUpDownSoCho
            // 
            this.numericUpDownSoCho.Location = new System.Drawing.Point(230, 33);
            this.numericUpDownSoCho.Name = "numericUpDownSoCho";
            this.numericUpDownSoCho.Size = new System.Drawing.Size(86, 26);
            this.numericUpDownSoCho.TabIndex = 1;
            // 
            // textBoxMaTimBA
            // 
            this.textBoxMaTimBA.Location = new System.Drawing.Point(230, 25);
            this.textBoxMaTimBA.Name = "textBoxMaTimBA";
            this.textBoxMaTimBA.Size = new System.Drawing.Size(224, 26);
            this.textBoxMaTimBA.TabIndex = 1;
            // 
            // comboBoxTrangThaiBA
            // 
            this.comboBoxTrangThaiBA.FormattingEnabled = true;
            this.comboBoxTrangThaiBA.Location = new System.Drawing.Point(230, 33);
            this.comboBoxTrangThaiBA.Name = "comboBoxTrangThaiBA";
            this.comboBoxTrangThaiBA.Size = new System.Drawing.Size(224, 28);
            this.comboBoxTrangThaiBA.TabIndex = 1;
            // 
            // buttonMa
            // 
            this.buttonMa.Location = new System.Drawing.Point(462, 49);
            this.buttonMa.Name = "buttonMa";
            this.buttonMa.Size = new System.Drawing.Size(75, 48);
            this.buttonMa.TabIndex = 2;
            this.buttonMa.Text = "OK";
            this.buttonMa.UseVisualStyleBackColor = true;
            this.buttonMa.Click += new System.EventHandler(this.buttonMa_Click);
            // 
            // TimKiemBanAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 332);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "TimKiemBanAn";
            this.Text = "Tìm Kiếm Bàn ăn";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSoCho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonMa;
        public System.Windows.Forms.TextBox textBoxMaTimBA;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox comboBoxTrangThaiBA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.NumericUpDown numericUpDownSoCho;
        private System.Windows.Forms.Label label3;
    }
}