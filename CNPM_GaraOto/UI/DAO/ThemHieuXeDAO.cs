using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM_GaraOto.UI.DAO
{
    public class ThemHieuXeDAO
    {
        private static ThemHieuXeDAO instance;
        public static ThemHieuXeDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ThemHieuXeDAO();

                }
                return instance;
            }
            private set { instance = value; }
        } 
        public bool AddHieuXe(string newHieuXe)
        {   
            DataTable cachieuxe= DataProvider.Instance.ExecuteQuery("SELECT * FROM HIEUXE where TENHIEUXE = '"+newHieuXe+"'");  
            if(cachieuxe.Rows.Count>0)
            {
                return false;
            } 
            else
            {
                string query = "INSERT INTO HIEUXE (TENHIEUXE) VALUES ('" + newHieuXe + "')"; 
                DataProvider.Instance.ExecuteNonQuery(query);
                return true;
            }
            
        }
    }
}
