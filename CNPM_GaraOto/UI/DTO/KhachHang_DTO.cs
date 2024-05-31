using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace CNPM_GaraOto.UI.DTO
{
    public class KhachHang_DTO
    {
        public KhachHang_DTO(int makhachhang, string tenchuxe, string diachi, string email, string sdt)
        {
            this.MaKhachHang = makhachhang;
            this.TenChuXe = tenchuxe;
            this.DiaChi = diachi;
            this.Email = email;
            this.SDT = sdt;
        }
        public KhachHang_DTO(DataRow ds)
        {
            this.MaKhachHang = Convert.ToInt32(ds["MaKhachHang"]);
            this.TenChuXe = ds["TenChu"].ToString();
            this.DiaChi = ds["DiaChi"].ToString();
            this.Email = ds["Email"].ToString();
            this.SDT = ds["SDT"].ToString();
        }
        private int makhachhang;
        private string tenchuxe, diachi, email, sdt;
        public int MaKhachHang {get { return makhachhang; } set{makhachhang = value;} }
        public string TenChuXe { get { return tenchuxe; } set { tenchuxe = value; } }
        public string DiaChi { get { return diachi; } set { diachi = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string SDT { get { return sdt; } set { sdt = value; } }
    }
}
