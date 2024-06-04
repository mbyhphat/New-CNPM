namespace CNPM_GaraOto.UI.ChucNang.TraCuuXe
{
    partial class ThemChiTietPhieuSuaChua
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
            label2 = new Label();
            label3 = new Label();
            txbSoluong = new TextBox();
            label4 = new Label();
            btnXacnhan = new Button();
            label5 = new Label();
            btnThoat = new Button();
            dtpNgaysuachua = new DateTimePicker();
            cbNoidung = new ComboBox();
            cbVattuphutung = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 70);
            label1.Name = "label1";
            label1.Size = new Size(134, 21);
            label1.TabIndex = 0;
            label1.Text = "Ngày sửa chữa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 113);
            label2.Name = "label2";
            label2.Size = new Size(82, 21);
            label2.TabIndex = 2;
            label2.Text = "Nội dung";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 156);
            label3.Name = "label3";
            label3.Size = new Size(133, 21);
            label3.TabIndex = 4;
            label3.Text = "Vật tư phụ tùng";
            // 
            // txbSoluong
            // 
            txbSoluong.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbSoluong.Location = new Point(152, 201);
            txbSoluong.Name = "txbSoluong";
            txbSoluong.Size = new Size(263, 28);
            txbSoluong.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 209);
            label4.Name = "label4";
            label4.Size = new Size(85, 21);
            label4.TabIndex = 6;
            label4.Text = "Số lượng";
            // 
            // btnXacnhan
            // 
            btnXacnhan.BackColor = Color.Red;
            btnXacnhan.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXacnhan.ForeColor = SystemColors.ButtonHighlight;
            btnXacnhan.Location = new Point(12, 261);
            btnXacnhan.Name = "btnXacnhan";
            btnXacnhan.Size = new Size(249, 50);
            btnXacnhan.TabIndex = 8;
            btnXacnhan.Text = "Xác nhận";
            btnXacnhan.UseVisualStyleBackColor = false;
            btnXacnhan.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(21, 9);
            label5.Name = "label5";
            label5.Size = new Size(382, 33);
            label5.TabIndex = 9;
            label5.Text = "THÊM CHI TIẾT SỬA CHỮA";
            // 
            // btnThoat
            // 
            btnThoat.BackColor = SystemColors.ActiveCaptionText;
            btnThoat.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThoat.ForeColor = SystemColors.ButtonHighlight;
            btnThoat.Location = new Point(264, 261);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(151, 50);
            btnThoat.TabIndex = 10;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += button2_Click;
            // 
            // dtpNgaysuachua
            // 
            dtpNgaysuachua.CustomFormat = "dd/MM/yyyy";
            dtpNgaysuachua.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpNgaysuachua.Format = DateTimePickerFormat.Custom;
            dtpNgaysuachua.Location = new Point(152, 63);
            dtpNgaysuachua.Name = "dtpNgaysuachua";
            dtpNgaysuachua.Size = new Size(260, 28);
            dtpNgaysuachua.TabIndex = 11;
            // 
            // cbNoidung
            // 
            cbNoidung.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbNoidung.FormattingEnabled = true;
            cbNoidung.Location = new Point(152, 108);
            cbNoidung.Name = "cbNoidung";
            cbNoidung.Size = new Size(260, 29);
            cbNoidung.TabIndex = 12;
            // 
            // cbVattuphutung
            // 
            cbVattuphutung.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbVattuphutung.FormattingEnabled = true;
            cbVattuphutung.Location = new Point(152, 156);
            cbVattuphutung.Name = "cbVattuphutung";
            cbVattuphutung.Size = new Size(260, 29);
            cbVattuphutung.TabIndex = 13;
            // 
            // ThemChiTietPhieuSuaChua
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 315);
            Controls.Add(cbVattuphutung);
            Controls.Add(cbNoidung);
            Controls.Add(dtpNgaysuachua);
            Controls.Add(btnThoat);
            Controls.Add(label5);
            Controls.Add(btnXacnhan);
            Controls.Add(txbSoluong);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ThemChiTietPhieuSuaChua";
            Text = "ThemChiTietPhieuSuaChua";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txbSoluong;
        private Label label4;
        private Button btnXacnhan;
        private Label label5;
        private Button btnThoat;
        private DateTimePicker dtpNgaysuachua;
        private ComboBox cbNoidung;
        private ComboBox cbVattuphutung;
    }
}