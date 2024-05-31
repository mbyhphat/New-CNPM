using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CNPM_GaraOto.UI.DTO
{
    public class TraCuuXe_DTO
    {
        public TraCuuXe_DTO(string tenChuXe, string bienSo, string tenHieuXe, DateTime ngayTiepNhan, decimal tienNo)
        {
            TenChuXe = tenChuXe;
            BienSo = bienSo;
            TenHieuXe = tenHieuXe;
            NgayTiepNhan = ngayTiepNhan;
            TienNo = tienNo;
        }

        public TraCuuXe_DTO(DataRow row)
        {
            TenChuXe = row["TenChuXe"].ToString();
            BienSo = row["BienSo"].ToString();
            TenHieuXe = row["TenHieuXe"].ToString();
            NgayTiepNhan = Convert.ToDateTime(row["NgayTiepNhan"]);
            TienNo = Convert.ToDecimal(row["TienNo"]);
        }

        public string TenChuXe { get; set; }
        public string BienSo { get; set; }
        public string TenHieuXe { get; set; }
        public DateTime NgayTiepNhan { get; set; }
        public decimal TienNo { get; set; }
    }
}