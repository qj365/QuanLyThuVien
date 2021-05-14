using QuanLyThuVien_TTN.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien_TTN.DAO
{
    class NhanVienDAO
    {
        private static NhanVienDAO instance; //Ctrl + R + E

        public static NhanVienDAO Instance
        {
            get { if (instance == null) instance = new NhanVienDAO(); return NhanVienDAO.instance; }
            private set { NhanVienDAO.instance = value; }
        }

        private NhanVienDAO() { }
        public List<NhanVien> GetListNhanVien()
        {
            List<NhanVien> list = new List<NhanVien>();
            DataTable data = DataProvider.Instance.executeQuery("USP_GetNhanVienList ");

            foreach (DataRow item in data.Rows)
            {
                NhanVien nv = new NhanVien(item);
                list.Add(nv);
            }
            return list;
        }

        //Tim kiem
        public List<NhanVien> SearchNV(string hoten, string manhanvien)
        {
            List<NhanVien> list = new List<NhanVien>();
            string query = string.Format("select * from NHANVIEN where (HOTEN like N'{0}') OR (MANHANVIEN like N'{1}')", hoten, manhanvien);
            DataTable data = DataProvider.Instance.executeQuery(query);

            foreach (DataRow item in data.Rows)
            {
                NhanVien nv = new NhanVien(item);
                list.Add(nv);
            }
            return list;
        }

        public void DeletePhieuMuonTraByMaNhanVien(string manhanvien)
        {
            DataProvider.Instance.executeQuery("delete from dbo.PHIEUMUONTRA where MANHANVIEN = " + manhanvien);
        }
        public bool themSua(string manhanvien, string hoten, string ngaysinh, string gioitinh, string sdt, string password)
        {
            string query = string.Format("exec ThemSuaNV @MANHANVIEN = N'{0}',@HOTEN=N'{1}',@NGAYSINH=N'{2}',@GIOITINH=N'{3}',@SODIENTHOAI=N'{4}',@PASSWORD=N'{5}'", manhanvien, hoten, ngaysinh, gioitinh, sdt, password);
            int result = DataProvider.Instance.executeNonQuery(query);
            return result > 0;
        }
        public bool DeleteNV(string manhanvien)
        {
            string query = string.Format(" delete from dbo.NHANVIEN where MANHANVIEN = N'{0}' ", manhanvien);
            int result = DataProvider.Instance.executeNonQuery(query);

            return result > 0;
        }
    }
}
