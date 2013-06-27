using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL;

namespace GUI
{
    public partial class frm_Config : Form
    {
        public frm_Config()
        {
            InitializeComponent();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cập nhật thành công");

            BL.StaticClass.tenbenhvien = txt_TenBenhVien.Text;   
        }
       

        private void btn_HuyBo_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
 