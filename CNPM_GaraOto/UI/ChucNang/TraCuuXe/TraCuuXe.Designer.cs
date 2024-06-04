namespace CNPM_GaraOto.UI.ChucNang.TraCuuXe
{
    partial class TraCuuXe
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
            panel1 = new Panel();
            btnTim = new Button();
            btn_TraCuuXe = new Button();
            txbNhapbienso = new TextBox();
            lblNhapbienso = new Label();
            dvgtTraCuuXe = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgtTraCuuXe).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(btnTim);
            panel1.Controls.Add(btn_TraCuuXe);
            panel1.Controls.Add(txbNhapbienso);
            panel1.Controls.Add(lblNhapbienso);
            panel1.Location = new Point(12, 12);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1660, 134);
            panel1.TabIndex = 0;
            // 
            // btnTim
            // 
            btnTim.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnTim.BackColor = Color.FromArgb(224, 224, 224);
            btnTim.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTim.ForeColor = Color.Red;
            btnTim.Location = new Point(843, 0);
            btnTim.Margin = new Padding(2, 2, 2, 2);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(276, 129);
            btnTim.TabIndex = 9;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = false;
            btnTim.Click += button2_Click;
            // 
            // btn_TraCuuXe
            // 
            btn_TraCuuXe.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn_TraCuuXe.BackColor = Color.CornflowerBlue;
            btn_TraCuuXe.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_TraCuuXe.ForeColor = SystemColors.ButtonHighlight;
            btn_TraCuuXe.Location = new Point(1382, 5);
            btn_TraCuuXe.Margin = new Padding(2, 2, 2, 2);
            btn_TraCuuXe.Name = "btn_TraCuuXe";
            btn_TraCuuXe.Size = new Size(276, 129);
            btn_TraCuuXe.TabIndex = 8;
            btn_TraCuuXe.Text = " Tra cứu ";
            btn_TraCuuXe.UseVisualStyleBackColor = false;
            btn_TraCuuXe.Click += button1_Click;
            // 
            // txbNhapbienso
            // 
            txbNhapbienso.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txbNhapbienso.Location = new Point(408, 21);
            txbNhapbienso.Margin = new Padding(2, 2, 2, 2);
            txbNhapbienso.Name = "txbNhapbienso";
            txbNhapbienso.Size = new Size(424, 54);
            txbNhapbienso.TabIndex = 3;
            // 
            // lblNhapbienso
            // 
            lblNhapbienso.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblNhapbienso.AutoSize = true;
            lblNhapbienso.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNhapbienso.Location = new Point(2, 26);
            lblNhapbienso.Margin = new Padding(2, 0, 2, 0);
            lblNhapbienso.Name = "lblNhapbienso";
            lblNhapbienso.Size = new Size(334, 46);
            lblNhapbienso.TabIndex = 0;
            lblNhapbienso.Text = "Nhập biển số xe:";
            // 
            // dvgtTraCuuXe
            // 
            dvgtTraCuuXe.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dvgtTraCuuXe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgtTraCuuXe.BackgroundColor = SystemColors.Control;
            dvgtTraCuuXe.BorderStyle = BorderStyle.None;
            dvgtTraCuuXe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgtTraCuuXe.Location = new Point(0, 150);
            dvgtTraCuuXe.Margin = new Padding(2, 2, 2, 2);
            dvgtTraCuuXe.Name = "dvgtTraCuuXe";
            dvgtTraCuuXe.RowHeadersWidth = 102;
            dvgtTraCuuXe.Size = new Size(1888, 787);
            dvgtTraCuuXe.TabIndex = 1;
            // 
            // TraCuuXe
            // 
            AutoScaleDimensions = new SizeF(19F, 47F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1890, 933);
            Controls.Add(dvgtTraCuuXe);
            Controls.Add(panel1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "TraCuuXe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TraCuuXe";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvgtTraCuuXe).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txbNhapbienso;
        private Label lblNhapbienso;
        private Button btn_TraCuuXe;
        private DataGridView dvgtTraCuuXe;
        private Button btnTim;
    }
}