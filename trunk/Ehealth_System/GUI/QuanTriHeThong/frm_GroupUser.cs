using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL.QuanTriHeThong;
using DO.QuanTriHeThong;

namespace GUI.QuanTriHeThong
{
    public partial class frm_GroupUser : Form
    {
        public frm_GroupUser()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Phân quyền
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_PhanQuyen_Click(object sender, EventArgs e)
        {
            PhanQuyen phanquyen = new PhanQuyen();
            phanquyen.ShowDialog();
        }

        private void frm_GroupUser_Load(object sender, EventArgs e)
        {
            LoadGroupUser();
            
            
        }

        private void LoadGroupUser()
        {
            grd_NhomnguoiDung.DataSource = BL.QuanTriHeThong.UserGroup_BL.GetAllUsserGroup();
        }

        private void btn_ThemMoi_Click(object sender, EventArgs e)
        {
            //Them moi nhom nguoi dung
            BL.QuanTriHeThong.UserGroup_BL.CreateUserGroup(txt_TenVietTat.Text, txt_TenNhom.Text, txt_MoTa.Text, chk_TrangThai.Checked );
            MessageBox.Show("Create Successful");
            //Load lai danh sach nhom nguoi dung
            LoadGroupUser();
        }

        private void grd_NhomnguoiDung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string ID = grd_NhomnguoiDung.CurrentRow.Cells[0].Value.ToString();
            List<UserGroup_DO> dsuser = BL.QuanTriHeThong.UserGroup_BL.GetUserGroup(ID);
            txt_TenVietTat.Text = dsuser[0].tenviettat_;
            txt_TenNhom.Text = dsuser[0].tennhom_;
            txt_MoTa.Text = dsuser[0].mota_;
            chk_TrangThai.Checked = dsuser[0].trangthai;
        }

        private void btn_ChinhSua_Click(object sender, EventArgs e)
        {
            BL.QuanTriHeThong.UserGroup_BL.EditUserGroup(txt_TenVietTat.Text, txt_TenNhom.Text, txt_MoTa.Text, chk_TrangThai.Checked);
            MessageBox.Show("Update Thanh Cong");
            LoadGroupUser();
        }
        


       
       
    }
}
