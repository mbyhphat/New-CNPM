using CNPM_GaraOto.UI.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM_GaraOto.UI.DAO
{
    public class DanhsachhieuxeDAO
    {
        private static DanhsachhieuxeDAO instance;
        public static DanhsachhieuxeDAO Instance
        {
            get { if (instance == null) instance = new DanhsachhieuxeDAO(); return instance; } 
            private set { instance=value; }
        }
        
        private DanhsachhieuxeDAO() { }   
        public List<HieuXe_DTO> LoadListHieuXe()
        {
            List<HieuXe_DTO> res = new List<HieuXe_DTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM HIEUXE");  
            foreach (DataRow item in data.Rows)
            {
                res.Add(new HieuXe_DTO(item));  

            }
            return res;

            
        }
    }
}
