using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien_TTN.DAO
{
    class TheThuVienDAO
    {
        private static TheThuVienDAO instance; //Ctrl + R + E

        public static TheThuVienDAO Instance
        {
            get { if (instance == null) instance = new TheThuVienDAO(); return TheThuVienDAO.instance; }
            private set { TheThuVienDAO.instance = value; }
        }

        private TheThuVienDAO() { }

        public int ktNgayHetHan(string date)
        {
            return (int)DataProvider.Instance.executeScalar("SELECT DATEDIFF(DAY, '"+date+"', CONVERT(date,GETDATE()))");
        }

        public DateTime getNgayHetHan(string mathe)
        {
            return (DateTime)DataProvider.Instance.executeScalar("SELECT ngayhethan FROM thethuvien where mathe = '" + mathe + "'");
        }
        public int getQuaHan(DateTime today, DateTime ngayhh)
        {
            string to = today.ToString("yyyy-MM-dd");
            string ngay = ngayhh.ToString("yyyy-MM-dd");
            int s = (int)DataProvider.Instance.executeScalar("SELECT DATEDIFF(day, '"+ngay+"', '"+to+"')");
            if (s > 0)
                return 0;
            return s * -1;
        }
    }
}
