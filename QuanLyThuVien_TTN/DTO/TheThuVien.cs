using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien_TTN.DTO
{
    class TheThuVien
    {
        private string mathe;
        private DateTime ngaybatdau;
        private DateTime ngayhethan;
        private string madocgia;

        public TheThuVien(DataRow row)
        {
            Mathe = row["mathe"].ToString();
            Madocgia = row["madocgia"].ToString();
            Ngaybatdau = (DateTime)row["ngaybatdau"];
            Ngayhethan = (DateTime)row["ngayhethan"];
        }

        public string Mathe { get => mathe; set => mathe = value; }
        public DateTime Ngaybatdau { get => ngaybatdau; set => ngaybatdau = value; }
        public DateTime Ngayhethan { get => ngayhethan; set => ngayhethan = value; }
        public string Madocgia { get => madocgia; set => madocgia = value; }
    }
}
