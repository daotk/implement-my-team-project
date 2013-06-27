using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DO.QuanTriHeThong;
using DA.QuanTriHeThong;
using BL.QuanTriHeThong;

namespace GUI.QuanTriHeThong
{
    public partial class frm_TypeService : Form
    {
        public frm_TypeService()
        {
            InitializeComponent();
        }
        private void frm_TypeService_Load(object sender, EventArgs e)
        {
            LoadGroupService();
        }

        private void LoadGroupService()
        {
            grd_NhomDichVu.DataSource= BL.QuanTriHeThong.GroupService_BL.GetGroupService();
            btn_ChinhSua.Text = "Chỉnh sửa";
            btn_ThemMoi.Text = "Thêm mới";
            btn_ChinhSua.Enabled = false;
            txt_TenVietTat.Enabled = false;
            txt_NhomDichVu.Enabled = false;
            chk_TrangThai.Enabled = false;
            txt_MoTa.Enabled = false;
            
        }

        private void btn_ThemMoi_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_ChinhSua_Click(object sender, EventArgs e)
        {
            
        }

        private void grd_NhomDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_ChinhSua.Enabled = true;
            string ID = grd_NhomDichVu.CurrentRow.Cells[1].Value.ToString();
            List<GroupService_DO> dsuser = BL.QuanTriHeThong.GroupService_BL.Get_GroupService(ID);
            //txt_TenVietTat.Text = dsuser[0].tenviettat_;
            txt_TenVietTat.Text = dsuser[0]._SERVICEGROUPID;
            //txt_TenNhom.Text = dsuser[0].tennhom_;
            //txt_MoTa.Text = dsuser[0].mota_;
            txt_NhomDichVu.Text = dsuser[0]._SERVICEGROUPNAME;
            txt_MoTa.Text = dsuser[0]._SERVICEBROUPDESCRIPTION;
            chk_TrangThai.Checked = dsuser[0]._SERVICEGROUPSTATUS;
        
        }

        private void btn_ThemMoi_Click_1(object sender, EventArgs e)
        {
            if (btn_ThemMoi.Text == "Thêm mới")
            {
                btn_ThemMoi.Text = "Lưu";
                btn_ChinhSua.Text = "Hủy bỏ";
                txt_TenVietTat.Enabled = true;
                txt_NhomDichVu.Enabled = true;

                chk_TrangThai.Enabled = true;
                txt_MoTa.Enabled = true;

            }
            else
            {
                if (btn_ThemMoi.Text == "Lưu")
                {
                    BL.QuanTriHeThong.GroupService_BL.CreateService(txt_TenVietTat.Text, txt_NhomDichVu.Text, txt_MoTa.Text, chk_TrangThai.Checked);
                    MessageBox.Show("Thêm mới thành công");
                    LoadGroupService();
                }
                else
                {
                    if (btn_ThemMoi.Text == "Cập Nhật")
                    {
                        BL.QuanTriHeThong.GroupService_BL.EditService(txt_TenVietTat.Text, txt_NhomDichVu.Text, txt_MoTa.Text, chk_TrangThai.Checked);
                        MessageBox.Show("Chỉnh sửa thành công");
                        LoadGroupService();
                    }
                }
            }
        }

        private void btn_ChinhSua_Click_1(object sender, EventArgs e)
        {
            if (btn_ChinhSua.Text == "Chỉnh sửa")
            {
                btn_ThemMoi.Text = "Cập Nhật";
                btn_ChinhSua.Text = "Hủy bỏ";
                txt_TenVietTat.Enabled = true;
                txt_NhomDichVu.Enabled = true;
                chk_TrangThai.Enabled = true;
                txt_MoTa.Enabled = true;

            }
            else
            {
                if (btn_ChinhSua.Text == "Hủy bỏ")
                {
                    btn_ThemMoi.Text = "Thêm mới";
                    btn_ChinhSua.Text = "Chỉnh sửa";
                    txt_TenVietTat.Enabled = false;
                    txt_NhomDichVu.Enabled = false;
                    chk_TrangThai.Enabled = false;
                    txt_MoTa.Enabled = false;

                }
            }
        }

    }
}
