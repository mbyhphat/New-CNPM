using CNPM_GaraOto.UI.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace CNPM_GaraOto.UI.DAO
{
    public class ThongTinXeDAO
    {
        private static ThongTinXeDAO instance;

        public static ThongTinXeDAO Instance
        {
            get { if (instance == null) instance = new ThongTinXeDAO(); return instance; }
            private set { instance = value; }
        }

        public List<ThongTinXe_DTO> GetThongTinXeByBienSo(string bienSo)
        {
            List<ThongTinXe_DTO> list = new List<ThongTinXe_DTO>();
            string query = @"
                SELECT
                    tc.MaTienCong,
                    tc.NoiDung,
                    vtpt.TenVatTuPhuTung,
                    ctv.SoLuong,
                    ctv.DonGia,
                    ctpsc.TienCong,
                    ctpsc.TongCong
                FROM
                    TIENCONG tc
                JOIN
                    CHITIETPHIEUSUACHUA ctpsc ON ctpsc.MaTienCong = tc.MaTienCong
                JOIN
                    CHITIETSUDUNGVATTUPHUTUNG ctv ON ctpsc.MaChiTietPhieuSuaChua = ctv.MaChiTietPhieuSuaChua
                JOIN
                    VATTUPHUTUNG vtpt ON vtpt.MaVatTuPhuTung = ctv.MaVatTuPhuTung
                JOIN
                    PHIEUSUACHUA pcs ON pcs.MaPhieuSuaChua = ctpsc.MaPhieuSuaChua
                WHERE
                    pcs.BienSo = @BienSo";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { bienSo });

            foreach (DataRow row in data.Rows)
            {
                ThongTinXe_DTO thongTin = new ThongTinXe_DTO(row);
                list.Add(thongTin);
            }

            return list;
        }
        public DataRow GetThongTinChiTietByBienSo(string bienSo)
        {
            string query = @"
                SELECT
                    kh.TenChuXe,
                    hx.TenHieuXe,
                    kh.DiaChi,
                    kh.SDT,
                    xe.NgayTiepNhan
                FROM 
                    XE xe
                JOIN 
                    KHACHHANG kh ON xe.MaKhachHang = kh.MaKhachHang
                JOIN
                    HIEUXE hx ON hx.MaHieuXe = xe.MaHieuXe
                WHERE 
                    xe.BienSo = @BienSo";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { bienSo });

            if (data.Rows.Count > 0)
            {
                return data.Rows[0];
            }

            return null;
        }

        public int GetMaKhachHangByBienSo(string bienso)
        {
            string query = string.Format("Select MaKhachHang From XE Where BienSo = '{0}'", bienso);
            return (int)DataProvider.Instance.ExecuteScalar(query);
        }
        public bool SuaThongTinXe(string hoten, string sdt, string diachi, string bienso)
        {
            int makhachhang = GetMaKhachHangByBienSo(bienso);
            string query = string.Format("Update KHACHHANG Set TenChuXe = N'{0}', DiaChi = N'{1}', SDT = '{2}' Where MaKhachHang = {3}", hoten, diachi, sdt, makhachhang);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public string GetHoTenByBienSo(string bienso)
        {
            int makh = GetMaKhachHangByBienSo(bienso);
            string query = string.Format("Select TenChuXe From KHACHHANG Where MaKhachHang = '{0}'", makh);
            return (string)DataProvider.Instance.ExecuteScalar(query);
        }
        public decimal GetTongtienByBienso(string bienso)
        {
            string query = string.Format("Select TongTien From PHIEUSUACHUA Where BienSo = '{0}'", bienso);
            return (decimal)DataProvider.Instance.ExecuteScalar(query);
        }
        public decimal GetTienThuByBienSo(string bienso)
        {
            string query = string.Format("Select SoTienThu From PHIEUTHUTIEN Where BienSo = '{0}'", bienso);
            object result = DataProvider.Instance.ExecuteScalar(query);
            if (result == null || result == DBNull.Value)
                return 0;
            return Convert.ToDecimal(result);
        }
        public void UpdatePhieuthutien(string bienSo, decimal tienThu, DateTime ngayThu)
        {
            string query = "UPDATE PHIEUTHUTIEN SET NgayThu = @NgayThu, SoTienThu = @TienThu WHERE BienSo = @BienSo";
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@NgayThu", ngayThu),
        new SqlParameter("@TienThu", tienThu),
        new SqlParameter("@BienSo", bienSo)
            };

            DataProvider.Instance.ExecuteNonQuery(query, parameters);
        }

        public void SetTienNo(string bienso)
        {
            decimal tienno = GetTongtienByBienso(bienso);
            string query = string.Format("Update XE Set TienNo = {0} Where BienSo = '{1}'", tienno, bienso);
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public decimal GetTienNo(string bienso)
        {
            //SetTienNo(bienso);
            string query = string.Format("Select TienNo From XE Where BienSo = '{0}'", bienso);
            return (decimal)DataProvider.Instance.ExecuteScalar(query);
        }
        public void UpdateTiennoByBienso(string bienso,decimal tienno)
        {
            string query = string.Format("Update XE set TienNo = {0} where BienSo = '{1}'",tienno,bienso);
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public decimal GetTongDoanhThu(int mabaocao)
        {
            string query = string.Format("Select TongDoanhThu From BAOCAODOANHSO " +
                "Where MaBaoCaoDoanhSo = {0}", mabaocao);
            return (decimal)DataProvider.Instance.ExecuteScalar(query);
        }
        public decimal GetThanhTienByHieuXe(int mahieuxe, int mabaocao)
        {
            string query = string.Format("Select ThanhTien From CHITIETBAOCAODOANHSO " +
                "Where MaHieuXe = {0} And MaBaoCaoDoanhSo = {1}", mahieuxe, mabaocao);
            object result = DataProvider.Instance.ExecuteScalar(query) ;
            if (result == null || result == DBNull.Value)
                return 0;
            return (decimal)result;
        }
        public List<int> GetListHieuXe(int mabaocao)
        {
            string query = string.Format("Select MaHieuXe From CHITIETBAOCAODOANHSO Where MaBaoCaoDoanhSo = {0}", mabaocao);
            List<int> listhieuxe = new List<int>();
            DataTable data = DataProvider.Instance.ExecuteQuery(query) ;
            foreach(DataRow row in data.Rows) 
            {
                listhieuxe.Add((int)row["MaHieuXe"]);
            }
            return listhieuxe;
        }
        public void UpdateTiLe(int mabaocao)
        {
            List<int> listhieuxe = GetListHieuXe (mabaocao);
            foreach(int ma in listhieuxe)
            {
                decimal tile = GetThanhTienByHieuXe(ma, mabaocao) / GetTongDoanhThu(mabaocao);
                string query = string.Format("Update CHITIETBAOCAODOANHSO Set TiLe = {0} " +
                    "Where MaHieuXe = {1} And MaBaoCaoDoanhSo = {2}", tile,ma,mabaocao);
                DataProvider.Instance.ExecuteNonQuery(query) ;
            }

        }
        public void ThemPhieuThuTien(string bienso, DateTime ngaythu, decimal tienthu)
        {
            string query = string.Format("Insert into PHIEUTHUTIEN values ('{0}', '{1}', {2})", bienso, ngaythu, tienthu);
            DataProvider.Instance.ExecuteNonQuery(query);
            int mahieuxe = LapPhieuSuaChuaDAO.Instance.GetMaHieuXe(bienso);
            int thang = ngaythu.Month;
            int nam = ngaythu.Year;
            int mabaocao = LapPhieuSuaChuaDAO.Instance.GetMaBaoCaoDoanhSo(thang, nam);
            if (mabaocao == 0)
            {
                LapPhieuSuaChuaDAO.Instance.ThemBaoCaoDoanhSo(thang, nam);
                mabaocao = LapPhieuSuaChuaDAO.Instance.GetMaBaoCaoDoanhSo(thang, nam);
            }
            string query1 = string.Format("Update BAOCAODOANHSO Set TongDoanhThu = TongDoanhThu + {0} " +
                "Where MaBaoCaoDoanhSo = {1} And Thang = {2} And Nam = {3}", tienthu, mabaocao, thang, nam);
            DataProvider.Instance.ExecuteNonQuery(query1);
            string query2 = "";
            if (LapPhieuSuaChuaDAO.Instance.KiemTraHieuXe(mahieuxe, thang, nam))
            {
                query2 = string.Format("Update CHITIETBAOCAODOANHSO Set ThanhTien = ThanhTien + {0}" +
                    "Where MaHieuXe = {1} And MaBaoCaoDoanhSo = {2}", tienthu,mahieuxe, mabaocao);
            }
            else
            {
                query2 = string.Format("Insert into CHITIETBAOCAODOANHSO Values({0},{1},0,{2},0)", mabaocao, mahieuxe, tienthu);
            }
            DataProvider.Instance.ExecuteNonQuery(query2);
            UpdateTiLe(mabaocao);
        }
    }
}
