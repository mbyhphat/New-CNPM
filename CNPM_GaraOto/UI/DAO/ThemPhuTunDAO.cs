using CNPM_GaraOto.UI.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CNPM_GaraOto.UI.DAO
{
    public class ThemPhuTunDAO
    {
        private static ThemPhuTunDAO instance;
        public static ThemPhuTunDAO Instance
        {
            get
            {
                if (instance == null) instance = new ThemPhuTunDAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private ThemPhuTunDAO() { }
        public void ThemVatTuPhuTung(string tenpt, Decimal dongianhap)
        {
            DataTable thamso = DataProvider.Instance.ExecuteQuery("SELECT * FROM THAMSO");
            DataRow ts = thamso.Rows[0];
            ThamSo_DTO thamsoDTO = new ThamSo_DTO(ts);
            Decimal tiledongiaban = thamsoDTO.TiLeDonGiaBan;
            Decimal dongiaban = dongianhap * tiledongiaban;
            string query = "INSERT INTO VATTUPHUTUNG VALUES ('" + tenpt + "','" + dongianhap.ToString() + "','" + dongiaban.ToString() + "','0')";
            DataProvider.Instance.ExecuteNonQuery(query);




        }
    }
}

