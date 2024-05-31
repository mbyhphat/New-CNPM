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

namespace CNPM_GaraOto.UI.ChucNang.VatTuPhuTung
{
    public partial class KhoPhuTung : Form
    {
        public KhoPhuTung()
        {
            InitializeComponent();
            LoadKhoPhuTung();
            AddKhoPTBinding();
        }

        void LoadKhoPhuTung()
        {
            dataGridView1.DataSource = KhoPhuTungDAO.Instance.GetVatTuPhuTung();
        }

        void AddKhoPTBinding()
        {
            txbMavtpt.DataBindings.Clear();
            txbTenvtpt.DataBindings.Clear();
            txbDongiaban.DataBindings.Clear();
            txbDongianhap.DataBindings.Clear();
            txbSoluongton.DataBindings.Clear();

            txbMavtpt.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "MaVatTuPhuTung", true, DataSourceUpdateMode.Never));
            txbTenvtpt.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "TenVatTuPhuTung", true, DataSourceUpdateMode.Never));
            txbDongiaban.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "DonGiaBan", true, DataSourceUpdateMode.Never));
            txbDongianhap.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "DonGiaNhap", true, DataSourceUpdateMode.Never));
            txbSoluongton.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "SoLuongTon", true, DataSourceUpdateMode.Never));
        }
        List<VatTuPhuTung_DTO> SearchPhuTungByName(string name)
        {
            List<VatTuPhuTung_DTO> listphutung = KhoPhuTungDAO.Instance.GetVatTuPhuTungByName(name);
            return listphutung;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = SearchPhuTungByName(txbSearch.Text);
            AddKhoPTBinding();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (AccountDAO.Instance.getVaitro())
            {
                DialogResult messageBox = MessageBox.Show("Sửa thông tin vật tư phụ tùng", "Bạn có muốn lưu những thay đổi này?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (messageBox == DialogResult.Yes)
                {
                    string mavtpt = txbMavtpt.Text.ToString();
                    string tenvtpt = txbTenvtpt.Text.ToString();
                    Decimal dongianhap = Decimal.Parse(txbDongianhap.Text.ToString());
                    XoaSuaVatTuPhuTungDAO.Instance.SuaVatTuPhuTung(Convert.ToInt32(mavtpt), tenvtpt, dongianhap);
                    LoadKhoPhuTung();
                    AddKhoPTBinding();
                }

            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập vào chức năng này!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (AccountDAO.Instance.getVaitro())
            {
                string mavtpt = txbMavtpt.Text.ToString();
                XoaSuaVatTuPhuTungDAO.Instance.XoaVatTuPhuTung(Convert.ToInt32(mavtpt));

            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập vào chức năng này!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AccountDAO.Instance.getVaitro())
            {
                ThemPhuTung t = new ThemPhuTung();
                t.DataAdded += ThemPhuTung_DataAdded;
                this.Hide();
                t.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập vào chức năng này!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NhapPhuTung nhap = new NhapPhuTung();
            nhap.DataAdded += NhapPhuTung_DataAdded;
            this.Hide();
            nhap.ShowDialog();
            this.Show();
        }

        private void ThemPhuTung_DataAdded(object sender, EventArgs e)
        {
            LoadKhoPhuTung();
            AddKhoPTBinding();
        }

        private void NhapPhuTung_DataAdded(object sender, EventArgs e)
        {
            LoadKhoPhuTung();
            AddKhoPTBinding();
        }
    }
}
