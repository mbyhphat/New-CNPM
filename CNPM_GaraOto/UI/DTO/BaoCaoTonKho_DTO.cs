using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace CNPM_GaraOto.UI.DTO
{
    public class BaoCaoTonKho_DTO
    {
        public BaoCaoTonKho_DTO(string tenvtpt, int tondau, int phatsinh, int toncuoi)
        {
            this.Tenvtpt = tenvtpt;
            this.TonDau = tondau;
            this.PhatSinh = phatsinh;
            this.TonCuoi = toncuoi;
        }
        public BaoCaoTonKho_DTO(DataRow ds)
        {
            this.Tenvtpt = ds["TenVatTuPhuTung"].ToString();
            this.TonDau = Convert.ToInt32(ds["TonDau"]);
            this.PhatSinh = Convert.ToInt32(ds["PhatSinh"]);
            this.TonCuoi = Convert.ToInt32(ds["TonCuoi"]);
        }
        private int tondau, phatsinh, toncuoi;
        private string tenvtpt;
        public string Tenvtpt { get { return tenvtpt; } set { tenvtpt = value; } }
        public int TonDau { get { return tondau;  } set { tondau = value; } }
        public int PhatSinh { get { return phatsinh; } set { phatsinh = value; } }
        public int TonCuoi { get { return toncuoi; } set { toncuoi = value; } }
        
    }
}
