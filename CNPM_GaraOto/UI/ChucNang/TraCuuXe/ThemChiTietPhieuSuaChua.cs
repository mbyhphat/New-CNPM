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
            dateTimePicker1.Value = LapPhieuSuaChuaDAO.Instance.GetNgaySuaChua(biensoxe);
            LoadTienCong();
            LoadVatTuPhuTung();
        }
        private void LoadTienCong()
        {
            List<TienCong_DTO> tcDTO = TienCongDAO.Instance.GetTienCong();
            comboBox1.DataSource = tcDTO;
            comboBox1.DisplayMember = "NoiDung";
        } 
        private void LoadVatTuPhuTung()
        {
            List<VatTuPhuTung_DTO> vtpt = KhoPhuTungDAO.Instance.GetVatTuPhuTung();
            comboBox2.DataSource = vtpt;
            comboBox2.DisplayMember = "TenVatTuPhuTung";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult messageBox = MessageBox.Show("Bạn có muốn thêm vào các nội dung này?",
                "Thêm nội dung chi tiết sửa chữa", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (messageBox == DialogResult.Yes)
            {
                DateTime ngaysuachua = dateTimePicker1.Value;
                int matiencong = (comboBox1.SelectedItem as TienCong_DTO).MaTienCong;
                int mavtpt = (comboBox2.SelectedItem as VatTuPhuTung_DTO).MaVatTuPhuTung;
                int soluong = Convert.ToInt32(textBox4.Text.ToString());
                int maphieusuachua = ThemChiTietPhieuSuaChuaDAO.Instance.getMaPhieuSuaChuaTuNgayVaBienSo(biensoxe, ngaysuachua);  
                if(maphieusuachua==-1)
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
                ThemChiTietPhieuSuaChuaDAO.Instance.UpdateTonKho(mavtpt, soluong, dateTimePicker1.Value.Month, dateTimePicker1.Value.Year);
                DataAdded?.Invoke(this, EventArgs.Empty);
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
