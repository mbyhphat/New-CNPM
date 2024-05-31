using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace CNPM_GaraOto.UI.DTO
{
    public class PhieuThuTien_DTO
    {
        public PhieuThuTien_DTO(int phieuthutien, string bienso, DateTime ngaythu, decimal sotienthu)
        {
            this.PhieuThuTien = phieuthutien;
            this.BienSo = bienso;
            this.NgayThu = ngaythu;
            this.SoTienThu = sotienthu;
        }
        public PhieuThuTien_DTO(DataRow ds)
        {
            this.PhieuThuTien = Convert.ToInt32(ds["PhieuThuTien"]);
            this.BienSo = ds["BienSo"].ToString();
            this.NgayThu = Convert.ToDateTime(ds["NgayThu"]);
            this.SoTienThu = Convert.ToDecimal(ds["SoTienThu"]);
        }
        private int phieuthutien;
        private string bienso;
        private DateTime ngaythu;
        private decimal sotienthu;
        public int PhieuThuTien { get { return phieuthutien; } set { phieuthutien = value; } }
        public string BienSo { get { return bienso; } set { bienso = value; } }
        public DateTime NgayThu { get { return ngaythu; } set { ngaythu = value; } }
        public decimal SoTienThu { get { return sotienthu; } set { sotienthu = value; } }
    }
}
