using CNPM_GaraOto.UI.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM_GaraOto.UI.DAO
{
    public class BaoCaoTonKhoDAO
    {
        private static BaoCaoTonKhoDAO instance;
        public static BaoCaoTonKhoDAO Instance
        {
            get { if (instance == null) instance = new BaoCaoTonKhoDAO(); return instance; }
            private set { instance = value; }
        }
        private BaoCaoTonKhoDAO() { }

        public List<int> GetListMaVTPT(int month, int year)
        {
            List<int> listvtpt = new List<int>();
            string query = string.Format("SELECT distinct MaVatTuPhuTung " +
                                           "From CHITIETPHIEUNHAP ct, PHIEUNHAPVATTUPHUTUNG pn " +
                                           "Where ct.MaPhieuNhap = pn.MaPhieuNhap And (Year(NgayNhap) < {0} " +
                                           "OR (Year(NgayNhap) = {1} And Month(NgayNhap) <= {2}))", year, year, month);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows) 
            {
                listvtpt.Add(Convert.ToInt32(row["MaVatTuPhuTung"]));
            }
            return listvtpt;
        }
        
        public List<BaoCaoTonKho_DTO> LapBaoCaoTonKho(int thang, int nam)
        {
            List<int> listvtpt = GetListMaVTPT(thang, nam);
            List<BaoCaoTonKho_DTO> baocao = new List<BaoCaoTonKho_DTO>();
            string query = "";
            foreach (int mavtpt in listvtpt)
            {
                //MessageBox.Show(mavtpt.ToString());
                if (!KhoPhuTungDAO.Instance.KiemTraMaVTPT(mavtpt, thang, nam))
                {
                    int tondau = KhoPhuTungDAO.Instance.GetTonCuoi(mavtpt, thang, nam);
                    //MessageBox.Show(tondau.ToString());
                    int phatsinh = KhoPhuTungDAO.Instance.GetPhatSinh(mavtpt, thang, nam);
                    //MessageBox.Show(phatsinh.ToString());
                    int toncuoi = tondau;
                    //MessageBox.Show(toncuoi.ToString());
                    query = String.Format("InSert into BAOCAOTONKHO Values ({0}, {1}, {2}, {3}, {4}, {5})", mavtpt, thang, nam, tondau, 0, toncuoi);
                    DataProvider.Instance.ExecuteNonQuery(query);
                    //MessageBox.Show(query);
                }
                query = string.Format("SELECT TenVatTuPhuTung, TonDau, PhatSinh,TonCuoi" +
                "\r\nFROM VATTUPHUTUNG vt, BAOCAOTONKHO bc" +
                "\r\nWHERE vt.MaVatTuPhuTung = bc.MaVatTuPhuTung And vt.MaVatTuPhuTung = {0} AND THANG = {1} AND NAM = {2}", mavtpt, thang, nam);
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                BaoCaoTonKho_DTO chitiet = new BaoCaoTonKho_DTO(data.Rows[0]);
                //List<DataTable> 
                baocao.Add(chitiet);
            }
            return baocao;
        }
        public bool CheckKiemTraThangTruoc(int thang, int nam)
        {
            string query = "";
            if (thang == 1)
                query = string.Format("Select Count(*) From BAOCAOTONKHO Where Thang = 12 And Nam = {0} - 1", nam);
            else
                query = string.Format("Select Count(*) From BAOCAOTONKHO Where Thang = {0} - 1 And Nam = {1}",thang, nam);
            object result = DataProvider.Instance.ExecuteScalar(query);
            if((int)result == 0 || result == DBNull.Value)
                return false;
            return true;
        }
    }
}
