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

namespace CNPM_GaraOto.UI.ChucNang.TienCong
{
    public partial class DanhSachTienCong : Form
    {
        public DanhSachTienCong()
        {
            InitializeComponent();
            LoadTienCong();
            AddTienCongBinding();
        }
        void LoadTienCong()
        {
            dataGridView1.DataSource = TienCongDAO.Instance.GetTienCong();
        }
        void AddTienCongBinding()
        {
            txbMatc.DataBindings.Clear();
            txbNoidung.DataBindings.Clear();
            txbTiencong.DataBindings.Clear();

            txbMatc.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "MaTienCong", true, DataSourceUpdateMode.Never));
            txbNoidung.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "NoiDung", true, DataSourceUpdateMode.Never));
            txbTiencong.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "SoTienCong", true, DataSourceUpdateMode.Never));
        }
        List<TienCong_DTO> SearchTienCongByName(string name)
        {
            List<TienCong_DTO> listtiencong = TienCongDAO.Instance.GetTienCongByName(name);
            return listtiencong;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = SearchTienCongByName(txbSearch.Text);
            AddTienCongBinding();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (AccountDAO.Instance.getVaitro())
            {
                ThemTienCong them = new ThemTienCong();
                them.DataAdded += ThemTienCong_DataAdded;
                them.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập vào chức năng này");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (AccountDAO.Instance.getVaitro())
            {
                DialogResult messageBox = MessageBox.Show("Sửa tiền công", "Bạn có muốn sửa tiền công này?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (messageBox == DialogResult.Yes)
                {
                    int matc = Convert.ToInt32(txbMatc.Text.ToString());
                    string noidung = txbNoidung.Text.ToString();
                    Decimal tien = Decimal.Parse(txbTiencong.Text.ToString());
                    SuaTienCongDAO.Instance.SuaTienCong(matc, noidung, tien);
                    LoadTienCong();
                    AddTienCongBinding();
                }
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập chức năng này");
            }
        }
        private void ThemTienCong_DataAdded(object sender, EventArgs e)
        {
            LoadTienCong();
            AddTienCongBinding();
        }
    }
}
