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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CNPM_GaraOto.UI.ChucNang.VatTuPhuTung
{
    public partial class ThemPhuTung : Form
    {
        public ThemPhuTung()
        {
            InitializeComponent();
        }
        public event EventHandler DataAdded;
        private void button1_Click(object sender, EventArgs e)
        {
            if (AccountDAO.Instance.getVaitro())
            {
                if (string.IsNullOrEmpty(txbTenvtpt.Text) || string.IsNullOrEmpty(txbGia.Text))
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult messageBox = MessageBox.Show("Thêm phụ tùng", "Bạn có muốn thêm phụ tùng này?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (messageBox == DialogResult.Yes)
                    {

                        string tenvtpt = txbTenvtpt.Text.ToString();
                        string dgn = txbGia.Text.ToString();
                        Decimal dongianhap = Decimal.Parse(dgn);
                        ThemPhuTunDAO.Instance.ThemVatTuPhuTung(tenvtpt, dongianhap);
                        DataAdded?.Invoke(this, EventArgs.Empty);
                        this.Close();
                    }
                
                }
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập chức năng này");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
