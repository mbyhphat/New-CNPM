using CNPM_GaraOto.UI.DAO;
using CNPM_GaraOto.UI.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CNPM_GaraOto.UI.ChucNang.TraCuuXe
{
    public partial class TraCuuXe : Form
    {
        public TraCuuXe()
        {
            InitializeComponent();
            LoadTraCuuXe();
            AddBindingThongtinxe();

            // Add KeyDown event handlers
            txbNhapbienso.KeyDown += txbNhapbienso_KeyDown;
        }

        private void txbNhapbienso_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btn_TraCuuXe.PerformClick(); // Simulate a button click
            }
        }

        public void LoadTraCuuXe()
        {
            dvgtTraCuuXe.DataSource = TraCuuXeDAO.Instance.GetTraCuuXe();
        }

        public void AddBindingThongtinxe()
        {
            txbNhapbienso.DataBindings.Clear();
            txbNhapbienso.DataBindings.Add(new Binding("Text", dvgtTraCuuXe.DataSource, "BienSo", true, DataSourceUpdateMode.Never));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string bienso = txbNhapbienso.Text;


            if (TraCuu(bienso))
            {
                ThongTinXe t = new ThongTinXe(bienso, this);
                this.Hide();
                t.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Nhập sai! Vui lòng nhập lại.");
                // Clear the textboxes
                txbNhapbienso.Text = string.Empty;
            }
        }

        bool TraCuu(string bienso)
        {
            return TraCuuXeDAO.Instance.TraCuu(bienso);
        }

        List<Xe_DTO> GetXeByBienSo(string bienso)
        {
            List<Xe_DTO> listxe = TraCuuXeDAO.Instance.GetXeByBienSo(bienso);
            return listxe;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dvgtTraCuuXe.DataSource = GetXeByBienSo(txbNhapbienso.Text);
            AddBindingThongtinxe();
        }
    }
}