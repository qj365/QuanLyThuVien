using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien_TTN
{
    public partial class UC_TheThuVien : UserControl
    {
        public UC_TheThuVien()
        {
            InitializeComponent();
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            frPhieuMuonTra muonTra = new frPhieuMuonTra();
            muonTra.Show();
            this.Hide();
        }
    }
}
