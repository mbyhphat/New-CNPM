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
    public partial class LapBaoCaoDoanhThu : Form
    {
        public LapBaoCaoDoanhThu()
        {
            InitializeComponent();
            cbMonth.SelectedItem = DateTime.Now.ToString("MM");
            cbYear.SelectedItem = DateTime.Now.ToString("yyyy");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbMonth.SelectedItem != null && cbYear.SelectedItem != null)
            {
                string month = cbMonth.SelectedItem.ToString();
                string year = cbYear.SelectedItem.ToString();
                BaoCaoDoanhThu baocao = new BaoCaoDoanhThu(month, year);
                this.Hide();
                baocao.ShowDialog();
                this.Show();
            }
            else if (cbMonth.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn tháng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn năm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
