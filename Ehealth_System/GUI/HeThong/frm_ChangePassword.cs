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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }
        /// <summary>
        /// nut huy bo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_HuyBoDoiMatKhau_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// nut luu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_LuuMatKhau_Click(object sender, EventArgs e)
        {
            string matkhaucu = txt_matkhaucu.Text;
            string matkhaumoi = txt_matkhaumoi.Text;
            string nhaplaimatkhaumoi = txt_nhaplaimatkhaumoi.Text;
            if (matkhaucu == "123")
            {
                if (matkhaumoi == nhaplaimatkhaumoi)
                {
                    MessageBox.Show("Bạn đã thay đổi mật khẩu thành công");
                    Close();
                }
                else
                {
                    MessageBox.Show("Ô nhập lại mật khẩu không trùng với mật khẩu mới ");
                }
            }
            else
            {
                MessageBox.Show("Bạn đã nhập sai mật khẩu cũ!");
            }
        }
    }
}
