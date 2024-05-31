using CNPM_GaraOto.UI.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CNPM_GaraOto.UI.ChucNang.TiepNhanXe
{
    public partial class TiepNhanXe : Form
    {
        public TiepNhanXe()
        {
            InitializeComponent();
            LoadHieuXe();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadHieuXe()
        {
            List<DTO.HieuXe_DTO> list = DanhsachhieuxeDAO.Instance.LoadListHieuXe();

 
            foreach (DTO.HieuXe_DTO item in list)
            {
                string HieuXe = item.TenHieuXe.ToString();
                comboBox_HieuXe.Items.Add(HieuXe); 
            }
        }
 

        private void TiepNhanXe_Load(object sender, EventArgs e)
        {
            text_NgayTiepNhan.Text = DateTime.Now.ToString("yyyy/MM/dd");
        }

        private bool isValidPhoneNumber(string SoDienThoai)
        {
            foreach (char c in SoDienThoai)
            {
                if (!Char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        private bool check_dinhdang_NgaySuaChua(string giatri)
        {
            string dinhdang = "yyyy/MM/dd";
            DateTime ngaythang;
            if (DateTime.TryParseExact(giatri, dinhdang, CultureInfo.InvariantCulture, DateTimeStyles.None, out ngaythang)) return true;
            return false;
        }
        private void button_XacNhan_Click(object sender, EventArgs e)
        {
            string TenChuXe = text_TenChuXe.Text;
            string BienSoXe = text_BienSoXe.Text;
            string HieuXe = comboBox_HieuXe.Text;
            string DiaChi = text_DiaChi.Text;
            string SoDienThoai = text_SoDienThoai.Text;
            string Email = text_Email.Text;
            string NgayTiepNhan = text_NgayTiepNhan.Text;
            string NgayHomNay = DateTime.Today.ToString("yyyy/MM/dd");
            DateTime date_NgayHomNay = DateTime.ParseExact(NgayHomNay, "yyyy/MM/dd", CultureInfo.InvariantCulture);

            if (TenChuXe == "")
            {
                MessageBox.Show("Không được để trống Tên Chủ Xe!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (BienSoXe == "")
                {
                    MessageBox.Show("Không được để trống Biển Số Xe!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (HieuXe == "")
                    {
                        MessageBox.Show("Không được để trống Hiệu Xe!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (TimKiemHieuXeDAO.Instance.timkiem(HieuXe).MaHieuXe == 0)
                    {
                        MessageBox.Show("Không tìm thấy hiệu xe của bạn!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else 
                    {
                        if (DiaChi == "")
                        {
                            MessageBox.Show("Không được để trống Địa Chỉ!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            if (SoDienThoai == "")
                            {
                                MessageBox.Show("Không được để trống Số Điện Thoại!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else if (!isValidPhoneNumber(SoDienThoai))
                            {
                                MessageBox.Show("Số Điện Thoại chỉ được chứa số!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }    
                            else if (SoDienThoai.Length > 11 || SoDienThoai.Length < 10)
                            {
                                MessageBox.Show("Số Điện Thoại chỉ chứa 10 hoặc 11 chữ số!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else 
                            {
                                if (Email == "")
                                {
                                    MessageBox.Show("Không được để trống Email!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                else
                                {
                                    if (NgayTiepNhan == "")
                                    {
                                        MessageBox.Show("Không được để trống Ngày Tiếp Nhận!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                    else if (!check_dinhdang_NgaySuaChua(NgayTiepNhan))
                                    {
                                        MessageBox.Show("Ngày Tiếp Nhận không hợp lệ!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    } 
                                    else if (DateTime.ParseExact(NgayTiepNhan, "yyyy/MM/dd", CultureInfo.InvariantCulture).CompareTo(date_NgayHomNay) > 0)
                                    {
                                        MessageBox.Show("Ngày Tiếp Nhận chưa xảy ra!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                    else 
                                    {

                                        bool Xe_in_dboXE = TiepNhanXeDAO.Instance.check_Xe_in_dboXE(BienSoXe);
                                        if (Xe_in_dboXE)
                                        {
                                            TiepNhanXeDAO.Instance.updateNgayTiepNhan(BienSoXe, NgayTiepNhan);
                                            MessageBox.Show("Xe này đã được tiếp nhận trước đây!\nTiếp Nhận Xe thành công!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                        else
                                        {
                                            int MaKhachHang = TiepNhanXeDAO.Instance.set_MaKhachHang();
                                            TiepNhanXeDAO.Instance.ThemKhachHang(TenChuXe, DiaChi, Email, SoDienThoai);
                                            TiepNhanXeDAO.Instance.ThemXe(BienSoXe, MaKhachHang, HieuXe, NgayTiepNhan, 0);
                                            MessageBox.Show("Tiếp Nhận Xe thành công!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                        this.Close();

                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
