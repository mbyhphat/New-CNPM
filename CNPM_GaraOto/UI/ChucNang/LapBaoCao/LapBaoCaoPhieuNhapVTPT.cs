using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPM_GaraOto.UI.ChucNang.LapBaoCao
{
    public partial class LapBaoCaoPhieuNhapVTPT : Form
    {
        public LapBaoCaoPhieuNhapVTPT()
        {
            InitializeComponent();
            LoadDateTimePicker();
        }

        void LoadDateTimePicker()
        {
            DateTime today = DateTime.Now;
            dtpkStart.Value = new DateTime(today.Year, today.Month, 1);
            dtpkEnd.Value = dtpkStart.Value.AddMonths(1).AddDays(-1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime start = dtpkStart.Value;
            DateTime end = dtpkEnd.Value;
            if (start != null && end != null)
            {
                if (start < end)
                {
                    BaoCaoPhieuNhapVTPT baocao = new BaoCaoPhieuNhapVTPT(dtpkStart.Value, dtpkEnd.Value);
                    this.Hide();
                    baocao.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn ngaỳ bắt đầu nhỏ hơn ngày kết thúc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (start == null)
            {
                MessageBox.Show("Vui lòng chọn ngaỳ bắt đầu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ngày kết thúc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
