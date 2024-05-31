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
    public partial class DanhSachHieuXe : Form
    {
        public DanhSachHieuXe()
        {
            InitializeComponent();
            LoadHieuXe();
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void LoadHieuXe()
        {
            List<DTO.HieuXe_DTO> list = DanhsachhieuxeDAO.Instance.LoadListHieuXe();
            dataGridView1.DataSource = list;  
        }  
        

        private void DanhSachHieuXe_Load(object sender, EventArgs e)
        {

        }

       
    }
}
