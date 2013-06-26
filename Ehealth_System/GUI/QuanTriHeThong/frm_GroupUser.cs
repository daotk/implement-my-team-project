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
            if (btn_ThemMoi.Text == "Thêm mới")
            {
                btn_ThemMoi.Text = "Lưu";
                btn_ChinhSua.Text = "Hủy bỏ";
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
                        if (CheckInfo(txt_TenVietTat.Text, txt_TenNhom.Text))
                        {
                            BL.QuanTriHeThong.UserGroup_BL.CreateUserGroup(txt_TenVietTat.Text, txt_TenNhom.Text, txt_MoTa.Text,"00000000000000", chk_TrangThai.Checked);
                            MessageBox.Show("Thêm mới thành công");
                            //Load lai danh sach nhom nguoi dung
                            LoadGroupUser();
                            btn_ThemMoi.Text = "Thêm mới";
                            btn_ChinhSua.Text = "Chỉnh sửa";
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
                    else
                    {
                        MessageBox.Show("Bạn phải nhập đầy đủ thông tin");
                    }
                }
                else {
                    if (btn_ThemMoi.Text == "Hủy bỏ") {
                        btn_ThemMoi.Text = "Thêm mới";
                        btn_ChinhSua.Text = "Chỉnh sửa";
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
                }

            }
            
            
        }

        private void grd_NhomnguoiDung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_ChinhSua.Enabled = true;
            string ID = grd_NhomnguoiDung.CurrentRow.Cells[0].Value.ToString();
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
                btn_ChinhSua.Text = "Lưu";
                btn_ThemMoi.Text = "Hủy bỏ";
                txt_TenNhom.Enabled = true;
                txt_MoTa.Enabled = true;
                chk_TrangThai.Enabled = true;
            }
            else 
            {
                if (btn_ChinhSua.Text == "Lưu")
                {
                    if (CheckInfoUserGroup(txt_TenVietTat.Text, txt_TenNhom.Text))
                    {
                         BL.QuanTriHeThong.UserGroup_BL.EditUserGroup(txt_TenVietTat.Text, txt_TenNhom.Text, txt_MoTa.Text, chk_TrangThai.Checked);
                            MessageBox.Show("Chỉnh sửa thành công");
                            LoadGroupUser();
                            btn_ThemMoi.Text = "Thêm mới";
                            btn_ChinhSua.Text = "Chỉnh sửa";
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
                        MessageBox.Show("Bạn phải nhập đầy dủ thông tin");
                    }
                }
                else {
                    if (btn_ChinhSua.Text == "Hủy bỏ") {
                        btn_ThemMoi.Text = "Thêm mới";
                        btn_ChinhSua.Text = "Chỉnh sửa";
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
        }// end CHeck
        //Check Chinh Sua
        
    }
}
