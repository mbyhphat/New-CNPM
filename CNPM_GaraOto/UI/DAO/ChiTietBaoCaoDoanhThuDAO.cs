using CNPM_GaraOto.UI.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM_GaraOto.UI.DAO
{
    public class ChiTietBaoCaoDoanhThuDAO
    {
        private static ChiTietBaoCaoDoanhThuDAO instance;
        public static ChiTietBaoCaoDoanhThuDAO Instance
        {
            get { if (instance == null) instance = new ChiTietBaoCaoDoanhThuDAO(); return instance; }
            private set { instance = value; }
        }
        private ChiTietBaoCaoDoanhThuDAO() { }

        public List<ChiTietBaoCaoDoanhSo_DTO> LapBaoCaoDoanhSo(int month, int year)
        {
            List<ChiTietBaoCaoDoanhSo_DTO> baocao = new List<ChiTietBaoCaoDoanhSo_DTO> ();
            string query = string.Format("SELECT TenHieuXe, SoLuotSua, ThanhTien, TiLe" +
                "\r\nFROM HIEUXE hx, CHITIETBAOCAODOANHSO ct, BAOCAODOANHSO bc" +
                "\r\nWHERE  hx.MaHieuXe = ct.MaHieuXe AND ct.MaBaoCaoDoanhSo = bc.MaBaoCaoDoanhSo AND Thang = {0} AND Nam = {1}", month, year);
            DataTable data = DataProvider.Instance.ExecuteQuery (query);
            foreach(DataRow row in data.Rows)
            {
                ChiTietBaoCaoDoanhSo_DTO chitiet = new ChiTietBaoCaoDoanhSo_DTO(row);
                baocao.Add(chitiet);
            }
            return baocao;
        }
    }
}
