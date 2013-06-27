using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL.QuanTriHeThong;
using DA.QuanTriHeThong;
using DO.QuanTriHeThong;

namespace GUI
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Hủy bỏ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_HuyBoDoiMatKhau_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Lưu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_LuuMatKhau_Click(object sender, EventArgs e)
        {
            string UserID = BL.StaticClass.UserID;
            List<DO.QuanTriHeThong.User_DO> user = BL.QuanTriHeThong.User_BL.GetUSerInfoFollowUserID(UserID);
            if (txt_matkhaucu.Text != "" && txt_matkhaumoi.Text != "" && txt_nhaplaimatkhaumoi.Text != "")
            {
                if (user[0]._PASSWORD == BL.MD5_BL.GetMD5(txt_matkhaucu.Text))
                {
                    if (txt_matkhaumoi.Text == txt_nhaplaimatkhaumoi.Text)
                    {
                        //Luu mat khau
                        BL.QuanTriHeThong.User_BL.ChangePassword(UserID, BL.MD5_BL.GetMD5(txt_matkhaumoi.Text));
                        MessageBox.Show("Thay đổi mật khẩu thành công");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Bạn nhập mật khẩu mới lần 2 không trùng khớp");
                    }
                }
                else
                {
                    MessageBox.Show("Bạn nhập mật khẩu củ  không trùng khớp");
                }
            }
            else
            {
                MessageBox.Show("Bạn Chưa nhập đầy đử thông tin");
            }
        }
      
    }
}
