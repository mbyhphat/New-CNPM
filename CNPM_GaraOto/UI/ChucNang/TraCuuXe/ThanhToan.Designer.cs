namespace CNPM_GaraOto.UI.ChucNang.TraCuuXe
{
    partial class ThanhToan
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
            dvgtThongTinXe2 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            txbTienthu = new TextBox();
            panel1 = new Panel();
            txbTienno = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            panel2 = new Panel();
            txbBienso = new TextBox();
            txbHoten = new TextBox();
            textBox7 = new TextBox();
            dtpngaythu = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dvgtThongTinXe2).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dvgtThongTinXe2
            // 
            dvgtThongTinXe2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgtThongTinXe2.BackgroundColor = SystemColors.Control;
            dvgtThongTinXe2.BorderStyle = BorderStyle.None;
            dvgtThongTinXe2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgtThongTinXe2.Location = new Point(0, 1);
            dvgtThongTinXe2.Margin = new Padding(1);
            dvgtThongTinXe2.Name = "dvgtThongTinXe2";
            dvgtThongTinXe2.RowHeadersWidth = 102;
            dvgtThongTinXe2.Size = new Size(816, 375);
            dvgtThongTinXe2.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(16, 140);
            button1.Margin = new Padding(1);
            button1.Name = "button1";
            button1.Size = new Size(158, 55);
            button1.TabIndex = 1;
            button1.Text = "Thanh toán";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(197, 142);
            button2.Margin = new Padding(1);
            button2.Name = "button2";
            button2.Size = new Size(109, 56);
            button2.TabIndex = 2;
            button2.Text = "Hủy ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(16, 105);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(84, 23);
            label2.TabIndex = 5;
            label2.Text = "Tiền thu:";
            // 
            // txbTienthu
            // 
            txbTienthu.Font = new Font("Arial", 11.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbTienthu.Location = new Point(149, 100);
            txbTienthu.Margin = new Padding(1);
            txbTienthu.Name = "txbTienthu";
            txbTienthu.PlaceholderText = "Vui lòng nhập tiền ";
            txbTienthu.Size = new Size(196, 29);
            txbTienthu.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.Controls.Add(txbTienno);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txbTienthu);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(464, 380);
            panel1.Name = "panel1";
            panel1.Size = new Size(346, 196);
            panel1.TabIndex = 7;
            // 
            // txbTienno
            // 
            txbTienno.Font = new Font("Arial", 11.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbTienno.Location = new Point(150, 63);
            txbTienno.Margin = new Padding(1);
            txbTienno.Name = "txbTienno";
            txbTienno.ReadOnly = true;
            txbTienno.Size = new Size(196, 29);
            txbTienno.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(19, 65);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(81, 23);
            label3.TabIndex = 8;
            label3.Text = "Tiền nợ:";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(0, 430);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(161, 28);
            textBox3.TabIndex = 8;
            textBox3.Text = "Họ tên khách hàng:";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(0, 464);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(125, 28);
            textBox4.TabIndex = 9;
            textBox4.Text = "Biển số:";
            // 
            // panel2
            // 
            panel2.Controls.Add(txbBienso);
            panel2.Controls.Add(txbHoten);
            panel2.Location = new Point(191, 413);
            panel2.Name = "panel2";
            panel2.Size = new Size(256, 95);
            panel2.TabIndex = 10;
            // 
            // txbBienso
            // 
            txbBienso.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbBienso.Location = new Point(3, 51);
            txbBienso.Name = "txbBienso";
            txbBienso.ReadOnly = true;
            txbBienso.Size = new Size(244, 28);
            txbBienso.TabIndex = 1;
            // 
            // txbHoten
            // 
            txbHoten.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbHoten.Location = new Point(3, 17);
            txbHoten.Name = "txbHoten";
            txbHoten.ReadOnly = true;
            txbHoten.Size = new Size(244, 28);
            txbHoten.TabIndex = 0;
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox7.Location = new Point(3, 522);
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(158, 28);
            textBox7.TabIndex = 11;
            textBox7.Text = "Ngày thanh toán";
            // 
            // dtpngaythu
            // 
            dtpngaythu.CustomFormat = "dd/MM/yyyy";
            dtpngaythu.Format = DateTimePickerFormat.Custom;
            dtpngaythu.Location = new Point(194, 521);
            dtpngaythu.Name = "dtpngaythu";
            dtpngaythu.Size = new Size(250, 27);
            dtpngaythu.TabIndex = 12;
            // 
            // ThanhToan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(817, 588);
            Controls.Add(dtpngaythu);
            Controls.Add(textBox7);
            Controls.Add(panel2);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(panel1);
            Controls.Add(dvgtThongTinXe2);
            Margin = new Padding(1);
            Name = "ThanhToan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ThanhToan";
            ((System.ComponentModel.ISupportInitialize)dvgtThongTinXe2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dvgtThongTinXe2;
        private Button button1;
        private Button button2;
        private Label label2;
        private TextBox txbTienthu;
        private Panel panel1;
        private TextBox textBox3;
        private TextBox textBox4;
        private Panel panel2;
        private TextBox txbBienso;
        private TextBox txbHoten;
        private TextBox textBox7;
        private DateTimePicker dtpngaythu;
        private TextBox txbTienno;
        private Label label3;
    }
}