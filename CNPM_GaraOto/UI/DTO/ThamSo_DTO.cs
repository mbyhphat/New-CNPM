using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CNPM_GaraOto.UI.DTO
{
    public class ThamSo_DTO
    {
        public ThamSo_DTO(int soxetiepnhantoida, decimal tiledongiaban)
        {
            this.SoXeTiepNhanToiDa = soxetiepnhantoida;
            this.TiLeDonGiaBan = tiledongiaban;
        }
        public ThamSo_DTO(DataRow ds)
        {
            this.SoXeTiepNhanToiDa = Convert.ToInt32(ds["SoXeTiepNhanToiDa"]);
            this.TiLeDonGiaBan = (Decimal)ds["TiLeDonGiaBan"];
        }
        private int soxetiepnhantoida;
        private decimal tiledongiaban;
        public int SoXeTiepNhanToiDa { get { return soxetiepnhantoida; } set { soxetiepnhantoida = value; } }
        public decimal TiLeDonGiaBan { get { return tiledongiaban; } set { tiledongiaban = value; } }
    }
}
