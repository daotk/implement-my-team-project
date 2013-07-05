using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DA.BaoCao;
using DO.BaoCao;
using BL.BaoCao;

namespace GUI.BaoCao
{
    public partial class frm_CreatedBillFollowStaff : Form
    {
        public frm_CreatedBillFollowStaff()
        {
            InitializeComponent();
        }


        private void dp_TuNgay_MonthCalendar_DateChanged(object sender, EventArgs e)
        {
            dp_DenNgay.Value.AddDays(7);
        }

        private void rad_TheoNgay_CheckedChanged(object sender, EventArgs e)
        {

            if (rad_TheoNgay.Checked == true)
            {
                dp_TuNgay.Visible = true;
                dp_DenNgay.Visible = false;
                lbl_TuNgay.Visible = true;
                lbl_DenNgay.Visible = false;
                lbl_ChonThang.Visible = false;
                cbo_Thang.Visible = false;
            }
            else
            {
                dp_TuNgay.Visible = false;
                dp_DenNgay.Visible = true;
                lbl_TuNgay.Visible = false;
                lbl_DenNgay.Visible = true;
                lbl_ChonThang.Visible = true;
                cbo_Thang.Visible = true;
            }

        }
        private void rad_TheoTuan_CheckedChanged(object sender, EventArgs e)
        {

            if (rad_TheoTuan.Checked == true)
            {
                dp_TuNgay.Visible = true;
                dp_DenNgay.Visible = true;
                dp_DenNgay.Enabled = false;
                lbl_TuNgay.Visible = true;
                lbl_DenNgay.Visible = true;
                lbl_ChonThang.Visible = false;
                cbo_Thang.Visible = false;
            }
            else
            {
                dp_TuNgay.Visible = true;
                dp_DenNgay.Visible = false;
                dp_DenNgay.Enabled = true;
                lbl_TuNgay.Visible = true;
                lbl_DenNgay.Visible = false;
                lbl_ChonThang.Visible = false;
                cbo_Thang.Visible = false;
            }

        }


        private void rad_TheoThang_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_TheoThang.Checked == true)
            {
                dp_TuNgay.Visible = false;
                dp_DenNgay.Visible = false;
                lbl_TuNgay.Visible = false;
                lbl_DenNgay.Visible = false;
                lbl_ChonThang.Visible = true;
                cbo_Thang.Visible = true;
            }
            else
            {
                dp_TuNgay.Visible = true;
                dp_DenNgay.Visible = true;
                lbl_TuNgay.Visible = true;
                lbl_DenNgay.Visible = true;
                lbl_ChonThang.Visible = false;
                cbo_Thang.Visible = false;
            }
        }
        private void dp_TuNgay_ValueChanged(object sender, EventArgs e)
        {
            if (rad_TheoTuan.Checked == true)
            {
                dp_DenNgay.Value = dp_TuNgay.Value.AddDays(7);
            }
        }

        public void loadDatagrid()
        {
            CreateBill_BL bill = new CreateBill_BL();
            grd_BaoCao.DataSource = bill.GetAllBill();
        }

        private void frm_CreatedBillFollowStaff_Load(object sender, EventArgs e)
        {
            loadDatagrid();
        }

       




    }
}
