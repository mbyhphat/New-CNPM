namespace CNPM_GaraOto.UI.ChucNang.ThayDoiQuyDinh
{
    partial class DanhSachHieuXe
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
            DanhSachHieuXe_DtGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DanhSachHieuXe_DtGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 20F);
            label1.Location = new Point(112, 9);
            label1.Name = "label1";
            label1.Size = new Size(709, 75);
            label1.TabIndex = 1;
            label1.Text = "Danh sách các hiệu xe";
            // 
            // DanhSachHieuXe_DtGridView
            // 
            DanhSachHieuXe_DtGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DanhSachHieuXe_DtGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DanhSachHieuXe_DtGridView.BackgroundColor = SystemColors.Control;
            DanhSachHieuXe_DtGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DanhSachHieuXe_DtGridView.Location = new Point(112, 51);
            DanhSachHieuXe_DtGridView.Name = "DanhSachHieuXe_DtGridView";
            DanhSachHieuXe_DtGridView.RowHeadersWidth = 51;
            DanhSachHieuXe_DtGridView.Size = new Size(356, 321);
            DanhSachHieuXe_DtGridView.TabIndex = 2;
            // 
            // DanhSachHieuXe
            // 
            AutoScaleDimensions = new SizeF(17F, 35F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 384);
            Controls.Add(DanhSachHieuXe_DtGridView);
            Controls.Add(label1);
            Font = new Font("Arial", 9F);
            Name = "DanhSachHieuXe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DanhSachHieuXe";
            Load += DanhSachHieuXe_Load;
            ((System.ComponentModel.ISupportInitialize)DanhSachHieuXe_DtGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private DataGridView DanhSachHieuXe_DtGridView;
    }
}