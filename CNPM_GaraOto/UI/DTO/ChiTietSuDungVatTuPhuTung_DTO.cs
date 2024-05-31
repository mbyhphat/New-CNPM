using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace CNPM_GaraOto.UI.DTO
{
    public class ChiTietSuDungVatTuPhuTung_DTO
    {
        public ChiTietSuDungVatTuPhuTung_DTO(int machitietphieusuachua, int mavattuphutung, int soluong, decimal dongia, decimal thanhtien)
        {
            this.MaChiTietPhieuSuaChua = machitietphieusuachua;
            this.MaVatTuPhuTung = mavattuphutung;
            this.SoLuong = soluong;
            this.DonGia = dongia;
            this.ThanhTien = thanhtien;
        }
        public ChiTietSuDungVatTuPhuTung_DTO(DataRow ds)
        {
            this.MaChiTietPhieuSuaChua = Convert.ToInt32(ds["MaChiTietPhieuSuaChua"]);
            this.MaVatTuPhuTung = Convert.ToInt32(ds["MaVatTuPhuTung"]);
            this.SoLuong = Convert.ToInt32(ds["SoLuong"]);
            this.DonGia = Convert.ToDecimal(ds["DonGia"]);
            this.ThanhTien = Convert.ToDecimal(ds["ThanhTien"]);
        }
        private int machitietphieusuachua, mavattuphutung, soluong;
        private decimal dongia, thanhtien;
        public int MaChiTietPhieuSuaChua { get { return machitietphieusuachua; } set { machitietphieusuachua = value; } }
        public int MaVatTuPhuTung { get { return mavattuphutung; } set { mavattuphutung = value; } }
        public int SoLuong { get { return soluong; } set { soluong = value; } }
        public decimal DonGia { get { return dongia; } set { dongia = value; } }
        public decimal ThanhTien { get { return thanhtien; } set { thanhtien = value; } }
    }
}
