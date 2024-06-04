namespace CNPM_GaraOto.UI.ChucNang.LapBaoCao
{
    partial class BaoCaoTonKho
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
            dtgvBaocaotonkho = new DataGridView();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnInbaocao = new Button();
            btnQuaylai = new Button();
            panel3 = new Panel();
            lbYear = new Label();
            label5 = new Label();
            lbMonth = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvBaocaotonkho).BeginInit();
            flowLayoutPanel1.SuspendLayout();
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
            textBox1.Text = "BÁO CÁO TỒN KHO THÁNG";
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
            panel1.Controls.Add(dtgvBaocaotonkho);
            panel1.Location = new Point(-1, 89);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 368);
            panel1.TabIndex = 2;
            // 
            // dtgvBaocaotonkho
            // 
            dtgvBaocaotonkho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvBaocaotonkho.BackgroundColor = SystemColors.Control;
            dtgvBaocaotonkho.BorderStyle = BorderStyle.None;
            dtgvBaocaotonkho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvBaocaotonkho.Location = new Point(3, 0);
            dtgvBaocaotonkho.Name = "dtgvBaocaotonkho";
            dtgvBaocaotonkho.ReadOnly = true;
            dtgvBaocaotonkho.RowHeadersWidth = 51;
            dtgvBaocaotonkho.Size = new Size(795, 368);
            dtgvBaocaotonkho.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnInbaocao);
            flowLayoutPanel1.Controls.Add(btnQuaylai);
            flowLayoutPanel1.Location = new Point(478, 463);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(322, 53);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // btnInbaocao
            // 
            btnInbaocao.BackColor = SystemColors.HotTrack;
            btnInbaocao.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInbaocao.ForeColor = Color.White;
            btnInbaocao.Location = new Point(3, 3);
            btnInbaocao.Name = "btnInbaocao";
            btnInbaocao.Size = new Size(157, 42);
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
            btnQuaylai.Size = new Size(108, 42);
            btnQuaylai.TabIndex = 1;
            btnQuaylai.Text = "Quay lại";
            btnQuaylai.UseVisualStyleBackColor = false;
            btnQuaylai.Click += button2_Click;
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
            // BaoCaoTonKho
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 520);
            Controls.Add(panel3);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Controls.Add(textBox1);
            Name = "BaoCaoTonKho";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Báo Cáo Tồn Kho";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvBaocaotonkho).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Panel panel1;
        private DataGridView dtgvBaocaotonkho;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnInbaocao;
        private Button btnQuaylai;
        private Panel panel3;
        private Label lbYear;
        private Label label5;
        private Label lbMonth;
    }
}