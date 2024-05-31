using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace CNPM_GaraOto.UI.DTO
{
    public class HieuXe_DTO
    {
        public HieuXe_DTO(int mahieuxe, string tenhieuxe)
        {
            this.MaHieuXe = mahieuxe;
            this.TenHieuXe = tenhieuxe;
        }   
        public HieuXe_DTO(DataRow ds)
        {
            this.MaHieuXe = Convert.ToInt32(ds["MaHieuXe"]);
            this.TenHieuXe = ds["TenHieuXe"].ToString();
        }
        private int mahieuxe;
        private string tenhieuxe;
        public int MaHieuXe { get { return mahieuxe; } set { mahieuxe = value; } }
        public string TenHieuXe { get { return tenhieuxe; } set { tenhieuxe = value; } }
    }
}
