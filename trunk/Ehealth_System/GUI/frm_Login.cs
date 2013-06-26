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
        public frm_Login()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frm_Login_Load(object sender, EventArgs e)
        {
            BL.QuanTriHeThong.User_BL.GetAllUSer();
        }


        private void btn_Submit_Click(object sender, EventArgs e)
        {
            string strUsername="";
            string strPassword="";
            if (txt_UserName.Text != ""|| txt_Password.Text != "")
            {
                strUsername = txt_UserName.Text;
                strPassword = txt_Password.Text;
                bool check = BL.QuanTriHeThong.User_BL.CheckLogin(strUsername,strPassword);
                if (check == true)
                {
                    this.Close();
                    Program.thread.Start();
                }
                else
                {
                    MessageBox.Show("Bạn đã nhập sai tên tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK);
                }
            }else
            {
                MessageBox.Show("Bạn chưa nhập tên tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

       

    }
}
