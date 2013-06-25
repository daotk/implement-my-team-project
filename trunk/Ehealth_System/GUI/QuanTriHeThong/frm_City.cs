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
                if (txt_TenVietTat.Text == null || txt_TenVietTat.Text == "")
                {
                    MessageBox.Show("Chưa nhập tên viết tắt", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txt_TenTinhThanh.Text == null || txt_TenTinhThanh.Text == "")
                {
                    MessageBox.Show("Chưa nhập tên tỉnh thành", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int i=City_BL.add(txt_TenVietTat.Text, txt_TenTinhThanh.Text, txt_MoTa.Text, chk_TrangThai.Checked);
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
                City_BL.edit(txt_TenVietTat.Text, txt_TenTinhThanh.Text, txt_MoTa.Text, chk_TrangThai.Checked);
            }
            loadDatagrid();
            

            Huy();
        }

        public void Huy()
        {
            enableText(false);
            enablebtn(false);
            flag_them = false;
            flag_sua = false;
        }
        public void loadDatagrid()
        {
            City_BL city = new City_BL();
            grd_ThanhPho.DataSource = city.GetAllCity();
        }
        private void btn_Huy_Click(object sender, EventArgs e)
        {
            Huy();
            //load lai du lieu
        }


        private void grd_ThanhPho_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < grd_ThanhPho.RowCount; i++)
            {
                grd_ThanhPho.Rows[i].Cells["STT"].Value = Convert.ToString(i + 1);
            }
        }

        private void grd_ThanhPho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = grd_ThanhPho.SelectedCells[0].RowIndex;
            txt_TenVietTat.Text = grd_ThanhPho.Rows[i].Cells[1].Value.ToString();
            txt_TenTinhThanh.Text = grd_ThanhPho.Rows[i].Cells[2].Value.ToString();
            txt_MoTa.Text = grd_ThanhPho.Rows[i].Cells[3].Value.ToString();
            if (Convert.ToBoolean(grd_ThanhPho.Rows[i].Cells[4].Value) == true) { chk_TrangThai.Checked = true; }
            else { chk_TrangThai.Checked = false; }

        }

        private void frm_City_Load(object sender, EventArgs e)
        {
            loadDatagrid();
        }

        private void grd_ThanhPho_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //grd_ThanhPho.Refresh();
        }


    }
}
