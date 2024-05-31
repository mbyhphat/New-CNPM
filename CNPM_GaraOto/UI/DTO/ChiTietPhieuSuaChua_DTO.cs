using CNPM_GaraOto.UI.ChucNang.LapPhieuSuaChua;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace CNPM_GaraOto.UI.DTO
{
    public class ChiTietPhieuSuaChua_DTO
    {
        public ChiTietPhieuSuaChua_DTO(int machitietphieusuachua, int maphieusuachua, int matiencong, decimal tiencong, decimal tongtienvattuphutung, decimal tongcong)
        {
            this.MaChiTietPhieuSuaChua = machitietphieusuachua;
            this.MaPhieuSuaChua = maphieusuachua;
            this.MaTienCong = matiencong;
            this.TienCong = tiencong;
            this.TongTienVatTuPhuTung = tongtienvattuphutung;
            this.TongCong = tongcong;
        }
        public ChiTietPhieuSuaChua_DTO(DataRow ds)
        {
            this.MaChiTietPhieuSuaChua = Convert.ToInt32(ds["MaChiTietPhieuSuaChua"]);
            this.MaPhieuSuaChua = Convert.ToInt32(ds["MaPhieuSuaChua"]);
            this.MaTienCong = Convert.ToInt32(ds["MaTienCong"]);
            this.TienCong = Convert.ToDecimal(ds["TienCong"]);
            this.TongTienVatTuPhuTung = Convert.ToDecimal(ds["TongTienVatTuPhuTung"]);
            this.TongCong = Convert.ToDecimal(ds["TongCong"]);
        }
        private int machitietphieusuachua, maphieusuachua, matiencong;
        private decimal tiencong, tongtienvattuphutung, tongcong;
        public int MaChiTietPhieuSuaChua { get { return machitietphieusuachua; } set { machitietphieusuachua = value; } }
        public int MaPhieuSuaChua { get { return maphieusuachua; } set { maphieusuachua = value; } }
        public int MaTienCong { get { return matiencong; } set { matiencong = value; } }
        public decimal TienCong { get { return tiencong; } set { tiencong = value; } }
        public decimal TongTienVatTuPhuTung { get { return tongtienvattuphutung; } set { tongtienvattuphutung = value; } }
        public decimal TongCong { get { return tongcong; } set { tongcong = value; } }
    }
}
