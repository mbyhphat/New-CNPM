namespace CNPM_GaraOto.UI.DangNhap
{
    partial class DangNhap
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            Username_TextBox = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            Password_TextBox = new TextBox();
            Login_Button = new Button();
            Exit_Button = new Button();
            button_showPassword = new Button();
            button_hidePassword = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.Screenshot_2024_05_06_190516;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(547, 423);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold);
            label1.Location = new Point(553, 67);
            label1.Name = "label1";
            label1.Size = new Size(315, 35);
            label1.TabIndex = 1;
            label1.Text = "QUẢN LÝ GARA ÔTÔ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15F, FontStyle.Bold);
            label2.Location = new Point(661, 149);
            label2.Name = "label2";
            label2.Size = new Size(162, 30);
            label2.TabIndex = 2;
            label2.Text = "ĐĂNG NHẬP";
            // 
            // Username_TextBox
            // 
            Username_TextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Username_TextBox.ForeColor = Color.Black;
            Username_TextBox.Location = new Point(642, 202);
            Username_TextBox.Name = "Username_TextBox";
            Username_TextBox.PlaceholderText = "Tên đăng nhập";
            Username_TextBox.Size = new Size(178, 25);
            Username_TextBox.TabIndex = 3;
            Username_TextBox.TextChanged += textBox1_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.Image = Properties.Resources.user_icon_153312;
            pictureBox2.Location = new Point(609, 198);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(28, 28);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox3.Image = Properties.Resources.lock_icon;
            pictureBox3.Location = new Point(609, 244);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(28, 28);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // Password_TextBox
            // 
            Password_TextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Password_TextBox.ForeColor = Color.Black;
            Password_TextBox.Location = new Point(642, 251);
            Password_TextBox.Name = "Password_TextBox";
            Password_TextBox.PasswordChar = '*';
            Password_TextBox.PlaceholderText = "Mật khẩu";
            Password_TextBox.Size = new Size(178, 25);
            Password_TextBox.TabIndex = 4;
            Password_TextBox.TextChanged += textBox2_TextChanged;
            // 
            // Login_Button
            // 
            Login_Button.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Login_Button.BackColor = SystemColors.Highlight;
            Login_Button.ForeColor = SystemColors.ControlLightLight;
            Login_Button.Location = new Point(611, 310);
            Login_Button.Name = "Login_Button";
            Login_Button.Size = new Size(214, 32);
            Login_Button.TabIndex = 5;
            Login_Button.Text = "Đăng nhập";
            Login_Button.UseVisualStyleBackColor = false;
            Login_Button.Click += button1_Click;
            // 
            // Exit_Button
            // 
            Exit_Button.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Exit_Button.BackColor = SystemColors.ActiveCaptionText;
            Exit_Button.ForeColor = SystemColors.ButtonHighlight;
            Exit_Button.Location = new Point(611, 353);
            Exit_Button.Name = "Exit_Button";
            Exit_Button.Size = new Size(214, 35);
            Exit_Button.TabIndex = 6;
            Exit_Button.Text = "Thoát";
            Exit_Button.UseVisualStyleBackColor = false;
            Exit_Button.Click += button2_Click;
            // 
            // button_showPassword
            // 
            button_showPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button_showPassword.BackColor = Color.White;
            button_showPassword.FlatStyle = FlatStyle.Flat;
            button_showPassword.ForeColor = Color.White;
            button_showPassword.Image = Properties.Resources.eye;
            button_showPassword.Location = new Point(790, 252);
            button_showPassword.Name = "button_showPassword";
            button_showPassword.Size = new Size(28, 19);
            button_showPassword.TabIndex = 14;
            button_showPassword.UseVisualStyleBackColor = false;
            button_showPassword.Click += button_showPassword_Click;
            // 
            // button_hidePassword
            // 
            button_hidePassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button_hidePassword.BackColor = Color.White;
            button_hidePassword.FlatStyle = FlatStyle.Flat;
            button_hidePassword.ForeColor = Color.White;
            button_hidePassword.Image = Properties.Resources.eye_off;
            button_hidePassword.Location = new Point(790, 252);
            button_hidePassword.Name = "button_hidePassword";
            button_hidePassword.Size = new Size(28, 19);
            button_hidePassword.TabIndex = 15;
            button_hidePassword.UseVisualStyleBackColor = false;
            button_hidePassword.Click += button_hidePassword_Click;
            // 
            // DangNhap
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(862, 425);
            Controls.Add(button_hidePassword);
            Controls.Add(button_showPassword);
            Controls.Add(Exit_Button);
            Controls.Add(Login_Button);
            Controls.Add(pictureBox3);
            Controls.Add(Password_TextBox);
            Controls.Add(pictureBox2);
            Controls.Add(Username_TextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Arial", 9F);
            Name = "DangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DangNhap";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox Username_TextBox;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private TextBox Password_TextBox;
        private Button Login_Button;
        private Button Exit_Button;
        private Button button_showPassword;
        private Button button_hidePassword;
    }
}