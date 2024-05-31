using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace CNPM_GaraOto.UI.DTO
{
    public class TienCong_DTO
    {
        public TienCong_DTO(int matiencong, string noidung, decimal sotiencong)
        {
            this.MaTienCong = matiencong;
            this.NoiDung = noidung;
            this.SoTienCong = sotiencong;
        }
        public TienCong_DTO(DataRow ds)
        {
            this.MaTienCong = Convert.ToInt32(ds["MaTienCong"]);
            this.NoiDung = ds["NoiDung"].ToString();
            this.SoTienCong = Convert.ToDecimal(ds["SoTienCong"]);
        }
        private int matiencong;
        private string noidung;
        private decimal sotiencong;
        public int MaTienCong { get { return matiencong; } set { matiencong = value; } }
        public string NoiDung { get { return noidung; } set { noidung = value; } }
        public decimal SoTienCong { get { return sotiencong; } set { sotiencong = value; } }
    }
}
