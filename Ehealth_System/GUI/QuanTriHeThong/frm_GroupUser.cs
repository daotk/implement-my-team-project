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
        private string StatusSave = "";

        private void LoadGroupUser()
        {
            grd_NhomnguoiDung.DataSource = BL.QuanTriHeThong.UserGroup_BL.GetAllUsserGroup();
        }

        private void btn_ThemMoi_Click(object sender, EventArgs e)
        {
            if (btn_ThemMoi.Text == "Thêm mới")
            {
                StatusSave = "create";
                btn_ThemMoi.Text = "Lưu";
                btn_ThemMoi.Image = global::GUI.Properties.Resources.Save_icon;
                btn_ChinhSua.Text = "Hủy bỏ";
                btn_ChinhSua.Image = global::GUI.Properties.Resources.cancel1;
                btn_ChinhSua.Enabled = true;
                txt_TenVietTat.Enabled = true;
                txt_TenNhom.Enabled = true;
                txt_MoTa.Enabled = true;
                chk_TrangThai.Enabled = true;

                txt_TenVietTat.Text = "";
                txt_TenNhom.Text = "";
                txt_MoTa.Text = "";
                chk_TrangThai.Checked = false;
            }
            else {
                if (btn_ThemMoi.Text == "Lưu")
                {
                    //Them moi nhom nguoi dung
                    if (CheckInfoUserGroup(txt_TenVietTat.Text, txt_TenNhom.Text))
                    {
                        if (StatusSave == "create")
                        {
                            if (CheckInfo(txt_TenVietTat.Text, txt_TenNhom.Text))
                            {
                                BL.QuanTriHeThong.UserGroup_BL.CreateUserGroup(txt_TenVietTat.Text, txt_TenNhom.Text, txt_MoTa.Text, "00000000000000", chk_TrangThai.Checked);
                                MessageBox.Show("Nhóm người dùng đã được tạo thành công", "Thông báo");
                                //Load lai danh sach nhom nguoi dung
                                LoadGroupUser();
                                btn_ThemMoi.Text = "Thêm mới";
                                btn_ThemMoi.Image = global::GUI.Properties.Resources.Actions_list_add_icon;
                                btn_ChinhSua.Text = "Chỉnh sửa";
                                btn_ChinhSua.Image = global::GUI.Properties.Resources.Edit_icon;
                                btn_ChinhSua.Enabled = false;
                                txt_TenVietTat.Enabled = false;
                                txt_TenNhom.Enabled = false;
                                txt_MoTa.Enabled = false;
                                chk_TrangThai.Enabled = false;

                                txt_TenVietTat.Text = "";
                                txt_TenNhom.Text = "";
                                txt_MoTa.Text = "";
                                chk_TrangThai.Checked = false;
                            }
                            else
                            {
                                MessageBox.Show("Tên viết tắt đã tồn tại");
                            }
                        }
                        else {
                            if (StatusSave == "edit") {
                                if (CheckInfoUserGroup(txt_TenVietTat.Text, txt_TenNhom.Text))
                                {

                                    BL.QuanTriHeThong.UserGroup_BL.EditUserGroup(txt_TenVietTat.Text, txt_TenNhom.Text, txt_MoTa.Text, chk_TrangThai.Checked);
                                    MessageBox.Show("Nhóm người dùng đã được chỉnh sửa thành công", "Thông báo");
                                    LoadGroupUser();
                                    btn_ThemMoi.Text = "Thêm mới";
                                    btn_ThemMoi.Image = global::GUI.Properties.Resources.Actions_list_add_icon;
                                    btn_ChinhSua.Text = "Chỉnh sửa";
                                    btn_ChinhSua.Image = global::GUI.Properties.Resources.Edit_icon;
                                    btn_ChinhSua.Enabled = false;
                                    txt_TenVietTat.Enabled = false;
                                    txt_TenNhom.Enabled = false;
                                    txt_MoTa.Enabled = false;
                                    chk_TrangThai.Enabled = false;
                                    txt_TenVietTat.Text = "";
                                    txt_TenNhom.Text = "";
                                    txt_MoTa.Text = "";
                                    chk_TrangThai.Checked = false;

                                }
                                else
                                {
                                    MessageBox.Show("Bạn phải nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }    
                            }
                        }
                        

                    }
                    else
                    {
                        MessageBox.Show("Bạn phải nhập đầy đủ thông tin","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    }
                }
                

            }
            
            
        }

        private void grd_NhomnguoiDung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_ChinhSua.Enabled = true;
            string ID = grd_NhomnguoiDung.CurrentRow.Cells[1].Value.ToString();
            List<UserGroup_DO> dsuser = BL.QuanTriHeThong.UserGroup_BL.GetUserGroup(ID);
            txt_TenVietTat.Text = dsuser[0].tenviettat_;
            txt_TenNhom.Text = dsuser[0].tennhom_;
            txt_MoTa.Text = dsuser[0].mota_;
            chk_TrangThai.Checked = dsuser[0].trangthai;
        }

        private void btn_ChinhSua_Click(object sender, EventArgs e)
        {
            if (btn_ChinhSua.Text == "Chỉnh sửa")
            {
                StatusSave = "edit";
                btn_ChinhSua.Text = "Hủy bỏ";
                btn_ChinhSua.Image = global::GUI.Properties.Resources.cancel1;
                btn_ThemMoi.Text = "Lưu";
                btn_ThemMoi.Image = global::GUI.Properties.Resources.Save_icon;
                txt_TenNhom.Enabled = true;
                txt_MoTa.Enabled = true;
                chk_TrangThai.Enabled = true;
            }
            else 
            {
                if (btn_ChinhSua.Text == "Lưu")
                {

                }
                else {
                    if (btn_ChinhSua.Text == "Hủy bỏ") {
                        btn_ThemMoi.Text = "Thêm mới";
                        btn_ThemMoi.Image = global::GUI.Properties.Resources.Actions_list_add_icon;
                        btn_ChinhSua.Text = "Chỉnh sửa";
                        btn_ChinhSua.Image = global::GUI.Properties.Resources.Edit_icon;
                        btn_ChinhSua.Enabled = false;
                        txt_TenVietTat.Enabled = false;
                        txt_TenNhom.Enabled = false;
                        txt_MoTa.Enabled = false;
                        chk_TrangThai.Enabled = false;
                        StatusSave = "";
                        txt_TenVietTat.Text = "";
                        txt_TenNhom.Text = "";
                        txt_MoTa.Text = "";
                        chk_TrangThai.Checked = false;
                    }
                }
            }


            
            
        }
        //Kiem tra thong tin tren giao dien
        private bool CheckInfoUserGroup(string ID, string Name)
        {
            bool test = true;
            if (ID == "" || Name == "" ) {
                test = false;
            }
            return test; 
        }
        //End kiem tra thong tin
       
       //Kiem tra thong itn duoi database
        private bool CheckInfo(string ID, string Name) 
        {
            bool test = true;
            List<UserGroup_DO> dsmanguoidung = BL.QuanTriHeThong.UserGroup_BL.CheckInfo();
            for (int i = 0; i < dsmanguoidung.Count; i++) 
            {
                if (txt_TenVietTat.Text.ToUpper() == dsmanguoidung[i].tenviettat_.ToUpper() )
                {
                    test = false;
                }
            }
                
            return test;
        }

       // end CHeck
        //Check Chinh Sua

        /// <summary>
        /// STT
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grd_NhomnguoiDung_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < grd_NhomnguoiDung.RowCount; i++)
            {
                grd_NhomnguoiDung.Rows[i].Cells["STT"].Value = Convert.ToString(i + 1);
            }
        }

        private void grd_NhomnguoiDung_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
