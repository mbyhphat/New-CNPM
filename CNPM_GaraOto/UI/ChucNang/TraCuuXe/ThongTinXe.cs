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

namespace CNPM_GaraOto.UI.ChucNang.TraCuuXe
{
    public partial class ThongTinXe : Form
    {
        private string bienSo;
        private TraCuuXe previousForm;
        /*private string hieuxe;
        private string tenchuxe;
        private string diachi;
        private string sdt;
        private string ngaytiepnhan;*/
        public ThongTinXe(string bienSo, TraCuuXe previousForm)
        {
            InitializeComponent();
            this.bienSo = bienSo;
            this.previousForm = previousForm;
            LoadThongTinXe();
            this.Load += ThongTinXe_Load;
        }
        public event EventHandler DataAdded;
        void LoadThongTinXe()
        {
            dvgtThongTinXe.DataSource = ThongTinXeDAO.Instance.GetThongTinXeByBienSo(bienSo);
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            DateTime ngaysuachua = LapPhieuSuaChuaDAO.Instance.GetNgaySuaChua(bienSo);
            if(ngaysuachua.Equals(DateTime.MinValue.Date))
            {
                MessageBox.Show("Chưa lập phiếu sửa chữa!");
            }
            else
            {
                ThemChiTietPhieuSuaChua t = new ThemChiTietPhieuSuaChua(this.bienSo);
                t.DataAdded += ThemChiTiet_DataAdded;
                this.Hide();
                t.ShowDialog();
                this.Show();
            }
        }
   
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, pnThongtinchung.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }
        private void ThongTinXe_Load(object sender, EventArgs e)
        {
            txbBienSo.Text = bienSo;

            DataRow thongTinChiTiet = ThongTinXeDAO.Instance.GetThongTinChiTietByBienSo(bienSo);
            if (thongTinChiTiet != null)
            {
                txbHoten.Text = thongTinChiTiet["TenChuXe"].ToString();
                txb_HieuXe.Text = thongTinChiTiet["TenHieuXe"].ToString();
                txbDiachi.Text = thongTinChiTiet["DiaChi"].ToString();
                txbSDT.Text = thongTinChiTiet["SDT"].ToString();
                txb_Ngaytiepnhan.Text = Convert.ToDateTime(thongTinChiTiet["NgayTiepNhan"]).ToString("dd/MM/yyyy");
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel2.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            decimal tienno = ThongTinXeDAO.Instance.GetTienNo(bienSo);
            if (tienno == 0)
            {
                MessageBox.Show("Khách hàng đã hoàn tất việc thanh toán!");
                return;
            }
            ThanhToan t = new ThanhToan(bienSo);
            this.Hide();
            t.ShowDialog();
            previousForm.LoadTraCuuXe();
            previousForm.AddBindingThongtinxe();
            this.Show();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult messageBox = MessageBox.Show("Sửa thông tin xe", "Bạn có muốn lưu những thay đổi này?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (messageBox == DialogResult.Yes)
            {
                string hoten = txbHoten.Text;
                string diachi = txbDiachi.Text;
                string sdt = txbSDT.Text;
                bool isUpdated = ThongTinXeDAO.Instance.SuaThongTinXe(hoten, sdt, diachi, bienSo);
                if(isUpdated)
                {
                    MessageBox.Show("Thông tin xe đã được cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadThongTinXe(); 
                    previousForm.LoadTraCuuXe();
                    previousForm.AddBindingThongtinxe();
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin xe thất bại. Vui lòng thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ThemChiTiet_DataAdded(object sender, EventArgs e)
        {
            LoadThongTinXe();
            previousForm.AddBindingThongtinxe();
        }
    }
}
