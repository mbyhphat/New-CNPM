using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace CNPM_GaraOto.UI.DTO
{
    public class PhieuSuaChua_DTO
    {
        public PhieuSuaChua_DTO(int maphieusuachua, string bienso, DateTime ngaysuachua, decimal tongtien)
        {
            this.MaPhieuSuaChua = maphieusuachua;
            this.BienSo = bienso;
            this.NgaySuaChua = ngaysuachua;
            this.TongTien = tongtien;
        }
        public PhieuSuaChua_DTO(DataRow ds)
        {
            this.MaPhieuSuaChua = Convert.ToInt32(ds["MaPhieuSuaChua"]);
            this.BienSo = ds["BienSo"].ToString();
            this.NgaySuaChua = Convert.ToDateTime(ds["NgaySuaChua"]);
            this.TongTien = Convert.ToDecimal(ds["TongTien"]);
        }
        private int maphieusuachua;
        private string bienso;
        private DateTime ngaysuachua;
        private decimal tongtien;
        public int MaPhieuSuaChua { get { return maphieusuachua; } set { maphieusuachua = value; } }
        public string BienSo { get { return bienso; } set { bienso = value; } }
        public DateTime NgaySuaChua { get { return ngaysuachua; } set { ngaysuachua = value; } }
        public decimal TongTien { get { return tongtien; } set { tongtien = value; } }
    }
}
