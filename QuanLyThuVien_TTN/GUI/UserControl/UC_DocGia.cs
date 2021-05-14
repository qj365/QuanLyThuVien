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
    public partial class UC_DocGia : UserControl
    {
        BindingSource docgiaList = new BindingSource();
        public UC_DocGia()
        {
            InitializeComponent();
            Load();
        }
        void Load()
        {
            dtgvDocgia.DataSource = docgiaList;
            LoadListDocGia();
            AddDocGiaBinding();
            disEnableDG(true);

        }
        void LoadListDocGia()
        {
            docgiaList.DataSource = DocGiaDAO.Instance.GetListDocGia();
        }
        void disEnableDG(bool e)
        {
            txbMadocgia.ReadOnly = e;
            txbTendocgia.ReadOnly = !e;
            txbGioitinh.ReadOnly = e;
            txbSdt.ReadOnly = e;
            txbDiachi.ReadOnly = e;
            btnThem.Enabled = e;
            btnSua.Enabled = e;
            btnXoa.Enabled = e;
            btnLuu.Enabled = !e;
            btnHuy.Enabled = !e;
        }
        void AddDocGiaBinding()
        {
            txbMadocgia.DataBindings.Add(new Binding("Text", docgiaList, "Madocgia", true, DataSourceUpdateMode.Never));
            txbTendocgia.DataBindings.Add(new Binding("Text", docgiaList, "Tendocgia", true, DataSourceUpdateMode.Never));
            txbGioitinh.DataBindings.Add(new Binding("Text",docgiaList, "Gioitinh", true, DataSourceUpdateMode.Never));
            txbSdt.DataBindings.Add(new Binding("Text",docgiaList, "Sodienthoai", true, DataSourceUpdateMode.Never));
            txbDiachi.DataBindings.Add(new Binding("Text",docgiaList, "Diachi", true, DataSourceUpdateMode.Never));
        }

        bool themSuaDG(string madocgia, string tendocgia,  string gioitinh, string sodienthoai, string diachi)
        {
            string query = string.Format("exec ThemSuaDG @MADOCGIA = N'{0}',@TENDOCGIA = N'{1}',@GIOITINH={2},@SODIENTHOAI=N'{3}',@DIACHI=N'{4}'", madocgia, tendocgia, gioitinh, sodienthoai, diachi);
            int result = DataProvider.Instance.executeNonQuery(query);
            return result > 0;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string madocgia = txbMadocgia.Text;
                string tendocgia = txbMadocgia.Text;
             
                string gioitinh = txbGioitinh.Text;
                string sodienthoai = txbSdt.Text;
                string diachi = txbDiachi.Text;
                themSuaDG(madocgia, tendocgia, gioitinh, sodienthoai, diachi);
                MessageBox.Show("Lưu thành công");
                disEnableDG(true);
            }
            catch
            {
                MessageBox.Show("Lưu thất bại. Xin mời nhập lại!");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            disEnableDG(false);
            txbMadocgia.Text = DataProvider.Instance.executeScalar("select [dbo].TAOMADG()").ToString();
            txbTendocgia.Text = "";
            txbGioitinh.Text = "";
            txbSdt.Text = "";
            txbDiachi.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            disEnableDG(false);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string madocgia= txbMadocgia.Text;
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
                DocGiaDAO.Instance.DeleteDocGia(madocgia);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            disEnableDG(true);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadListDocGia();
        }
        List<DocGia> SearchDG(string madocgia, string tendocgia)
        {
            List<DocGia> listDS = DocGiaDAO.Instance.SearchDG(madocgia, tendocgia);
            return listDS;
        }
        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            docgiaList.DataSource = SearchDG(txbTimKiemDG.Text, txbTimKiemDG.Text);
        }
    }
}
