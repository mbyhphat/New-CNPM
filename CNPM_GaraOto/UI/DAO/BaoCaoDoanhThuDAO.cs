using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CNPM_GaraOto.UI.DAO
{
    public class BaoCaoDoanhThuDAO
    {
        private static BaoCaoDoanhThuDAO instance;
        public static BaoCaoDoanhThuDAO Instance
        {
            get { if (instance == null) instance = new BaoCaoDoanhThuDAO(); return instance; }
            private set { instance = value; }
        }
        private BaoCaoDoanhThuDAO() { }

        public float GetDoanhThu(int month, int year)
        {
            float result = 0;
            string query = string.Format("SELECT TongDoanhThu FROM BAOCAODOANHSO WHERE Thang = {0} AND Nam = {1}", month, year);
            object value = DataProvider.Instance.ExecuteScalar(query);
            if (value != null)
            {
                result = Convert.ToSingle((decimal)value); 
            }
            return result;
        }
        
    }
}
