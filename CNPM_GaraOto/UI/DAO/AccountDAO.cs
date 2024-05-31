using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM_GaraOto.UI.DAO
{
    public class  AccountDAO
    {
        private string user;
        public string getUsername()
        {
            return user;
        }
        private static AccountDAO instance; 
        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }
        private bool vaitro;
        private AccountDAO() { }  
        public bool getVaitro()
        {
            return vaitro;
        }
        public bool Login(string username, string password)
        {
            string query = "SELECT * FROM dbo.TAIKHOAN WHERE Username = N'" + username + "' AND Pass_word = N'" + password + "'";
            DataTable res = DataProvider.Instance.ExecuteQuery(query);   
            if(res.Rows.Count > 0)
            {
                int vt = int.Parse(res.Rows[0]["Type"].ToString());
                if (vt == 0) vaitro = false;
                else vaitro = true;
                user = res.Rows[0]["Username"].ToString();
            }
            return res.Rows.Count>0;
        }
        
    }
}
