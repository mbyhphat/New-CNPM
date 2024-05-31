using CNPM_GaraOto.UI.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace CNPM_GaraOto.UI.DAO
{
    public class TraCuuXeDAO
    {
        private static TraCuuXeDAO instance;

        public static TraCuuXeDAO Instance
        {
            get { if (instance == null) instance = new TraCuuXeDAO(); return instance; }
            private set { instance = value; }
        }

        private TraCuuXeDAO() { }

        public List<TraCuuXe_DTO> GetTraCuuXe()
        {
            
            List<TraCuuXe_DTO> tracuuxe = new List<TraCuuXe_DTO>();
            string query = @"SELECT
                                kh.TenChuXe,
                                xe.BienSo,
                                hx.TenHieuXe,
                                xe.NgayTiepNhan,
                                xe.TienNo
                            FROM
                                XE xe
                            JOIN
                                KHACHHANG kh ON xe.MaKhachHang = kh.MaKhachHang
                            JOIN HIEUXE hx ON hx.MaHieuXe = xe.MaHieuXe";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                TraCuuXe_DTO tracuu = new TraCuuXe_DTO(row);
                tracuuxe.Add(tracuu);
            }

            return tracuuxe;
        }
        public bool TraCuu(string bienSo)
        {


            string query = "SELECT * FROM XE JOIN KHACHHANG  ON XE.MaKhachHang = KHACHHANG.MaKhachHang JOIN HIEUXE  ON HIEUXE.MaHieuXe = XE.MaHieuXe WHERE BienSo = N'" + bienSo + "'";

            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }

        public List<Xe_DTO> GetXeByBienSo(string bienso)
        {
            List<Xe_DTO> listxe = new List<Xe_DTO>();

            string query = string.Format("SELECT BienSo, TenChuXe, TenHieuXe, NgayTiepNhan, TienNo " +
                                         "From XE, KHACHHANG kh, HIEUXE hx " +
                                        "WHERE XE.MaKhachHang = kh.MaKhachHang And XE.MaHieuXe = hx.MaHieuXe And " +
                                        "dbo.fuConvertToUnsign1(BienSo) Like N'%' + dbo.fuConvertToUnsign1(N'{0}') + N'%'", bienso);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                Xe_DTO xe = new Xe_DTO(row);
                listxe.Add(xe);
            }
            return listxe;
        }

    }

}