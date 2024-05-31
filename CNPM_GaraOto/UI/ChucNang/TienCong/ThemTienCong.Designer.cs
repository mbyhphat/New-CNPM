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
            button2 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button2.AutoSize = true;
            button2.BackColor = Color.FromArgb(64, 64, 64);
            button2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(513, 416);
            button2.Margin = new Padding(7, 7, 7, 7);
            button2.Name = "button2";
            button2.Size = new Size(363, 80);
            button2.TabIndex = 4;
            button2.Text = "Hủy ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(128, 42);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.Name = "label1";
            label1.Size = new Size(681, 87);
            label1.TabIndex = 0;
            label1.Text = "THÊM TIỀN CÔNG";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(5, 174);
            textBox1.Margin = new Padding(7, 7, 7, 7);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Nội dung công việc ";
            textBox1.Size = new Size(1028, 47);
            textBox1.TabIndex = 1;
            textBox1.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(5, 273);
            textBox2.Margin = new Padding(7, 7, 7, 7);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Tiền công ";
            textBox2.Size = new Size(1028, 47);
            textBox2.TabIndex = 2;
            textBox2.TabStop = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button1.AutoSize = true;
            button1.BackColor = Color.DodgerBlue;
            button1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(128, 416);
            button1.Margin = new Padding(7, 7, 7, 7);
            button1.Name = "button1";
            button1.Size = new Size(363, 80);
            button1.TabIndex = 3;
            button1.Text = "Xác nhận ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ThemTienCong
            // 
            AutoScaleDimensions = new SizeF(19F, 47F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1043, 557);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Margin = new Padding(7, 7, 7, 7);
            Name = "ThemTienCong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm phụ tùng";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
    }
}