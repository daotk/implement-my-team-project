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
        /// <summary>
        /// load danh sach nhom dich vu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frm_TypeService_Load(object sender, EventArgs e)
        {
            LoadGroupService();
        }
        /// <summary>
        /// load danh sach nhom dich vu
        /// </summary>
        private void LoadGroupService()
        {
            grd_NhomDichVu.DataSource = BL.QuanTriHeThong.GroupService_BL.GetGroupService();
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
        /// <summary>
        /// load thong tin nhom dich vu vao bang thong tin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// chon chuc nang them moi nhom dich vu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ThemMoi_Click_1(object sender, EventArgs e)
        {
            if (btn_ThemMoi.Text == "Thêm mới")
            {
                btn_ThemMoi.Text = "Lưu";
                btn_ChinhSua.Text = "Hủy bỏ";
                Pank();
                Enable();
            }
            else
            {
                if (btn_ThemMoi.Text == "Lưu")
                {
                    if (Check())
                    {
                        BL.QuanTriHeThong.GroupService_BL.CreateGroupService(txt_TenVietTat.Text, txt_NhomDichVu.Text, txt_MoTa.Text, chk_TrangThai.Checked);
                        MessageBox.Show("Thêm mới thành công");
                        LoadGroupService();
                        Pank();
                    }
                }
                else
                {
                    if (Check())
                    {
                        if (btn_ThemMoi.Text == "Cập Nhật")
                        {
                            BL.QuanTriHeThong.GroupService_BL.EditGroupService(txt_TenVietTat.Text, txt_NhomDichVu.Text, txt_MoTa.Text, chk_TrangThai.Checked);
                            MessageBox.Show("Chỉnh sửa thành công");
                            LoadGroupService();
                        }
                    }
                }
            }
        }
        /// <summary>
        /// chon chuc nang chinh sua thong tin nhom dich vu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ChinhSua_Click_1(object sender, EventArgs e)
        {
            if (btn_ChinhSua.Text == "Chỉnh sửa")
            {
                btn_ThemMoi.Text = "Cập Nhật";
                btn_ChinhSua.Text = "Hủy bỏ";
                Enable();
            }
            else
            {
                if (btn_ChinhSua.Text == "Hủy bỏ")
                {
                    btn_ThemMoi.Text = "Thêm mới";
                    btn_ChinhSua.Text = "Chỉnh sửa";
                    Disiable();

                }
            }
        }
        private void Enable()
        {
            txt_TenVietTat.Enabled = true;
            txt_NhomDichVu.Enabled = true;
            chk_TrangThai.Enabled = true;
            txt_MoTa.Enabled = true;
        }
        private void Disiable()
        {
            txt_TenVietTat.Enabled = false;
            txt_NhomDichVu.Enabled = false;
            chk_TrangThai.Enabled = false;
            txt_MoTa.Enabled = false;
        }
        private void Pank()
        {
            txt_TenVietTat.Text = "";
            txt_NhomDichVu.Text = "";
            txt_MoTa.Text = "";
            chk_TrangThai.Checked = false;
        }
        private bool Check()
        {
            bool test = true;
            if (txt_TenVietTat.Text == null || txt_TenVietTat.Text == "")
            {
                MessageBox.Show("Chưa nhập tên viết tắt", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                test = false;
            }
            else
            {
                if (txt_NhomDichVu.Text == null || txt_NhomDichVu.Text == "")
                {
                    MessageBox.Show("Chưa nhập tên dich vu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    test = false;
                }
            }
            return test;
        }
        /// <summary>
        /// tu dong cap nhat STT
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grd_NhomDichVu_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < grd_NhomDichVu.RowCount; i++)
            {
                grd_NhomDichVu.Rows[i].Cells["STT"].Value = Convert.ToString(i + 1);
            }
        }
        /// <summary>
        /// search
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            grd_NhomDichVu.DataSource = BL.QuanTriHeThong.GroupService_BL.SearchGroupService(txt_TimKiem.Text);
        }

       
    }
}
