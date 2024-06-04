namespace CNPM_GaraOto.UI.ChucNang.ThayDoiQuyDinh
{
    partial class ThayDoiQuyDinh
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            SoXeTiepNhan_TextBox = new TextBox();
            LuuSoXe_Button = new Button();
            ThemHieuXe_Button = new Button();
            label4 = new Label();
            TenHieuXeMoi_TextBox = new TextBox();
            DanhSachHieuXe_Button = new Button();
            LuuTiLe_Button = new Button();
            TiLeDonGiaNhapBan_TextBox = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 20F);
            label1.Location = new Point(203, 7);
            label1.Name = "label1";
            label1.Size = new Size(848, 75);
            label1.TabIndex = 0;
            label1.Text = "THAY ĐỔI CÁC QUY ĐỊNH";
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = Properties.Resources.manhinhchinh;
            pictureBox1.ImageLocation = "Center";
            pictureBox1.InitialImage = Properties.Resources.manhinhchinh;
            pictureBox1.Location = new Point(0, 166);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(806, 190);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(14, 99);
            label2.Name = "label2";
            label2.Size = new Size(433, 32);
            label2.TabIndex = 3;
            label2.Text = "Số xe tiếp nhận tối đa trong ngày:";
            // 
            // SoXeTiepNhan_TextBox
            // 
            SoXeTiepNhan_TextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            SoXeTiepNhan_TextBox.Location = new Point(240, 96);
            SoXeTiepNhan_TextBox.Name = "SoXeTiepNhan_TextBox";
            SoXeTiepNhan_TextBox.Size = new Size(57, 39);
            SoXeTiepNhan_TextBox.TabIndex = 4;
            // 
            // LuuSoXe_Button
            // 
            LuuSoXe_Button.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LuuSoXe_Button.BackColor = SystemColors.ActiveCaptionText;
            LuuSoXe_Button.ForeColor = SystemColors.ButtonHighlight;
            LuuSoXe_Button.Location = new Point(297, 92);
            LuuSoXe_Button.Name = "LuuSoXe_Button";
            LuuSoXe_Button.Size = new Size(73, 36);
            LuuSoXe_Button.TabIndex = 5;
            LuuSoXe_Button.Text = "Lưu";
            LuuSoXe_Button.UseVisualStyleBackColor = false;
            LuuSoXe_Button.Click += button3_Click;
            // 
            // ThemHieuXe_Button
            // 
            ThemHieuXe_Button.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ThemHieuXe_Button.BackColor = SystemColors.ActiveCaptionText;
            ThemHieuXe_Button.ForeColor = SystemColors.ButtonHighlight;
            ThemHieuXe_Button.Location = new Point(297, 57);
            ThemHieuXe_Button.Name = "ThemHieuXe_Button";
            ThemHieuXe_Button.Size = new Size(73, 33);
            ThemHieuXe_Button.TabIndex = 11;
            ThemHieuXe_Button.Text = "Thêm";
            ThemHieuXe_Button.UseVisualStyleBackColor = false;
            ThemHieuXe_Button.Click += button2_Click_1;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(14, 64);
            label4.Name = "label4";
            label4.Size = new Size(183, 32);
            label4.TabIndex = 9;
            label4.Text = "Thêm hiệu xe";
            // 
            // TenHieuXeMoi_TextBox
            // 
            TenHieuXeMoi_TextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TenHieuXeMoi_TextBox.Location = new Point(112, 60);
            TenHieuXeMoi_TextBox.Name = "TenHieuXeMoi_TextBox";
            TenHieuXeMoi_TextBox.Size = new Size(185, 39);
            TenHieuXeMoi_TextBox.TabIndex = 12;
            // 
            // DanhSachHieuXe_Button
            // 
            DanhSachHieuXe_Button.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            DanhSachHieuXe_Button.BackColor = SystemColors.ActiveCaptionText;
            DanhSachHieuXe_Button.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DanhSachHieuXe_Button.ForeColor = SystemColors.ButtonHighlight;
            DanhSachHieuXe_Button.Location = new Point(390, 58);
            DanhSachHieuXe_Button.Name = "DanhSachHieuXe_Button";
            DanhSachHieuXe_Button.Size = new Size(356, 43);
            DanhSachHieuXe_Button.TabIndex = 13;
            DanhSachHieuXe_Button.Text = "Xem các hiệu xe";
            DanhSachHieuXe_Button.UseVisualStyleBackColor = false;
            DanhSachHieuXe_Button.Click += button4_Click;
            // 
            // LuuTiLe_Button
            // 
            LuuTiLe_Button.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LuuTiLe_Button.BackColor = SystemColors.ActiveCaptionText;
            LuuTiLe_Button.ForeColor = SystemColors.ButtonHighlight;
            LuuTiLe_Button.Location = new Point(297, 131);
            LuuTiLe_Button.Name = "LuuTiLe_Button";
            LuuTiLe_Button.Size = new Size(73, 37);
            LuuTiLe_Button.TabIndex = 16;
            LuuTiLe_Button.Text = "Lưu";
            LuuTiLe_Button.UseVisualStyleBackColor = false;
            LuuTiLe_Button.Click += button5_Click;
            // 
            // TiLeDonGiaNhapBan_TextBox
            // 
            TiLeDonGiaNhapBan_TextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TiLeDonGiaNhapBan_TextBox.Location = new Point(240, 134);
            TiLeDonGiaNhapBan_TextBox.Name = "TiLeDonGiaNhapBan_TextBox";
            TiLeDonGiaNhapBan_TextBox.Size = new Size(57, 39);
            TiLeDonGiaNhapBan_TextBox.TabIndex = 15;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(14, 137);
            label5.Name = "label5";
            label5.Size = new Size(304, 32);
            label5.TabIndex = 14;
            label5.Text = "Tỉ lệ đơn giá nhập/bán:";
            // 
            // ThayDoiQuyDinh
            // 
            AutoScaleDimensions = new SizeF(16F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 354);
            Controls.Add(LuuTiLe_Button);
            Controls.Add(TiLeDonGiaNhapBan_TextBox);
            Controls.Add(label5);
            Controls.Add(DanhSachHieuXe_Button);
            Controls.Add(TenHieuXeMoi_TextBox);
            Controls.Add(ThemHieuXe_Button);
            Controls.Add(label4);
            Controls.Add(LuuSoXe_Button);
            Controls.Add(SoXeTiepNhan_TextBox);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Font = new Font("Arial", 8.25F);
            Name = "ThayDoiQuyDinh";
            Text = "ThayDoiQuyDinh";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox SoXeTiepNhan_TextBox;
        private Button LuuSoXe_Button;
        private Button ThemHieuXe_Button;
        private Label label4;
        private TextBox TenHieuXeMoi_TextBox;
        private Button DanhSachHieuXe_Button;
        private Button LuuTiLe_Button;
        private TextBox TiLeDonGiaNhapBan_TextBox;
        private Label label5;
    }
}