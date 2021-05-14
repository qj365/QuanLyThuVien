using QuanLyThuVien_TTN.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien_TTN.DAO
{
    class SachDAO
    {
        private static SachDAO instance; //Ctrl + R + E

        public static SachDAO Instance
        {
            get { if (instance == null) instance = new SachDAO(); return SachDAO.instance; }
            private set { SachDAO.instance = value; }
        }

        private SachDAO() { }

        public Sach getSachbyMaSach(string masach)
        {
            DataTable table = DataProvider.Instance.executeQuery("select * from sach where masach = '" + masach + "'");
            Sach s = new Sach(table.Rows[0]);
            return s;
        }

        public bool ttSach(string masach)
        {
            DataTable table = DataProvider.Instance.executeQuery("select * from sach where masach = '" + masach + "'");
            if (table.Rows.Count > 0)
                return true;

            return false;
        }

        public bool kiemtraTrasach(string masach)
        {
            int c = (int)DataProvider.Instance.executeScalar("select count(*) from chitietmuontra where masach = '" + masach + "' and ngaytra is null");
            if (c > 0)
                return false;
            return true;
        }

        public bool ktDGtraSach(string mattv)
        {
            DataTable table = DataProvider.Instance.executeQuery("select PHIEUMUONTRA.MAMUONTRA from THETHUVIEN,PHIEUMUONTRA,CHITIETMUONTRA where THETHUVIEN.MATHE = PHIEUMUONTRA.MATHE and PHIEUMUONTRA.MAMUONTRA = CHITIETMUONTRA.MAMUONTRA and NGAYTRA is null and  THETHUVIEN.MATHE = '" + mattv + "'");
            if (table.Rows.Count > 0)
                return false;
            return true;
        }
        public string getMaMuonTra(string mattv)
        {
            DataTable table = DataProvider.Instance.executeQuery("select PHIEUMUONTRA.MAMUONTRA from THETHUVIEN,PHIEUMUONTRA,CHITIETMUONTRA where THETHUVIEN.MATHE = PHIEUMUONTRA.MATHE and PHIEUMUONTRA.MAMUONTRA = CHITIETMUONTRA.MAMUONTRA and NGAYTRA is null and  THETHUVIEN.MATHE = '" + mattv + "'");
            return table.Rows[0].Field<string>(0);
        }

        public List<string> getSacHDGmuon(string mattv) 
        {
            List<string> lst = new List<string>();
            DataTable table = DataProvider.Instance.executeQuery("select masach from THETHUVIEN,PHIEUMUONTRA,CHITIETMUONTRA where THETHUVIEN.MATHE = PHIEUMUONTRA.MATHE and PHIEUMUONTRA.MAMUONTRA = CHITIETMUONTRA.MAMUONTRA and NGAYTRA is null and  THETHUVIEN.MATHE = '" + mattv + "'");
            foreach (DataRow item in table.Rows)
            {
                string ts = item["masach"].ToString();
                lst.Add(ts);
            }
            return lst;
        }
        public DateTime getHanTraSach(string mattv)
        {
            DataTable table = DataProvider.Instance.executeQuery("select hantra from THETHUVIEN,PHIEUMUONTRA,CHITIETMUONTRA where THETHUVIEN.MATHE = PHIEUMUONTRA.MATHE and PHIEUMUONTRA.MAMUONTRA = CHITIETMUONTRA.MAMUONTRA and NGAYTRA is null and  THETHUVIEN.MATHE = '" + mattv + "'");
            DateTime hantra = table.Rows[0].Field<DateTime>("hantra");
            return hantra;
        }

        public List<Sach> GetListSach()
        {
            List<Sach> list = new List<Sach>();
            DataTable data = DataProvider.Instance.executeQuery("select MASACH,NAMXUATBAN,SACH.MADAUSACH,TENDAUSACH from SACH, DAUSACH where SACH.MADAUSACH=DAUSACH.MADAUSACH ");

            foreach (DataRow item in data.Rows)
            {
                Sach s = new Sach(item);
                list.Add(s);
            }
            return list;
        }

        //Tim kiem
        public List<Sach> SearchS(string masach, string dausach)
        {
            List<Sach> list = new List<Sach>();
            string query = string.Format("select * from SACH where (MASACH like N'{0}') OR (MADAUSACH like N'{1}')", masach, dausach);
            DataTable data = DataProvider.Instance.executeQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Sach s = new Sach(item);
                list.Add(s);
            }
            return list;
        }
        public bool DeleteS(string mas)
        {
            string query = string.Format(" delete from dbo.SACH where MASACH = N'{0}' ", mas);
            int result = DataProvider.Instance.executeNonQuery(query);

            return result > 0;
        }
    }
}
