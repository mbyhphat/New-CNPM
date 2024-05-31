using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace CNPM_GaraOto.UI.DTO
{
    public class BaoCaoDoanhSo_DTO
    {
        public BaoCaoDoanhSo_DTO(int mabaocaodoanhso, decimal tongdoanhthu, int thang, int nam)
        {
            this.MaBaoCaoDoanhSo = mabaocaodoanhso;
            this.TongDoanhThu = tongdoanhthu;
            this.Thang = thang;
            this.Nam = nam;  
           
        }
        public BaoCaoDoanhSo_DTO(DataRow ds)
        {
            this.MaBaoCaoDoanhSo = Convert.ToInt32(ds["MaBaoCaoDoanhSo"]);
            this.TongDoanhThu = Convert.ToDecimal(ds["TongDoanhThu"]);
            this.Thang = Convert.ToInt32(ds["Thang"]);
            this.Nam = Convert.ToInt32(ds["Nam"]);
        }
        private int mabaocaodoanhso, thang, nam;
        private decimal tongdoanhthu;
        public int MaBaoCaoDoanhSo { get { return mabaocaodoanhso; } set { mabaocaodoanhso = value; } }
        public decimal TongDoanhThu { get { return tongdoanhthu; } set { tongdoanhthu = value; } }
        public int Thang { get { return thang; } set { thang = value; } }
        public int Nam { get { return nam;} set { nam = value; } }
    }
}
