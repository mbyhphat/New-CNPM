namespace CNPM_GaraOto.UI.ChucNang.VatTuPhuTung
{
    partial class KhoPhuTung
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
            txbSearch = new TextBox();
            btnThem = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnSua = new Button();
            btnNhap = new Button();
            panel1 = new Panel();
            dtgvVTPT = new DataGridView();
            txbTenvtpt = new TextBox();
            label2 = new Label();
            txbDongianhap = new TextBox();
            label3 = new Label();
            txbDongiaban = new TextBox();
            label4 = new Label();
            txbSoluongton = new TextBox();
            label5 = new Label();
            panel2 = new Panel();
            txbMavtpt = new TextBox();
            label1 = new Label();
            btnSearch = new Button();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvVTPT).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(255, 255, 128);
            textBox1.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(1, 0);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(800, 39);
            textBox1.TabIndex = 0;
            textBox1.TabStop = false;
            textBox1.Text = "KHO PHỤ TÙNG ";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // txbSearch
            // 
            txbSearch.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbSearch.Location = new Point(1, 53);
            txbSearch.Name = "txbSearch";
            txbSearch.PlaceholderText = "Tên phụ tùng";
            txbSearch.Size = new Size(254, 30);
            txbSearch.TabIndex = 1;
            txbSearch.TabStop = false;
            // 
            // btnThem
            // 
            btnThem.BackColor = SystemColors.MenuHighlight;
            btnThem.CausesValidation = false;
            btnThem.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(3, 3);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 34);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm ";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += button1_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnThem);
            flowLayoutPanel1.Controls.Add(btnSua);
            flowLayoutPanel1.Controls.Add(btnNhap);
            flowLayoutPanel1.Location = new Point(395, 53);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(306, 37);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // btnSua
            // 
            btnSua.BackColor = SystemColors.MenuHighlight;
            btnSua.CausesValidation = false;
            btnSua.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(103, 3);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 34);
            btnSua.TabIndex = 4;
            btnSua.Text = "Sửa ";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += button2_Click;
            // 
            // btnNhap
            // 
            btnNhap.BackColor = Color.Lime;
            btnNhap.CausesValidation = false;
            btnNhap.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNhap.ForeColor = Color.Black;
            btnNhap.Location = new Point(203, 3);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(94, 34);
            btnNhap.TabIndex = 6;
            btnNhap.Text = "Nhập";
            btnNhap.UseVisualStyleBackColor = false;
            btnNhap.Click += button4_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(dtgvVTPT);
            panel1.Location = new Point(1, 242);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 292);
            panel1.TabIndex = 8;
            // 
            // dtgvVTPT
            // 
            dtgvVTPT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvVTPT.BackgroundColor = SystemColors.Control;
            dtgvVTPT.BorderStyle = BorderStyle.None;
            dtgvVTPT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvVTPT.Location = new Point(0, 3);
            dtgvVTPT.Name = "dtgvVTPT";
            dtgvVTPT.RowHeadersWidth = 51;
            dtgvVTPT.Size = new Size(797, 289);
            dtgvVTPT.TabIndex = 0;
            // 
            // txbTenvtpt
            // 
            txbTenvtpt.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbTenvtpt.Location = new Point(190, 41);
            txbTenvtpt.Name = "txbTenvtpt";
            txbTenvtpt.ScrollBars = ScrollBars.Both;
            txbTenvtpt.Size = new Size(125, 28);
            txbTenvtpt.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 44);
            label2.Name = "label2";
            label2.Size = new Size(173, 21);
            label2.TabIndex = 11;
            label2.Text = "Tên vật tư phụ tùng:";
            // 
            // txbDongianhap
            // 
            txbDongianhap.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbDongianhap.Location = new Point(520, 44);
            txbDongianhap.Name = "txbDongianhap";
            txbDongianhap.ReadOnly = true;
            txbDongianhap.Size = new Size(125, 28);
            txbDongianhap.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(352, 41);
            label3.Name = "label3";
            label3.Size = new Size(124, 21);
            label3.TabIndex = 13;
            label3.Text = "Đơn giá nhập:";
            // 
            // txbDongiaban
            // 
            txbDongiaban.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbDongiaban.Location = new Point(190, 79);
            txbDongiaban.Name = "txbDongiaban";
            txbDongiaban.ReadOnly = true;
            txbDongiaban.Size = new Size(125, 28);
            txbDongiaban.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 79);
            label4.Name = "label4";
            label4.Size = new Size(114, 21);
            label4.TabIndex = 15;
            label4.Text = "Đơn giá bán:";
            // 
            // txbSoluongton
            // 
            txbSoluongton.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbSoluongton.Location = new Point(520, 79);
            txbSoluongton.Name = "txbSoluongton";
            txbSoluongton.ReadOnly = true;
            txbSoluongton.Size = new Size(78, 28);
            txbSoluongton.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(352, 79);
            label5.Name = "label5";
            label5.Size = new Size(120, 21);
            label5.TabIndex = 17;
            label5.Text = "Số lượng tồn:";
            // 
            // panel2
            // 
            panel2.Controls.Add(txbMavtpt);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txbSoluongton);
            panel2.Controls.Add(txbTenvtpt);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txbDongiaban);
            panel2.Controls.Add(txbDongianhap);
            panel2.Location = new Point(4, 89);
            panel2.Name = "panel2";
            panel2.Size = new Size(794, 147);
            panel2.TabIndex = 21;
            // 
            // txbMavtpt
            // 
            txbMavtpt.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbMavtpt.Location = new Point(190, 7);
            txbMavtpt.Name = "txbMavtpt";
            txbMavtpt.ReadOnly = true;
            txbMavtpt.Size = new Size(125, 28);
            txbMavtpt.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 10);
            label1.Name = "label1";
            label1.Size = new Size(166, 21);
            label1.TabIndex = 19;
            label1.Text = "Mã vật tư phụ tùng:";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.ActiveBorder;
            btnSearch.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.IndianRed;
            btnSearch.Location = new Point(252, 53);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(58, 30);
            btnSearch.TabIndex = 22;
            btnSearch.Text = "Tìm";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // KhoPhuTung
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 534);
            Controls.Add(btnSearch);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(txbSearch);
            Controls.Add(textBox1);
            Font = new Font("Arial", 9F);
            Name = "KhoPhuTung";
            Text = "Kho phụ tùng";
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvVTPT).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox txbSearch;
        private Button btnThem;
        private Button btnSua;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private TextBox txbTenvtpt;
        private Label label2;
        private TextBox txbDongianhap;
        private Label label3;
        private TextBox txbDongiaban;
        private Label label4;
        private TextBox txbSoluongton;
        private Label label5;
        private Panel panel2;
        private DataGridView dtgvVTPT;
        private Button btnNhap;
        private TextBox txbMavtpt;
        private Label label1;
        private Button btnSearch;
    }
}
