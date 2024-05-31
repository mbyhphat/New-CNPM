using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace CNPM_GaraOto.UI.DTO
{
    public class VatTuPhuTung_DTO
    {
        public VatTuPhuTung_DTO(int mavattuphutung, string tenvattuphutung, decimal dongianhap, decimal dongiaban, int soluongton)
        {
            this.MaVatTuPhuTung = mavattuphutung;
            this.TenVatTuPhuTung = tenvattuphutung;
            this.DonGiaNhap = dongianhap;
            this.DonGiaBan = dongiaban;
            this.SoLuongTon = soluongton;   
            
        }
        public VatTuPhuTung_DTO(DataRow ds)
        {
            this.MaVatTuPhuTung = Convert.ToInt32(ds["MaVatTuPhuTung"]);
            this.TenVatTuPhuTung = ds["TenVatTuPhuTung"].ToString();
            this.DonGiaNhap = Convert.ToDecimal(ds["DonGiaNhap"]);
            this.DonGiaBan = Convert.ToDecimal(ds["DonGiaBan"]);
            this.SoLuongTon = Convert.ToInt32(ds["SoLuongTon"]);
        }
        private int mavattuphutung, soluongton;
        private string tenvattuphutung;
        private decimal dongianhap, dongiaban;
        public int MaVatTuPhuTung { get { return mavattuphutung; } set { mavattuphutung = value; } }
        public string TenVatTuPhuTung { get { return tenvattuphutung; } set { tenvattuphutung = value; } }
        public decimal DonGiaNhap { get { return dongianhap; } set { dongianhap = value; } }
        public decimal DonGiaBan { get { return dongiaban; } set { dongiaban = value; } }
        public int SoLuongTon { get { return soluongton; } set { soluongton = value; } }
    }
}
