using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
            frm_MainForm main = new frm_MainForm();
            MessageBox.Show("Cập nhật thành công");
           
            main.nhandata(txt_TenBenhVien.Text);
            main.Show();
            this.Hide();
            }
       

        private void btn_HuyBo_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
 