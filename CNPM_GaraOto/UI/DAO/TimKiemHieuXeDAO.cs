using CNPM_GaraOto.UI.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM_GaraOto.UI.DAO
{
    public class TimKiemHieuXeDAO
    {
        private static TimKiemHieuXeDAO instance;  
        public static TimKiemHieuXeDAO Instance
        {
            get
            {
                if(instance==null)
                {
                    instance = new TimKiemHieuXeDAO();  
                }
                return instance;
            } 
            private set
            {
                instance = value;
            }
        }   
        public HieuXe_DTO timkiem(string info)
        {
            DataTable result = DataProvider.Instance.ExecuteQuery("SELECT * FROM HIEUXE WHERE TenHieuXe = '" + info + "'");   
            if(result.Rows.Count==0)
            {
                return new HieuXe_DTO(0, "");
            }  
            else
            {
                return new HieuXe_DTO(result.Rows[0]);
            }
            
        }
    }
}
