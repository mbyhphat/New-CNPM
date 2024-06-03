namespace CNPM_GaraOto.UI.ChucNang.LapBaoCao
{
    partial class BaoCaoDoanhThu
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
            textBox1 = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnInbaocao = new Button();
            btnQuaylai = new Button();
            panel2 = new Panel();
            lbDoanhthu = new Label();
            panel3 = new Panel();
            lbYear = new Label();
            label5 = new Label();
            lbMonth = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(255, 255, 128);
            textBox1.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(1, 2);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(799, 45);
            textBox1.TabIndex = 0;
            textBox1.TabStop = false;
            textBox1.Text = "BÁO CÁO DOANH THU THÁNG";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(263, 5);
            label1.Name = "label1";
            label1.Size = new Size(75, 26);
            label1.TabIndex = 1;
            label1.Text = "Tháng";
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(-1, 89);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 368);
            panel1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(798, 362);
            dataGridView1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 10);
            label2.Name = "label2";
            label2.Size = new Size(180, 21);
            label2.TabIndex = 3;
            label2.Text = "TỔNG DOANH THU:";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnInbaocao);
            flowLayoutPanel1.Controls.Add(btnQuaylai);
            flowLayoutPanel1.Location = new Point(478, 512);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(322, 39);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // btnInbaocao
            // 
            btnInbaocao.BackColor = SystemColors.HotTrack;
            btnInbaocao.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInbaocao.ForeColor = Color.White;
            btnInbaocao.Location = new Point(3, 3);
            btnInbaocao.Name = "btnInbaocao";
            btnInbaocao.Size = new Size(157, 29);
            btnInbaocao.TabIndex = 0;
            btnInbaocao.Text = "In Báo Cáo";
            btnInbaocao.UseVisualStyleBackColor = false;
            btnInbaocao.Click += button1_Click;
            // 
            // btnQuaylai
            // 
            btnQuaylai.BackColor = SystemColors.ActiveCaptionText;
            btnQuaylai.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnQuaylai.ForeColor = Color.White;
            btnQuaylai.Location = new Point(166, 3);
            btnQuaylai.Name = "btnQuaylai";
            btnQuaylai.Size = new Size(94, 29);
            btnQuaylai.TabIndex = 1;
            btnQuaylai.Text = "Quay lại";
            btnQuaylai.UseVisualStyleBackColor = false;
            btnQuaylai.Click += button2_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(lbDoanhthu);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(477, 460);
            panel2.Name = "panel2";
            panel2.Size = new Size(323, 49);
            panel2.TabIndex = 5;
            // 
            // lbDoanhthu
            // 
            lbDoanhthu.AutoSize = true;
            lbDoanhthu.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbDoanhthu.Location = new Point(186, 11);
            lbDoanhthu.Name = "lbDoanhthu";
            lbDoanhthu.Size = new Size(0, 21);
            lbDoanhthu.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Controls.Add(lbYear);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(lbMonth);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(2, 53);
            panel3.Name = "panel3";
            panel3.Size = new Size(798, 33);
            panel3.TabIndex = 6;
            // 
            // lbYear
            // 
            lbYear.AutoSize = true;
            lbYear.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbYear.Location = new Point(436, 5);
            lbYear.Name = "lbYear";
            lbYear.Size = new Size(0, 26);
            lbYear.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(412, 5);
            label5.Name = "label5";
            label5.Size = new Size(18, 26);
            label5.TabIndex = 3;
            label5.Text = "/";
            // 
            // lbMonth
            // 
            lbMonth.AutoSize = true;
            lbMonth.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbMonth.Location = new Point(344, 5);
            lbMonth.Name = "lbMonth";
            lbMonth.Size = new Size(0, 26);
            lbMonth.TabIndex = 2;
            // 
            // BaoCaoDoanhThu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 567);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Controls.Add(textBox1);
            Name = "BaoCaoDoanhThu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Báo Cáo Doanh Thu";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Panel panel1;
        private DataGridView dataGridView1;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnInbaocao;
        private Button btnQuaylai;
        private Panel panel2;
        private Label lbDoanhthu;
        private Panel panel3;
        private Label lbYear;
        private Label label5;
        private Label lbMonth;
    }
}
