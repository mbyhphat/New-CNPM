using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM_GaraOto.UI.DAO
{
    public class XoahieuxeDAO
    {  
        private static XoahieuxeDAO instance;   
        public  static XoahieuxeDAO Instance
        {
            get{  
                if(instance == null)
                {
                    instance = new XoahieuxeDAO();  

                }
                return instance;
            }   
            private set
            {
                instance = value;
            }
        } 
        public bool XoaHieuXe(string tenhieuxe)
        {
            DataTable xoahieuxe = DataProvider.Instance.ExecuteQuery("SELECT * FROM HIEUXE where TENHIEUXE = '" + tenhieuxe + "'");
            if (xoahieuxe.Rows.Count == 0) return false;
            else
            {
                DataProvider.Instance.ExecuteNonQuery("DELETE FROM HIEUXE where TENHIEUXE = '" + tenhieuxe + "'");
                return true;
            }
        }
    }
}
