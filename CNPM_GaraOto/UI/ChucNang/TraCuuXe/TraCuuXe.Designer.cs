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
            button2 = new Button();
            button1 = new Button();
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
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txbNhapbienso);
            panel1.Controls.Add(lblNhapbienso);
            panel1.Location = new Point(5, 5);
            panel1.Margin = new Padding(1);
            panel1.Name = "panel1";
            panel1.Size = new Size(699, 57);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button2.BackColor = Color.FromArgb(224, 224, 224);
            button2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Red;
            button2.Location = new Point(355, 0);
            button2.Margin = new Padding(1);
            button2.Name = "button2";
            button2.Size = new Size(116, 55);
            button2.TabIndex = 9;
            button2.Text = "Tìm";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.CornflowerBlue;
            button1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(582, 2);
            button1.Margin = new Padding(1);
            button1.Name = "button1";
            button1.Size = new Size(116, 55);
            button1.TabIndex = 8;
            button1.Text = " Tra cứu ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txbNhapbienso
            // 
            txbNhapbienso.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txbNhapbienso.Location = new Point(172, 9);
            txbNhapbienso.Margin = new Padding(1);
            txbNhapbienso.Name = "txbNhapbienso";
            txbNhapbienso.Size = new Size(181, 27);
            txbNhapbienso.TabIndex = 3;
            // 
            // lblNhapbienso
            // 
            lblNhapbienso.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblNhapbienso.AutoSize = true;
            lblNhapbienso.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNhapbienso.Location = new Point(1, 11);
            lblNhapbienso.Margin = new Padding(1, 0, 1, 0);
            lblNhapbienso.Name = "lblNhapbienso";
            lblNhapbienso.Size = new Size(169, 24);
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
            dvgtTraCuuXe.Location = new Point(0, 64);
            dvgtTraCuuXe.Margin = new Padding(1);
            dvgtTraCuuXe.Name = "dvgtTraCuuXe";
            dvgtTraCuuXe.RowHeadersWidth = 102;
            dvgtTraCuuXe.Size = new Size(795, 335);
            dvgtTraCuuXe.TabIndex = 1;
            // 
            // TraCuuXe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(796, 397);
            Controls.Add(dvgtTraCuuXe);
            Controls.Add(panel1);
            Margin = new Padding(1);
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
        private Button button1;
        private DataGridView dvgtTraCuuXe;
        private Button button2;
    }
}