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

namespace CNPM_GaraOto.UI.ChucNang.TraCuuXe
{
    public partial class ThemChiTietPhieuSuaChua : Form
    {
        private string biensoxe;
        public event EventHandler DataAdded;
        public ThemChiTietPhieuSuaChua(string biensoxe)
        {
            InitializeComponent();
            this.biensoxe = biensoxe;
            dtpNgaysuachua.Value = LapPhieuSuaChuaDAO.Instance.GetNgaySuaChua(biensoxe);
            LoadTienCong();
            LoadVatTuPhuTung();
        }
        private void LoadTienCong()
        {
            List<TienCong_DTO> tcDTO = TienCongDAO.Instance.GetTienCong();
            cbNoidung.DataSource = tcDTO;
            cbNoidung.DisplayMember = "NoiDung";
        } 
        private void LoadVatTuPhuTung()
        {
            List<VatTuPhuTung_DTO> vtpt = KhoPhuTungDAO.Instance.GetVatTuPhuTung();
            cbVattuphutung.DataSource = vtpt;
            cbVattuphutung.DisplayMember = "TenVatTuPhuTung";
        }
        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult messageBox;

            if (!string.IsNullOrEmpty(txbSoluong.Text))
            {
                messageBox = MessageBox.Show("Bạn có muốn thêm vào các nội dung này?",
                    "Thêm nội dung chi tiết sửa chữa", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số lượng trước.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbSoluong.Focus();
                return; // Kết thúc phương thức nếu không nhập số lượng
            }

            if (messageBox == DialogResult.Yes)
            {
                DateTime ngaysuachua = dtpNgaysuachua.Value;
                int matiencong = (cbNoidung.SelectedItem as TienCong_DTO).MaTienCong;
                int mavtpt = (cbVattuphutung.SelectedItem as VatTuPhuTung_DTO).MaVatTuPhuTung;
                int soluong;

                try
                {
                    soluong = Convert.ToInt32(txbSoluong.Text.ToString());
                }
                catch
                {
                    MessageBox.Show("Số lượng không hợp lệ. Vui lòng nhập lại số nguyên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbSoluong.Focus();
                    return; // Kết thúc phương thức nếu số lượng không hợp lệ
                }

                int maphieusuachua = ThemChiTietPhieuSuaChuaDAO.Instance.getMaPhieuSuaChuaTuNgayVaBienSo(biensoxe, ngaysuachua);
                if (maphieusuachua == -1)
                {
                    MessageBox.Show("Dữ liệu nhập sai, vui lòng nhập lại!");
                    return;
                }

                if (!ThemChiTietPhieuSuaChuaDAO.Instance.checkConDuVatTuPhuTung(mavtpt, soluong))
                {
                    MessageBox.Show("Không còn đủ vật tư phụ tùng");
                    return;
                }

                ThemChiTietPhieuSuaChuaDAO.Instance.ThemChiTiet(maphieusuachua, matiencong, mavtpt, soluong);
                ThemChiTietPhieuSuaChuaDAO.Instance.UpdateTonKho(mavtpt, soluong, dtpNgaysuachua.Value.Month, dtpNgaysuachua.Value.Year);
                DataAdded?.Invoke(this, EventArgs.Empty);
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
