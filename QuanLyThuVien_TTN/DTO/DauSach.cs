using System.Data;

namespace QuanLyThuVien_TTN.DTO
{
    class DauSach
    {
        private string madausach;
        private string tendausach;
        private int giatien;
        private string tenNXB;
        private string tenTG;
        private string dongTG;
        private string theloai;

        public DauSach(DataRow row)
        {
            Madausach = row["madausach"].ToString();
            Tendausach = row["tendausach"].ToString();
            Giatien = (int)row["giatien"];
            TenNXB = row["TENNXB"].ToString();
            TenTG = row["TENTACGIA"].ToString();
            DongTG = row["DONGTACGIA"].ToString();
            Theloai = row["theloai"].ToString();
        }

        public string Madausach { get => madausach; set => madausach = value; }
        public string Tendausach { get => tendausach; set => tendausach = value; }
        public int Giatien { get => giatien; set => giatien = value; }
        public string TenNXB { get => tenNXB; set => tenNXB = value; }
        public string TenTG { get => tenTG; set => tenTG = value; }
        public string DongTG { get => dongTG; set => dongTG = value; }
        public string Theloai { get => theloai; set => theloai = value; }
    }
}
