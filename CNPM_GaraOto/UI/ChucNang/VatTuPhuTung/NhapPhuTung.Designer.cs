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
            button1 = new Button();
            button2 = new Button();
            comboBox1 = new ComboBox();
            panel1 = new Panel();
            txbMavtpt = new TextBox();
            txbDongianhap = new TextBox();
            dateTimePicker1 = new DateTimePicker();
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
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(66, 133, 244);
            button1.Font = new Font("Arial", 14F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(5, 270);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(144, 82);
            button1.TabIndex = 5;
            button1.Text = "XÁC NHẬN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button2.BackColor = Color.Black;
            button2.Font = new Font("Arial", 14F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(249, 270);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(144, 82);
            button2.TabIndex = 6;
            button2.Text = "HỦY";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBox1.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(3, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(388, 29);
            comboBox1.TabIndex = 9;
            comboBox1.Text = "Tên vật tư phụ tùng";
            comboBox1.SelectedValueChanged += comboBox1_SelectedValueChanged;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(txbMavtpt);
            panel1.Controls.Add(txbDongianhap);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(comboBox1);
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
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(3, 80);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(388, 28);
            dateTimePicker1.TabIndex = 10;
            // 
            // NhapPhuTung
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(397, 363);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(button1);
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
        private Button button1;
        private Button button2;
        private ComboBox comboBox1;
        private Panel panel1;
        private DateTimePicker dateTimePicker1;
        private TextBox txbDongianhap;
        private TextBox txbMavtpt;
    }
}