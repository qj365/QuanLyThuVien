using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien_TTN.DTO
{
    class Sach
    {
        private string masach;
        private string namxuatban;
        private string madausach;

        public Sach(DataRow row)
        {
            Masach = row["masach"].ToString();
            Namxuatban = row["namxuatban"].ToString();
            Madausach = row["madausach"].ToString();
        }

        public string Masach { get => masach; set => masach = value; }
        public string Namxuatban { get => namxuatban; set => namxuatban = value; }
        public string Madausach { get => madausach; set => madausach = value; }
    }
}
