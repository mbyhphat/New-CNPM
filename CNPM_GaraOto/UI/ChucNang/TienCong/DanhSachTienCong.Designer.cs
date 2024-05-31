namespace CNPM_GaraOto.UI.ChucNang.TienCong
{
    partial class DanhSachTienCong
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
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            txbNoidung = new TextBox();
            label2 = new Label();
            txbTiencong = new TextBox();
            label4 = new Label();
            panel2 = new Panel();
            txbMatc = new TextBox();
            label1 = new Label();
            btnSearch = new Button();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.BackColor = Color.FromArgb(255, 255, 128);
            textBox1.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(1, -1);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(815, 39);
            textBox1.TabIndex = 0;
            textBox1.TabStop = false;
            textBox1.Text = "NỘI DUNG SỬA CHỮA";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // txbSearch
            // 
            txbSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txbSearch.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbSearch.Location = new Point(1, 52);
            txbSearch.Name = "txbSearch";
            txbSearch.PlaceholderText = "Tên tiền công ";
            txbSearch.Size = new Size(269, 30);
            txbSearch.TabIndex = 1;
            txbSearch.TabStop = false;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            btnThem.Click += btnThem_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.Controls.Add(btnThem);
            flowLayoutPanel1.Controls.Add(btnSua);
            flowLayoutPanel1.Location = new Point(395, 52);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(201, 37);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            btnSua.Click += btnSua_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(1, 241);
            panel1.Name = "panel1";
            panel1.Size = new Size(815, 292);
            panel1.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(812, 289);
            dataGridView1.TabIndex = 0;
            // 
            // txbNoidung
            // 
            txbNoidung.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txbNoidung.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbNoidung.Location = new Point(190, 41);
            txbNoidung.Name = "txbNoidung";
            txbNoidung.ScrollBars = ScrollBars.Both;
            txbNoidung.Size = new Size(140, 28);
            txbNoidung.TabIndex = 12;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 48);
            label2.Name = "label2";
            label2.Size = new Size(87, 21);
            label2.TabIndex = 11;
            label2.Text = "Nội dung:";
            // 
            // txbTiencong
            // 
            txbTiencong.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txbTiencong.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbTiencong.Location = new Point(190, 79);
            txbTiencong.Name = "txbTiencong";
            txbTiencong.Size = new Size(140, 28);
            txbTiencong.TabIndex = 16;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 79);
            label4.Name = "label4";
            label4.Size = new Size(94, 21);
            label4.TabIndex = 15;
            label4.Text = "Tiền công:";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(txbMatc);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txbNoidung);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txbTiencong);
            panel2.Location = new Point(4, 88);
            panel2.Name = "panel2";
            panel2.Size = new Size(809, 147);
            panel2.TabIndex = 21;
            // 
            // txbMatc
            // 
            txbMatc.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txbMatc.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbMatc.Location = new Point(190, 7);
            txbMatc.Name = "txbMatc";
            txbMatc.ReadOnly = true;
            txbMatc.Size = new Size(140, 28);
            txbMatc.TabIndex = 20;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 10);
            label1.Name = "label1";
            label1.Size = new Size(123, 21);
            label1.TabIndex = 19;
            label1.Text = "Mã tiền công: ";
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnSearch.BackColor = SystemColors.ActiveBorder;
            btnSearch.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.IndianRed;
            btnSearch.Location = new Point(252, 44);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(73, 38);
            btnSearch.TabIndex = 22;
            btnSearch.Text = "Tìm";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // DanhSachTienCong
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 535);
            Controls.Add(btnSearch);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(txbSearch);
            Controls.Add(textBox1);
            Font = new Font("Arial", 9F);
            Name = "DanhSachTienCong";
            Text = "Nội dung sửa chữa";
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private TextBox txbNoidung;
        private Label label2;
        private Label label3;
        private TextBox txbTiencong;
        private Label label4;
        private Label label5;
        private Panel panel2;
        private DataGridView dataGridView1;
        private TextBox txbMatc;
        private Label label1;
        private Button btnSearch;
    }
}