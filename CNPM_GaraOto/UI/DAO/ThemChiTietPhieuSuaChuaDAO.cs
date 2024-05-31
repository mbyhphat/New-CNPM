using CNPM_GaraOto.UI.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace CNPM_GaraOto.UI.DAO
{
    public class ThemChiTietPhieuSuaChuaDAO
    {
        private static ThemChiTietPhieuSuaChuaDAO instance;
        public static ThemChiTietPhieuSuaChuaDAO Instance {  
            get
            {
                if (instance == null) instance = new ThemChiTietPhieuSuaChuaDAO();
                return instance;
            } 
            private set
            {
                instance = value;
            }
        }    
        
        
        public int getMaPhieuSuaChuaTuNgayVaBienSo(string bienso, DateTime day)
        {
            string querry = "SELECT * FROM PHIEUSUACHUA WHERE BIENSO ='" + bienso + "' AND NGAYSUACHUA='" + day + "'";
            DataTable res = DataProvider.Instance.ExecuteQuery(querry);
            if (res.Rows.Count == 1)
            {
                PhieuSuaChua_DTO pscDTO = new PhieuSuaChua_DTO(res.Rows[0]);
                return pscDTO.MaPhieuSuaChua;
            }
            return -1;
        }
        public string getBienSobyMaPhieu(int maphieu)
        {
            string query = string.Format("Select BienSo From PHIEUSUACHUA Where MaPhieuSuaChua = {0}", maphieu);
            return (string)DataProvider.Instance.ExecuteScalar(query);
        }
        public int getMaTienCongTuTen(string tentiencong)
        {
            string querry = "SELECT * FROM TIENCONG WHERE NOIDUNG='" + tentiencong + "'";
            DataTable res = DataProvider.Instance.ExecuteQuery(querry);   
            if(res.Rows.Count==1)
            {
                TienCong_DTO tcDTO = new TienCong_DTO(res.Rows[0]);
                return tcDTO.MaTienCong;
            }
            return -1;
        }  
        public int getMaVTPTTuTen(string tenvtpt)
        {
            string querry = "SELECT * FROM VATTUPHUTUNG WHERE TENVATTUPHUTUNG='" + tenvtpt + "'";
            DataTable res = DataProvider.Instance.ExecuteQuery(querry);  
            if(res.Rows.Count==1)
            {
                VatTuPhuTung_DTO vtptDTO = new VatTuPhuTung_DTO(res.Rows[0]);
                return vtptDTO.MaVatTuPhuTung;
            }
            return -1;
        }
        public bool checkConDuVatTuPhuTung(int mavtpt, int soluong)
        {
            DataTable vtpt = DataProvider.Instance.ExecuteQuery("SELECT * FROM VATTUPHUTUNG WHERE MAVATTUPHUTUNG = '" + mavtpt.ToString()+"'");
            DataRow vt = vtpt.Rows[0];
            VatTuPhuTung_DTO vtptDTO = new VatTuPhuTung_DTO(vt);
            if (vtptDTO.SoLuongTon < soluong) return false;// Kiểm tra số lượng tồn còn đủ ko
            return true ;
        }
        public void UpdateTonKho(int mavtpt, int soluong, int thang, int nam)
        {
            string query = string.Format("Update BAOCAOTONKHO Set TonCuoi = TonCuoi - {0} Where MaVatTuPhuTung = {1} And Thang = {2} And Nam = {3}", soluong,mavtpt, thang, nam); 
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public bool ThemChiTiet(int maphieu, int matiencong, int mavtpt, int soluong)
        {
            string tinhtiencong = "SELECT * FROM TIENCONG WHERE MATIENCONG=" + matiencong.ToString();
            DataTable tctbl = DataProvider.Instance.ExecuteQuery(tinhtiencong);
            if (tctbl.Rows.Count == 0) return false;   
            DataRow tcong=tctbl.Rows[0];
            TienCong_DTO tiencongDTO = new TienCong_DTO(tcong);
            Decimal sotiencong = tiencongDTO.SoTienCong;  // Lấy số tiền công   

            string timvattuphutung = "SELECT * FROM VATTUPHUTUNG WHERE MAVATTUPHUTUNG=" + mavtpt.ToString();
            DataTable tvtpttbl = DataProvider.Instance.ExecuteQuery(timvattuphutung);   
            if(tvtpttbl.Rows.Count == 0) { return false; }
            VatTuPhuTung_DTO vtptDTO = new VatTuPhuTung_DTO(tvtpttbl.Rows[0]);
            Decimal tongtienvtpt = vtptDTO.DonGiaBan * soluong;  // Lấy tổng tiền vtpt
            Decimal tongcong = sotiencong + tongtienvtpt;
            int soluongton = vtptDTO.SoLuongTon;//Lấy số lượng tồn hiện tại của vptp   

            string insertQuerry = "INSERT INTO CHITIETPHIEUSUACHUA VALUES (" + maphieu.ToString() + "," + matiencong.ToString()   
                + "," + sotiencong.ToString() + "," + tongtienvtpt.ToString()+ ","  + tongcong.ToString() + ")";
            DataProvider.Instance.ExecuteNonQuery(insertQuerry);//Insert vào chi tiết phiếu sửa chữa

            string timchitietphieu = "SELECT IDENT_CURRENT('dbo.CHITIETPHIEUSUACHUA') as MACTPHIEUSUACHUA";
            DataTable ctpsc = DataProvider.Instance.ExecuteQuery(timchitietphieu);
            int mactpsc = Convert.ToInt32(ctpsc.Rows[0]["MACTPHIEUSUACHUA"]);
            /*string timchitietphieusuachua = "SELECT * FROM CHITIETPHIEUSUACHUA WHERE MACHITIETPHIEUSUACHUA=" + mactpsc.ToString();

            DataTable listCTPSC = DataProvider.Instance.ExecuteQuery(timchitietphieusuachua);
            if (listCTPSC.Rows.Count == 0) return false;
            ChiTietPhieuSuaChua_DTO ctpscDTO = new ChiTietPhieuSuaChua_DTO(listCTPSC.Rows[0]);  //tìm mã chi tiết phiếu sửa chữa vừa nhập
            */
            //string insertSDVTPT = "INSERT INTO CHITIETSUDUNGVATTUPHUTUNG VALUES (" + ctpscDTO.MaChiTietPhieuSuaChua.ToString() + ","
            //+ mavtpt.ToString() + "," + soluong.ToString() + "," + vtptDTO.DonGiaBan.ToString() + "," + tongtienvtpt + ")";
            string insertSDVTPT = "INSERT INTO CHITIETSUDUNGVATTUPHUTUNG VALUES (" + mactpsc.ToString() + ","
                + mavtpt.ToString() + "," + soluong.ToString() + "," + vtptDTO.DonGiaBan.ToString() + "," + tongtienvtpt + ")";
            DataProvider.Instance.ExecuteNonQuery(insertSDVTPT);//insert vào chi tiết sử dụng vật tư phụ tùng
            int newsoluongton = soluongton - soluong;
            string updateVTPT = "UPDATE VATTUPHUTUNG SET SOLUONGTON=" + newsoluongton.ToString() + " WHERE MAVATTUPHUTUNG = " + mavtpt.ToString();
            DataProvider.Instance.ExecuteNonQuery(updateVTPT);//cập nhật lại số lượng tồn kho của loại vptp vừa sử dụng
            
            string bienso = getBienSobyMaPhieu(maphieu);
            string query = string.Format("Update PHIEUSUACHUA Set TongTien = TongTien + {0} Where BienSo = '{1}'", tongcong, bienso);
            DataProvider.Instance.ExecuteNonQuery(query);

            string query2 = string.Format("Update XE Set TienNo = TienNo + {0} Where BienSo = '{1}'", tongcong, bienso);
            DataProvider.Instance.ExecuteNonQuery(query2);
            DateTime ngaysuachua = LapPhieuSuaChuaDAO.Instance.GetNgaySuaChua(bienso);
            int thang = ngaysuachua.Month;
            int nam = ngaysuachua.Year;
            /*string query3 = string.Format("Update BAOCAOTONKHO Set TonCuoi = TonCuoi - {0} " +
                "Where MaVatTuPhuTung = {1} And Thang = {2} And Nam = {3}", soluong, mavtpt, thang, nam);
            DataProvider.Instance.ExecuteNonQuery(query3);*/

            string query4 = string.Format("Update BAOCAOTONKHO Set TonDau = TonDau - {0}, TonCuoi = TonCuoi - {0}" +
                                    "Where ((Thang > {1} And Nam = {2}) Or Nam > {2}) And MaVatTuPhuTung = {3}", soluong, thang, nam, mavtpt);
            DataProvider.Instance.ExecuteNonQuery(query4);
            return true;

        }
    }
}
