using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL;
using DA;
using DO;

namespace GUI.QuanTriHeThong
{
    public partial class frm_ViewDetailDepartment : Form
    {
        public string departmentid;
        public frm_ViewDetailDepartment(string id)
        {
            departmentid = id;
            InitializeComponent();
        }

        private void frm_ViewDetailDepartment_Load(object sender, EventArgs e)
        {
            grd_Ban.DataSource = BL.QuanTriHeThong.Desk_BL.GetDesk(departmentid);
        }
    }
}
