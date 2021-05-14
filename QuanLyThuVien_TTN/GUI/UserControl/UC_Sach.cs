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
    public partial class UC_Sach : UserControl
    {
        BindingSource dsList = new BindingSource();
        public UC_Sach()
        {
            InitializeComponent();
            LoadDS();
            LoadS();
        }
        void LoadDS()
        {
            dtgvDS.DataSource = dsList;
            LoadListDS();
            AddDSBinding();
            disEnableDS(true);
        }
        void disEnableDS(bool e)
        {
            txbTenDS.ReadOnly = e;
            nmGiaTien.Enabled = !e;
            txbTenNXB.ReadOnly = e;
            txbTenTG.ReadOnly = e;
            txbTheLoai.ReadOnly = e;
            btnThemDS.Enabled = e;
            btnSuaDS.Enabled = e;
            btnXoaDS.Enabled = e;
            btnLuuDS.Enabled = !e;
            btnHuyDS.Enabled = !e;
        }
        void LoadListDS()
        {
            dsList.DataSource = DauSachDAO.Instance.GetListDauSach();
        }
        void AddDSBinding()
        {
            txbMaDS.DataBindings.Add(new Binding("Text", dsList, "MaDauSach", true, DataSourceUpdateMode.Never));
            txbTenDS.DataBindings.Add(new Binding("Text", dsList, "TenDauSach", true, DataSourceUpdateMode.Never));
            nmGiaTien.DataBindings.Add(new Binding("Text", dsList, "GiaTien", true, DataSourceUpdateMode.Never));
            txbTenNXB.DataBindings.Add(new Binding("Text", dsList, "TenNXB", true, DataSourceUpdateMode.Never));
            txbTenTG.DataBindings.Add(new Binding("Text", dsList, "TenTacGia", true, DataSourceUpdateMode.Never));
            txbTheLoai.DataBindings.Add(new Binding("Text", dsList, "TheLoai", true, DataSourceUpdateMode.Never));
        }
        List<DauSach> SearchDS(string tendausach, string madausach, string tennxb, string tentacgia, string theloai)
        {
            List<DauSach> listDS = DauSachDAO.Instance.SearchDS(tendausach, madausach, tennxb, tentacgia, theloai);
            return listDS;
        }
        bool themSuaDS(string madausach, string tendausach, int giatien, string tennxb, string tentacgia, string theloai)
        {
            string query = string.Format("exec ThemSuaDS @MADAUSACH = N'{0}',@TENDAUSACH = N'{1}',@GIATIEN={2},@TENNXB=N'{3}',@TENTACGIA=N'{4}',@THELOAI=N'{5}'", madausach, tendausach, giatien, tennxb, tentacgia, theloai);
            int result = DataProvider.Instance.executeNonQuery(query);
            return result > 0;
        }
        //////////////////////////////Sách
        BindingSource sList = new BindingSource();
        void LoadS()
        {
            dtgvS.DataSource = sList;
            LoadListS();
            AddSBinding();
            disEnableS(true);
            dtNamXuatBan.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            LoadMaDauSachIntoComboBox(cbDauS);
        }
        void LoadMaDauSachIntoComboBox(ComboBox cb)
        {
            cb.DataSource = DauSachDAO.Instance.GetListDauSach();
            cb.DisplayMember = "TenDauSach";
        }
        void disEnableS(bool e)
        {
            dtNamXuatBan.Enabled = !e;
            cbDauS.Enabled = !e;
            btnThemS.Enabled = e;
            btnSuaS.Enabled = e;
            btnXoaS.Enabled = e;
            btnLuuS.Enabled = !e;
            btnHuyS.Enabled = !e;
        }
        void LoadListS()
        {
            sList.DataSource = SachDAO.Instance.GetListSach();
        }
        void AddSBinding()
        {
            txbMaS.DataBindings.Add(new Binding("Text", sList, "MaSach", true, DataSourceUpdateMode.Never));
            dtNamXuatBan.DataBindings.Add(new Binding("Text", sList, "NamXuatBan", true, DataSourceUpdateMode.Never));
            cbDauS.DataBindings.Add(new Binding("Text", sList, "TenDauSach", true, DataSourceUpdateMode.Never));
        }
        bool themSuaS(string masach, string namxuatban, string madausach)
        {
            string query = string.Format("exec ThemSuaS @MASACH = N'{0}',@NAMXUATBAN = N'{1}',@MADAUSACH={2}", masach, namxuatban, madausach);
            int result = DataProvider.Instance.executeNonQuery(query);
            return result > 0;
        }
        List<Sach> SearchS(string masach, string madausach)
        {
            List<Sach> listS = SachDAO.Instance.SearchS(masach, madausach);
            return listS;
        }

        private void btnReLoadDS_Click(object sender, EventArgs e)
        {
            LoadListDS();
        }

        private void txbTimKiemDS_MouseClick(object sender, MouseEventArgs e)
        {
            txbTimKiemDS.Clear();
            txbTimKiemDS.ForeColor = Color.Black;
        }

        private void btnTimKiemDS_Click(object sender, EventArgs e)
        {
            dsList.DataSource = SearchDS(txbTimKiemDS.Text, txbTimKiemDS.Text, txbTimKiemDS.Text, txbTimKiemDS.Text, txbTimKiemDS.Text);
        }

        private void btnThemDS_Click(object sender, EventArgs e)
        {
            disEnableDS(false);
            txbMaDS.Text = DataProvider.Instance.executeScalar("select [dbo].TAOMADS()").ToString();
            txbTenDS.Text = "";
            txbTenNXB.Text = "";
            txbTenTG.Text = "";
            txbTheLoai.Text = "";
        }

        private void btnSuaDS_Click(object sender, EventArgs e)
        {
            disEnableDS(false);
        }

        private void btnXoaDS_Click(object sender, EventArgs e)
        {
            string madausach = txbMaDS.Text;
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
                DauSachDAO.Instance.DeleteDS(madausach);
            }
        }

        private void btnLuuDS_Click(object sender, EventArgs e)
        {
            try
            {
                string madausach = txbMaDS.Text;
                string tendausach = txbTenDS.Text;
                int giatien = (int)nmGiaTien.Value;
                string tennxb = txbTenNXB.Text;
                string tentacgia = txbTenTG.Text;
                string theloai = txbTheLoai.Text;
                themSuaDS(madausach, tendausach, giatien, tennxb, tentacgia, theloai);
                MessageBox.Show("Lưu thành công");
                disEnableDS(true);
            }
            catch
            {
                MessageBox.Show("Lưu thất bại. Xin mời nhập lại!");
            }
        }

        private void btnHuyDS_Click(object sender, EventArgs e)
        {
            disEnableDS(true);
        }

        private void btnReLoadS_Click(object sender, EventArgs e)
        {
            LoadListS();
        }

        private void txbTimKiemS_MouseClick(object sender, MouseEventArgs e)
        {
            txbTimKiemS.Clear();
            txbTimKiemS.ForeColor = Color.Black;
        }

        private void btnThemS_Click(object sender, EventArgs e)
        {
            disEnableS(false);
            txbMaS.Text = DataProvider.Instance.executeScalar("select [dbo].TAOMAS()").ToString();
        }

        private void btnSuaS_Click(object sender, EventArgs e)
        {
            disEnableS(false);
        }

        private void btnXoaS_Click(object sender, EventArgs e)
        {
            string masach = txbMaS.Text;
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
                SachDAO.Instance.DeleteS(masach);
            }
        }

        private void btnLuuS_Click(object sender, EventArgs e)
        {
            try
            {
                string masach = txbMaS.Text;
                string namxuatban = dtNamXuatBan.Value.ToString("yyyy/MM/dd HH:mm:ss");
                string madausach = (cbDauS.SelectedItem as DauSach).MaDauSach;
                themSuaS(masach, namxuatban, madausach);
                MessageBox.Show("Lưu thành công");
                disEnableS(true);
            }
            catch
            {
                MessageBox.Show("Lưu thất bại. Xin mời nhập lại!");
            }
        }

        private void btnHuyS_Click(object sender, EventArgs e)
        {
            disEnableS(true);
        }

        private void btnTimKiemS_Click(object sender, EventArgs e)
        {
            sList.DataSource = SearchS(txbTimKiemS.Text, txbTimKiemS.Text);
        }

        private void txbMaS_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtgvS.SelectedCells.Count > 0)
                {

                    string madausach = Convert.ToString(dtgvS.SelectedCells[0].OwningRow.Cells["MaDauSach"].Value);
                    DauSach dausach = DauSachDAO.Instance.GetDauSachByMaDauSach(madausach);
                    cbDauS.SelectedItem = dausach;
                    int index = -1;
                    int i = 0;
                    foreach (DauSach item in cbDauS.Items)
                    {
                        if (item.MaDauSach == dausach.MaDauSach)
                        {
                            index = i;
                            break;
                        }
                        i++;
                    }
                    cbDauS.SelectedIndex = index;
                }
            }
            catch
            {

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
