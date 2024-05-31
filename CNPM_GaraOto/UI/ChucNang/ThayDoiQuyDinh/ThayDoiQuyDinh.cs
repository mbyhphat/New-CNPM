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

namespace CNPM_GaraOto.UI.ChucNang.ThayDoiQuyDinh
{
    public partial class ThayDoiQuyDinh : Form
    {
        public ThayDoiQuyDinh()
        {
            InitializeComponent();
            LoadThamSo();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            DanhSachHieuXe t = new DanhSachHieuXe();
            t.ShowDialog();




        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (AccountDAO.Instance.getVaitro())
            {
                
                DialogResult messageBox = MessageBox.Show("Thêm hiệu xe", "Bạn có muốn thêm hiệu xe này?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (messageBox == DialogResult.Yes)
                {
                    string newHieuXe = textBox4.Text.ToString();
                    if (ThemHieuXeDAO.Instance.AddHieuXe(newHieuXe))
                    {
                        MessageBox.Show("Thêm thành công");
                    }
                    else
                    {
                        MessageBox.Show("Hiệu xe bạn cần thêm đã có trong danh sách");
                    }
                }

            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập vào chức năng này!");
            }

        }

        
        private void LoadThamSo()
        {
            string querry = "SELECT * FROM THAMSO";
            DataTable dttb = DataProvider.Instance.ExecuteQuery(querry);
            DataRow ts = dttb.Rows[0];
            ThamSo_DTO thamso = new ThamSo_DTO(ts);
            textBox1.Text = thamso.SoXeTiepNhanToiDa.ToString();
            textBox3.Text = thamso.TiLeDonGiaBan.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (AccountDAO.Instance.getVaitro())
            {
                int soxemoi = Convert.ToInt32(textBox1.Text.ToString());
                DialogResult messageBox = MessageBox.Show("Bạn có muốn lưu các thay đổi?",
                    "Thay đổi số xe tiếp nhận tối đa trong ngày", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (messageBox == DialogResult.Yes)
                {
                    ThayDoiThamSoDAO.Instance.ThayDoiSoXeTiepNhanToiDa(soxemoi);
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập vào chức năng này!");
            }




        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (AccountDAO.Instance.getVaitro())
            {
                Decimal tilemoi = Decimal.Parse(textBox3.Text.ToString());
                DialogResult messageBox = MessageBox.Show("Bạn có muốn lưu các thay đổi?",
                    "Thay đổi tỉ lệ đơn giá bán", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (messageBox == DialogResult.Yes)
                {
                    ThayDoiThamSoDAO.Instance.ThayDoiTiLeDonGiaBan(tilemoi);
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập vào chức năng này!");
            }

        }

        
    }
}
