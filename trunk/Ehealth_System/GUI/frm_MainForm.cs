using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using log4net;

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
        string madonvi = "";
        bool tabnhaplieu = false;
        bool tabthungan = false;
     
        public frm_MainForm()
        {
            InitializeComponent();
        }
        private static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        /// <summary>
        /// Load Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Load(object sender, EventArgs e)
        {
            lbl_TenBenhVien.Text = "Bệnh Viện ABC";
            lbl_UserName.Text = "Ngưởi dùng: " + BL.StaticClass.UserName + " ("+BL.StaticClass.GroupUser+")";
            lbl_NgayThang.Text ="Ngày tháng: "+ DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString();
            lbl_NgayGio.Text ="Giờ: "+ DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString();
            SetAuthorization(BL.StaticClass.Authorization);
            timer1.Start();
           
            //Load don vi
            List<DO.ThuNgan.Department_TN_DO> ds = BL.ThuNgan.Department_TN_BL.GetAllDepart();
            for (int i = 0; i < ds.Count(); i++)
            {
                if(ds[i]._DEPARTMENTTYPEID.Contains("TN"))
                {                
                    RibbonButton btn = new RibbonButton();
                    btn.Text = ds[i]._DEPARTMENTNAME.ToString();
                    cbo_ChonDonVi.DropDownItems.Add(btn);
                }
            }
           

        }

        private void cbo_ChonDonVi_TextBoxTextChanged(object sender, EventArgs e)
        {
            cbo_ChonBan.DropDownItems.Clear();
            List<DO.ThuNgan.Desk_DO> ds = BL.ThuNgan.Desk_BL.GetAllDesk();
            for (int i = 0; i < ds.Count(); i++)
            {
                if (ds[i]._DEPARTMENTNAME.Contains(cbo_ChonDonVi.SelectedItem.Text))
                {      
                    RibbonButton btn = new RibbonButton();
                    btn.Text = ds[i]._DESKNAME;
                    cbo_ChonBan.DropDownItems.Add(btn);
                }
            }

        }

        private void cbo_ChonBan_TextBoxTextChanged(object sender, EventArgs e)
        {
            List<DO.ThuNgan.Desk_DO> ds = BL.ThuNgan.Desk_BL.GetDesk(cbo_ChonBan.SelectedItem.Text);
            for (int i = 0; i < ds.Count(); i++)
            {
                //thu ngan
                if (ds[i]._CASHIER == false)
                {
                    chk_ThuNgan.Enabled = true;
                }
                else
                {
                    if (ds[i]._CASHIER == true)
                    {
                        chk_ThuNgan.Enabled = false;
                    }

                }
                //nhap lieu
                if (ds[i]._TYPIST == false)
                {
                    chk_NhapLieu.Enabled = true;
                }
                else
                {
                    if (ds[i]._TYPIST == true)
                    {
                        chk_NhapLieu.Enabled = false;
                    }

                }
              
            }

        }

        private void LoadHospitalName()
        {
            lbl_TenBenhVien.Text = BL.StaticClass.tenbenhvien;
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
            logger.Info(BL.StaticClass.UserName + " Has to Group User catalog");
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
            logger.Info(BL.StaticClass.UserName + " Has to User catalog");
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
            logger.Info(BL.StaticClass.UserName + " Has to Province - City catalog");
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
            logger.Info(BL.StaticClass.UserName + " Has to District catalog");
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
            logger.Info(BL.StaticClass.UserName + " Has to Group Departments catalog");
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
            logger.Info(BL.StaticClass.UserName + " Has to Departments catalog");
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
            logger.Info(BL.StaticClass.UserName + " Has to Group Service catalog");
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
            logger.Info(BL.StaticClass.UserName + " Has to Service catalog");
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
            logger.Info(BL.StaticClass.UserName + " Đã vào thống ke danh sach bien lai duoc lap");
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
            logger.Info(BL.StaticClass.UserName + " Đã vào thống ke danh sach bien lai thu tiền");
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
            logger.Info(BL.StaticClass.UserName + " Đã vào thống ke danh sach bien lai duoc thu tien theo nhóm");
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

      /// <summary>
      /// Thông kê doanh thu
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
        private void btn_DoanhThu_Click(object sender, EventArgs e)
        {
            logger.Info(BL.StaticClass.UserName + " Đã vào thống ke doanh thu");
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
            if (config.ShowDialog() == DialogResult.Cancel || config.ShowDialog() == DialogResult.OK)
            {
                LoadHospitalName();
            }
        }

        /// <summary>
        /// Đăng xuất
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(" Bạn có chắc là đăng xuất khỏi chương trình không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                frm_Login login = new frm_Login();
                login.Show();
                logger.Info("  Has to Logout");
            }
            
        }

        private void frm_MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult result = MessageBox.Show(" Bạn có chắc là đăng xuất khỏi chương trình không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                frm_Login login = new frm_Login();
                login.Show();
                logger.Info("  Has to Logout");
            }
            else
            {
                Application.Exit();

            }
           
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

        /// <summary>
        /// tab remove
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControl1_TabRemoved(object sender, EventArgs e)
        {
            if (tabnhaplieu == true)
            {
                BL.ThuNgan.Desk_BL.UpdateTypistInfo(cbo_ChonBan.SelectedItem.Text, false);
                tabnhaplieu = false;
            }

            if (tabthungan == true)
            {
                tabthungan = false;
                BL.ThuNgan.Desk_BL.UpdateCashierInfo(cbo_ChonBan.SelectedItem.Text, false);
            }
            
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
            if (chk_NhapLieu.Checked == true && chk_NhapLieu.Enabled == true && checkTab(thungan1)==false)
            {
                if (checkTab(nhaplieu1) == false)
                {
                    MoGiaoDienNhapLieu();
                    BL.ThuNgan.Desk_BL.UpdateTypistInfo(cbo_ChonBan.SelectedItem.Text.ToString(), true);
                    tabnhaplieu = true;
                    logger.Info("  Has to Cashier");
                }
            }
            else
            {
                if (chk_ThuNgan.Checked == true && chk_ThuNgan.Enabled == true && checkTab(nhaplieu1)==false)
                {
                    if (checkTab(thungan1) == false)
                    {
                        MoGiaoDienThuNgan();
                        BL.ThuNgan.Desk_BL.UpdateCashierInfo(cbo_ChonBan.SelectedItem.Text.ToString(), true);
                        tabthungan = true;
                        logger.Info("  Has to Typist");
                    }
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

        private void SetAuthorization(string authorization) {
            if (authorization[0].ToString() == "0") { btn_CauHinh.Enabled = false; }
            if (authorization[1].ToString() == "0") { btn_NhomNguoiDung.Enabled = false; }
            if (authorization[2].ToString() == "0") { btn_nguoidung.Enabled = false; }
            if (authorization[3].ToString() == "0") { btn_TinhThanhPho.Enabled = false; }
            if (authorization[4].ToString() == "0") { btn_Quan.Enabled = false; }
            if (authorization[5].ToString() == "0") { btn_LoaiPhongBan.Enabled = false; }
            if (authorization[6].ToString() == "0") { btn_PhongBan.Enabled = false; }
            if (authorization[7].ToString() == "0") { btn_NhomDichVu.Enabled = false; }
            if (authorization[8].ToString() == "0") { btn_DichVu.Enabled = false; }
            if (authorization[9].ToString() == "0") { btn_BatDau.Enabled = false; }
            if (authorization[10].ToString() == "0") { btn_BienLaiDuocLap.Enabled = false; }
            if (authorization[11].ToString() == "0") { btn_BienLaiDuocThuTien.Enabled = false; }
            if (authorization[12].ToString() == "0") { btn_DanhSachThuTienTheoNhomDichVu.Enabled = false; }
            if (authorization[13].ToString() == "0") { btn_DoanhThu.Enabled = false; }
        }

      

     

     

       
       

       
       
    }
}
