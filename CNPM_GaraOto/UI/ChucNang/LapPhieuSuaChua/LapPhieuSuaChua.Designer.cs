namespace CNPM_GaraOto.UI.ChucNang.LapPhieuSuaChua
{
    partial class LapPhieuSuaChua
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LapPhieuSuaChua));
            lbLapPhieuSuaChua = new Label();
            lbBienSoXe = new Label();
            lbNgaySuaChua = new Label();
            btnXacNhan = new Button();
            btnDong = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            imageList1 = new ImageList(components);
            pictureBox2 = new PictureBox();
            tbBienSoXe = new TextBox();
            tbNgaySuaChua = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lbLapPhieuSuaChua
            // 
            lbLapPhieuSuaChua.AutoSize = true;
            lbLapPhieuSuaChua.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLapPhieuSuaChua.Location = new Point(297, 9);
            lbLapPhieuSuaChua.Name = "lbLapPhieuSuaChua";
            lbLapPhieuSuaChua.Size = new Size(315, 32);
            lbLapPhieuSuaChua.TabIndex = 0;
            lbLapPhieuSuaChua.Text = "LẬP PHIẾU SỬA CHỮA";
            // 
            // lbBienSoXe
            // 
            lbBienSoXe.AutoSize = true;
            lbBienSoXe.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbBienSoXe.ForeColor = Color.FromArgb(130, 130, 130);
            lbBienSoXe.Location = new Point(313, 63);
            lbBienSoXe.Name = "lbBienSoXe";
            lbBienSoXe.Size = new Size(76, 17);
            lbBienSoXe.TabIndex = 1;
            lbBienSoXe.Text = "Biển số xe";
            // 
            // lbNgaySuaChua
            // 
            lbNgaySuaChua.AutoSize = true;
            lbNgaySuaChua.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbNgaySuaChua.ForeColor = Color.FromArgb(130, 130, 130);
            lbNgaySuaChua.Location = new Point(313, 162);
            lbNgaySuaChua.Name = "lbNgaySuaChua";
            lbNgaySuaChua.Size = new Size(235, 17);
            lbNgaySuaChua.TabIndex = 2;
            lbNgaySuaChua.Text = "Ngày sửa chữa (Ví dụ: 2024/12/04)";
            // 
            // btnXacNhan
            // 
            btnXacNhan.BackColor = Color.FromArgb(66, 133, 244);
            btnXacNhan.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXacNhan.ForeColor = Color.White;
            btnXacNhan.Location = new Point(196, 258);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(150, 60);
            btnXacNhan.TabIndex = 3;
            btnXacNhan.Text = "XÁC NHẬN";
            btnXacNhan.UseVisualStyleBackColor = false;
            btnXacNhan.Click += button_XacNhan_Click;
            // 
            // btnDong
            // 
            btnDong.BackColor = Color.Black;
            btnDong.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDong.ForeColor = Color.White;
            btnDong.Location = new Point(540, 258);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(150, 60);
            btnDong.TabIndex = 4;
            btnDong.Text = "ĐÓNG";
            btnDong.UseVisualStyleBackColor = false;
            btnDong.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(228, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = Color.Black;
            label1.Location = new Point(313, 118);
            label1.Name = "label1";
            label1.Size = new Size(306, 2);
            label1.TabIndex = 6;
            // 
            // label2
            // 
            label2.BackColor = Color.Black;
            label2.Location = new Point(313, 220);
            label2.Name = "label2";
            label2.Size = new Size(306, 2);
            label2.TabIndex = 7;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(228, 162);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(60, 60);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // tbBienSoXe
            // 
            tbBienSoXe.BackColor = SystemColors.Control;
            tbBienSoXe.BorderStyle = BorderStyle.None;
            tbBienSoXe.Font = new Font("Arial", 12F);
            tbBienSoXe.Location = new Point(313, 99);
            tbBienSoXe.Name = "tbBienSoXe";
            tbBienSoXe.Size = new Size(306, 19);
            tbBienSoXe.TabIndex = 0;
            // 
            // tbNgaySuaChua
            // 
            tbNgaySuaChua.BackColor = SystemColors.Control;
            tbNgaySuaChua.BorderStyle = BorderStyle.None;
            tbNgaySuaChua.Font = new Font("Arial", 12F);
            tbNgaySuaChua.Location = new Point(313, 201);
            tbNgaySuaChua.Name = "tbNgaySuaChua";
            tbNgaySuaChua.Size = new Size(306, 19);
            tbNgaySuaChua.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(40, 40);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // LapPhieuSuaChua
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(871, 339);
            Controls.Add(tbNgaySuaChua);
            Controls.Add(tbBienSoXe);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnDong);
            Controls.Add(btnXacNhan);
            Controls.Add(lbNgaySuaChua);
            Controls.Add(lbBienSoXe);
            Controls.Add(lbLapPhieuSuaChua);
            Name = "LapPhieuSuaChua";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LapPhieuSuaChua";
            Load += LapPhieuSuaChua_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbLapPhieuSuaChua;
        private Label lbBienSoXe;
        private Label lbNgaySuaChua;
        private Button btnXacNhan;
        private Button btnDong;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private ImageList imageList1;
        private PictureBox pictureBox2;
        private TextBox tbBienSoXe;
        private TextBox tbNgaySuaChua;
        private ContextMenuStrip contextMenuStrip1;
    }
}