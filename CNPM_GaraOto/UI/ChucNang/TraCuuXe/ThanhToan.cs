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

namespace CNPM_GaraOto.UI.ChucNang.TraCuuXe
{
    public partial class ThanhToan : Form
    {
        private string bienSo;
        public ThanhToan(string bienSo)
        {
            this.bienSo = bienSo;

            InitializeComponent();
            LoadThongTinXe();
            LoadThanhToan();
        }
        void LoadThongTinXe()
        {
            dvgtThongTinXe2.DataSource = ThongTinXeDAO.Instance.GetThongTinXeByBienSo(bienSo);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void LoadThanhToan()
        {
            txbBienso.Text = bienSo;
            txbHoten.Text = ThongTinXeDAO.Instance.GetHoTenByBienSo(bienSo);
            txbTienno.Text = ThongTinXeDAO.Instance.GetTienNo(bienSo).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal tienno = ThongTinXeDAO.Instance.GetTienNo(bienSo);
            /*if(tienno == 0)
            {
                MessageBox.Show("Khách hàng đã hoàn tất việc thanh toán!");
                return;
            }*/
            decimal tienthu = decimal.Parse(txbTienthu.Text.ToString());
            if(tienthu <= 0 )
            {
                MessageBox.Show("Số tiền thanh toán phải lớn hơn 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbTienthu.Text = "";
                return;
            }
            DateTime ngaythu = dtpngaythu.Value;
            if (tienthu > tienno)
            {
                decimal tienthua = tienthu - tienno;
                tienthu = tienno;
                ThongTinXeDAO.Instance.ThemPhieuThuTien(bienSo, ngaythu, tienthu);
                MessageBox.Show(string.Format("Trả lại cho khách: {0}", tienthua));
                tienno = 0;
            }
            else
            {
                ThongTinXeDAO.Instance.ThemPhieuThuTien(bienSo, ngaythu, tienthu);
                tienno = tienno - tienthu;
            }


            DialogResult result = MessageBox.Show($"Số tiền nợ của bạn là {tienno:N0} VNĐ?", "Xác nhận thanh toán", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {

                MessageBox.Show("Thanh toán thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ThongTinXeDAO.Instance.UpdateTiennoByBienso(bienSo, tienno);
                this.Close();
            }
        }


    }
}
