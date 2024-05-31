using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CNPM_GaraOto.UI.DAO
{
    public class TiepNhanXeDAO
    {
        private static TiepNhanXeDAO instance;
        public static TiepNhanXeDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TiepNhanXeDAO();
                }
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        public bool check_Xe_in_dboXE(string BienSoXe)
        {
            // False = Xe chưa từng được tiếp nhận, True = Xe đã được tiếp nhận trong quá khứ
            DataTable ThongTinXe_XE = DataProvider.Instance.ExecuteQuery("SELECT * FROM [dbo].[XE] where BienSo = ('" + BienSoXe + "')");
            if (ThongTinXe_XE.Rows.Count > 0 )
            {
                return true;
            }
            return false;
        }

        // Dùng để tạo `MAKHACHHANG` mới cho người lần đầu tiên tới GARA
        public int set_MaKhachHang()
        {
            string query = "SELECT IDENT_CURRENT('dbo.KHACHHANG') AS MaKhachHang";
            DataTable res = DataProvider.Instance.ExecuteQuery(query);
            if (res.Rows.Count > 0)
            {
                int MaKhachHang = Convert.ToInt32(res.Rows[0]["MaKhachHang"]) + 1;
                return MaKhachHang;
            }
            return 0;
        }

        public string get_NgayTiepNhan(string BienSoXe)
        {
            string query = "SELECT [NgayTiepNhan] FROM [dbo].[XE] where BienSo =" + "('" + BienSoXe + "')";
            DataTable res = DataProvider.Instance.ExecuteQuery(query);
            if (res.Rows.Count > 0)
            {
                string NgayTiepNhan_Time = res.Rows[0]["NgayTiepNhan"].ToString();
                DateTime ngayTiepNhanDateTime = DateTime.Parse(NgayTiepNhan_Time);
                string NgayTiepNhan= ngayTiepNhanDateTime.ToString("yyyy/MM/dd");
                return NgayTiepNhan;
            }
            return "";
        }

        public int get_MaHieuXe(string HieuXe)
        {
            string query = "SELECT MaHieuXe FROM [dbo].[HIEUXE] where TenHieuXe = ('" + HieuXe + "')";
            DataTable res = DataProvider.Instance.ExecuteQuery(query);

            if (res.Rows.Count > 0)
            {
                int MaHieuXe = Convert.ToInt32(res.Rows[0][0]);
                return MaHieuXe;
            }
            return 0;
        }

        public void updateNgayTiepNhan(string BienSoXe, string new_NgayTiepNhan)
        {
            string query = "UPDATE [dbo].[XE] set [NgayTiepNhan] = "+"('"+new_NgayTiepNhan+"') WHERE [BIENSO] =" + "('"+BienSoXe+"')";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public void ThemKhachHang(string TenChuXe, string DiaChi, string Email, string SoDienThoai)
        {
            string query = "INSERT INTO [dbo].[KHACHHANG] ([TenChuXe], [DiaChi], [Email], [SDT]) VALUES" + 
                "(N'"+TenChuXe+"', N'"+DiaChi+"', '"+Email+"', '"+SoDienThoai+"')";
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public void ThemXe(string BienSoXe, int MaKhachHang, string HieuXe, string NgayTiepNhan, float TienNo)
        {
            int MaHieuXe = get_MaHieuXe(HieuXe);
            string query = "INSERT INTO [dbo].[XE] ([BienSo], [MaKhachHang], [MaHieuXe], [NgayTiepNhan], [TienNo]) VALUES" +
    "('" + BienSoXe + "', '" + MaKhachHang + "', '" + MaHieuXe + "', '" + NgayTiepNhan + "', '" + TienNo + "')";
            DataProvider.Instance.ExecuteNonQuery(query);
        }

    }
}
