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
using DA.QuanTriHeThong;
using BL;

namespace GUI.QuanTriHeThong
{
    public partial class frm_Department : Form
    {
        bool flag_them = false;
        bool flag_sua = false;
        public frm_Department()
        {
            InitializeComponent();
            enableText(false);
            enablebtn(false);
            enablecbo(false);
        }

        public void enableText(bool enable)
        {
            txt_TenVietTat.Enabled = enable;
            txt_phongBan.Enabled = enable;
            txt_MoTa.Enabled = enable;
            chk_TrangThai.Enabled = enable;
        }

        public void enablebtn(bool enable)
        {
            btn_ThemMoi.Visible = !enable;
            btn_ChinhSua.Visible = !enable;
            btn_luu.Visible = enable;
            btn_huy.Visible = enable;
        }

        public void enablecbo(bool enable)
        {
            cbo_LoaiPhongban.Enabled = enable;


        }


        public void Huy()
        {
            enableText(false);
            enablebtn(false);
            enablecbo(false);
            flag_them = false;
            flag_sua = false;
        }


        public void loadDatagrid()
        {
            Department_BL depart = new Department_BL();
            grd_PhongBan.DataSource = depart.GetAllDepart();
        }

        //public void focus()
        //{
        //    int i;
        //    i = grd_PhongBan.SelectedCells[0].RowIndex;
        //    txt_TenVietTat.Text = grd_PhongBan.Rows[i].Cells[1].Value.ToString();
        //    txt_phongBan.Text = grd_PhongBan.Rows[i].Cells[2].Value.ToString();
        //    cbo_LoaiPhongban.SelectedValue = grd_PhongBan.Rows[i].Cells[3].Value.ToString();
        //    txt_MoTa.Text = grd_PhongBan.Rows[i].Cells[5].Value.ToString();
        //    if (Convert.ToBoolean(grd_PhongBan.Rows[i].Cells[6].Value) == true) { chk_TrangThai.Checked = true; }
        //    else { chk_TrangThai.Checked = false; }
        //}

        private void frm_Department_Load(object sender, EventArgs e)
        {
            //TypeDepartment_BL bl = new TypeDepartment_BL();
            cbo_LoaiPhongban.DataSource = BL.QuanTriHeThong.TypeDepartment_BL.GetAllDepartment();
            cbo_LoaiPhongban.DisplayMember = "_DEPARTMENTNAME";
            cbo_LoaiPhongban.ValueMember = "_DEPARTMENTTYPEID";

            cbo_LocTheoLoaiPhongBan.DataSource = BL.QuanTriHeThong.TypeDepartment_BL.GetAllDepartment();
            cbo_LocTheoLoaiPhongBan.DisplayMember = "_DEPARTMENTNAME";
            cbo_LocTheoLoaiPhongBan.ValueMember = "_DEPARTMENTTYPEID";
            cbo_LocTheoLoaiPhongBan.SelectedIndex = -1;
            loadDatagrid();
            //focus();
        
        }

        private void cbo_LoaiPhongban_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_LoaiPhongban.SelectedIndex >= 0)
            {
                int DEPARTMENTID;
                Int32.TryParse(cbo_LoaiPhongban.SelectedValue.ToString(), out DEPARTMENTID);
            }
        }

        private void btn_ThemMoi_Click(object sender, EventArgs e)
        {
            enablebtn(true);
            enableText(true);
            enablecbo(true);
            flag_them = true;
            txt_TenVietTat.Text = "";
            txt_phongBan.Text = "";
            txt_MoTa.Text = "";
            chk_TrangThai.Checked = false;
            cbo_LoaiPhongban.SelectedIndex = 0;
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (flag_them == true)
            {
                if (txt_TenVietTat.Text == null || txt_TenVietTat.Text == "")
                {
                    MessageBox.Show("Chưa nhập tên viết tắt", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txt_phongBan.Text == null || txt_phongBan.Text == "")
                {
                    MessageBox.Show("Chưa nhập tên phòng ban", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int i = Department_BL.add(txt_TenVietTat.Text, txt_phongBan.Text, cbo_LoaiPhongban.SelectedValue.ToString(), txt_MoTa.Text, chk_TrangThai.Checked);
                if (i == -1)
                {
                    MessageBox.Show("Error adding", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Success Adding", "Succeed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            if (flag_sua == true)
            {
                txt_TenVietTat.Enabled = false;
                Department_BL.edit(txt_TenVietTat.Text, txt_phongBan.Text, cbo_LoaiPhongban.SelectedValue.ToString(), txt_MoTa.Text, chk_TrangThai.Checked);
            }
            loadDatagrid();
            Huy();
        }



        private void btn_ChinhSua_Click(object sender, EventArgs e)
        {
            enablebtn(true);
            enableText(true);
            enablecbo(true);
            flag_sua = true;
            
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            Huy();
        }

        private void grd_PhongBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grd_PhongBan_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < grd_PhongBan.RowCount; i++)
            {
                grd_PhongBan.Rows[i].Cells["STT"].Value = Convert.ToString(i + 1);
            }
        }





       
    }
}
