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
            if (txt_UserName.Text == "admin" && txt_Password.Text == "123")
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
