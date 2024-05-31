using CNPM_GaraOto.UI.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM_GaraOto.UI.DAO
{
    public class ThayDoiThamSoDAO
    {
        private static ThayDoiThamSoDAO instance;
        public static ThayDoiThamSoDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ThayDoiThamSoDAO();
                }
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private ThayDoiThamSoDAO()
        {

        }
        public void ThayDoiSoXeTiepNhanToiDa(int newSoXe)
        {
            string querry = "SELECT * FROM THAMSO";
            DataTable dttb = DataProvider.Instance.ExecuteQuery(querry);
            DataRow ts = dttb.Rows[0];
            ThamSo_DTO thamso = new ThamSo_DTO(ts);
            string deleteQuerry = "DELETE  FROM THAMSO";
            DataProvider.Instance.ExecuteNonQuery(deleteQuerry);
            string insertQuery = "INSERT INTO THAMSO VALUES (" + newSoXe.ToString() + "," + thamso.TiLeDonGiaBan.ToString() + ")";
            DataProvider.Instance.ExecuteNonQuery(insertQuery);
        }
        public void ThayDoiTiLeDonGiaBan(Decimal newTile)
        {
            string querry = "SELECT * FROM THAMSO";
            DataTable dttb = DataProvider.Instance.ExecuteQuery(querry);
            DataRow ts = dttb.Rows[0];
            ThamSo_DTO thamso = new ThamSo_DTO(ts);
            string deleteQuerry = "DELETE  FROM THAMSO";
            DataProvider.Instance.ExecuteNonQuery(deleteQuerry);
            string insertQuery = "INSERT INTO THAMSO VALUES (" + thamso.SoXeTiepNhanToiDa.ToString() + "," + newTile.ToString() + ")";
            DataProvider.Instance.ExecuteNonQuery(insertQuery);
        }

    }
}
