using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace CNPM_GaraOto.UI.DTO
{
    public class ChiTietPhieuNhap_DTO
    {
        public ChiTietPhieuNhap_DTO(int maphieunhap, int mavattuphutung, int soluongnhap, decimal dongianhap, decimal thanhtien)
        {
            this.MaPhieuNhap = maphieunhap;
            this.MaVatTuPhuTung = mavattuphutung;
            this.SoLuongNhap = soluongnhap;
            this.DonGiaNhap = dongianhap;
            this.ThanhTien = thanhtien;
        }
        public ChiTietPhieuNhap_DTO(DataRow ds)
        {
            this.MaPhieuNhap = Convert.ToInt32(ds["MaPhieuNhap"]);
            this.MaVatTuPhuTung = Convert.ToInt32(ds["MaVatTuPhuTung"]);
            this.SoLuongNhap = Convert.ToInt32(ds["SoLuongNhap"]);
            this.DonGiaNhap = Convert.ToDecimal(ds["DonGiaNhap"]);
            this.ThanhTien = Convert.ToDecimal(ds["ThanhTien"]);
        }
        private int maphieunhap, mavattuphutung, soluongnhap;
        private decimal dongianhap, thanhtien;
        public int MaPhieuNhap { get { return maphieunhap; } set { maphieunhap = value; } }
        public int MaVatTuPhuTung { get { return mavattuphutung; } set { mavattuphutung = value; } }
        public int SoLuongNhap { get { return soluongnhap; } set { soluongnhap = value; } }
        public decimal DonGiaNhap { get { return dongianhap; } set { dongianhap = value; } }
        public decimal ThanhTien { get { return thanhtien; } set { thanhtien = value; } }
    }
}
