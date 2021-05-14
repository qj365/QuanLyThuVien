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
        public DocGia(string madocgia, string tendocgia, string gioitinh, string sodienthoai, string diachi)
        {
            this.Madocgia = madocgia;// ma sinh vien
            this.Tendocgia = madocgia;
            this.Gioitinh = gioitinh;
            this.Sodienthoai = sodienthoai;
            this.Diachi = diachi;

        }
        private string madocgia;
        private string tendocgia;
        private string gioitinh;
        private string sodienthoai;
        private string diachi;

        public DocGia(DataRow row)
        {
            this.Madocgia = row["madocgia"].ToString();
            this.Tendocgia = row["tendocgia"].ToString();
           this.Gioitinh = row["gioitinh"].ToString();
            this.Sodienthoai = row["sodienthoai"].ToString();
            this.Diachi = row["diachi"].ToString();

        }

        public string Madocgia { get => madocgia; set => madocgia = value; }
        public string Tendocgia { get => tendocgia; set => tendocgia = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Sodienthoai { get => sodienthoai; set => sodienthoai = value; }
        public string Diachi { get => diachi; set => diachi = value; }
    }
}
