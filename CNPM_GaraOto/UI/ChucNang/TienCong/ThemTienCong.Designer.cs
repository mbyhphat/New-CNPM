namespace CNPM_GaraOto.UI.ChucNang.TienCong
{
    partial class ThemTienCong
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
            txbNoidungsuachua = new TextBox();
            txbGiatiencong = new TextBox();
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
            btnHuy.Location = new Point(216, 177);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(153, 34);
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
            label1.Size = new Size(341, 44);
            label1.TabIndex = 0;
            label1.Text = "THÊM TIỀN CÔNG";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txbNoidungsuachua
            // 
            txbNoidungsuachua.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txbNoidungsuachua.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbNoidungsuachua.Location = new Point(2, 74);
            txbNoidungsuachua.Name = "txbNoidungsuachua";
            txbNoidungsuachua.PlaceholderText = "Nội dung công việc ";
            txbNoidungsuachua.Size = new Size(435, 27);
            txbNoidungsuachua.TabIndex = 1;
            txbNoidungsuachua.TabStop = false;
            // 
            // txbGiatiencong
            // 
            txbGiatiencong.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txbGiatiencong.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbGiatiencong.Location = new Point(2, 116);
            txbGiatiencong.Name = "txbGiatiencong";
            txbGiatiencong.PlaceholderText = "Tiền công ";
            txbGiatiencong.Size = new Size(435, 27);
            txbGiatiencong.TabIndex = 2;
            txbGiatiencong.TabStop = false;
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
            btnXacnhan.Size = new Size(153, 34);
            btnXacnhan.TabIndex = 3;
            btnXacnhan.Text = "Xác nhận ";
            btnXacnhan.UseVisualStyleBackColor = false;
            btnXacnhan.Click += button1_Click;
            // 
            // ThemTienCong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 237);
            Controls.Add(btnHuy);
            Controls.Add(btnXacnhan);
            Controls.Add(txbGiatiencong);
            Controls.Add(txbNoidungsuachua);
            Controls.Add(label1);
            Name = "ThemTienCong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm tiền công";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txbNoidungsuachua;
        private TextBox txbGiatiencong;
        private Button btnXacnhan;
        private Button btnHuy;
    }
}