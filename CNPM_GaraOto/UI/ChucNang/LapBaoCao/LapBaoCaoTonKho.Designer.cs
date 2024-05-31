namespace CNPM_GaraOto.UI.ChucNang.LapBaoCao
{
    partial class LapBaoCaoTonKho
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            cbMonth = new ComboBox();
            cbYear = new ComboBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(53, 20);
            label1.Name = "label1";
            label1.Size = new Size(418, 40);
            label1.TabIndex = 0;
            label1.Text = "LẬP BÁO CÁO TỒN KHO";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(cbMonth);
            flowLayoutPanel1.Controls.Add(cbYear);
            flowLayoutPanel1.Location = new Point(180, 75);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(173, 64);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // cbMonth
            // 
            cbMonth.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbMonth.FormattingEnabled = true;
            cbMonth.Items.AddRange(new object[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12" });
            cbMonth.Location = new Point(3, 3);
            cbMonth.Name = "cbMonth";
            cbMonth.Size = new Size(170, 25);
            cbMonth.TabIndex = 2;
            cbMonth.TabStop = false;
            cbMonth.Text = "Tháng ";
            // 
            // cbYear
            // 
            cbYear.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbYear.FormattingEnabled = true;
            cbYear.Items.AddRange(new object[] { "2024", "2025" });
            cbYear.Location = new Point(3, 34);
            cbYear.Name = "cbYear";
            cbYear.Size = new Size(170, 25);
            cbYear.TabIndex = 3;
            cbYear.TabStop = false;
            cbYear.Text = "Năm ";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(button1);
            flowLayoutPanel2.Controls.Add(button2);
            flowLayoutPanel2.Location = new Point(139, 146);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(250, 87);
            flowLayoutPanel2.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.ForeColor = Color.White;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(247, 40);
            button1.TabIndex = 0;
            button1.Text = "Xem báo cáo";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaptionText;
            button2.ForeColor = Color.White;
            button2.Location = new Point(3, 49);
            button2.Name = "button2";
            button2.Size = new Size(247, 40);
            button2.TabIndex = 3;
            button2.Text = "Quay lại ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // LapBaoCaoTonKho
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 283);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label1);
            Name = "LapBaoCaoTonKho";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lập Báo Cáo Doanh Thu";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private ComboBox cbMonth;
        private ComboBox cbYear;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button button1;
        private Button button2;
    }
}