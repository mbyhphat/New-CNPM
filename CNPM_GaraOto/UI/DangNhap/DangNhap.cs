using CNPM_GaraOto.UI.DAO;
using CNPM_GaraOto.UI.ManHinhChinh;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPM_GaraOto.UI.DangNhap
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            if (Login(username, password))
            {

                CNPM_GaraOto.UI.ManHinhChinh.ManHinhChinh t = new CNPM_GaraOto.UI.ManHinhChinh.ManHinhChinh();
                this.Hide();
                t.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu");
            }

        }
        private bool Login(string username, string password)
        {
            return AccountDAO.Instance.Login(username, password);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button_hidePassword_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '*')
            {
                button_showPassword.BringToFront();
                textBox2.PasswordChar = '\0';
            };
        }

        private void button_showPassword_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '\0')
            {
                button_hidePassword.BringToFront();
                textBox2.PasswordChar = '*';
            };
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
