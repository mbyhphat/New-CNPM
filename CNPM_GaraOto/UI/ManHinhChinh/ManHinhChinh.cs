using CNPM_GaraOto.UI.ChucNang.LapBaoCao;
using CNPM_GaraOto.UI.ChucNang.LapPhieuSuaChua;
using CNPM_GaraOto.UI.ChucNang.ThayDoiQuyDinh;
using CNPM_GaraOto.UI.ChucNang.TienCong;
using CNPM_GaraOto.UI.ChucNang.TiepNhanXe;
using CNPM_GaraOto.UI.ChucNang.TraCuuXe;
using CNPM_GaraOto.UI.ChucNang.VatTuPhuTung;
using CNPM_GaraOto.UI.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPM_GaraOto.UI.ManHinhChinh
{
    public partial class ManHinhChinh : Form
    {
        public ManHinhChinh()
        {
            InitializeComponent();
            LoadThongTinUser();

        }

        private void LoadThongTinUser()
        {
            label3.Text = AccountDAO.Instance.getUsername();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TiepNhanXe t = new TiepNhanXe();
            t.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TraCuuXe t = new TraCuuXe();
            t.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LapPhieuSuaChua t = new LapPhieuSuaChua();
            t.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            KhoPhuTung t = new KhoPhuTung();
            t.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LapBaoCaoTonKho bc = new LapBaoCaoTonKho();
            this.Hide();
            bc.ShowDialog();
            this.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LapBaoCaoDoanhThu t = new LapBaoCaoDoanhThu();
            t.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ThayDoiQuyDinh t = new ThayDoiQuyDinh();
            t.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            DanhSachTienCong t = new DanhSachTienCong();
            t.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            LapBaoCaoPhieuNhapVTPT t = new LapBaoCaoPhieuNhapVTPT();  
            t.ShowDialog();
        }
    }
}
