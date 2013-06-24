using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace GUI
{
    public partial class frm_MainForm : Form
    {
        string nhomnguoidung = "Nhóm người dùng";
        string nguoidung = "Người dùng";
        string tinhthanhpho = "Danh mục Tỉnh - Thành Phố";
        string quanhuyen = "Danh mục Quận - Huyện";
        string loaiphongban = "Danh muc loại phòng ban";
        string phongban = "Danh mục phòng ban";
        string nhomdichvu = "Danh mục nhóm dịch vụ";
        string dichvu = "Danh mục dịch vụ";
        string bienlaiduoclap = "Danh sách biên lai được lập";
        string bienlaiduocthutien = "Danh sách biên lai được thu tiền";
        string danhsachthutien = "Danh sách thu tiền";
        string doanhthu = "Thống kê doanh thu";
        string nhaplieu1 = "Nhập liệu 1";
        string thungan1 = "Thu ngân 1";
     
        public frm_MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Load(object sender, EventArgs e)
        {
            frm_Login login = new frm_Login();
            lbl_UserName.Text = "Ngưởi dùng: " + login.username + "(Quản trị)";
            lbl_TenBenhVien.Text ="Bệnh viện ABC";
            lbl_NgayThang.Text ="Ngày tháng: "+ DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString();
            lbl_NgayGio.Text ="Giờ: "+ DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString();
            timer1.Start();      
        }

        /// <summary>
        /// about me
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cảm ơn bạn đã sử dụng phần mềm của chúng tôi.\nNếu có gặp khó khăn trong quá trình sử dụng các bạn có thể liên lạc với chúng tôi qua mail: team02k16t01@googlegroup.com.\nDH Văn Lang\nK16T01\nTeam 02");
        }

        /// <summary>
        /// nut chang pass
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Changepass_Click(object sender, EventArgs e)
        {
            ChangePassword changepass = new ChangePassword();
            changepass.ShowDialog();
        }


        /// <summary>
        /// nhóm người dùng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_NhomNguoiDung_Click(object sender, EventArgs e)
        {

            if (checkTab(nhomnguoidung) == false)
            {
                tab_MainTab.Visible = true;
                TabItem t = tab_MainTab.CreateTab(nhomnguoidung);
                QuanTriHeThong.frm_GroupUser k = new QuanTriHeThong.frm_GroupUser();
                k.TopLevel = false;
                k.Dock = DockStyle.Fill;
                t.AttachedControl.Controls.Add(k);
                k.Show();
                tab_MainTab.SelectedTabIndex = tab_MainTab.Tabs.Count - 1;
                pic_Bacground.Visible = false;
            }
        }

       
        /// <summary>
        /// Nguoi dung
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_nguoidung_Click(object sender, EventArgs e)
        {
            if (checkTab(nguoidung) == false)
            {
                tab_MainTab.Visible = true;
                TabItem t = tab_MainTab.CreateTab(nguoidung);
                QuanTriHeThong.frm_User k = new QuanTriHeThong.frm_User();
                k.TopLevel = false;
                k.Dock = DockStyle.Fill;
                t.AttachedControl.Controls.Add(k);
                k.Show();
                tab_MainTab.SelectedTabIndex = tab_MainTab.Tabs.Count - 1;
                pic_Bacground.Visible = false;
            }
        }


        /// <summary>
        /// danh muc tinh thanh pho
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_TinhThanhPho_Click(object sender, EventArgs e)
        {
            tab_MainTab.Visible = true;
            if(checkTab(tinhthanhpho) == false){
            TabItem t = tab_MainTab.CreateTab(tinhthanhpho);
            QuanTriHeThong.frm_City k = new QuanTriHeThong.frm_City();
            k.TopLevel = false;
            k.Dock = DockStyle.Fill;
            t.AttachedControl.Controls.Add(k);
            k.Show();
            tab_MainTab.SelectedTabIndex = tab_MainTab.Tabs.Count - 1;
            pic_Bacground.Visible = false;
            }
        }
        /// <summary>
        /// danh muc quan huyen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_QuanHuyen_Click(object sender, EventArgs e)
        {
            if (checkTab(quanhuyen) == false)
            {
                tab_MainTab.Visible = true;
                TabItem t = tab_MainTab.CreateTab(quanhuyen);
                QuanTriHeThong.frm_District k = new QuanTriHeThong.frm_District();
                k.TopLevel = false;
                k.Dock = DockStyle.Fill;
                t.AttachedControl.Controls.Add(k);
                k.Show();
                tab_MainTab.SelectedTabIndex = tab_MainTab.Tabs.Count - 1;
                pic_Bacground.Visible = false;
            }
        }

        private void btn_LoaiPhongBan_Click(object sender, EventArgs e)
        {
            if (checkTab(loaiphongban) == false)
            {
                tab_MainTab.Visible = true;
                TabItem t = tab_MainTab.CreateTab(loaiphongban);
                QuanTriHeThong.frm_TypeDepartment k = new QuanTriHeThong.frm_TypeDepartment();
                k.TopLevel = false;
                k.Dock = DockStyle.Fill;
                t.AttachedControl.Controls.Add(k);
                k.Show();
                tab_MainTab.SelectedTabIndex = tab_MainTab.Tabs.Count - 1;
                pic_Bacground.Visible = false;
            }
        }


        private void btn_PhongBan1_Click(object sender, EventArgs e)
        {
            if (checkTab(phongban) == false)
            {
                tab_MainTab.Visible = true;
                TabItem t = tab_MainTab.CreateTab(phongban);
                QuanTriHeThong.frm_Department k = new QuanTriHeThong.frm_Department();
                k.TopLevel = false;
                k.Dock = DockStyle.Fill;
                t.AttachedControl.Controls.Add(k);
                k.Show();
                tab_MainTab.SelectedTabIndex = tab_MainTab.Tabs.Count - 1;
                pic_Bacground.Visible = false;
            }
        }

        private void btn_LoaiDichVu_Click(object sender, EventArgs e)
        {
            if (checkTab(nhomdichvu) == false)
            {
                tab_MainTab.Visible = true;
                TabItem t = tab_MainTab.CreateTab(nhomdichvu);
                QuanTriHeThong.frm_TypeService k = new QuanTriHeThong.frm_TypeService();
                k.TopLevel = false;
                k.Dock = DockStyle.Fill;
                t.AttachedControl.Controls.Add(k);
                k.Show();
                tab_MainTab.SelectedTabIndex = tab_MainTab.Tabs.Count - 1;
                pic_Bacground.Visible = false;
            }
        }

        private void btn_dichvu_Click(object sender, EventArgs e)
        {
            if (checkTab(dichvu) == false)
            {
                tab_MainTab.Visible = true;
                TabItem t = tab_MainTab.CreateTab(dichvu);
                QuanTriHeThong.frm_Service k = new QuanTriHeThong.frm_Service();
                k.TopLevel = false;
                k.Dock = DockStyle.Fill;
                t.AttachedControl.Controls.Add(k);
                k.Show();
                tab_MainTab.SelectedTabIndex = tab_MainTab.Tabs.Count - 1;
                pic_Bacground.Visible = false;
            }
        }
        /// <summary>
        /// bien lai duoc lap
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_BienLaiDuocLap_Click(object sender, EventArgs e)
        {
            if (checkTab(bienlaiduoclap) == false)
            {
                tab_MainTab.Visible = true;
                TabItem t = tab_MainTab.CreateTab(bienlaiduoclap);
                BaoCao.frm_CreatedBillFollowStaff k = new BaoCao.frm_CreatedBillFollowStaff();
                k.TopLevel = false;
                k.Dock = DockStyle.Fill;
                t.AttachedControl.Controls.Add(k);
                k.Show();
                tab_MainTab.SelectedTabIndex = tab_MainTab.Tabs.Count - 1;
                pic_Bacground.Visible = false;
            }
        }
        /// <summary>
        /// Bien lai duoc thu tien
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_BienLaiDuocThuTien_Click(object sender, EventArgs e)
        {
            if (checkTab(bienlaiduocthutien) == false)
            {
                tab_MainTab.Visible = true;
                TabItem t = tab_MainTab.CreateTab(bienlaiduocthutien);
                BaoCao.DSBienLaiDuocThuTien k = new BaoCao.DSBienLaiDuocThuTien();
                k.TopLevel = false;
                k.Dock = DockStyle.Fill;
                t.AttachedControl.Controls.Add(k);
                k.Show();
                tab_MainTab.SelectedTabIndex = tab_MainTab.Tabs.Count - 1;
                pic_Bacground.Visible = false;
            }

        }
        /// <summary>
        /// DS thi tien
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_DanhSachThuTienTheoNhomDichVu_Click(object sender, EventArgs e)
        {
            if (checkTab(danhsachthutien) == false)
            {
                tab_MainTab.Visible = true;
                TabItem t = tab_MainTab.CreateTab(danhsachthutien);
                BaoCao.frm_ListBill k = new BaoCao.frm_ListBill();
                k.TopLevel = false;
                k.Dock = DockStyle.Fill;
                t.AttachedControl.Controls.Add(k);
                k.Show();
                tab_MainTab.SelectedTabIndex = tab_MainTab.Tabs.Count - 1;
                pic_Bacground.Visible = false;
            }
        }

      
        private void btn_DoanhThu_Click(object sender, EventArgs e)
        {
            if (checkTab(doanhthu) == false)
            {
                tab_MainTab.Visible = true;
                TabItem t = tab_MainTab.CreateTab(doanhthu);
                BaoCao.DoanhThu k = new BaoCao.DoanhThu();
                k.TopLevel = false;
                k.Dock = DockStyle.Fill;
                t.AttachedControl.Controls.Add(k);
                k.Show();
                tab_MainTab.SelectedTabIndex = tab_MainTab.Tabs.Count - 1;
                pic_Bacground.Visible = false;
            }
        }

     

        /// <summary>
        /// cấu hình
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_CauHinh_Click(object sender, EventArgs e)
        {
            frm_Config config = new frm_Config();
            config.ShowDialog();
        }


        private bool checkTab(string name)
        {
            for (int i = 0; i < tab_MainTab.Tabs.Count; i++)
            {
                if (tab_MainTab.Tabs[i].Text == name)
                {
                    tab_MainTab.SelectedTabIndex = i;
                    return true;
                }
            }
            return false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {



            lbl_NgayGio.Text = "Giờ: " + DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString();
        }

        private void tabControl1_TabItemClose(object sender, TabStripActionEventArgs e)
        {
            if (tab_MainTab.Tabs.Count == 1)
            {
                tab_MainTab.Visible = false;
                pic_Bacground.Visible = true;

            }
        }

        private void ribbonButton4_Click(object sender, EventArgs e)
        {
            if (checkTab(nhaplieu1) == true )
            {
                MessageBox.Show("Bạn đang ở trong nhập liệu bàn 1. Bạn không thể tham gia vào nhập liệu bàn 2","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
            if (checkTab(thungan1) == true)
            {
                MessageBox.Show("Bạn đang ở trong thu ngân bàn 1. Bạn không thể tham gia vào nhập liệu bàn 2", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void ribbonButton5_Click(object sender, EventArgs e)
        {
            if (checkTab(nhaplieu1) == true)
            {
                MessageBox.Show("Bạn đang ở trong nhập liệu bàn 1. Bạn không thể tham gia vào thu ngân bàn 2", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            if (checkTab(thungan1) == true)
            {
                MessageBox.Show("Bạn đang ở trong thu ngân bàn 1. Bạn không thể tham gia vào thu ngân bàn 2", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        /// <summary>
        /// tab remove
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControl1_TabRemoved(object sender, EventArgs e)
        {
            if (tab_MainTab.Tabs.Count == 0)
            {
                pic_Bacground.Visible = true;
                tab_MainTab.Visible = false;
            }
        }
        /// <summary>
        /// dau thu lam viec
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_BatDau_Click(object sender, EventArgs e)
        {
            if (chk_ThuNgan.Checked == true)
            {
                if (checkTab(nhaplieu1) == false)
                {
                    MoGiaoDienThuNgan();
                }
                else
                {
                    MessageBox.Show("Bạn đang mở giao diện nhập liệu. Bạn phải tắt giao diện nhập liệu để tiếp tục");
                }
            }
            if (chk_NhapLieu.Checked == true)
            {
                if (checkTab(thungan1) == false)
                {
                    MoGiaoDienNhapLieu();
                }
                else
                {
                    MessageBox.Show("Bạn đang mở giao diện thu ngân. Bạn phải tắt giao diện thu ngân để tiếp tục");
                }
            }
        }//end event button start



        private void MoGiaoDienNhapLieu()
        {
                if (checkTab(nhaplieu1) == false)
                {
                    tab_MainTab.Visible = true;
                    TabItem t = tab_MainTab.CreateTab(nhaplieu1);
                    ThuNgan.frm_InputData k = new ThuNgan.frm_InputData();
                    k.TopLevel = false;
                    k.Dock = DockStyle.Fill;
                    t.AttachedControl.Controls.Add(k);
                    k.Show();
                    tab_MainTab.SelectedTabIndex = tab_MainTab.Tabs.Count - 1;
                    pic_Bacground.Visible = false;
                }
        }

        private void MoGiaoDienThuNgan()
        {
                if (checkTab(thungan1) == false)
                {
                    tab_MainTab.Visible = true;
                    TabItem t = tab_MainTab.CreateTab(thungan1);
                    ThuNgan.frm_Cashier k = new ThuNgan.frm_Cashier();
                    k.TopLevel = false;
                    k.Dock = DockStyle.Fill;
                    t.AttachedControl.Controls.Add(k);
                    k.Show();
                    tab_MainTab.SelectedTabIndex = tab_MainTab.Tabs.Count - 1;
                    pic_Bacground.Visible = false;
                }
        }

       

       

       
       
    }
}
