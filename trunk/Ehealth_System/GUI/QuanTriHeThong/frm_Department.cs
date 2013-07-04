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
        int totalcount;
        public frm_Department()
        {
            InitializeComponent();
            enableText(false);
            enablebtn(false);
            enablecbo(false);
        }

        /// <summary>
        /// Ẩn các textbox
        /// </summary>
        /// <param name="enable"></param>
        public void enableText(bool enable)
        {
            txt_TenVietTat.Enabled = enable;
            txt_phongBan.Enabled = enable;
            txt_MoTa.Enabled = enable;
            chk_TrangThai.Enabled = enable;
        }//end

        /// <summary>
        /// Ẩn các button
        /// </summary>
        /// <param name="enable"></param>
        public void enablebtn(bool enable)
        {
            btn_ThemMoi.Visible = !enable;
            btn_ChinhSua.Visible = !enable;
            btn_luu.Visible = enable;
            btn_huy.Visible = enable;
        }//end

        /// <summary>
        /// ẩn các combobox
        /// </summary>
        /// <param name="enable"></param>
        public void enablecbo(bool enable)
        {
            cbo_LoaiPhongban.Enabled = enable;


        }//end

        /// <summary>
        /// Xử lí "hủy bỏ"
        /// </summary>
        public void Huy()
        {
            enableText(false);
            enablebtn(false);
            enablecbo(false);
            flag_them = false;
            flag_sua = false;
        }//end

        /// <summary>
        /// load dữ liệu lên datagrid
        /// </summary>
        public void loadDatagrid()
        {
            Department_BL depart = new Department_BL();
            grd_PhongBan.DataSource = depart.GetAllDepart();

            int count = grd_PhongBan.Rows.Count;
            totalcount = count;
        }//end

        /// <summary>
        /// lấy dữ liệu vào textbox khi nhấn vào dữ liệu trên datagrid
        /// </summary>
        public void focus()
        {
            if (grd_PhongBan.Rows.Count != 0) 
            {
                int i;
                i = grd_PhongBan.SelectedCells[0].RowIndex;
                txt_TenVietTat.Text = grd_PhongBan.Rows[i].Cells[1].Value.ToString();
                txt_phongBan.Text = grd_PhongBan.Rows[i].Cells[2].Value.ToString();
                cbo_LoaiPhongban.SelectedValue = grd_PhongBan.Rows[i].Cells[3].Value.ToString();
                //txt_MoTa.Text = grd_PhongBan.Rows[i].Cells[5].Value.ToString();
                if (grd_PhongBan.Rows[i].Cells[5].Value == null)
                {
                    txt_MoTa.Text = "";
                }
                else
                {
                    txt_MoTa.Text = grd_PhongBan.Rows[i].Cells[3].Value.ToString();
                }
                if (Convert.ToBoolean(grd_PhongBan.Rows[i].Cells[6].Value) == true) { chk_TrangThai.Checked = true; }
                else { chk_TrangThai.Checked = false; }
            }
            
        }//end


        /// <summary>
        /// load phòng ban
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frm_Department_Load(object sender, EventArgs e)
        {
            //TypeDepartment_BL bl = new TypeDepartment_BL();
            
            cbo_LoaiPhongban.DataSource = BL.QuanTriHeThong.Department_BL.GetAllDepart1();
            cbo_LoaiPhongban.DisplayMember = "_DEPARTMENTNAME";
            cbo_LoaiPhongban.ValueMember = "_DEPARTMENTTYPEID";
            
           

            cbo_LocTheoLoaiPhongBan.DataSource = BL.QuanTriHeThong.TypeDepartment_BL.GetAllDepartment();
            cbo_LocTheoLoaiPhongBan.DisplayMember = "_DEPARTMENTNAME";
            cbo_LocTheoLoaiPhongBan.ValueMember = "_DEPARTMENTTYPEID";
            cbo_LocTheoLoaiPhongBan.SelectedIndex = -1;

            loadDatagrid();
            focus();

            btn_ChinhSua.Enabled = false;

            lbl_KetQua.Text = "Kết quả : Tìm được 0 trong tổng số" + " " + totalcount + " phòng ban";
        
        }//end

        /// <summary>
        /// load loại phòng ban vào combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbo_LoaiPhongban_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_LoaiPhongban.SelectedIndex >= 0)
            {
                int DEPARTMENTID;
                Int32.TryParse(cbo_LoaiPhongban.SelectedValue.ToString(), out DEPARTMENTID);
            }
        }//end


        /// <summary>
        /// xử lí button "thêm mới"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            cbo_LoaiPhongban.Text="";
            cbo_LoaiPhongban.SelectedIndex = 0;
        }//end

        /// <summary>
        /// Xử lí nhấn lưu khi thêm mới và chỉnh sửa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (flag_them == true)
            {
                if (txt_TenVietTat.Text == null || txt_TenVietTat.Text == "")
                {
                    MessageBox.Show("Bạn phải nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }//end if
                if (txt_phongBan.Text == null || txt_phongBan.Text == "")
                {
                    MessageBox.Show("Bạn phải nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }//end if

                if (cbo_LoaiPhongban.Text == null || cbo_LoaiPhongban.Text == "")
                {
                    MessageBox.Show("Bạn phải nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }//end if

                int i = Department_BL.add(txt_TenVietTat.Text, txt_phongBan.Text, cbo_LoaiPhongban.SelectedValue.ToString(), txt_MoTa.Text, chk_TrangThai.Checked);
                if (i == -1)
                {
                    MessageBox.Show("Phòng ban đã tồn tại trong hệ thống", "Thông báo");
                    return;
                }
                else
                {
                    MessageBox.Show("Danh mục phòng ban đã được tạo thành công", "Thông báo");
                }
                
            }
            if (flag_sua == true)
            {
                txt_TenVietTat.Enabled = false;
                
                if (txt_phongBan.Text == null || txt_phongBan.Text == "")
                {
                    MessageBox.Show("Bạn phải nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (cbo_LoaiPhongban.Text == null || cbo_LoaiPhongban.Text == "")
                {
                    MessageBox.Show("Bạn phải nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int i = Department_BL.edit(txt_TenVietTat.Text, txt_phongBan.Text, cbo_LoaiPhongban.SelectedValue.ToString(), txt_MoTa.Text, chk_TrangThai.Checked);
                if (i == -1)
                {
                    MessageBox.Show("Lỗi hệ thống. Xin quay lại sau", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Danh mục phòng ban đã được chỉnh sửa thành công", "Thông báo");
                }
            }
            loadDatagrid();
            
            Huy();
            
        }//end


        /// <summary>
        /// Xử lí button chỉnh sửa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ChinhSua_Click(object sender, EventArgs e)
        {
            enablebtn(true);
            enableText(true);
            enablecbo(true);
            flag_sua = true;
            txt_TenVietTat.Enabled = false;
            
        }//end

        /// <summary>
        /// Xử lí button "hủy bỏ"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_huy_Click(object sender, EventArgs e)
        {
            Huy();
            focus();
        }//end



        /// <summary>
        /// lấy dữ liệu từ datagrid vào textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grd_PhongBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            focus();
            btn_ChinhSua.Enabled = true;
            if (grd_PhongBan.CurrentRow.Cells["LoaiPhongBan"].Value.ToString().Contains("Thu ngân") || grd_PhongBan.CurrentRow.Cells["LoaiPhongBan"].Value.ToString().Contains("Thu Ngân"))
            {
                btn_Xemchitiêt.Visible = true;
            }
            else
            {
                btn_Xemchitiêt.Visible = false;
            }


           
        }//end

        /// <summary>
        /// Xử lí số thứ tự trong data grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grd_PhongBan_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < grd_PhongBan.RowCount; i++)
            {
                grd_PhongBan.Rows[i].Cells["STT"].Value = Convert.ToString(i + 1);
            }
        }//end


        /// <summary>
        /// xử lí tìm kiếm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            grd_PhongBan.DataSource = BL.QuanTriHeThong.Department_BL.SearchDepart(txt_TimKiem.Text);
            lbl_KetQua.Text = "Kết quả: tìm được " + grd_PhongBan.DisplayedRowCount(true) + " trong tổng số " + totalcount.ToString() + " phòng ban";
        }

        private void cbo_LocTheoLoaiPhongBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_TimKiem.Text == null || txt_TimKiem.Text == "")
            {
                if (cbo_LocTheoLoaiPhongBan.SelectedIndex >= 0)
                {
                    grd_PhongBan.DataSource = Department_BL.SearchDistrByDeparttype(cbo_LocTheoLoaiPhongBan.SelectedValue.ToString());
                    if (grd_PhongBan.DisplayedRowCount(true) > 0)
                    {
                        lbl_KetQua.Text = "Kết quả: tìm được " + grd_PhongBan.DisplayedRowCount(true) + " trong tổng số " + totalcount + " phòng ban";
                    }
                }
            }
            else
            {
                if (cbo_LocTheoLoaiPhongBan.SelectedIndex >= 0)
                {
                    if (grd_PhongBan.DisplayedRowCount(true) > 0)
                    {
                        grd_PhongBan.DataSource = BL.QuanTriHeThong.Department_BL.SearchDepartByBoth(txt_TimKiem.Text, cbo_LocTheoLoaiPhongBan.SelectedValue.ToString());
                        lbl_KetQua.Text = "Kết quả: tìm được " + grd_PhongBan.DisplayedRowCount(true) + " trong tổng số " + totalcount + " phòng ban";
                    }
                }
            }
        }

        private void btn_Xemchitiêt_Click(object sender, EventArgs e)
        {
            string id = grd_PhongBan.CurrentRow.Cells["TenVietTat"].Value.ToString();
            frm_ViewDetailDepartment viewdetail = new frm_ViewDetailDepartment(id);
            viewdetail.ShowDialog();
        }//end


       
    }
}//end calss
