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
            dateTimePicker1.Value = new DateTime(today.Year, today.Month, 1);
            dateTimePicker2.Value = dateTimePicker1.Value.AddMonths(1).AddDays(-1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime start = dateTimePicker1.Value;
            DateTime end = dateTimePicker2.Value;
            if (start != null && end != null)
            {
                if (start < end)
                {
                    BaoCaoPhieuNhapVTPT baocao = new BaoCaoPhieuNhapVTPT(dateTimePicker1.Value, dateTimePicker2.Value);
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
