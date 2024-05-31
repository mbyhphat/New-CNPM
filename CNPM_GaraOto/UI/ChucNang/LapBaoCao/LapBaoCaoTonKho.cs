using CNPM_GaraOto.UI.DAO;
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
    public partial class LapBaoCaoTonKho : Form
    {
        public LapBaoCaoTonKho()
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
                if(BaoCaoTonKhoDAO.Instance.CheckKiemTraThangTruoc(Convert.ToInt32(month), Convert.ToInt32(year)))
                {
                    BaoCaoTonKho baocao = new BaoCaoTonKho(month, year);
                    baocao.Show();
                }
                else
                {
                    MessageBox.Show("Bạn chưa lập báo cáo của tháng trước đó!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
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
