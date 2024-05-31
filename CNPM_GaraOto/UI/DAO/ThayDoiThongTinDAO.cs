using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;

namespace CNPM_GaraOto.UI.DAO
{
    public class ThayDoiThongTinDAO
    {
        private static ThayDoiThongTinDAO instance;
        public static ThayDoiThongTinDAO Instance
        {
            get { if (instance == null) instance = new ThayDoiThongTinDAO(); return instance; }
            private set { instance = value; }
        }

        private ThayDoiThongTinDAO() { }

        public bool UpdateThongTin(string tenChuXe, string hieuxe, string sdt, DateTime ngayTiepNhan, string diaChi, string bienSo)
        {
            string query = "USP_UpdateThayDoiThongTin @TenChuXe , @Hieuxe , @SDT , @Ngaytiepnhan , @Diachi , @Bienso";
            object[] parameters = new object[]
            {
                new SqlParameter("@TenChuXe", tenChuXe),
                new SqlParameter("@Hieuxe", hieuxe),
                new SqlParameter("@SDT", sdt),
                new SqlParameter("@Ngaytiepnhan", ngayTiepNhan),
                new SqlParameter("@Diachi", diaChi),
                new SqlParameter("@Bienso", bienSo)
            };

            int rowsAffected = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return rowsAffected > 0;
        }
    }
}