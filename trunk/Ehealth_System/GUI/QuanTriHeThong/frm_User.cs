using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL.QuanTriHeThong;

namespace GUI.QuanTriHeThong
{
    public partial class frm_User : Form
    {
        public frm_User()
        {
            InitializeComponent();
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            PhanQuyen phanquyen = new PhanQuyen();
            phanquyen.ShowDialog();
        }
        /// <summary>
        /// Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frm_User_Load(object sender, EventArgs e)
        {
            LoadUserInfo();
            LoadGroupUser();
        }
        /// <summary>
        /// Load user info
        /// </summary>
        private void LoadUserInfo()
        {
            grd_User.DataSource = BL.QuanTriHeThong.User_BL.GetAllUserInfo();
        }

        /// <summary>
        /// Load nhom nguoi dung
        /// </summary>
        private void LoadGroupUser()
        {
            cbo_NhomNguoiDung.DataSource = BL.QuanTriHeThong.UserGroup_BL.GetAllUsserGroup();
            cbo_NhomNguoiDung.DisplayMember = "tennhom_";
            cbo_NhomNguoiDung.ValueMember = "tenviettat_";
            cbo_NhomNguoiDung.Text = "";
        }

        /// <summary>
        /// STT
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grd_User_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < grd_User.RowCount; i++)
            {
                grd_User.Rows[i].Cells["STT"].Value = Convert.ToString(i + 1);
            }
        }

        /// <summary>
        /// Cell Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grd_User_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string userid = grd_User.CurrentRow.Cells["MaNhanVien"].Value.ToString();
            List<DO.QuanTriHeThong.User_DO> user = BL.QuanTriHeThong.User_BL.GetUSerInfoFollowUserID(userid);
            txt_MaNhanVien.Text = user[0]._USERID;
            txt_HoTen.Text = user[0]._USERNAME;
            txt_Email.Text = user[0]._EMAIL;
            txt_TaiKhoan.Text = user[0]._ACCOUNT;
            chk_TrangThai.Checked = user[0]._STATUS;
            cbo_NhomNguoiDung.SelectedValue = user[0]._USERTYPEID;
        }

        private void btn_ThemMoi_Click(object sender, EventArgs e)
        {

            if (btn_ThemMoi.Text == "Thêm mới")
            {

            }
        }

       


       
    }
}
