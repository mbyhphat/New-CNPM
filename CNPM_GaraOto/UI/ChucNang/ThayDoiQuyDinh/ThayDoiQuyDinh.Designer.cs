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
            textBox1 = new TextBox();
            button3 = new Button();
            button2 = new Button();
            label4 = new Label();
            textBox4 = new TextBox();
            button4 = new Button();
            button5 = new Button();
            textBox3 = new TextBox();
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
            label1.Size = new Size(427, 39);
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
            label2.Size = new Size(220, 16);
            label2.TabIndex = 3;
            label2.Text = "Số xe tiếp nhận tối đa trong ngày:";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(240, 96);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(57, 23);
            textBox1.TabIndex = 4;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button3.BackColor = SystemColors.ActiveCaptionText;
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(297, 92);
            button3.Name = "button3";
            button3.Size = new Size(73, 36);
            button3.TabIndex = 5;
            button3.Text = "Lưu";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button2.BackColor = SystemColors.ActiveCaptionText;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(297, 57);
            button2.Name = "button2";
            button2.Size = new Size(73, 33);
            button2.TabIndex = 11;
            button2.Text = "Thêm";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(14, 64);
            label4.Name = "label4";
            label4.Size = new Size(92, 16);
            label4.TabIndex = 9;
            label4.Text = "Thêm hiệu xe";
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox4.Location = new Point(112, 60);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(185, 23);
            textBox4.TabIndex = 12;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button4.BackColor = SystemColors.ActiveCaptionText;
            button4.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(390, 58);
            button4.Name = "button4";
            button4.Size = new Size(356, 43);
            button4.TabIndex = 13;
            button4.Text = "Xem các hiệu xe";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button5.BackColor = SystemColors.ActiveCaptionText;
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(297, 131);
            button5.Name = "button5";
            button5.Size = new Size(73, 37);
            button5.TabIndex = 16;
            button5.Text = "Lưu";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox3.Location = new Point(240, 134);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(57, 23);
            textBox3.TabIndex = 15;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(14, 137);
            label5.Name = "label5";
            label5.Size = new Size(154, 16);
            label5.TabIndex = 14;
            label5.Text = "Tỉ lệ đơn giá nhập/bán:";
            // 
            // ThayDoiQuyDinh
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 354);
            Controls.Add(button5);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(button4);
            Controls.Add(textBox4);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private Button button3;
        private Button button2;
        private Label label4;
        private TextBox textBox4;
        private Button button4;
        private Button button5;
        private TextBox textBox3;
        private Label label5;
    }
}