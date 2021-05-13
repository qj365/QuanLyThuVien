using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien_TTN.DAO
{
    class AccountDAO
    {
        private static AccountDAO instance;

        internal static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }
        private AccountDAO() { }
        public static string username;
        public static string hoten;
        public bool Login(string user, string pass)
        {
            string q = "select * from NhanVien where USERNAME = @user and PASSWORD = @pass";
            DataTable result = DataProvider.Instance.executeQuery(q, new object[] { user, pass });
            if (result.Rows.Count > 0)
            {
                username = result.Rows[0].Field<string>(0);
                hoten = result.Rows[0].Field<string>("HOTEN");
                return true;
            }
            return false;
        }
        public string getNameByUsername(string username)
        {
            string data = DataProvider.Instance.executeScalar("select HOTEN from NhanVien where USERNAME = '" + username + "'").ToString();
            return data;
        }
    }
}
