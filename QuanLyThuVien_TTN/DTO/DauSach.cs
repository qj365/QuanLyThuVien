using System.Data;

namespace QuanLyThuVien_TTN.DTO
{
    class DauSach
    {
        public DauSach(string madausach, string tendausach, int giatien, string tennxb, string tentacgia, string theloai)
        {
            this.MaDauSach = madausach;
            this.TenDauSach = tendausach;
            this.GiaTien = giatien;
            this.TenNXB = tennxb;
            this.TenTacGia = tentacgia;
            this.TheLoai = theloai;
        }
        public DauSach(DataRow row)
        {
            this.MaDauSach = row["madausach"].ToString();
            this.TenDauSach = row["tendausach"].ToString();
            this.GiaTien = (int)row["giatien"];
            this.TenNXB = row["tennxb"].ToString();
            this.TenTacGia = row["tentacgia"].ToString();
            this.TheLoai = row["theloai"].ToString();
        }
        private string maDauSach;
        private string tenDauSach;
        private int giaTien;
        private string tenNXB;
        private string tenTacGia;
        private string theLoai;

        public string MaDauSach { get => maDauSach; set => maDauSach = value; }
        public string TenDauSach { get => tenDauSach; set => tenDauSach = value; }
        public int GiaTien { get => giaTien; set => giaTien = value; }
        public string TenNXB { get => tenNXB; set => tenNXB = value; }
        public string TenTacGia { get => tenTacGia; set => tenTacGia = value; }
        public string TheLoai { get => theLoai; set => theLoai = value; }

    }
}
