namespace CNPM_GaraOto.UI.ChucNang.LapBaoCao
{
    partial class LapBaoCaoPhieuNhapVTPT
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
            flowLayoutPanel2 = new FlowLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            flowLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(-7, 47);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.Name = "label1";
            label1.Size = new Size(1062, 78);
            label1.TabIndex = 0;
            label1.Text = "LẬP BÁO CÁO NHẬP PHỤ TÙNG";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel2.Controls.Add(button1);
            flowLayoutPanel2.Controls.Add(button2);
            flowLayoutPanel2.Location = new Point(330, 343);
            flowLayoutPanel2.Margin = new Padding(7, 7, 7, 7);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(594, 204);
            flowLayoutPanel2.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.ForeColor = Color.White;
            button1.Location = new Point(7, 7);
            button1.Margin = new Padding(7, 7, 7, 7);
            button1.Name = "button1";
            button1.Size = new Size(587, 94);
            button1.TabIndex = 0;
            button1.Text = "Xem báo cáo";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaptionText;
            button2.ForeColor = Color.White;
            button2.Location = new Point(7, 115);
            button2.Margin = new Padding(7, 7, 7, 7);
            button2.Name = "button2";
            button2.Size = new Size(587, 94);
            button2.TabIndex = 3;
            button2.Text = "Quay lại ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(dateTimePicker2);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Location = new Point(330, 148);
            panel1.Margin = new Padding(7, 7, 7, 7);
            panel1.Name = "panel1";
            panel1.Size = new Size(594, 176);
            panel1.TabIndex = 3;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(0, 92);
            dateTimePicker2.Margin = new Padding(7, 7, 7, 7);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(588, 54);
            dateTimePicker2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(0, 14);
            dateTimePicker1.Margin = new Padding(7, 7, 7, 7);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(588, 54);
            dateTimePicker1.TabIndex = 0;
            // 
            // LapBaoCaoPhieuNhapVTPT
            // 
            AutoScaleDimensions = new SizeF(19F, 47F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1313, 665);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(label1);
            Margin = new Padding(7, 7, 7, 7);
            Name = "LapBaoCaoPhieuNhapVTPT";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lập Báo Cáo Doanh Thu";
            flowLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button button1;
        private Button button2;
        private Panel panel1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
    }
}