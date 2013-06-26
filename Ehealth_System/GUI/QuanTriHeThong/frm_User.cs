using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL.QuanTriHeThong;

namespace GUI.QuanTriHeThong
{
    public partial class frm_User : Form
    {
        public frm_User()
        {
            InitializeComponent();
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            PhanQuyen phanquyen = new PhanQuyen();
            phanquyen.ShowDialog();
        }
        /// <summary>
        /// Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frm_User_Load(object sender, EventArgs e)
        {
            grd_User.DataSource = BL.QuanTriHeThong.User_BL.GetUSerInfo().ToList();
            LoadUserInfo();
         
        }

        private void LoadUserInfo()
        {
            
            for (int i = 0; i < grd_User.Rows.Count; i++)
            {
                grd_User.Rows[i].Cells[0].Value = (i + 1).ToString();
            }


           
        }

       
    }
}
