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

namespace GUI.QuanTriHeThong
{
    public partial class frm_GroupUser : Form
    {
        public frm_GroupUser()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Phân quyền
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_PhanQuyen_Click(object sender, EventArgs e)
        {
            PhanQuyen phanquyen = new PhanQuyen();
            phanquyen.ShowDialog();
        }

        private void frm_GroupUser_Load(object sender, EventArgs e)
        {
            grd_NhomnguoiDung.DataSource = BL.QuanTriHeThong.UserGroup_BL.GetAllUsserGroup();
            //STT
            for (int i = 0; i < grd_NhomnguoiDung.Rows.Count; i++) {
                grd_NhomnguoiDung.Rows[i].Cells[0].Value = i + 1;
            }
        }


       
       
    }
}
