using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien_TTN.DTO
{
    class NhanVien
    {
        public NhanVien(string manhanvien, string hoten, string ngaysinh, string gioitinh, string sodienthoai, string password)
        {
            this.MaNhanVien = manhanvien;
            this.HoTen = hoten;
            this.NgaySinh = ngaysinh;
            this.GioiTinh = gioitinh;
            this.SoDienThoai = sodienthoai;

        }
        public NhanVien(DataRow row)
        {
            this.MaNhanVien = row["manhanvien"].ToString();
            this.HoTen = row["hoten"].ToString();
            this.NgaySinh = row["ngaysinh"].ToString();
            this.GioiTinh = row["gioitinh"].ToString();
            this.SoDienThoai = row["sodienthoai"].ToString();
            this.PassWord = row["password"].ToString();
        }
        private string maNhanVien;
        private string hoTen;
        private string ngaySinh;
        private string gioiTinh;
        private string soDienThoai;
        private string passWord;

        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string PassWord { get => passWord; set => passWord = value; }
    }
}
