using CNPM_GaraOto.UI.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM_GaraOto.UI.DAO
{
    public class PhieuNhapVTPTDAO
    {
        private static PhieuNhapVTPTDAO instance;
        public static PhieuNhapVTPTDAO Instance
        {
            get { if (instance == null) instance = new PhieuNhapVTPTDAO(); return instance; }
            private set { instance = value; }
        }
        private PhieuNhapVTPTDAO() { }

        public List<PhieuNhapVatTuPhuTung_DTO> GetPhieuNhap(DateTime start, DateTime end)
        {
            List<PhieuNhapVatTuPhuTung_DTO> listphieunhap = new List<PhieuNhapVatTuPhuTung_DTO> ();
            string query = string.Format("Select * From PHIEUNHAPVATTUPHUTUNG Where '{0}' <= NgayNhap And NgayNhap <= '{1}'", start, end);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows) 
            {
                PhieuNhapVatTuPhuTung_DTO phieunhap = new PhieuNhapVatTuPhuTung_DTO(row);
                listphieunhap.Add(phieunhap);
            }
            return listphieunhap;
        }
        //public void ThemPhieuNhapVTPT()
        public float GetDoanhThu(DateTime start, DateTime end)
        {
            float result = 0;
            string query = string.Format("SELECT Sum(TongTien) FROM PHIEUNHAPVATTUPHUTUNG Where '{0}' <= NgayNhap And NgayNhap <= '{1}'", start, end);
            object value = DataProvider.Instance.ExecuteScalar(query);
            if (value != null && value != DBNull.Value)
            {
                result = Convert.ToSingle((decimal)value);
            }
            return result;
        }
    }
}
