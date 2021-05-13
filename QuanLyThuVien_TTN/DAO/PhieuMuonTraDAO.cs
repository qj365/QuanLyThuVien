using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien_TTN.DAO
{
    class PhieuMuonTraDAO
    {
        private static PhieuMuonTraDAO instance; //Ctrl + R + E

        public static PhieuMuonTraDAO Instance
        {
            get { if (instance == null) instance = new PhieuMuonTraDAO(); return PhieuMuonTraDAO.instance; }
            private set { PhieuMuonTraDAO.instance = value; }
        }

        private PhieuMuonTraDAO() { }

        public void taoPhieuMuon(string manv,string mathe)
        {
            DataProvider.Instance.executeQuery("EXEC TAOPHIEUMUONTRA @MANV , @MATHE",new object[] {manv,mathe });
        }

        public void taoCTPhieuMuon(string mapm,string masach)
        {
            DataProvider.Instance.executeQuery("insert into CHITIETMUONTRA(MAMUONTRA,MASACH) values ('" + mapm+"','"+masach+"')");
        }
        public string getPhieuMuonMax()
        {
            return DataProvider.Instance.executeScalar("select max(MAMUONTRA) from phieumuontra").ToString();
        }

        public DateTime Today()
        {
            DateTime today = (DateTime)DataProvider.Instance.executeScalar("select convert(date,getdate())");

            return today;
        }

        public void updateCTMTtrasach(string mapm)
        {
            DataProvider.Instance.executeNonQuery("update CHITIETMUONTRA set NGAYTRA = CONVERT(date, GETDATE()) where MAMUONTRA = '"+mapm+"'");
        }
    }
}
