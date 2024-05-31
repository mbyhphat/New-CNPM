using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM_GaraOto.UI.DAO
{
    public class SuaTienCongDAO
    {
        private static SuaTienCongDAO instance;
        public static SuaTienCongDAO Instance
        {
            get
            {
                if(instance==null)
                {
                    instance = new SuaTienCongDAO();
                }
                return instance;
            } 
            private set
            {
                instance = value;
            } 
        }  
        public void SuaTienCong(int matc, string ndmoi, Decimal tiencongmoi)
        {
            string querry = "UPDATE TIENCONG SET NOIDUNG='" + ndmoi + "', SOTIENCONG=" + tiencongmoi.ToString() + " WHERE MATIENCONG=" + matc.ToString();
            DataProvider.Instance.ExecuteNonQuery(querry);
        }
    }
}
