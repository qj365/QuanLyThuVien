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
        public List<DocGia> GetListDocGia()

        {
            List<DocGia> list = new List<DocGia>();
            DataTable data = DataProvider.Instance.executeQuery("select * from DOCGIA");
            //List<DocGia> list = new List<DocGia>();
            //DataTable data = DataProvider.Instance.ExecuteQuery("select * from DOCGIA ");

            foreach (DataRow item in data.Rows)
            {
                DocGia docGia = new DocGia(item);
                list.Add(docGia);
            }
            return list;
        }
        public bool InsertDocGia(string madocgia, string tendocgia, string gioitinh, string sodienthoai, string diachi)
        {
            string query = string.Format("insert DOCGIA ( MADOCGIA, TENDOCGIA, GIOITINH,SODIENTHOAI,DIACHI) values" +
                " ( N'{0}', N'{1}',N'{2}',N'{3}',N'{4}')", madocgia, tendocgia, gioitinh, sodienthoai, diachi);
            int result = DataProvider.Instance.executeNonQuery(query);
            return result > 0;
        }
        public bool UpdateDocGia(string madocgia, string tendocgia, string gioitinh, string sodienthoai, string diachi)
        {
            string query = string.Format(
            "update DOCGIA set  TENDOCGIA= N'{0}', GIOITINH=N'{1}', SODIENTHOAI=N'{2}', DIACHI=N'{3}' where MADOCGIA = N'{4}' ",
             tendocgia, gioitinh, sodienthoai, diachi, madocgia);
            int result = DataProvider.Instance.executeNonQuery(query);

            return result > 0;
        }

        public bool DeleteDocGia(string madocgia)
        {
            string query = string.Format(" delete from DOCGIA where MADOCGIA = N'{0}' ", madocgia);
            int result = DataProvider.Instance.executeNonQuery(query);

            return result > 0;
        }
        public List<DocGia> SearchSvByTenDG(string tendocgia, string madocgia)
        {
            List<DocGia> list = new List<DocGia>();
            string query = string.Format("select * from DOCGIA where [dbo].[GetUnsignString](TENDOCGIA) like N'%'" +
                "+[dbo].[GetUnsignString](N'{0}')+ '%' and [dbo].[GetUnsignString](MADOCGIA) " +
                "like N'%' +[dbo].[GetUnsignString](N'{1}') + '%'", tendocgia, madocgia);
            DataTable data = DataProvider.Instance.executeQuery(query);

            foreach (DataRow item in data.Rows)
            {
                DocGia docGia = new DocGia(item);
                list.Add(docGia);
            }
            return list;
        }
        public List<DocGia> SearchSvByMaDG(string madocgia)
        {
            List<DocGia> list = new List<DocGia>();
            string query = string.Format("select * from DOCGIA where [dbo].[GetUnsignString](MADOCGIA) " +
                "like N'%'+[dbo].[GetUnsignString](N'{0}')+'%' ", madocgia);
            // '%0%' or '%1%' or '%2%' or '%2%' or '%3%' or '%4%' or '%5%' or '%6%' or '%7%' or '%8%' or '%9%
            DataTable data = DataProvider.Instance.executeQuery(query);
            foreach (DataRow item in data.Rows)
            {
                DocGia docGia = new DocGia(item);
                list.Add(docGia);
            }
            return list;
        }
        public List<DocGia> SearchDG(string madocgia, string tendocgia)
        {
            List<DocGia> list = new List<DocGia>();
            string query = string.Format("select * from DOCGIA where (MADOCGIA like N'{0}') OR (TENDOCGIA like N'{1}')", madocgia, tendocgia);
            DataTable data = DataProvider.Instance.executeQuery(query);

            foreach (DataRow item in data.Rows)
            {
                DocGia ds = new DocGia(item);
                list.Add(ds);
            }
            return list;
        }

    }
}
