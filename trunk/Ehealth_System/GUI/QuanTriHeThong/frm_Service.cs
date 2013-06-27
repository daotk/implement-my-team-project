using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DO.QuanTriHeThong;
using BL.QuanTriHeThong;

namespace GUI.QuanTriHeThong
{
    public partial class frm_Service : Form
    {
        public frm_Service()
        {
            InitializeComponent();
        }


        private void frm_Service_Load(object sender, EventArgs e)
        {
            LoadDSService();

        }

        private void LoadDSService()
        {
            grd_NhomDichVu.DataSource = BL.QuanTriHeThong.ServiceBL.GetService();
            btn_ChinhSua.Text = "Chỉnh sửa";
            btn_ThemMoi.Text = "Thêm mới";
            btn_ChinhSua.Enabled = false;
            txt_TenVietTat.Enabled = false;
            txt_NhomDichVu.Enabled = false;
            txt_GiaTien.Enabled = false;
            chk_TrangThai.Enabled = false;
            txt_MoTa.Enabled = false;
            cbo_NhomDichVu.Enabled = false;
        }

        private void btn_ThemMoi_Click(object sender, EventArgs e)
        {
            if (btn_ThemMoi.Text == "Thêm mới")
            {
                btn_ThemMoi.Text = "Lưu";
                btn_ChinhSua.Text = "Hủy bỏ";
                txt_TenVietTat.Enabled = true;
                txt_NhomDichVu.Enabled = true;
                txt_GiaTien.Enabled = true;
                chk_TrangThai.Enabled = true;
                txt_MoTa.Enabled = true;
                cbo_NhomDichVu.Enabled = true;
            }
            else {
                if (btn_ThemMoi.Text == "Lưu")
                {
                    BL.QuanTriHeThong.ServiceBL.CreateService(txt_TenVietTat.Text, "AA", txt_NhomDichVu.Text, txt_GiaTien.Text, txt_MoTa.Text, chk_TrangThai.Checked);
                    MessageBox.Show("Thêm mới thành công");
                    LoadDSService();
                }
                else {
                    if (btn_ThemMoi.Text == "Cập Nhật") {
                        BL.QuanTriHeThong.ServiceBL.EditService(txt_TenVietTat.Text, cbo_NhomDichVu.Text, txt_NhomDichVu.Text, txt_GiaTien.Text, txt_MoTa.Text, chk_TrangThai.Checked);
                        MessageBox.Show("Chỉnh sửa thành công");
                        LoadDSService();
                    }
                }
            }
        }

        private void btn_ChinhSua_Click(object sender, EventArgs e)
        {
            if (btn_ChinhSua.Text == "Chỉnh sửa")
            {
                btn_ThemMoi.Text = "Cập Nhật";
                btn_ChinhSua.Text = "Hủy bỏ";
                txt_TenVietTat.Enabled = true;
                txt_NhomDichVu.Enabled = true;
                txt_GiaTien.Enabled = true;
                chk_TrangThai.Enabled = true;
                txt_MoTa.Enabled = true;
                cbo_NhomDichVu.Enabled = true;
            }
            else {
                if (btn_ChinhSua.Text == "Hủy bỏ") {
                    btn_ThemMoi.Text = "Thêm mới";
                    btn_ChinhSua.Text = "Chỉnh sửa";
                    txt_TenVietTat.Enabled = false;
                    txt_NhomDichVu.Enabled = false;
                    txt_GiaTien.Enabled = false;
                    chk_TrangThai.Enabled = false;
                    txt_MoTa.Enabled = false;
                    cbo_NhomDichVu.Enabled = false;
                }
            }
        }

        private void grd_NhomDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_ChinhSua.Enabled = true;
            string ID = grd_NhomDichVu.CurrentRow.Cells[1].Value.ToString();
            List<ServiceDO> dsuser = BL.QuanTriHeThong.ServiceBL.Get_Service(ID);
            //txt_TenVietTat.Text = dsuser[0].tenviettat_;
            txt_TenVietTat.Text = dsuser[0].serviceid_;
            //txt_TenNhom.Text = dsuser[0].tennhom_;
            cbo_NhomDichVu.Text = dsuser[0].servicegroupid_;
            //txt_MoTa.Text = dsuser[0].mota_;
            txt_NhomDichVu.Text = dsuser[0].servicename_;
            txt_GiaTien.Text = dsuser[0].servicecost_;
            txt_MoTa.Text = dsuser[0].servicedescription_;
            chk_TrangThai.Checked = dsuser[0].servicestatus_;
        }


    

    }
}
