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

    }
}
