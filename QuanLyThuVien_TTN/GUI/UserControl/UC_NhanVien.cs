using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThuVien_TTN.DAO;
using QuanLyThuVien_TTN.DTO;

namespace QuanLyThuVien_TTN
{
    public partial class UC_NhanVien : UserControl
    {
        BindingSource nvList = new BindingSource();
        public UC_NhanVien()
        {
            InitializeComponent();
            Load();
        }
        void Load()
        {
            dtgvNV.DataSource = nvList;
            LoadListNV();
            AddNVBinding();
            disEnable(true);
        }
        void disEnable(bool e)
        {
            txbTenNV.ReadOnly = e;
            txbSDTNV.ReadOnly = e;
            cbGioiTinhNV.Enabled = !e;
            dtNgaySinhNV.Enabled = !e;
            txbPassWordNV.ReadOnly = e;
            btnThemNV.Enabled = e;
            btnSuaNV.Enabled = e;
            btnXoaNV.Enabled = e;
            btnLuuNV.Enabled = !e;
            btnHuyNV.Enabled = !e;
        }
        void LoadListNV()
        {
            nvList.DataSource = NhanVienDAO.Instance.GetListNhanVien();
        }
        void AddNVBinding()
        {
            txbMaNV.DataBindings.Add(new Binding("Text", nvList, "MaNhanVien", true, DataSourceUpdateMode.Never));
            txbTenNV.DataBindings.Add(new Binding("Text", nvList, "HoTen", true, DataSourceUpdateMode.Never));
            txbPassWordNV.DataBindings.Add(new Binding("Text", nvList, "PassWord", true, DataSourceUpdateMode.Never));
            dtNgaySinhNV.DataBindings.Add(new Binding("Text", nvList, "NgaySinh", true, DataSourceUpdateMode.Never));
            txbSDTNV.DataBindings.Add(new Binding("Text", nvList, "SoDienThoai", true, DataSourceUpdateMode.Never));
            cbGioiTinhNV.DataBindings.Add(new Binding("Text", nvList, "GioiTinh", true, DataSourceUpdateMode.Never));
        }

        private void btnReLoadNV_Click(object sender, EventArgs e)
        {
            LoadListNV();
        }
        List<NhanVien> SearchNV(string hoten, string manhanvien)
        {
            List<NhanVien> listLopCN = NhanVienDAO.Instance.SearchNV(hoten, manhanvien);
            return listLopCN;
        }

        private void btnTimKiemNV_Click(object sender, EventArgs e)
        {
            nvList.DataSource = SearchNV(txbTimKiemNV.Text, txbTimKiemNV.Text);
        }

        private void txbTimKiemNV_MouseClick(object sender, MouseEventArgs e)
        {
            txbTimKiemNV.Clear();
            txbTimKiemNV.ForeColor = Color.Black;
        }
        void xoa(string manhanvien)
        {
            DataProvider.Instance.executeNonQuery("delete from NHANVIEN where MANV={0} ", new object[] { manhanvien });
        }

        private void dtgvNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            disEnable(true);
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            disEnable(false);
            txbMaNV.Text = DataProvider.Instance.executeScalar("select [dbo].TAOMANV()").ToString();
            txbTenNV.Text = "";
            txbSDTNV.Text = "";
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            disEnable(false);
        }

        private void btnLuuNV_Click(object sender, EventArgs e)
        {
            try
            {
                string manhanvien = txbMaNV.Text;
                string hoten = txbTenNV.Text;
                string ngaysinh = dtNgaySinhNV.Value.ToString("yyyy/MM/dd");
                string gioitinh = cbGioiTinhNV.SelectedItem.ToString();
                string sodienthoai = txbSDTNV.Text;
                string password = txbPassWordNV.Text;
                NhanVienDAO.Instance.themSua(manhanvien, hoten, ngaysinh, gioitinh, sodienthoai, password);
                MessageBox.Show("Lưu thành công");
                disEnable(true);
            }
            catch
            {
                MessageBox.Show("Lưu thất bại. Xin mời nhập lại!");
            }
        }

        private void btnHuyNV_Click(object sender, EventArgs e)
        {
            disEnable(true);
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            string manhanvien = txbMaNV.Text;
            string message = "Bạn có chắc chắn muốn xóa?";
            string caption = "Xác nhận xóa";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.No)
            {

            }
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                NhanVienDAO.Instance.DeleteNV(manhanvien);
            }
        }
    }
}
