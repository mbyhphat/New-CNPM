using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace CNPM_GaraOto.UI.DTO
{
    public class PhieuNhapVatTuPhuTung_DTO
    {
        public PhieuNhapVatTuPhuTung_DTO(int maphieunhap, DateTime ngaynhap, decimal tongtien)
        {
            this.MaPhieuNhap = maphieunhap;
            this.NgayNhap = ngaynhap;
            this.TongTien = tongtien;
        }    
        public PhieuNhapVatTuPhuTung_DTO(DataRow ds)
        {
            this.MaPhieuNhap = Convert.ToInt32(ds["MaPhieuNhap"]);
            this.NgayNhap = Convert.ToDateTime(ds["NgayNhap"]);
            this.TongTien = Convert.ToDecimal(ds["TongTien"]);
        }
        private int maphieunhap;
        private DateTime ngaynhap;
        private decimal tongtien;
        public int MaPhieuNhap { get { return maphieunhap; } set { maphieunhap = value; } }
        public DateTime NgayNhap { get { return ngaynhap; } set { ngaynhap = value; } }
        public decimal TongTien { get { return tongtien; } set { tongtien = value; } }
    }
}
