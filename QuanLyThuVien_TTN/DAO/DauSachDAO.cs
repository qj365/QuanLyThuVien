using QuanLyThuVien_TTN.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien_TTN.DAO
{
    class DauSachDAO
    {
        private static DauSachDAO instance; //Ctrl + R + E

        public static DauSachDAO Instance
        {
            get { if (instance == null) instance = new DauSachDAO(); return DauSachDAO.instance; }
            private set { DauSachDAO.instance = value; }
        }

        private DauSachDAO() { }

        public DauSach getDauSachbyMaSach(string masach)
        {
            DataTable table = DataProvider.Instance.executeQuery("select DAUSACH.MADAUSACH,TENDAUSACH, GIATIEN, TENNXB, TENTACGIA, DONGTACGIA, THELOAI from DAUSACH, SACH where DAUSACH.MADAUSACH = SACH.MADAUSACH and MASACH = '"+masach+"'");
            DauSach ds = new DauSach(table.Rows[0]);
            return ds;
        }

        public List<DauSach> GetListDauSach()
        {
            List<DauSach> list = new List<DauSach>();
            DataTable data = DataProvider.Instance.executeQuery("USP_GetDauSachList ");

            foreach (DataRow item in data.Rows)
            {
                DauSach ds = new DauSach(item);
                list.Add(ds);
            }
            return list;
        }
        public DauSach GetDauSachByMaDauSach(string madausach)
        {
            DauSach dausach = null;
            string query = "select * from DAUSACH where MADAUSACH = " + madausach;
            DataTable data = DataProvider.Instance.executeQuery(query);

            foreach (DataRow item in data.Rows)
            {
                dausach = new DauSach(item);
                return dausach;
            }

            return dausach;
        }
        //Tim kiem
        public List<DauSach> SearchDS(string tendausach, string madausach, string tennxb, string tentacgia, string theloai)
        {
            List<DauSach> list = new List<DauSach>();
            string query = string.Format("select * from DAUSACH where (TENDAUSACH like N'{0}') OR " +
                "(MADAUSACH like N'{1}') OR " +
                "(TENNXB like N'{2}') OR " +
                "(TENTACGIA like N'{3}') OR " +
                "(THELOAI like N'{4}')", tendausach, madausach, tennxb, tentacgia, theloai);
            DataTable data = DataProvider.Instance.executeQuery(query);

            foreach (DataRow item in data.Rows)
            {
                DauSach ds = new DauSach(item);
                list.Add(ds);
            }
            return list;
        }

        public void DeleteSachByMaDauSach(string madausach)
        {
            DataProvider.Instance.executeQuery("delete from dbo.DAUSACH where MADAUSACH = " + madausach);
        }
        public bool DeleteDS(string mads)
        {
            string query = string.Format(" delete from dbo.DAUSACH where MADAUSACH = N'{0}' ", mads);
            int result = DataProvider.Instance.executeNonQuery(query);

            return result > 0;
        }
    }
}
