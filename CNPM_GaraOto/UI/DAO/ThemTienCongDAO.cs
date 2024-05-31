using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM_GaraOto.UI.DAO
{
    public class ThemTienCongDAO
    {
        private static ThemTienCongDAO instance;  
        public static ThemTienCongDAO Instance
        {
            get
            {
                if(instance==null) 
                    instance = new ThemTienCongDAO();
                return instance;
             } 
            private set
            {
                instance = value;
            }
        }  
        public void ThemTienCong(string noidung, Decimal tien)
        {
            DataProvider.Instance.ExecuteNonQuery("INSERT INTO TIENCONG VALUES (N'" + noidung + "'," + tien.ToString() + ")");   
        }
    }
}
