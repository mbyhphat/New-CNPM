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
            btnXembaocao = new Button();
            btnQuaylai = new Button();
            panel1 = new Panel();
            dtpkEnd = new DateTimePicker();
            dtpkStart = new DateTimePicker();
            flowLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(-3, 20);
            label1.Name = "label1";
            label1.Size = new Size(544, 40);
            label1.TabIndex = 0;
            label1.Text = "LẬP BÁO CÁO NHẬP PHỤ TÙNG";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel2.Controls.Add(btnXembaocao);
            flowLayoutPanel2.Controls.Add(btnQuaylai);
            flowLayoutPanel2.Location = new Point(139, 146);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(250, 87);
            flowLayoutPanel2.TabIndex = 2;
            // 
            // btnXembaocao
            // 
            btnXembaocao.BackColor = SystemColors.HotTrack;
            btnXembaocao.ForeColor = Color.White;
            btnXembaocao.Location = new Point(3, 3);
            btnXembaocao.Name = "btnXembaocao";
            btnXembaocao.Size = new Size(247, 40);
            btnXembaocao.TabIndex = 0;
            btnXembaocao.Text = "Xem báo cáo";
            btnXembaocao.UseVisualStyleBackColor = false;
            btnXembaocao.Click += button1_Click;
            // 
            // btnQuaylai
            // 
            btnQuaylai.BackColor = SystemColors.ActiveCaptionText;
            btnQuaylai.ForeColor = Color.White;
            btnQuaylai.Location = new Point(3, 49);
            btnQuaylai.Name = "btnQuaylai";
            btnQuaylai.Size = new Size(247, 40);
            btnQuaylai.TabIndex = 3;
            btnQuaylai.Text = "Quay lại ";
            btnQuaylai.UseVisualStyleBackColor = false;
            btnQuaylai.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(dtpkEnd);
            panel1.Controls.Add(dtpkStart);
            panel1.Location = new Point(139, 63);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 75);
            panel1.TabIndex = 3;
            // 
            // dtpkEnd
            // 
            dtpkEnd.CustomFormat = "dd/MM/yyyy";
            dtpkEnd.Format = DateTimePickerFormat.Custom;
            dtpkEnd.Location = new Point(0, 39);
            dtpkEnd.Name = "dtpkEnd";
            dtpkEnd.Size = new Size(250, 27);
            dtpkEnd.TabIndex = 1;
            // 
            // dtpkStart
            // 
            dtpkStart.CustomFormat = "dd/MM/yyyy";
            dtpkStart.Format = DateTimePickerFormat.Custom;
            dtpkStart.Location = new Point(0, 6);
            dtpkStart.Name = "dtpkStart";
            dtpkStart.Size = new Size(250, 27);
            dtpkStart.TabIndex = 0;
            // 
            // LapBaoCaoPhieuNhapVTPT
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 283);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(label1);
            Name = "LapBaoCaoPhieuNhapVTPT";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lập Báo Cáo Phiếu Nhập Vật Tư Phụ Tùng";
            flowLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button btnXembaocao;
        private Button btnQuaylai;
        private Panel panel1;
        private DateTimePicker dtpkEnd;
        private DateTimePicker dtpkStart;
    }
}