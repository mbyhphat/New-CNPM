namespace CNPM_GaraOto.UI.ChucNang.VatTuPhuTung
{
    partial class NhapPhuTung
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
            label_NhapPhuTung = new Label();
            txbSoluong = new TextBox();
            btnXacnhan = new Button();
            btnHuy = new Button();
            cbTenvtpt = new ComboBox();
            panel1 = new Panel();
            txbMavtpt = new TextBox();
            txbDongianhap = new TextBox();
            dtpkNgaynhapvtpt = new DateTimePicker();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label_NhapPhuTung
            // 
            label_NhapPhuTung.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_NhapPhuTung.Font = new Font("Arial", 20.25F, FontStyle.Bold);
            label_NhapPhuTung.Location = new Point(28, 9);
            label_NhapPhuTung.Name = "label_NhapPhuTung";
            label_NhapPhuTung.Size = new Size(330, 59);
            label_NhapPhuTung.TabIndex = 0;
            label_NhapPhuTung.Text = "NHẬP PHỤ TÙNG";
            label_NhapPhuTung.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txbSoluong
            // 
            txbSoluong.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txbSoluong.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbSoluong.Location = new Point(3, 169);
            txbSoluong.Margin = new Padding(3, 4, 3, 4);
            txbSoluong.Name = "txbSoluong";
            txbSoluong.PlaceholderText = "Số lượng ";
            txbSoluong.Size = new Size(388, 28);
            txbSoluong.TabIndex = 4;
            // 
            // btnXacnhan
            // 
            btnXacnhan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnXacnhan.BackColor = Color.FromArgb(66, 133, 244);
            btnXacnhan.Font = new Font("Arial", 14F);
            btnXacnhan.ForeColor = Color.White;
            btnXacnhan.Location = new Point(5, 270);
            btnXacnhan.Margin = new Padding(3, 4, 3, 4);
            btnXacnhan.Name = "btnXacnhan";
            btnXacnhan.Size = new Size(144, 82);
            btnXacnhan.TabIndex = 5;
            btnXacnhan.Text = "XÁC NHẬN";
            btnXacnhan.UseVisualStyleBackColor = false;
            btnXacnhan.Click += button1_Click;
            // 
            // btnHuy
            // 
            btnHuy.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnHuy.BackColor = Color.Black;
            btnHuy.Font = new Font("Arial", 14F);
            btnHuy.ForeColor = Color.White;
            btnHuy.Location = new Point(249, 270);
            btnHuy.Margin = new Padding(3, 4, 3, 4);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(144, 82);
            btnHuy.TabIndex = 6;
            btnHuy.Text = "HỦY";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += button2_Click;
            // 
            // cbTenvtpt
            // 
            cbTenvtpt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cbTenvtpt.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbTenvtpt.FormattingEnabled = true;
            cbTenvtpt.Location = new Point(3, 3);
            cbTenvtpt.Name = "cbTenvtpt";
            cbTenvtpt.Size = new Size(388, 29);
            cbTenvtpt.TabIndex = 9;
            cbTenvtpt.Text = "Tên vật tư phụ tùng";
            cbTenvtpt.SelectedValueChanged += comboBox1_SelectedValueChanged;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(txbMavtpt);
            panel1.Controls.Add(txbDongianhap);
            panel1.Controls.Add(dtpkNgaynhapvtpt);
            panel1.Controls.Add(cbTenvtpt);
            panel1.Controls.Add(txbSoluong);
            panel1.Location = new Point(2, 71);
            panel1.Name = "panel1";
            panel1.Size = new Size(394, 201);
            panel1.TabIndex = 10;
            // 
            // txbMavtpt
            // 
            txbMavtpt.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbMavtpt.Location = new Point(3, 41);
            txbMavtpt.Name = "txbMavtpt";
            txbMavtpt.PlaceholderText = "Mã vật tư phụ tùng";
            txbMavtpt.ReadOnly = true;
            txbMavtpt.Size = new Size(388, 28);
            txbMavtpt.TabIndex = 12;
            // 
            // txbDongianhap
            // 
            txbDongianhap.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txbDongianhap.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbDongianhap.Location = new Point(3, 125);
            txbDongianhap.Name = "txbDongianhap";
            txbDongianhap.PlaceholderText = "Đơn giá nhập";
            txbDongianhap.Size = new Size(388, 28);
            txbDongianhap.TabIndex = 11;
            // 
            // dtpkNgaynhapvtpt
            // 
            dtpkNgaynhapvtpt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtpkNgaynhapvtpt.CustomFormat = "dd/MM/yyyy";
            dtpkNgaynhapvtpt.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpkNgaynhapvtpt.Format = DateTimePickerFormat.Custom;
            dtpkNgaynhapvtpt.Location = new Point(3, 80);
            dtpkNgaynhapvtpt.Name = "dtpkNgaynhapvtpt";
            dtpkNgaynhapvtpt.Size = new Size(388, 28);
            dtpkNgaynhapvtpt.TabIndex = 10;
            // 
            // NhapPhuTung
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(397, 363);
            Controls.Add(panel1);
            Controls.Add(btnHuy);
            Controls.Add(btnXacnhan);
            Controls.Add(label_NhapPhuTung);
            Margin = new Padding(3, 4, 3, 4);
            Name = "NhapPhuTung";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NhapPhuTung";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label_NhapPhuTung;
        private TextBox txbSoluong;
        private Button btnXacnhan;
        private Button btnHuy;
        private ComboBox cbTenvtpt;
        private Panel panel1;
        private DateTimePicker dtpkNgaynhapvtpt;
        private TextBox txbDongianhap;
        private TextBox txbMavtpt;
    }
}