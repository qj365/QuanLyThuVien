using QuanLyThuVien_TTN.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien_TTN.DAO
{
    class DocGiaDAO
    {
        private static DocGiaDAO instance; //Ctrl + R + E

        public static DocGiaDAO Instance
        {
            get { if (instance == null) instance = new DocGiaDAO(); return DocGiaDAO.instance; }
            private set { DocGiaDAO.instance = value; }
        }

        private DocGiaDAO() { }

        public DocGia getDGbyMaThe(string mathe)
        {
            DataTable table = DataProvider.Instance.executeQuery("select docgia.MADOCGIA,TENDOCGIA,GIOITINH,SODIENTHOAI,DIACHI from docgia, THETHUVIEN where docgia.MADOCGIA = THETHUVIEN.MADOCGIA and MATHE = '"+mathe+"'");
            DocGia dg = new DocGia(table.Rows[0]);
            return dg;
        }
        public bool ktDGtt(string mathe)
        {
            DataTable table = DataProvider.Instance.executeQuery("select docgia.MADOCGIA,TENDOCGIA,GIOITINH,SODIENTHOAI,DIACHI from docgia, THETHUVIEN where docgia.MADOCGIA = THETHUVIEN.MADOCGIA and MATHE = '" + mathe + "'");
            if (table.Rows.Count > 0)
                return true;
            return false;
        }
    }
}
