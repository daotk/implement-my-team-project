﻿using System;
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

namespace GUI.QuanTriHeThong
{
    public partial class frm_District : Form
    {
        bool flag_them = false;
        bool flag_sua = false;
        public frm_District()
        {
            InitializeComponent();
            enableText(false);
            enablebtn(false);
            enablecbo(false);
        }
        public void enableText(bool enable)
        {
            txt_TenVietTat.Enabled = enable;
            txt_TenQuanHuyen.Enabled = enable;
            txt_MoTa.Enabled = enable;
            chk_TrangThai.Enabled = enable;
        }
        public void enablebtn(bool enable)
        {
            btn_ThemMoi.Visible = !enable;
            btn_ChinhSua.Visible = !enable;
            btn_Luu.Visible = enable;
            btn_Huy.Visible = enable;
        }
        public void enablecbo(bool enable)
        {
            cbo_TinhThanhPho.Enabled = enable;
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
            District_BL district = new District_BL();
            grd_QuanHuyen.DataSource = district.GetAllDistrict();

        }

        private void btn_ThemMoi_Click(object sender, EventArgs e)
        {
            enablebtn(true);
            enableText(true);
            enablecbo(true);
            flag_them = true;
            txt_TenVietTat.Text = "";
            txt_TenQuanHuyen.Text = "";
            txt_MoTa.Text = "";

            chk_TrangThai.Checked = false;
            cbo_TinhThanhPho.SelectedIndex = 0;
        }

        private void btn_ChinhSua_Click(object sender, EventArgs e)
        {
            enablebtn(true);
            enableText(true);
            enablecbo(true);
            flag_sua = true;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (flag_them == true)
            {
                if (txt_TenVietTat.Text == null || txt_TenVietTat.Text == "")
                {
                    MessageBox.Show("Chưa nhập tên viết tắt", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txt_TenQuanHuyen.Text == null || txt_TenQuanHuyen.Text == "")
                {
                    MessageBox.Show("Chưa nhập tên tỉnh thành", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int i = District_BL.add(txt_TenVietTat.Text, txt_TenQuanHuyen.Text, cbo_TinhThanhPho.SelectedValue.ToString(), txt_MoTa.Text, chk_TrangThai.Checked);
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
                District_BL.edit(txt_TenVietTat.Text, txt_TenQuanHuyen.Text, cbo_TinhThanhPho.SelectedValue.ToString(), txt_MoTa.Text, chk_TrangThai.Checked);
            }
            loadDatagrid();
            Huy();
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            Huy();
            //load lai du lieu
        }

        private void cbo_TinhThanhPho_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_TinhThanhPho.SelectedIndex >= 0)
            {
                int CITYID;
                Int32.TryParse(cbo_TinhThanhPho.SelectedValue.ToString(), out CITYID);

            }

        }
             private void frm_District_Load(object sender, EventArgs e)
        {
        loadDatagrid();
            City_BL bl = new City_BL();
            cbo_TinhThanhPho.DataSource = bl.GetAllCity();
            cbo_TinhThanhPho.DisplayMember = "_CITYNAME";
            cbo_TinhThanhPho.ValueMember = "_CITYID";

            int i;
            i = grd_QuanHuyen.SelectedCells[0].RowIndex;
            txt_TenVietTat.Text = grd_QuanHuyen.Rows[i].Cells[1].Value.ToString();
            txt_TenQuanHuyen.Text = grd_QuanHuyen.Rows[i].Cells[2].Value.ToString();
            cbo_TinhThanhPho.SelectedValue = grd_QuanHuyen.Rows[i].Cells[3].Value.ToString();
            txt_MoTa.Text = grd_QuanHuyen.Rows[i].Cells[4].Value.ToString();
            if (Convert.ToBoolean(grd_QuanHuyen.Rows[i].Cells[5].Value) == true) { chk_TrangThai.Checked = true; }
            else { chk_TrangThai.Checked = false; }
        }

             private void cbo_LocTheoTinhThanh_SelectedIndexChanged(object sender, EventArgs e)
             {
                 if (cbo_LocTheoTinhThanh.SelectedIndex >= 0)
                 {
                     int CITYID;
                     Int32.TryParse(cbo_LocTheoTinhThanh.SelectedValue.ToString(), out CITYID);
                 }
             }

             private void grd_QuanHuyen_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
             {
                 for (int i = 0; i < grd_QuanHuyen.RowCount; i++)
                 {
                     grd_QuanHuyen.Rows[i].Cells["STTTinhThanh"].Value = Convert.ToString(i + 1);
                 }
             }

             private void grd_QuanHuyen_CellClick(object sender, DataGridViewCellEventArgs e)
             {
                 int i;
                 i = grd_QuanHuyen.SelectedCells[0].RowIndex;
                 txt_TenVietTat.Text = grd_QuanHuyen.Rows[i].Cells[1].Value.ToString();
                 txt_TenQuanHuyen.Text = grd_QuanHuyen.Rows[i].Cells[2].Value.ToString();
                 cbo_TinhThanhPho.SelectedValue = grd_QuanHuyen.Rows[i].Cells[3].Value.ToString();
                 txt_MoTa.Text = grd_QuanHuyen.Rows[i].Cells[4].Value.ToString();
                 if (Convert.ToBoolean(grd_QuanHuyen.Rows[i].Cells[5].Value) == true) { chk_TrangThai.Checked = true; }
                 else { chk_TrangThai.Checked = false; }
             }

       

    }

       
}