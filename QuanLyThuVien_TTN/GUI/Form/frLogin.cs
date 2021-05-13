using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien_TTN
{
    public partial class frLogin : Form
    {
        private bool enterU = false;
        private bool enterP = false;
        public frLogin()
        {
            InitializeComponent();
        }
      
        private void textBoxUser_Enter(object sender, EventArgs e)
        {
            if (!enterU)
            {
                textBoxUser.Text = "";
                textBoxUser.ForeColor = Color.Black;
                enterU = true;
            }
        }
        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            if (!enterP)
            {
                textBoxPassword.Text = "";
                textBoxPassword.ForeColor = Color.Black;
                textBoxPassword.UseSystemPasswordChar = true;
                enterP = true;
            }
        }

        private void textBoxUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buttonLogin_Click(sender, e);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                textBoxPassword.UseSystemPasswordChar = false;
            else
                textBoxPassword.UseSystemPasswordChar = true;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string userName = textBoxUser.Text;
            string passWord = textBoxPassword.Text;
            //if (Login(userName, passWord))
            //{
                FormMenu f = new FormMenu();
                this.Hide();
                f.ShowDialog();
                this.Show();
            //}
            //else
            //{
            //    MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai!");
            //}
        }
        //bool Login(string user, string pass)
        //{
        //    //return AccountDAO.Instance.Login(user, pass);
        //}
    }
}
