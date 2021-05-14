using QuanLyThuVien_TTN.DAO;
using QuanLyThuVien_TTN.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuanLyThuVien_TTN
{
    public partial class UC_MuonSach : UserControl
    {
        public UC_MuonSach()
        {
            InitializeComponent();
            clearTraSach();
        }

        private void txtMaThe_Leave(object sender, EventArgs e)
        {
            if (txtMaThe.Text != "")
            {
                if (DocGiaDAO.Instance.ktDGtt(txtMaThe.Text))
                {
                    DocGia dg = DocGiaDAO.Instance.getDGbyMaThe(txtMaThe.Text);
                    txtNguoiMuon.Text = dg.Tendocgia;
                    txtGT.Text = dg.Gioitinh;
                    txtDiaChi.Text = dg.Diachi;
                    txtSDT.Text = dg.Sdt;
                }

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (SachDAO.Instance.ttSach(txtMaSach.Text) && SachDAO.Instance.kiemtraTrasach(txtMaSach.Text))
            {
                if (SachDAO.Instance.ktDGtraSach(txtMaThe.Text))
                {
                    DauSach ds = DauSachDAO.Instance.getDauSachbyMaSach(txtMaSach.Text);
                    Sach s = SachDAO.Instance.getSachbyMaSach(txtMaSach.Text);
                    txtTenSach.Text = ds.TenDauSach;
                    ListViewItem listItem = new ListViewItem(txtMaSach.Text);
                    listItem.SubItems.Add(ds.TenDauSach);
                    listItem.SubItems.Add(ds.TheLoai);
                    listItem.SubItems.Add(ds.TenTacGia);

                    lsvSachMuon.Items.Add(listItem);
                }
                else
                {
                    MessageBox.Show("Độc giả chưa trả hết sách");
                }

            }
            else
            {
                MessageBox.Show("Mã sách không tồn tại hoặc sách chưa được trả. Vui lòng nhập lại!");
            }

        }
        void clearAll()
        {
            txtMaThe.Text = "";
            txtNguoiMuon.Text = "";
            txtGT.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
            txtMaSach.Text = "";
            txtTenSach.Text = "";
            lsvSachMuon.Items.Clear();
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (lsvSachMuon.Items.Count > 0)
            {
                if (DocGiaDAO.Instance.ktDGtt(txtMaThe.Text))
                {
                    if (TheThuVienDAO.Instance.ktNgayHetHan(TheThuVienDAO.Instance.getNgayHetHan(txtMaThe.Text).ToString("yyyy-MM-dd")) < 0)
                    {
                        PhieuMuonTraDAO.Instance.taoPhieuMuon("nv1", txtMaThe.Text); // chú ý
                        for (int i = 0; i < lsvSachMuon.Items.Count; i++)
                        {
                            PhieuMuonTraDAO.Instance.taoCTPhieuMuon(PhieuMuonTraDAO.Instance.getPhieuMuonMax(), lsvSachMuon.Items[i].Text);
                        }
                        MessageBox.Show("Thành công!");
                        clearAll();
                    }
                    else
                    {
                        MessageBox.Show("Thẻ thư viện đã hết hạn. Vui lòng gia hạn!");
                    }

                }
                else
                {
                    MessageBox.Show("Độc giả chưa có thẻ hoặc mã thẻ sai. Vui lòng nhập lại!");
                }
            }
            else
            {
                MessageBox.Show("Danh sách mượn trống");
            }
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            lsvTraSach.Items.Clear();
            if (DocGiaDAO.Instance.ktDGtt(txtMaTheTra.Text))
            {
                if (!SachDAO.Instance.ktDGtraSach(txtMaTheTra.Text))
                {
                    List<string> lst = SachDAO.Instance.getSacHDGmuon(txtMaTheTra.Text);
                    foreach (string item in lst)
                    {
                        DauSach ds = DauSachDAO.Instance.getDauSachbyMaSach(item);
                        Sach s = SachDAO.Instance.getSachbyMaSach(item);
                        ListViewItem listItem = new ListViewItem(item);
                        listItem.SubItems.Add(ds.TenDauSach);
                        listItem.SubItems.Add(ds.TheLoai);
                        listItem.SubItems.Add(ds.TenTacGia);

                        lsvTraSach.Items.Add(listItem);
                    }
                    DateTime today = PhieuMuonTraDAO.Instance.Today();
                    DateTime hantra = SachDAO.Instance.getHanTraSach(txtMaTheTra.Text);
                    lblToday.Text = today.ToString("dd-MM-yyyy");
                    lblHan.Text = hantra.ToString("dd-MM-yyyy");
                    lblQuaHan.Text = TheThuVienDAO.Instance.getQuaHan(hantra, today) + " ngày";
                    lblPhi.Text = (lsvTraSach.Items.Count * 1000 * TheThuVienDAO.Instance.getQuaHan(hantra, today)).ToString() + " đ";
                }
                else
                {
                    MessageBox.Show("Độc giả đã trả hết sách");
                }

            }
            else
            {
                MessageBox.Show("Độc giả chưa có thẻ hoặc mã thẻ sai. Vui lòng nhập lại!");
            }
        }

        void clearTraSach()
        {
            lsvTraSach.Items.Clear();
            txtMaTheTra.Text = "";
            txtNguoiTra.Text = "";
            txtSDTtra.Text = "";
            txtDCtra.Text = "";
            lblToday.Text = "";
            lblHan.Text = "";
            lblQuaHan.Text = "";
            lblPhi.Text ="";
        }

        private void btnTraSach_Click(object sender, EventArgs e)
        {
            if (lsvTraSach.Items.Count > 0)
            {
                string mapmt = SachDAO.Instance.getMaMuonTra(txtMaTheTra.Text);
                PhieuMuonTraDAO.Instance.updateCTMTtrasach(mapmt);
                MessageBox.Show("Trả sách thành công");
                clearTraSach();
            }
            else
            {
                MessageBox.Show("Vui lòng nhấn tìm kiếm để tìm sách đọc giả đã mượn");
            }
        }
    }
}
