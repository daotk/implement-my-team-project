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

namespace GUI.QuanTriHeThong
{
    public partial class frm_City : Form
    {
        bool flag_them = false;
        bool flag_sua = false;
        public frm_City()
        {
            InitializeComponent();
            enableText(false);
            enablebtn(false);
        }
        public void enableText(bool enable)
        {
            txt_TenVietTat.Enabled = enable;
            txt_TenTinhThanh.Enabled = enable;
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
      

        private void btn_ThemMoi_Click(object sender, EventArgs e)
        {
            enablebtn(true);
            enableText(true);
            flag_them = true;
            txt_TenVietTat.Text = "";
            txt_TenTinhThanh.Text = "";
            txt_MoTa.Text = "";
            chk_TrangThai.Checked = false;
            CityBL city = new CityBL();
            grd_ThanhPho.DataSource = city.GetAllCity();
        }

        private void btn_ChinhSua_Click(object sender, EventArgs e)
        {
            enablebtn(true);
            enableText(true);
            flag_sua = true;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (flag_them == true)
            {
                CityBL.add(txt_TenVietTat.Text, txt_TenTinhThanh.Text, txt_MoTa.Text, chk_TrangThai.Checked);
            }
            if (flag_sua == true)
            {
                CityBL.edit(txt_TenVietTat.Text, txt_TenTinhThanh.Text, txt_MoTa.Text, chk_TrangThai.Checked);
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            enableText(false);
            enablebtn(false);
            flag_them = false;
            flag_sua = false;
            //load lai du lieu
        }

        private void frm_City_Load(object sender, EventArgs e)
        {

            CityBL city = new CityBL();
            grd_ThanhPho.DataSource = city.GetAllCity();

        }





    }
}
