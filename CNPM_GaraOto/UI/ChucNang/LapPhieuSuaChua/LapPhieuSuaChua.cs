using CNPM_GaraOto.UI.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace CNPM_GaraOto.UI.ChucNang.LapPhieuSuaChua
{
    public partial class LapPhieuSuaChua : Form
    {
        public LapPhieuSuaChua()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LapPhieuSuaChua_Load(object sender, EventArgs e)
        {
            textBox_NgaySuaChua.Text = DateTime.Now.ToString("yyyy/MM/dd");
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
            string BienSoXe = textBox_BienSoXe.Text;
            string NgaySuaChua = textBox_NgaySuaChua.Text;
            string NgayHomNay = DateTime.Today.ToString("yyyy/MM/dd");
            DateTime date_NgayHomNay = DateTime.ParseExact(NgayHomNay, "yyyy/MM/dd", CultureInfo.InvariantCulture);

            if (BienSoXe == "")
            {
                MessageBox.Show("Chưa nhập Biển Số Xe!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (NgaySuaChua == "")
                {
                    MessageBox.Show("Chưa nhập Ngày Sửa Chữa!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (!check_dinhdang_NgaySuaChua(NgaySuaChua))
                    {
                        MessageBox.Show("Định dạng Ngày Sửa Chữa không hợp lệ!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (DateTime.ParseExact(NgaySuaChua, "yyyy/MM/dd", CultureInfo.InvariantCulture).CompareTo(date_NgayHomNay) > 0)
                    {
                        MessageBox.Show("Ngày Sửa Chữa chưa xảy ra!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        bool Xe_in_dboXE = TiepNhanXeDAO.Instance.check_Xe_in_dboXE(BienSoXe);

                        if (!Xe_in_dboXE)
                        {
                            MessageBox.Show("Xe này chưa được tiếp nhận trong Gara!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else 
                        {
                            string NgayTiepNhan = TiepNhanXeDAO.Instance.get_NgayTiepNhan(BienSoXe);
                            DateTime dt_NgayTiepNhan = DateTime.ParseExact(NgayTiepNhan, "yyyy/MM/dd", CultureInfo.InvariantCulture);

                            DateTime dt_NgaySuaChua = DateTime.ParseExact(NgaySuaChua, "yyyy/MM/dd", CultureInfo.InvariantCulture);
                            if (dt_NgayTiepNhan.CompareTo(dt_NgaySuaChua) > 0)
                            {
                                MessageBox.Show("Ngày Sửa Chữa không thể xảy ra trước Ngày Tiếp Nhận", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                if (LapPhieuSuaChuaDAO.Instance.isSuaChuaThemXe(BienSoXe, NgaySuaChua))
                                {
                                    bool Xe_in_dboPHIEUSUACHUA = LapPhieuSuaChuaDAO.Instance.check_Xe_in_dboPHIEUSUACHUA(BienSoXe);
                                    if (Xe_in_dboPHIEUSUACHUA)
                                    {
                                        LapPhieuSuaChuaDAO.Instance.updateNgaySuaChua(BienSoXe, NgaySuaChua);
                                        MessageBox.Show("Xe này đã được lập phiếu trước đây!\nLập Phiếu Sửa Chữa thành công!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        LapPhieuSuaChuaDAO.Instance.LapPhieu(BienSoXe, NgaySuaChua, 0);
                                        MessageBox.Show("Đã lập phiếu sửa chữa cho xe!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Đã tiếp nhận đủ số xe trong ngày!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
