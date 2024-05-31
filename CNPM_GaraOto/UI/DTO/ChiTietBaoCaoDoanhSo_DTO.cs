using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace CNPM_GaraOto.UI.DTO
{
    public class ChiTietBaoCaoDoanhSo_DTO
    {
        public ChiTietBaoCaoDoanhSo_DTO(string tenhieuxe, int soluotsua, decimal thanhtien, decimal tile)
        {
            this.TenHieuXe = tenhieuxe;
            this.SoLuotSua = soluotsua;
            this.ThanhTien = thanhtien;
            this.TiLe = tile;
        }
        public ChiTietBaoCaoDoanhSo_DTO(DataRow ds)
        {
            this.TenHieuXe = ds["TenHieuXe"].ToString();
            this.SoLuotSua = Convert.ToInt32(ds["SoLuotSua"]);
            this.ThanhTien = Convert.ToDecimal(ds["ThanhTien"]);
            this.TiLe = Convert.ToDecimal(ds["TiLe"]);
        }
        private int soluotsua;
        private decimal thanhtien, tile;
        string tenhieuxe;
        public string TenHieuXe { get { return tenhieuxe; } set { tenhieuxe = value; } }
        public int SoLuotSua { get { return soluotsua; } set { soluotsua = value; } }
        public decimal ThanhTien { get { return thanhtien; } set { thanhtien = value; } }
        public decimal TiLe { get { return tile; } set { tile = value; } }
    }
}
