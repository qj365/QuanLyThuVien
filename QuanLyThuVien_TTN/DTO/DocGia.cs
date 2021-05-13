using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien_TTN.DTO
{
    class DocGia
    {
        private string madocgia;
        private string tendocgia;
        private string gioitinh;
        private string sdt;
        private string diachi;

        public DocGia(DataRow row)
        {
            Madocgia = row["madocgia"].ToString();
            Tendocgia = row["tendocgia"].ToString();
            Gioitinh = row["gioitinh"].ToString();
            Sdt = row["sodienthoai"].ToString();
            Diachi = row["diachi"].ToString();

        }

        public string Madocgia { get => madocgia; set => madocgia = value; }
        public string Tendocgia { get => tendocgia; set => tendocgia = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Diachi { get => diachi; set => diachi = value; }
    }
}
