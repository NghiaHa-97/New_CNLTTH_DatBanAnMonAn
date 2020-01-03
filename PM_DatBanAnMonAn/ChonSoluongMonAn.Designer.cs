namespace PM_DatBanAnMonAn
{
    partial class ChonSoluongMonAn
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.labelGia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(338, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số Lượng";
            // 
            // numericUpDownSoLuong
            // 
            this.numericUpDownSoLuong.Location = new System.Drawing.Point(210, 52);
            this.numericUpDownSoLuong.Name = "numericUpDownSoLuong";
            this.numericUpDownSoLuong.Size = new System.Drawing.Size(159, 26);
            this.numericUpDownSoLuong.TabIndex = 2;
            this.numericUpDownSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSoLuong.ValueChanged += new System.EventHandler(this.numericUpDownSoLuong_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Giá";
            // 
            // labelGia
            // 
            this.labelGia.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelGia.Location = new System.Drawing.Point(206, 115);
            this.labelGia.Name = "labelGia";
            this.labelGia.Size = new System.Drawing.Size(159, 26);
            this.labelGia.TabIndex = 4;
            // 
            // ChonSoluongMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 304);
            this.Controls.Add(this.labelGia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownSoLuong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "ChonSoluongMonAn";
            this.Text = "Cọn Số Lượng Món Ăn";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.NumericUpDown numericUpDownSoLuong;
        public System.Windows.Forms.Label labelGia;
    }
}