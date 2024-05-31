using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace CNPM_GaraOto.UI.DAO
{
    public class LapPhieuSuaChuaDAO
    {
        private static LapPhieuSuaChuaDAO instance;
        public static LapPhieuSuaChuaDAO Instance
        {
            get
            {
                if (instance == null)
                { 
                    instance = new LapPhieuSuaChuaDAO();
                }
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

 
        public bool check_Xe_in_dboPHIEUSUACHUA(string BienSoXe)
        {
            // False = Xe chưa từng được lập phiếu sửa chữa, True = Xe đã được đã được lập phiếu sửa chữa trong quá khứ
            DataTable ThongTinXe_PHIEUSUACHUA = DataProvider.Instance.ExecuteQuery("SELECT * FROM [dbo].[PHIEUSUACHUA] where BienSo = ('" + BienSoXe + "')");
            if (ThongTinXe_PHIEUSUACHUA.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }

        public int get_MaPhieuSuaChua()
        {
            string query = "SELECT COUNT(*) AS TotalRows FROM [dbo].[PHIEUSUACHUA];";
            DataTable res = DataProvider.Instance.ExecuteQuery(query); 
            if (res.Rows.Count > 0)
            {
                int MaPhieuSuaChua = Convert.ToInt32(res.Rows[0]["TotalRows"]) + 1;
                return MaPhieuSuaChua;
            }
            return 0;
        }

        public int GetMaHieuXe(string bienso)
        {
            string query = string.Format("Select MaHieuXe From XE Where BienSo = '{0}'", bienso);
            return (int)DataProvider.Instance.ExecuteScalar(query);
        }

        public void LapPhieu(string BienSoXe, string NgaySuaChua, float TongTien)
        {
            string query = "INSERT INTO [dbo].[PHIEUSUACHUA] ([BienSo], [NgaySuaChua], [TongTien]) VALUES" +
                " ('" + BienSoXe + "', '" + NgaySuaChua + "', " + TongTien + ");";
            DataProvider.Instance.ExecuteQuery(query);
            int mahieuxe = GetMaHieuXe(BienSoXe);
            int thang = int.Parse(NgaySuaChua.Substring(5, 2));
            int nam = int.Parse(NgaySuaChua.Substring(0, 4));
            int mabaocao = GetMaBaoCaoDoanhSo(thang, nam);
            if (mabaocao == 0)
            {
                ThemBaoCaoDoanhSo(thang, nam);
                mabaocao = GetMaBaoCaoDoanhSo(thang, nam);
            }
            string query2 = "";
            if (KiemTraHieuXe(mahieuxe, thang, nam))
            {
                query2 = string.Format("Update CHITIETBAOCAODOANHSO Set SoLuotSua = SoLuotSua + 1 " +
                    "Where MaHieuXe = {0} And MaBaoCaoDoanhSo = {1}", mahieuxe, mabaocao);
                 
            }
            else
            {
                query2 = string.Format("Insert into CHITIETBAOCAODOANHSO Values({0},{1},1,0,0)", mabaocao,mahieuxe);
            }
            DataProvider.Instance.ExecuteNonQuery(query2);
        }
        public DateTime GetNgaySuaChua(string bienso)
        {
            string query = string.Format("Select NgaySuaChua From PHIEUSUACHUA Where BienSo = '{0}'", bienso);
            object result = DataProvider.Instance.ExecuteScalar(query);
            if(result == null || result == DBNull.Value) 
            {
                return DateTime.MinValue.Date;
            }
            return (DateTime)DataProvider.Instance.ExecuteScalar(query);
        }
        public void updateNgaySuaChua(string BienSoXe, string new_NgaySuaChua)
        {
            string query = "UPDATE [dbo].[PHIEUSUACHUA] set [NGAYSUACHUA] = " + "('" + new_NgaySuaChua + "') WHERE [BIENSO] =" + "('" + BienSoXe + "')";
            DataProvider.Instance.ExecuteNonQuery(query);
            int mahieuxe = GetMaHieuXe(BienSoXe);
            int thang = int.Parse(new_NgaySuaChua.Substring(5, 2));
            int nam = int.Parse(new_NgaySuaChua.Substring(0, 4));
            int mabaocao = GetMaBaoCaoDoanhSo(thang, nam);
            if (mabaocao == 0)
            {
                ThemBaoCaoDoanhSo(thang, nam);
                mabaocao = GetMaBaoCaoDoanhSo(thang, nam);
            }
            string query2 = "";
            if (KiemTraHieuXe(mahieuxe, thang, nam))
            {
                query2 = string.Format("Update CHITIETBAOCAODOANHSO Set SoLuotSua = SoLuotSua + 1 " +
                    "Where MaHieuXe = {0} And MaBaoCaoDoanhSo = {1}", mahieuxe, mabaocao);

            }
            else
            {
                query2 = string.Format("Insert into CHITIETBAOCAODOANHSO Values({0},{1},1,0,0)", mabaocao, mahieuxe);
            }
            DataProvider.Instance.ExecuteNonQuery(query2);
        }

        public bool KiemTraHieuXe(int mahieuxe, int month, int year)
        {
            string query = string.Format("Select Count(*) From CHITIETBAOCAODOANHSO ct , BAOCAODOANHSO bc " +
                                "Where ct.MaBaoCaoDoanhSo = bc.MaBaoCaoDoanhSo And MaHieuXe = {0} " +
                                "And Thang = {1} And Nam = {2}", mahieuxe, month, year);
            int result = (int)DataProvider.Instance.ExecuteScalar(query);
            return result > 0;
        }
        public int GetMaBaoCaoDoanhSo(int month, int year)
        {
            string query = string.Format("Select MaBaoCaoDoanhSo From BAOCAODOANHSO Where Thang = {0} And Nam = {1}", month, year);
            object result = DataProvider.Instance.ExecuteScalar(query);
            if (result == null || result == DBNull.Value)
                return 0;
            return (int)result;
        }

        public void ThemBaoCaoDoanhSo(int month, int year)
        {
            string query = string.Format("Insert into BAOCAODOANHSO Values ({0}, {1}, {2})", 0, month, year);
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public bool isSuaChuaThemXe(string bienso, string ngaysuachua)
        {
            string query = string.Format("Select Count(*) From PHIEUSUACHUA Where NgaySuaChua = '{0}'", ngaysuachua);
            object result = DataProvider.Instance.ExecuteScalar(query);
            int soxesuachuatrongngay = 0;
            if(result != null && result != DBNull.Value)
                soxesuachuatrongngay = Convert.ToInt32(result);
            string query3 = "SELECT [SoXeTiepNhanToiDa] From [dbo].[THAMSO]";
            DataTable res3 = DataProvider.Instance.ExecuteQuery(query3);
            int max = 0;
            if (res3.Rows.Count > 0)
            {
                max = Convert.ToInt32(res3.Rows[0][0]);
            }

            if (soxesuachuatrongngay < max) return true;
            return false;
        }
    }
}
