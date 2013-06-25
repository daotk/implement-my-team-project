﻿using System;
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
    public partial class frm_TypeDepartment : Form
    {
        bool flag_them= false;
        bool flag_sua=false;
        public frm_TypeDepartment()
        {
            InitializeComponent();
            enableText(false);
            enablebtn(false);
        }
        public void enableText(bool enable)
        {
            txt_TenVietTat.Enabled = enable;
            txt_LoaiPhongBan.Enabled = enable;
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
        private void btn_ThemMoi_Click(object sender, EventArgs e)
        {
            enablebtn(true);
            enableText(true);
            flag_them = true;
            txt_TenVietTat.Text = "";
            txt_LoaiPhongBan.Text = "";
            txt_MoTa.Text = "";
            chk_TrangThai.Checked = false;
        }
         public void Huy()
        {
            
            flag_them = false;
            flag_sua = false;
        }
        public void loadDatagrid()
        {
            DepartmentTypeBL depart = new DepartmentTypeBL();
            grd_LoaiPhongBan.DataSource = depart.GetAllDepartment();
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
                if (txt_LoaiPhongBan.Text == null || txt_LoaiPhongBan.Text == "")
                {
                    MessageBox.Show("Chưa nhập tên phòng ban", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int i = DepartmentTypeBL.add(txt_TenVietTat.Text, txt_LoaiPhongBan.Text, txt_MoTa.Text, chk_TrangThai.Checked);
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
                CityBL.edit(txt_TenVietTat.Text, txt_LoaiPhongBan.Text, txt_MoTa.Text, chk_TrangThai.Checked);
            }
            loadDatagrid();


            Huy();
        }

        private void grd_LoaiPhongBan_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < grd_LoaiPhongBan.RowCount; i++)
            {
                grd_LoaiPhongBan.Rows[i].Cells["STT"].Value = Convert.ToString(i + 1);
            }
        }

        private void grd_LoaiPhongBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frm_TypeDepartment_Load(object sender, EventArgs e)
        {
            loadDatagrid();
        }
      
        }
       

      
    }
