using CNPM_GaraOto.UI.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CNPM_GaraOto.UI.DAO
{
    public class KhoPhuTungDAO
    {
        private static KhoPhuTungDAO instance;
        public static KhoPhuTungDAO Instance
        {
            get { if (instance == null) instance = new KhoPhuTungDAO(); return instance; }
            private set { instance = value; }
        }
        private KhoPhuTungDAO() { }

        public List<VatTuPhuTung_DTO> GetVatTuPhuTung()
        {
            List<VatTuPhuTung_DTO> khophutung = new List<VatTuPhuTung_DTO> ();
            string query = "SELECT * FROM VATTUPHUTUNG";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                VatTuPhuTung_DTO phutung = new VatTuPhuTung_DTO(row);
                khophutung.Add(phutung);
            }
            return khophutung;
        }

        public List<VatTuPhuTung_DTO> GetVatTuPhuTungByName(string name)
        {
            List<VatTuPhuTung_DTO> listphutung = new List<VatTuPhuTung_DTO>();
            string query = string.Format("SELECT * FROM VATTUPHUTUNG WHERE dbo.fuConvertToUnsign1(TenVatTuPhuTung) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", name);
            DataTable data = DataProvider.Instance.ExecuteQuery (query);
            foreach(DataRow row in data.Rows)
            {
                VatTuPhuTung_DTO phutung = new VatTuPhuTung_DTO(row);
                listphutung.Add(phutung);
            }
            return listphutung; 
        }
        public void ThemPhieuNhapVTPT(DateTime ngaynhap)
        {
            string query = string.Format("Insert into PHIEUNHAPVATTUPHUTUNG values ('{0}' , 0)", ngaynhap);
            DataProvider.Instance.ExecuteNonQuery (query);
        }

        public int GetMaNhapVTPT(DateTime ngaynhap)
        {
            object result = DataProvider.Instance.ExecuteScalar(string.Format("Select MaPhieuNhap From PHIEUNHAPVATTUPHUTUNG Where NgayNhap = '{0}'",ngaynhap));
            if(result == null || result == DBNull.Value)
            {
                ThemPhieuNhapVTPT(ngaynhap);
                return (int)DataProvider.Instance.ExecuteScalar(string.Format("Select MaPhieuNhap From PHIEUNHAPVATTUPHUTUNG Where NgayNhap = '{0}'", ngaynhap));
            }
            else
            {
                return Convert.ToInt32(result);
            }
        }
        private bool CheckMaVTPTTrongChiTietPhieuNhap(int mavtpt, int maphieunhap)
        {
            string query = string.Format("Select Count(*) From CHITIETPHIEUNHAP Where MaPhieuNhap = {0} And MaVatTuPhuTung = {1}", maphieunhap, mavtpt);
            int result = (int)DataProvider.Instance.ExecuteScalar (query);
            return result > 0;
        }
        public void NhapVTPT(int maphieunhap, int mavtpt, int soluong, Decimal dongianhap, decimal thanhtien)
        {
            string query = "";
            if(!CheckMaVTPTTrongChiTietPhieuNhap(mavtpt,maphieunhap))
            {
                query = string.Format("Insert into CHITIETPHIEUNHAP values ({0}, {1}, {2}, {3}, {4})", maphieunhap, mavtpt, soluong, dongianhap, thanhtien);
                
            }
            else
            {
                query = string.Format("Update CHITIETPHIEUNHAP Set SoLuongNhap = SoLuongNhap + {0}, DonGiaNhap = {1}, ThanhTien = ThanhTien +  {2} " +
                                     "Where MaVatTuPhuTung = {3} And MaPhieuNhap = {4}", soluong, dongianhap, thanhtien, mavtpt, maphieunhap);
            }
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public void UpdateKhoVTPT(int mavtpt, int soluongnhap, decimal dongianhap)
        {
            DataTable thamso = DataProvider.Instance.ExecuteQuery("SELECT * FROM THAMSO");
            DataRow ts = thamso.Rows[0];
            ThamSo_DTO thamsoDTO = new ThamSo_DTO(ts);
            decimal tiledongiaban = thamsoDTO.TiLeDonGiaBan;
            decimal dongiaban = dongianhap * tiledongiaban;
            string query = string.Format("Update VATTUPHUTUNG Set SoLuongTon = SoLuongTon + {0}, DonGiaNhap = {1}, DonGiaBan = {2} " +
                                            "Where MaVatTuPhuTung = {3}", soluongnhap,dongianhap,dongiaban,mavtpt);
            DataProvider.Instance.ExecuteNonQuery (query);
        }
        public void UpdatePhieuNhapVTPT(int maphieunhap, decimal thanhtien)
        {
            string query = string.Format("Update PHIEUNHAPVATTUPHUTUNG Set TongTien = TongTien + {0} Where MaPhieuNhap = {1}", thanhtien, maphieunhap);
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public bool KiemTraMaVTPT(int mavtpt, int month, int year)
        {
            string query = string.Format("Select Count(*) From BAOCAOTONKHO Where MaVatTuPhuTung = {0} And Thang = {1} And Nam = {2}", mavtpt, month, year);
            int result = (int)DataProvider.Instance.ExecuteScalar(query);
            return result > 0;
        }
        public int SoVTPTSuDung(int mavtpt, int thang, int nam)
        {
            string query = string.Format("Select Sum(SoLuong) " +
                            "From CHITIETSUDUNGVATTUPHUTUNG ctsd, VATTUPHUTUNG vtpt, CHITIETPHIEUSUACHUA ct, PHIEUSUACHUA psc " +
                            "Where ctsd.MaVatTuPhuTung = vtpt.MaVatTuPhuTung And ctsd.MaChiTietPhieuSuaChua = ct.MaChiTietPhieuSuaChua " +
                            "And ct.MaPhieuSuaChua = psc.MaPhieuSuaChua And vtpt.MaVatTuPhuTung = {0} And Month(NgaySuaChua) = {1} " +
                            "And Year(NgaySuaChua) = '{2}'", mavtpt, thang, nam);

             object result = DataProvider.Instance.ExecuteScalar(query);
            if (result == null || result == DBNull.Value)
                return 0;
            else
                return Convert.ToInt32(result);
        }
        public int SoLuongTon(int mavtpt)
        {

            string query = string.Format("Select SoLuongTon From VATTUPHUTUNG Where MaVatTuPhuTung = {0}", mavtpt);

            return (int)DataProvider.Instance.ExecuteScalar(query);
        }
        public int GetTonCuoi(int mavtpt, int thang, int nam)
        {
            string query = "";
            if (thang == 1)
                query = string.Format("Select TonCuoi From BAOCAOTONKHO Where MaVatTuPhuTung = {0} And Thang = 12 And Nam = {1} - 1", mavtpt, nam);
            else
                query = string.Format("Select TonCuoi From BAOCAOTONKHO Where MaVatTuPhuTung = {0} And Thang = {1} - 1 And Nam = {2}", mavtpt, thang, nam);
            object result = DataProvider.Instance.ExecuteScalar(query);

            if (result != null)
                return Convert.ToInt32(result);
            return 0;
        }
        public int GetPhatSinh(int mavtpt, int thang, int nam)
        {

            string query = string.Format("Select PhatSinh From BAOCAOTONKHO Where MaVatTuPhuTung = {0} And Thang = {1} And Nam = {2}", mavtpt, thang, nam);
            object result = DataProvider.Instance.ExecuteScalar(query);

            if (result == null || result == DBNull.Value)
                return 0;
            return Convert.ToInt32(result);
        }
        public int GetTonDau(int mavtpt, int thang, int nam)
        {
            string query = string.Format("Select TonDau From BAOCAOTONKHO Where MaVatTuPhuTung = {0} And Thang = {1} And Nam = {2}", mavtpt, thang, nam);
            object result = DataProvider.Instance.ExecuteScalar(query);
            if(result == null || result == DBNull.Value)
                return 0;
            return (int)result;
        }

        public void UpdateBaoCaoTonKho(int mavtpt, int soluong, int thang, int nam)
        {
            int soluongsd = SoVTPTSuDung(mavtpt, thang, nam);
            int soluongton = SoLuongTon(mavtpt);
            string query = "";
            if (!KiemTraMaVTPT(mavtpt, thang, nam))
            {
                int tondau = GetTonCuoi(mavtpt, thang, nam);

                int phatsinh = GetPhatSinh(mavtpt, thang, nam);

                int toncuoi = tondau  + phatsinh + soluong - soluongsd;

                query = String.Format("InSert into BAOCAOTONKHO Values ({0}, {1}, {2}, {3}, {4}, {5})", mavtpt, thang, nam, tondau, soluong, toncuoi);

            }
                
            else
            {
                int toncuoi = GetTonDau(mavtpt, thang, nam) + GetPhatSinh(mavtpt, thang, nam) + soluong - soluongsd;

                query = string.Format("Update BAOCAOTONKHO Set PhatSinh = PhatSinh + {0}, TonCuoi = {1} " +
                    "Where MaVatTuPhuTung = {2} And Thang = {3} And Nam = {4}", soluong, toncuoi, mavtpt,thang,nam);
            }
                

            DataProvider.Instance.ExecuteNonQuery(query);

        }
        public void UpdateCacBaoCaoTonKho(int soluongnhap, int mavtpt, int thang, int nam)
        {

            string query = string.Format("UPDATE BaoCaoTonKho SET TonDau = TonDau + {0}, TonCuoi = TonCuoi + {0} " +
                "WHERE ((Thang > {1} And Nam = {2}) Or Nam > {2}) AND MaVatTuPhuTung = {3}",soluongnhap, thang, nam, mavtpt);
            DataProvider.Instance.ExecuteNonQuery(query);
        }


    }
}
