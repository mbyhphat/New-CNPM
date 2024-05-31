using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace CNPM_GaraOto.UI.DTO
{
    public class TaiKhoan_DTO
    {
        public TaiKhoan_DTO(string username, string pass_word, int type, DateTime birthday, string cccd, string email, string sdt)
        {
            this.Username = username;
            this.Pass_word = pass_word;
            this.Type = type;
            this.Birthday = birthday;
            this.CCCD = cccd;
            this.Email = email; ;
            this.SDT = sdt;
        }
        public TaiKhoan_DTO(DataRow ds)
        {
            this.Username = ds["Username"].ToString();
            this.Pass_word = ds["Pass_word"].ToString();
            this.Type = Convert.ToInt32(ds["Type"]);
            this.Birthday = Convert.ToDateTime(ds["Birthday"]);
            this.CCCD = ds["CCCD"].ToString();
            this.Email = ds["Email"].ToString();
            this.SDT = ds["SDT"].ToString();
        }
        private string username, pass_word, cccd, email, sdt;
        
        private DateTime birthday;
        private int type;

        public string Username { get { return username; } set { username = value; } }
        public string Pass_word { get { return pass_word; } set { pass_word = value; } }
        public int Type { get { return type; } set { type = value; } }
        public DateTime Birthday { get { return birthday; } set { birthday = value; } }
        public string CCCD { get { return cccd; } set { cccd = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string SDT { get { return sdt; } set { sdt = value; } }
    }
}
