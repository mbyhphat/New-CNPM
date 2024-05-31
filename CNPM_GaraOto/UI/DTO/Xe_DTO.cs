using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM_GaraOto.UI.DTO
{
    public class Xe_DTO
    {
        public Xe_DTO(string bienso, string tenchuxe, string tenhieuxe, DateTime ngaytiepnhan, decimal tienno)
        {
            this.BienSo = bienso;
            this.TenChuXe = tenchuxe;
            this.TenHieuXe = tenhieuxe;
            this.NgayTiepNhan = ngaytiepnhan;
            this.TienNo = tienno;
        }
        public Xe_DTO(DataRow ds)
        {
            this.BienSo = ds["BienSo"].ToString();
            this.TenChuXe = ds["TenChuXe"].ToString();
            this.TenHieuXe = ds["TenHieuXe"].ToString();
            this.NgayTiepNhan = Convert.ToDateTime(ds["NgayTiepNhan"]);
            this.TienNo = Convert.ToDecimal(ds["TienNo"]);
        }
        private string bienso;
        private string tenchuxe, tenhieuxe;
        private DateTime ngaytiepnhan;
        private decimal tienno;
        public string BienSo { get { return bienso; } set { bienso = value; } }
        public string TenChuXe { get { return tenchuxe; } set { tenchuxe = value; } }
        public string TenHieuXe { get { return tenhieuxe; } set { tenhieuxe = value; } }
        public DateTime NgayTiepNhan { get { return ngaytiepnhan; } set { ngaytiepnhan = value; } }
        public decimal TienNo { get { return tienno; } set { tienno = value; } }
    }
}
