using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL.QuanTriHeThong;
using DA.QuanTriHeThong;
using DO;

namespace GUI
{
    public partial class PhanQuyen : Form
    {
        public PhanQuyen()
        {
            InitializeComponent();
     
        }
        private static string IDindex = "";
        private static string result = "";
        private void HandleOnTreeViewAfterCheck(Object sender,TreeViewEventArgs e)
        {
            CheckTreeViewNode(e.Node, e.Node.Checked);
        }

        private void CheckTreeViewNode(TreeNode node, Boolean isChecked)
        {
            foreach (TreeNode item in node.Nodes)
            {
                item.Checked = isChecked;

                if (item.Nodes.Count > 0)
                {
                    this.CheckTreeViewNode(item, isChecked);
                }
            }
        }

        private void PhanQuyen_Load(object sender, EventArgs e)
        {
            LoadDSUserGroup();
        }
        //Load List User Group
        private void LoadDSUserGroup()
        {
            grd_NhomNguoiDung.DataSource = BL.QuanTriHeThong.UserGroup_BL.GetAllUsserGroup();
            for (int i = 0; i < grd_NhomNguoiDung.Rows.Count; i++)
            {
                grd_NhomNguoiDung.Rows[i].Cells[0].Value = i + 1;
            }
        }
        //Select item of datagridview
        private void grd_NhomNguoiDung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IDindex = "";
            btn_Luu.Enabled = true;
            btn_Huy.Enabled = true;
            IDindex = IDindex + grd_NhomNguoiDung.CurrentRow.Cells[1].Value.ToString();
            List<DO.QuanTriHeThong.UserGroup_DO> array = BL.QuanTriHeThong.UserGroup_BL.LoadAuthorization(IDindex);
            LoadQuyen(array[0].author_);
            txt_TenVietTac.Text = grd_NhomNguoiDung.CurrentRow.Cells["TenVietTat"].Value.ToString() ;
            txt_NhomNguoiDung.Text = grd_NhomNguoiDung.CurrentRow.Cells["NhomNguoiDung"].Value.ToString();
            txt_MoTa.Text = grd_NhomNguoiDung.CurrentRow.Cells["Mota"].Value.ToString();


        }
       //Load Authorization from db
        private void LoadQuyen(string chuoiquyen) {
            if (chuoiquyen[0].ToString() == "1")
            {
                trv_PhanQuyen.Nodes[0].Nodes[0].Checked = true;
            }
            else
            {
                trv_PhanQuyen.Nodes[0].Nodes[0].Checked = false;
            }

            if (chuoiquyen[1].ToString() == "1")
            {
                trv_PhanQuyen.Nodes[1].Nodes[0].Checked = true;
            }
            else
            {
                trv_PhanQuyen.Nodes[1].Nodes[0].Checked = false;
            }

            if (chuoiquyen[2].ToString() == "1")
            {
                trv_PhanQuyen.Nodes[1].Nodes[1].Checked = true;
            }
            else
            {
                trv_PhanQuyen.Nodes[1].Nodes[1].Checked = false;
            }

            if (chuoiquyen[3].ToString() == "1")
            {
                trv_PhanQuyen.Nodes[1].Nodes[2].Checked = true;
            }
            else
            {
                trv_PhanQuyen.Nodes[1].Nodes[2].Checked = false;
            }

            if (chuoiquyen[4].ToString() == "1")
            {
                trv_PhanQuyen.Nodes[1].Nodes[3].Checked = true;
            }
            else
            {
                trv_PhanQuyen.Nodes[1].Nodes[3].Checked = false;
            }

            if (chuoiquyen[5].ToString() == "1")
            {
                trv_PhanQuyen.Nodes[1].Nodes[4].Checked = true;
            }
            else
            {
                trv_PhanQuyen.Nodes[1].Nodes[4].Checked = false;
            }

            if (chuoiquyen[6].ToString() == "1")
            {
                trv_PhanQuyen.Nodes[1].Nodes[5].Checked = true;
            }
            else
            {
                trv_PhanQuyen.Nodes[1].Nodes[5].Checked = false;
            }

            if (chuoiquyen[7].ToString() == "1")
            {
                trv_PhanQuyen.Nodes[1].Nodes[6].Checked = true;
            }
            else
            {
                trv_PhanQuyen.Nodes[1].Nodes[6].Checked = false;
            }

            if (chuoiquyen[8].ToString() == "1")
            {
                trv_PhanQuyen.Nodes[1].Nodes[7].Checked = true;
            }
            else
            {
                trv_PhanQuyen.Nodes[1].Nodes[7].Checked = false;
            }

            if (chuoiquyen[9].ToString() == "1")
            {
                trv_PhanQuyen.Nodes[2].Checked = true;
            }
            else
            {
                trv_PhanQuyen.Nodes[2].Checked = false;
            }

            if (chuoiquyen[10].ToString() == "1")
            {
                trv_PhanQuyen.Nodes[3].Nodes[0].Checked = true;
            }
            else
            {
                trv_PhanQuyen.Nodes[3].Nodes[0].Checked = false;
            }

            if (chuoiquyen[11].ToString() == "1")
            {
                trv_PhanQuyen.Nodes[3].Nodes[1].Checked = true;
            }
            else
            {
                trv_PhanQuyen.Nodes[3].Nodes[1].Checked = false;
            }

            if (chuoiquyen[12].ToString() == "1")
            {
                trv_PhanQuyen.Nodes[3].Nodes[2].Checked = true;
            }
            else
            {
                trv_PhanQuyen.Nodes[3].Nodes[2].Checked = false;
            }

            if (chuoiquyen[13].ToString() == "1")
            {
                trv_PhanQuyen.Nodes[3].Nodes[3].Checked = true;
            }
            else
            {
                trv_PhanQuyen.Nodes[3].Nodes[3].Checked = false;
            }
            
        }
        //Set atuhorization
        private string  PhanQuyen1( string chuoi) {
            chuoi = "";
            if (trv_PhanQuyen.Nodes[0].Nodes[0].Checked == true)
            {
                chuoi = chuoi + "1";
            }else {
                chuoi = chuoi + "0";
            }
            if (trv_PhanQuyen.Nodes[1].Nodes[0].Checked == true)
            {
                chuoi = chuoi + "1";
            }else{
                chuoi = chuoi + "0";
            }
            if (trv_PhanQuyen.Nodes[1].Nodes[1].Checked == true)
            {
                chuoi = chuoi + "1";
            }else{
                chuoi = chuoi + "0";
            }
            if (trv_PhanQuyen.Nodes[1].Nodes[2].Checked == true)
            {
                chuoi = chuoi + "1";
            } else{
                chuoi = chuoi + "0";
            }
            if (trv_PhanQuyen.Nodes[1].Nodes[3].Checked == true)
            {
                chuoi = chuoi + "1";
            }else{
                chuoi = chuoi + "0";
            }
            if (trv_PhanQuyen.Nodes[1].Nodes[4].Checked == true)
            {
                chuoi = chuoi + "1";
            } else {
                chuoi = chuoi + "0";
            }
            if (trv_PhanQuyen.Nodes[1].Nodes[5].Checked == true)
            {
                chuoi = chuoi + "1";
            } else{
                chuoi = chuoi + "0";
            }
            if (trv_PhanQuyen.Nodes[1].Nodes[6].Checked == true)
            {
                chuoi = chuoi + "1";
            }else {
                chuoi = chuoi + "0";
            }
            if (trv_PhanQuyen.Nodes[1].Nodes[7].Checked == true)
            {
                chuoi = chuoi + "1";
            }else{
                chuoi = chuoi + "0";
            }
            if (trv_PhanQuyen.Nodes[2].Checked == true)
            {
                chuoi = chuoi + "1";
            } else {
                chuoi = chuoi + "0";
            }
            if (trv_PhanQuyen.Nodes[3].Nodes[0].Checked == true)
            {
                chuoi = chuoi + "1";
            }else{
                chuoi = chuoi + "0";
            }
            if (trv_PhanQuyen.Nodes[3].Nodes[1].Checked == true)
            {
                chuoi = chuoi + "1";
            }else{
                chuoi = chuoi + "0";
            }
            if (trv_PhanQuyen.Nodes[3].Nodes[2].Checked == true)
            {
                chuoi = chuoi + "1";
            }else{
                chuoi = chuoi + "0";
            }
            if (trv_PhanQuyen.Nodes[3].Nodes[3].Checked == true)
            {
                chuoi = chuoi + "1";
            }else {
                chuoi = chuoi + "0";
            }
            return chuoi;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            BL.QuanTriHeThong.UserGroup_BL.EditAuthorization(IDindex, PhanQuyen1(result));
            MessageBox.Show("Phân Quyền Thành Công");
            IDindex = "";
            result = "";
            btn_Luu.Enabled = false;
            btn_Huy.Enabled = false;
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            IDindex = "";
            result = "";
            btn_Luu.Enabled = false;
            btn_Huy.Enabled = false;
            trv_PhanQuyen.Nodes[0].Nodes[0].Checked = false;
            trv_PhanQuyen.Nodes[1].Nodes[0].Checked = false;
            trv_PhanQuyen.Nodes[1].Nodes[1].Checked = false;
            trv_PhanQuyen.Nodes[1].Nodes[2].Checked = false;
            trv_PhanQuyen.Nodes[1].Nodes[3].Checked = false;
            trv_PhanQuyen.Nodes[1].Nodes[4].Checked = false;
            trv_PhanQuyen.Nodes[1].Nodes[5].Checked = false;
            trv_PhanQuyen.Nodes[1].Nodes[6].Checked = false;
            trv_PhanQuyen.Nodes[1].Nodes[7].Checked = false;
            trv_PhanQuyen.Nodes[2].Checked = false;
            trv_PhanQuyen.Nodes[3].Nodes[0].Checked = false;
            trv_PhanQuyen.Nodes[3].Nodes[1].Checked = false;
            trv_PhanQuyen.Nodes[3].Nodes[2].Checked = false;
            trv_PhanQuyen.Nodes[3].Nodes[3].Checked = false;
        }





    }
}
