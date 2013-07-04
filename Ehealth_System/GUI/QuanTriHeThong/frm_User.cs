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
            cbo_NhomNguoiDung.DataSource = BL.QuanTriHeThong.User_BL.GetAllUser1();
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
            txt_MatKhau.Text = user[0]._PASSWORD;
            chk_TrangThai.Checked = user[0]._STATUS;
            cbo_NhomNguoiDung.SelectedValue = user[0]._USERTYPEID;
        }
        private string StatusSave = "";
        /// <summary>
        /// them moi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ThemMoi_Click(object sender, EventArgs e)
        {

            if (btn_ThemMoi.Text == "Thêm mới")
            {
                StatusSave = "Create";
                ///enable = true
                txt_MaNhanVien.Enabled = true;
                txt_HoTen.Enabled = true;
                txt_Email.Enabled = true;
                txt_TaiKhoan.Enabled = true;
                txt_MatKhau.Enabled = true;
                cbo_NhomNguoiDung.Enabled = true;
                chk_TrangThai.Enabled = true;
                //set text = null
                txt_MaNhanVien.Text = "";
                txt_HoTen.Text = "";
                txt_Email.Text = "";
                txt_TaiKhoan.Text = "";
                //button
                btn_ThemMoi.Text = "Lưu";
                btn_ThemMoi.Image = global::GUI.Properties.Resources.Save_icon;
                btn_ChinhSua.Text = "Hủy bỏ";
                btn_ChinhSua.Image = global::GUI.Properties.Resources.cancel1;
            }
            else
            {
                if (StatusSave == "Create")
                {
                    if (btn_ThemMoi.Text == "Lưu")
                    {
                        if (txt_MaNhanVien.Text != "" && txt_HoTen.Text != "" && cbo_NhomNguoiDung.SelectedValue.ToString() != "" && txt_TaiKhoan.Text != "" && txt_MatKhau.Text != "")
                        {
                            string manhanvien = txt_MaNhanVien.Text;
                            string hoten = txt_HoTen.Text;
                            string email = txt_Email.Text;
                            string taikhoan = txt_TaiKhoan.Text;
                            string matkhau = BL.MD5_BL.GetMD5(txt_MatKhau.Text);
                            string nhomnguoidung = cbo_NhomNguoiDung.SelectedValue.ToString();
                            bool trangthai = chk_TrangThai.Checked;
                            BL.QuanTriHeThong.User_BL.InsertUser(manhanvien, hoten, email, nhomnguoidung, taikhoan, matkhau, trangthai);
                            MessageBox.Show("Người dùng đã được tạo thành công", "Thông báo");
                            LoadUserInfo();
                            StatusCancel();
                        }
                        else
                        {
                            MessageBox.Show("Bạn phải nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                }
                else
                {
                    if (StatusSave == "Edit")
                    {
                        if (btn_ThemMoi.Text == "Lưu")
                        {
                            //xử lý cập nhật
                            string manhanvien = txt_MaNhanVien.Text;
                            string hoten = txt_HoTen.Text;
                            string email = txt_Email.Text;
                            string taikhoan = txt_TaiKhoan.Text;
                            string matkhau = BL.MD5_BL.GetMD5(txt_MatKhau.Text);
                            string nhomnguoidung = cbo_NhomNguoiDung.SelectedValue.ToString();
                            bool trangthai = chk_TrangThai.Checked;
                            if (txt_MaNhanVien.Text != "" && txt_HoTen.Text != "" && cbo_NhomNguoiDung.SelectedValue.ToString() != "" && txt_TaiKhoan.Text != "" && txt_MatKhau.Text != "")
                            {
                                BL.QuanTriHeThong.User_BL.UpdateUser(manhanvien, hoten, email, nhomnguoidung, taikhoan, matkhau, trangthai);
                                MessageBox.Show("Người dùng đã được chỉnh sửa thành công", "Thông báo");
                                LoadUserInfo();
                                StatusCancel();
                            }
                            else
                            {
                                MessageBox.Show("Bạn phải nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
            }

        }//end button Them moi

        /// <summary>
        /// chinh sua
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ChinhSua_Click(object sender, EventArgs e)
        {
            if (btn_ChinhSua.Text == "Chỉnh sửa")
            {
                ///xu ly chinh sua
                StatusSave = "Edit";
                btn_ThemMoi.Text = "Lưu";
                btn_ThemMoi.Image = global::GUI.Properties.Resources.Save_icon;
                btn_ChinhSua.Text = "Hủy bỏ";
                btn_ChinhSua.Image = global::GUI.Properties.Resources.cancel1;
                txt_HoTen.Enabled = true;
                txt_Email.Enabled = true;
                txt_TaiKhoan.Enabled = true;
                txt_MatKhau.Enabled = true;
                txt_MatKhau.Text = "";
                cbo_NhomNguoiDung.Enabled = true;
                chk_TrangThai.Enabled = true;

            }
            else
            {
                //xu ly cancel
                ///enable = false
                StatusCancel();
            }

        }//end button chinh sua

        private void StatusCancel()
        {
            txt_MaNhanVien.Enabled = false;
            txt_HoTen.Enabled = false;
            txt_Email.Enabled = false;
            txt_TaiKhoan.Enabled = false;
            txt_MatKhau.Enabled = false;
            cbo_NhomNguoiDung.Enabled = false;
            chk_TrangThai.Enabled = false;
            //button
            btn_ThemMoi.Text = "Thêm mới";
            btn_ChinhSua.Text = "Chỉnh sửa";
        }





    }
}

