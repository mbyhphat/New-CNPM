using CNPM_GaraOto.UI.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM_GaraOto.UI.DAO
{
    public class TienCongDAO
    {
        private static TienCongDAO instance;
        public static TienCongDAO Instance
        {
            get { if (instance == null) instance = new TienCongDAO(); return instance; }
            private set { instance = value; }
        }
        private TienCongDAO() { }

        public List<TienCong_DTO> GetTienCong()
        {
            List<TienCong_DTO> listtiencong = new List<TienCong_DTO> ();
            string query = "SELECT * FROM TIENCONG";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow dr in data.Rows)
            {
                TienCong_DTO tiencong = new TienCong_DTO(dr);
                listtiencong.Add(tiencong);
            }
            return listtiencong;
        }

        public List<TienCong_DTO> GetTienCongByName(string name)
        {
            List<TienCong_DTO> listtiencong = new List<TienCong_DTO>();
            string query = string.Format("SELECT * FROM TIENCONG WHERE dbo.fuConvertToUnsign1(NoiDung) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow dr in data.Rows)
            {
                TienCong_DTO tiencong = new TienCong_DTO(dr);
                listtiencong.Add(tiencong);
            }
            return listtiencong;
        }
    }
}
