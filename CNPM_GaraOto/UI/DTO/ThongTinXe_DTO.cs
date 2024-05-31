using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CNPM_GaraOto.UI.DTO
{
    public class ThongTinXe_DTO
    {
        public ThongTinXe_DTO(int matiencong, string noidung, string tenvattuphutung, int soluong, decimal dongia, decimal tiencong, decimal tongcong)
        {
            this.MaTienCong = matiencong;
            this.NoiDung = noidung;
            this.TenVatTuPhuTung = tenvattuphutung;
            this.SoLuong = soluong;
            this.DonGia = dongia;
            this.TienCong = tiencong;
            this.TongCong = tongcong;
        }

        public ThongTinXe_DTO(DataRow row)
        {
            this.MaTienCong = Convert.ToInt32(row["MaTienCong"]);
            this.NoiDung = row["NoiDung"].ToString();
            this.TenVatTuPhuTung = row["TenVatTuPhuTung"].ToString();
            this.SoLuong = Convert.ToInt32(row["SoLuong"]);
            this.DonGia = Convert.ToDecimal(row["DonGia"]);
            this.TienCong = Convert.ToDecimal(row["TienCong"]);
            this.TongCong = Convert.ToDecimal(row["TongCong"]);
        }

        public int MaTienCong { get; set; }
        public string NoiDung { get; set; }
        public string TenVatTuPhuTung { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public decimal TienCong { get; set; }
        public decimal TongCong { get; set; }
    }
}