using CNPM_GaraOto.UI.DAO;
using CNPM_GaraOto.UI.DTO;
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
    public partial class NhapPhuTung : Form
    {
        public NhapPhuTung()
        {
            InitializeComponent();
            LoadVTPT();
        }
        public event EventHandler DataAdded;
        void LoadVTPT()
        {
            List<VatTuPhuTung_DTO> vtpt = KhoPhuTungDAO.Instance.GetVatTuPhuTung();
            cbTenvtpt.DataSource = vtpt;
            cbTenvtpt.DisplayMember = "TenVatTuPhuTung";
            txbMavtpt.Text = (cbTenvtpt.SelectedItem as VatTuPhuTung_DTO).MaVatTuPhuTung.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AccountDAO.Instance.getVaitro())
            {
                if (string.IsNullOrEmpty(txbDongianhap.Text) || string.IsNullOrEmpty(txbSoluong.Text))
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DateTime ngaynhap = dtpkNgaynhapvtpt.Value;
                    int maphieunhap = KhoPhuTungDAO.Instance.GetMaNhapVTPT(ngaynhap);
                    int mavtpt = (cbTenvtpt.SelectedItem as VatTuPhuTung_DTO).MaVatTuPhuTung;
                    int soluong = int.Parse(txbSoluong.Text.ToString());
                    Decimal dongianhap = Decimal.Parse(txbDongianhap.Text.ToString());
                    Decimal thanhtien = soluong * dongianhap;

                    KhoPhuTungDAO.Instance.NhapVTPT(maphieunhap, mavtpt, soluong, dongianhap, thanhtien);

                    KhoPhuTungDAO.Instance.UpdatePhieuNhapVTPT(maphieunhap, thanhtien);
                    KhoPhuTungDAO.Instance.UpdateBaoCaoTonKho(mavtpt, soluong, ngaynhap.Month, ngaynhap.Year);
                    KhoPhuTungDAO.Instance.UpdateKhoVTPT(mavtpt, soluong, dongianhap);
                    KhoPhuTungDAO.Instance.UpdateCacBaoCaoTonKho(soluong, mavtpt, ngaynhap.Month, ngaynhap.Year);
                    DataAdded?.Invoke(this, EventArgs.Empty);
                    this.Close();
                }
                
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập vào chức năng này");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {

            txbMavtpt.Text = (cbTenvtpt.SelectedItem as VatTuPhuTung_DTO).MaVatTuPhuTung.ToString();
        }
    }
}
