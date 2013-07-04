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
    public partial class frm_District : Form
    {
        bool flag_them = false;
        bool flag_sua = false;
        int totalcount;

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
            int count = grd_QuanHuyen.Rows.Count;
            totalcount = count;
            if (grd_QuanHuyen.Rows.Count == 0)
            {
                btn_ChinhSua.Enabled = false;
            }
        }

        public void focus()
        {
            if (grd_QuanHuyen.Rows.Count != 0)
            {
                int i;
                i = grd_QuanHuyen.SelectedCells[0].RowIndex;
                txt_TenVietTat.Text = grd_QuanHuyen.Rows[i].Cells[1].Value.ToString();
                txt_TenQuanHuyen.Text = grd_QuanHuyen.Rows[i].Cells[2].Value.ToString();
                cbo_TinhThanhPho.SelectedValue = grd_QuanHuyen.Rows[i].Cells[3].Value.ToString();
                if (grd_QuanHuyen.Rows[i].Cells[5].Value == null)
                {
                    txt_MoTa.Text = "";
                }
                else
                {
                    txt_MoTa.Text = grd_QuanHuyen.Rows[i].Cells[5].Value.ToString();
                }

                if (Convert.ToBoolean(grd_QuanHuyen.Rows[i].Cells[6].Value) == true) { chk_TrangThai.Checked = true; }
                else { chk_TrangThai.Checked = false; }
            }
        }

        private void frm_District_Load(object sender, EventArgs e)
        {
            cbo_TinhThanhPho.DataSource = BL.QuanTriHeThong.District_BL.GetAllDis1();
            cbo_TinhThanhPho.DisplayMember = "_CITYNAME";
            cbo_TinhThanhPho.ValueMember = "_CITYID";
            City_BL bl = new City_BL();
            cbo_LocTheoTinhThanh.DataSource = bl.GetAllCity();
            cbo_LocTheoTinhThanh.DisplayMember = "_CITYNAME";
            cbo_LocTheoTinhThanh.ValueMember = "_CITYID";
            cbo_LocTheoTinhThanh.SelectedIndex = -1;
            loadDatagrid();
            focus();
            lbl_KetQua.Text = "Kết quả: tìm được 0 trong tổng số " + totalcount+" Quận huyện";
            if (cbo_TinhThanhPho.Items.Count <= 0)
            {
                btn_ThemMoi.Enabled = false;
            }
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
            txt_TenVietTat.Enabled = false;
            flag_sua = true;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (flag_them == true)
            {
                if (txt_TenVietTat.Text == null || txt_TenVietTat.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên viết tắt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txt_TenQuanHuyen.Text == null || txt_TenQuanHuyen.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên quận huyện", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int i = District_BL.add(txt_TenVietTat.Text, txt_TenQuanHuyen.Text, cbo_TinhThanhPho.SelectedValue.ToString(), txt_MoTa.Text, chk_TrangThai.Checked);
                if (i == -1)
                {
                    MessageBox.Show("Tên viết tắt đã tồn tại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Quận - huyện đã được tạo thành công", "Succeed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (flag_sua == true)
            {
                txt_TenVietTat.Enabled = false;
                if (txt_TenQuanHuyen.Text == null || txt_TenQuanHuyen.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên quận huyện", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int i = District_BL.edit(txt_TenVietTat.Text, txt_TenQuanHuyen.Text, cbo_TinhThanhPho.SelectedValue.ToString(), txt_MoTa.Text, chk_TrangThai.Checked);
                if (i == -1)
                {
                    MessageBox.Show("Tên viết tắt đã tồn tại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Quận - huyện đã được chỉnh sửa thành công", "Thông báo");
                }
            }
            loadDatagrid();
            Huy();
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            Huy();
            focus();
        }

        private void cbo_TinhThanhPho_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_TinhThanhPho.SelectedIndex >= 0)
            {
                int CITYID;
                Int32.TryParse(cbo_TinhThanhPho.SelectedValue.ToString(), out CITYID);
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
            focus();
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            grd_QuanHuyen.DataSource = BL.QuanTriHeThong.District_BL.SearchDistrict(txt_TimKiem.Text);
            lbl_KetQua.Text = "Kết quả: tìm được " + grd_QuanHuyen.DisplayedRowCount(true) + " trong tổng số " + totalcount.ToString()+" Quận huyện";
        }

        private void cbo_LocTheoTinhThanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_TimKiem.Text == null || txt_TimKiem.Text == "")
            {
                if (cbo_LocTheoTinhThanh.SelectedIndex >= 0)
                {
                    grd_QuanHuyen.DataSource = District_BL.SearchDistrictByCity(cbo_LocTheoTinhThanh.SelectedValue.ToString());
                    if (grd_QuanHuyen.DisplayedRowCount(true) > 0)
                    {
                        lbl_KetQua.Text = "Kết quả: tìm được " + grd_QuanHuyen.DisplayedRowCount(true) + " trong tổng số " + totalcount+" Quận huyện";
                    }
                }
            }
            else
            {
                if (cbo_LocTheoTinhThanh.SelectedIndex >= 0)
                {
                    if (grd_QuanHuyen.DisplayedRowCount(true) > 0)
                    {
                        grd_QuanHuyen.DataSource = BL.QuanTriHeThong.District_BL.SearchDistrictByBoth(txt_TimKiem.Text, cbo_LocTheoTinhThanh.SelectedValue.ToString());
                        lbl_KetQua.Text = "Kết quả: tìm được " + grd_QuanHuyen.DisplayedRowCount(true) + " trong tổng số " + totalcount+" Quận huyện";
                    }
                }
            }
        }
    }
}
