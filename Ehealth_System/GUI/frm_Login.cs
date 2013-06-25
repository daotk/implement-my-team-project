using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_Login : Form
    {
        public  string username = "admin";
        public frm_Login()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            string strUsername="";
            string strPassword="";
            if (txt_UserName.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên tài khoản");
            }
            else
            {
                strUsername = txt_UserName.Text;
            }
            if (txt_Password.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu");
            }
            else
            {
                strPassword = txt_Password.Text;
            }

            bool check = BL.QuanTriHeThong.User_BL.CheckLogin(strUsername,strPassword);
            if (check == true)
            {
                MessageBox.Show("Đăng nhập thành công. Bạn sẽ quay về trang chính", "Thông báo", MessageBoxButtons.OK);
                this.Close();
                Program.thread.Start();
            }
            else
            {
                MessageBox.Show("Bạn đã nhập sai username hoặc password", "Thông báo", MessageBoxButtons.OK);
            }
        }

    }
}
