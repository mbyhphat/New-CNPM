namespace CNPM_GaraOto.UI.ChucNang.VatTuPhuTung
{
    partial class ThemPhuTung
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnHuy = new Button();
            label1 = new Label();
            txbTenvtpt = new TextBox();
            txbGia = new TextBox();
            btnXacnhan = new Button();
            SuspendLayout();
            // 
            // btnHuy
            // 
            btnHuy.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnHuy.AutoSize = true;
            btnHuy.BackColor = Color.FromArgb(64, 64, 64);
            btnHuy.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHuy.ForeColor = Color.White;
            btnHuy.Location = new Point(270, 177);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(157, 34);
            btnHuy.TabIndex = 4;
            btnHuy.Text = "Hủy ";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += button2_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(54, 18);
            label1.Name = "label1";
            label1.Size = new Size(330, 44);
            label1.TabIndex = 0;
            label1.Text = "THÊM PHỤ TÙNG";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txbTenvtpt
            // 
            txbTenvtpt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txbTenvtpt.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbTenvtpt.Location = new Point(2, 74);
            txbTenvtpt.Name = "txbTenvtpt";
            txbTenvtpt.PlaceholderText = "Tên phụ tùng ";
            txbTenvtpt.Size = new Size(463, 27);
            txbTenvtpt.TabIndex = 1;
            txbTenvtpt.TabStop = false;
            // 
            // txbGia
            // 
            txbGia.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txbGia.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbGia.Location = new Point(2, 116);
            txbGia.Name = "txbGia";
            txbGia.PlaceholderText = "Giá";
            txbGia.Size = new Size(463, 27);
            txbGia.TabIndex = 2;
            txbGia.TabStop = false;
            // 
            // btnXacnhan
            // 
            btnXacnhan.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnXacnhan.AutoSize = true;
            btnXacnhan.BackColor = Color.DodgerBlue;
            btnXacnhan.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXacnhan.ForeColor = Color.Red;
            btnXacnhan.Location = new Point(54, 177);
            btnXacnhan.Name = "btnXacnhan";
            btnXacnhan.Size = new Size(157, 34);
            btnXacnhan.TabIndex = 3;
            btnXacnhan.Text = "Xác nhận ";
            btnXacnhan.UseVisualStyleBackColor = false;
            btnXacnhan.Click += button1_Click;
            // 
            // ThemPhuTung
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 223);
            Controls.Add(btnHuy);
            Controls.Add(btnXacnhan);
            Controls.Add(txbGia);
            Controls.Add(txbTenvtpt);
            Controls.Add(label1);
            Name = "ThemPhuTung";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm phụ tùng";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txbTenvtpt;
        private TextBox txbGia;
        private Button btnXacnhan;
        private Button btnHuy;
    }
}
