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
    public class XoaSuaVatTuPhuTungDAO
    {
        private static XoaSuaVatTuPhuTungDAO instance;
        public static XoaSuaVatTuPhuTungDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new XoaSuaVatTuPhuTungDAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        public void XoaVatTuPhuTung(int mavtpt)
        {
            string querry = "DELETE FROM VATTUPHUTUNG WHERE MAVATTUPHUTUNG=" + mavtpt.ToString();
            DataProvider.Instance.ExecuteNonQuery(querry);
        }
        public void SuaVatTuPhuTung(int mavtpt, string ten, Decimal Dongianhap)
        {
            DataTable thamso = DataProvider.Instance.ExecuteQuery("SELECT * FROM THAMSO");
            DataRow ts = thamso.Rows[0];
            ThamSo_DTO tsDTO = new ThamSo_DTO(ts);
            Decimal dgb = Dongianhap * tsDTO.TiLeDonGiaBan;

            string querry = "UPDATE VATTUPHUTUNG SET TENVATTUPHUTUNG=N'" + ten + "',DONGIANHAP=" + Dongianhap.ToString() + ",DONGIABAN=" + dgb.ToString() + " WHERE MAVATTUPHUTUNG=" + mavtpt.ToString();
            DataProvider.Instance.ExecuteNonQuery(querry);

        }
    }
}
