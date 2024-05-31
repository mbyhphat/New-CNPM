using CNPM_GaraOto.UI.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPM_GaraOto.UI.ChucNang.TienCong
{
    public partial class ThemTienCong : Form
    {
        public ThemTienCong()
        {
            InitializeComponent();
        }
        public event EventHandler DataAdded;

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult messageBox = MessageBox.Show("Thêm tiền công", "Bạn có muốn thêm tiền công này?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (messageBox == DialogResult.Yes)
                {
                    string nd = textBox1.Text.ToString();
                    Decimal t = Decimal.Parse(textBox2.Text.ToString());
                    ThemTienCongDAO.Instance.ThemTienCong(nd, t);
                    DataAdded?.Invoke(this, EventArgs.Empty);
                    this.Close();
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
