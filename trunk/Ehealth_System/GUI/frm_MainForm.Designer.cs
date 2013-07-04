namespace GUI
{
    partial class frm_MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_MainForm));
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.btn_Changepass = new System.Windows.Forms.RibbonButton();
            this.btn_CauHinh = new System.Windows.Forms.RibbonButton();
            this.btn_Logout = new System.Windows.Forms.RibbonButton();
            this.tp_QuanTriHeThong = new System.Windows.Forms.RibbonTab();
            this.pn_NguoiDung = new System.Windows.Forms.RibbonPanel();
            this.btn_NhomNguoiDung = new System.Windows.Forms.RibbonButton();
            this.btn_nguoidung = new System.Windows.Forms.RibbonButton();
            this.bn_TinhThanhPho = new System.Windows.Forms.RibbonPanel();
            this.btn_TinhThanhPho = new System.Windows.Forms.RibbonButton();
            this.btn_Quan = new System.Windows.Forms.RibbonButton();
            this.pn_DanhMucPhongBan = new System.Windows.Forms.RibbonPanel();
            this.btn_LoaiPhongBan = new System.Windows.Forms.RibbonButton();
            this.btn_PhongBan = new System.Windows.Forms.RibbonButton();
            this.pn_DanhMucDichVu = new System.Windows.Forms.RibbonPanel();
            this.btn_NhomDichVu = new System.Windows.Forms.RibbonButton();
            this.btn_DichVu = new System.Windows.Forms.RibbonButton();
            this.tp_ThuNgan = new System.Windows.Forms.RibbonTab();
            this.pn_LamViec = new System.Windows.Forms.RibbonPanel();
            this.btn_BatDau = new System.Windows.Forms.RibbonButton();
            this.ribbonSeparator3 = new System.Windows.Forms.RibbonSeparator();
            this.chk_ThuNgan = new System.Windows.Forms.RibbonCheckBox();
            this.chk_NhapLieu = new System.Windows.Forms.RibbonCheckBox();
            this.ribbonSeparator2 = new System.Windows.Forms.RibbonSeparator();
            this.cbo_ChonBan = new System.Windows.Forms.RibbonComboBox();
            this.cbo_ChonDonVi = new System.Windows.Forms.RibbonComboBox();
            this.tp_BaoCao = new System.Windows.Forms.RibbonTab();
            this.pn_DanhSachBienLai = new System.Windows.Forms.RibbonPanel();
            this.btn_BienLaiDuocLap = new System.Windows.Forms.RibbonButton();
            this.btn_BienLaiDuocThuTien = new System.Windows.Forms.RibbonButton();
            this.btn_DanhSachThuTienTheoNhomDichVu = new System.Windows.Forms.RibbonButton();
            this.pn_DoanhThu = new System.Windows.Forms.RibbonPanel();
            this.btn_DoanhThu = new System.Windows.Forms.RibbonButton();
            this.tp_TroGiop = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel4 = new System.Windows.Forms.RibbonPanel();
            this.btn_Help = new System.Windows.Forms.RibbonButton();
            this.btn_About = new System.Windows.Forms.RibbonButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.lbl_TenBenhVien = new DevComponents.DotNetBar.LabelItem();
            this.lbl_UserName = new DevComponents.DotNetBar.LabelItem();
            this.lbl_NgayThang = new DevComponents.DotNetBar.LabelItem();
            this.lbl_NgayGio = new DevComponents.DotNetBar.LabelItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pic_Bacground = new System.Windows.Forms.PictureBox();
            this.tab_MainTab = new DevComponents.DotNetBar.TabControl();
            this.ribbonButton1 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton2 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton3 = new System.Windows.Forms.RibbonButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Bacground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab_MainTab)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon1
            // 
            this.ribbon1.CaptionBarVisible = false;
            this.ribbon1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Minimized = false;
            this.ribbon1.Name = "ribbon1";
            // 
            // 
            // 
            this.ribbon1.OrbDropDown.BorderRoundness = 8;
            this.ribbon1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.OrbDropDown.MaximumSize = new System.Drawing.Size(160, 250);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.btn_Changepass);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.btn_CauHinh);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.btn_Logout);
            this.ribbon1.OrbDropDown.MinimumSize = new System.Drawing.Size(160, 200);
            this.ribbon1.OrbDropDown.Name = "";
            this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(160, 204);
            this.ribbon1.OrbDropDown.TabIndex = 0;
            this.ribbon1.OrbImage = null;
            this.ribbon1.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2010;
            this.ribbon1.OrbText = "Hệ thống";
            this.ribbon1.PanelCaptionHeight = 20;
            // 
            // 
            // 
            this.ribbon1.QuickAcessToolbar.DropDownButtonVisible = false;
            this.ribbon1.QuickAcessToolbar.Visible = false;
            this.ribbon1.Size = new System.Drawing.Size(1370, 125);
            this.ribbon1.TabIndex = 0;
            this.ribbon1.Tabs.Add(this.tp_QuanTriHeThong);
            this.ribbon1.Tabs.Add(this.tp_ThuNgan);
            this.ribbon1.Tabs.Add(this.tp_BaoCao);
            this.ribbon1.Tabs.Add(this.tp_TroGiop);
            this.ribbon1.TabsMargin = new System.Windows.Forms.Padding(12, 2, 20, 0);
            this.ribbon1.Text = "ribbon1";
            // 
            // btn_Changepass
            // 
            this.btn_Changepass.Image = ((System.Drawing.Image)(resources.GetObject("btn_Changepass.Image")));
            this.btn_Changepass.SmallImage = global::GUI.Properties.Resources.ChangePass1;
            this.btn_Changepass.Text = "Đổi mật khẩu";
            this.btn_Changepass.Click += new System.EventHandler(this.btn_Changepass_Click);
            // 
            // btn_CauHinh
            // 
            this.btn_CauHinh.Image = ((System.Drawing.Image)(resources.GetObject("btn_CauHinh.Image")));
            this.btn_CauHinh.SmallImage = global::GUI.Properties.Resources.config;
            this.btn_CauHinh.Text = "Cấu hình";
            this.btn_CauHinh.Click += new System.EventHandler(this.btn_CauHinh_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.Image = ((System.Drawing.Image)(resources.GetObject("btn_Logout.Image")));
            this.btn_Logout.SmallImage = global::GUI.Properties.Resources.logout1;
            this.btn_Logout.Text = "Đăng xuất";
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // tp_QuanTriHeThong
            // 
            this.tp_QuanTriHeThong.Panels.Add(this.pn_NguoiDung);
            this.tp_QuanTriHeThong.Panels.Add(this.bn_TinhThanhPho);
            this.tp_QuanTriHeThong.Panels.Add(this.pn_DanhMucPhongBan);
            this.tp_QuanTriHeThong.Panels.Add(this.pn_DanhMucDichVu);
            this.tp_QuanTriHeThong.Text = "Quản trị hệ thống";
            // 
            // pn_NguoiDung
            // 
            this.pn_NguoiDung.Items.Add(this.btn_NhomNguoiDung);
            this.pn_NguoiDung.Items.Add(this.btn_nguoidung);
            this.pn_NguoiDung.Text = "Người dùng";
            // 
            // btn_NhomNguoiDung
            // 
            this.btn_NhomNguoiDung.Image = global::GUI.Properties.Resources.GroupUser;
            this.btn_NhomNguoiDung.MinimumSize = new System.Drawing.Size(100, 0);
            this.btn_NhomNguoiDung.SmallImage = ((System.Drawing.Image)(resources.GetObject("btn_NhomNguoiDung.SmallImage")));
            this.btn_NhomNguoiDung.Text = "Nhóm người dùng";
            this.btn_NhomNguoiDung.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center;
            this.btn_NhomNguoiDung.ToolTip = "Bạn có thể tìm kiếm, xem, chỉnh sửa hay ẩn nhóm người dùng ";
            this.btn_NhomNguoiDung.Click += new System.EventHandler(this.btn_NhomNguoiDung_Click);
            // 
            // btn_nguoidung
            // 
            this.btn_nguoidung.Image = global::GUI.Properties.Resources.User;
            this.btn_nguoidung.MinimumSize = new System.Drawing.Size(100, 0);
            this.btn_nguoidung.SmallImage = ((System.Drawing.Image)(resources.GetObject("btn_nguoidung.SmallImage")));
            this.btn_nguoidung.Text = "Người dùng";
            this.btn_nguoidung.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center;
            this.btn_nguoidung.ToolTip = "Bạn có thể tìm kiếm, xem, chỉnh sửa, phân quyền người dùng";
            this.btn_nguoidung.Click += new System.EventHandler(this.btn_nguoidung_Click);
            // 
            // bn_TinhThanhPho
            // 
            this.bn_TinhThanhPho.Items.Add(this.btn_TinhThanhPho);
            this.bn_TinhThanhPho.Items.Add(this.btn_Quan);
            this.bn_TinhThanhPho.Text = "Quận-Tinh Thành";
            // 
            // btn_TinhThanhPho
            // 
            this.btn_TinhThanhPho.Image = global::GUI.Properties.Resources.TinhThanh;
            this.btn_TinhThanhPho.MinimumSize = new System.Drawing.Size(100, 0);
            this.btn_TinhThanhPho.SmallImage = ((System.Drawing.Image)(resources.GetObject("btn_TinhThanhPho.SmallImage")));
            this.btn_TinhThanhPho.Text = "Tỉnh-Thành";
            this.btn_TinhThanhPho.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center;
            this.btn_TinhThanhPho.Click += new System.EventHandler(this.btn_TinhThanhPho_Click);
            // 
            // btn_Quan
            // 
            this.btn_Quan.Image = global::GUI.Properties.Resources.QuanHuyen;
            this.btn_Quan.MinimumSize = new System.Drawing.Size(100, 0);
            this.btn_Quan.SmallImage = ((System.Drawing.Image)(resources.GetObject("btn_Quan.SmallImage")));
            this.btn_Quan.Text = "Quận-Huyện";
            this.btn_Quan.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center;
            this.btn_Quan.ToolTip = "Bạn có thể xem, chỉnh sửa danh mục quận-huyện";
            this.btn_Quan.Click += new System.EventHandler(this.btn_QuanHuyen_Click);
            // 
            // pn_DanhMucPhongBan
            // 
            this.pn_DanhMucPhongBan.Items.Add(this.btn_LoaiPhongBan);
            this.pn_DanhMucPhongBan.Items.Add(this.btn_PhongBan);
            this.pn_DanhMucPhongBan.Text = "Danh mục phòng ban";
            // 
            // btn_LoaiPhongBan
            // 
            this.btn_LoaiPhongBan.Image = global::GUI.Properties.Resources.loaiphongban;
            this.btn_LoaiPhongBan.MinimumSize = new System.Drawing.Size(100, 0);
            this.btn_LoaiPhongBan.SmallImage = ((System.Drawing.Image)(resources.GetObject("btn_LoaiPhongBan.SmallImage")));
            this.btn_LoaiPhongBan.Text = "Loại Phòng ban";
            this.btn_LoaiPhongBan.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center;
            this.btn_LoaiPhongBan.Click += new System.EventHandler(this.btn_LoaiPhongBan_Click);
            // 
            // btn_PhongBan
            // 
            this.btn_PhongBan.Image = global::GUI.Properties.Resources.phongban;
            this.btn_PhongBan.MinimumSize = new System.Drawing.Size(100, 0);
            this.btn_PhongBan.SmallImage = ((System.Drawing.Image)(resources.GetObject("btn_PhongBan.SmallImage")));
            this.btn_PhongBan.Text = "Phòng ban";
            this.btn_PhongBan.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center;
            this.btn_PhongBan.Click += new System.EventHandler(this.btn_PhongBan1_Click);
            // 
            // pn_DanhMucDichVu
            // 
            this.pn_DanhMucDichVu.Items.Add(this.btn_NhomDichVu);
            this.pn_DanhMucDichVu.Items.Add(this.btn_DichVu);
            this.pn_DanhMucDichVu.Text = "Danh muc dich vụ";
            // 
            // btn_NhomDichVu
            // 
            this.btn_NhomDichVu.Image = global::GUI.Properties.Resources.nhomdichvu;
            this.btn_NhomDichVu.MinimumSize = new System.Drawing.Size(100, 0);
            this.btn_NhomDichVu.SmallImage = ((System.Drawing.Image)(resources.GetObject("btn_NhomDichVu.SmallImage")));
            this.btn_NhomDichVu.Text = "Nhóm dịch vụ";
            this.btn_NhomDichVu.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center;
            this.btn_NhomDichVu.Click += new System.EventHandler(this.btn_LoaiDichVu_Click);
            // 
            // btn_DichVu
            // 
            this.btn_DichVu.Image = global::GUI.Properties.Resources.dichvu;
            this.btn_DichVu.MinimumSize = new System.Drawing.Size(100, 0);
            this.btn_DichVu.SmallImage = ((System.Drawing.Image)(resources.GetObject("btn_DichVu.SmallImage")));
            this.btn_DichVu.Text = "Dịch vụ";
            this.btn_DichVu.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center;
            this.btn_DichVu.Click += new System.EventHandler(this.btn_dichvu_Click);
            // 
            // tp_ThuNgan
            // 
            this.tp_ThuNgan.Panels.Add(this.pn_LamViec);
            this.tp_ThuNgan.Text = "Thu ngân";
            this.tp_ThuNgan.ToolTip = "";
            // 
            // pn_LamViec
            // 
            this.pn_LamViec.FlowsTo = System.Windows.Forms.RibbonPanelFlowDirection.Left;
            this.pn_LamViec.Items.Add(this.btn_BatDau);
            this.pn_LamViec.Items.Add(this.ribbonSeparator3);
            this.pn_LamViec.Items.Add(this.chk_ThuNgan);
            this.pn_LamViec.Items.Add(this.chk_NhapLieu);
            this.pn_LamViec.Items.Add(this.ribbonSeparator2);
            this.pn_LamViec.Items.Add(this.cbo_ChonBan);
            this.pn_LamViec.Items.Add(this.cbo_ChonDonVi);
            this.pn_LamViec.Text = "Làm việc";
            // 
            // btn_BatDau
            // 
            this.btn_BatDau.Image = global::GUI.Properties.Resources.start;
            this.btn_BatDau.MinimumSize = new System.Drawing.Size(100, 0);
            this.btn_BatDau.SmallImage = ((System.Drawing.Image)(resources.GetObject("btn_BatDau.SmallImage")));
            this.btn_BatDau.Text = "Bắt đầu";
            this.btn_BatDau.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center;
            this.btn_BatDau.Click += new System.EventHandler(this.btn_BatDau_Click);
            // 
            // chk_ThuNgan
            // 
            this.chk_ThuNgan.CheckedGroup = "CongViec";
            this.chk_ThuNgan.Text = "Thu ngân";
            // 
            // chk_NhapLieu
            // 
            this.chk_NhapLieu.CheckedGroup = "CongViec";
            this.chk_NhapLieu.Text = "Nhập liệu";
            // 
            // cbo_ChonBan
            // 
            this.cbo_ChonBan.AllowTextEdit = false;
            this.cbo_ChonBan.DrawIconsBar = false;
            this.cbo_ChonBan.LabelWidth = 100;
            this.cbo_ChonBan.Text = "Chọn bàn";
            this.cbo_ChonBan.TextBoxText = "";
            this.cbo_ChonBan.TextBoxWidth = 150;
            this.cbo_ChonBan.TextBoxTextChanged += new System.EventHandler(this.cbo_ChonBan_TextBoxTextChanged);
            // 
            // cbo_ChonDonVi
            // 
            this.cbo_ChonDonVi.AllowTextEdit = false;
            this.cbo_ChonDonVi.DrawIconsBar = false;
            this.cbo_ChonDonVi.LabelWidth = 100;
            this.cbo_ChonDonVi.Text = "Chọn đơn vị";
            this.cbo_ChonDonVi.TextBoxText = "";
            this.cbo_ChonDonVi.TextBoxWidth = 150;
            this.cbo_ChonDonVi.TextBoxTextChanged += new System.EventHandler(this.cbo_ChonDonVi_TextBoxTextChanged);
            // 
            // tp_BaoCao
            // 
            this.tp_BaoCao.Panels.Add(this.pn_DanhSachBienLai);
            this.tp_BaoCao.Panels.Add(this.pn_DoanhThu);
            this.tp_BaoCao.Text = "Báo cáo";
            // 
            // pn_DanhSachBienLai
            // 
            this.pn_DanhSachBienLai.Items.Add(this.btn_BienLaiDuocLap);
            this.pn_DanhSachBienLai.Items.Add(this.btn_BienLaiDuocThuTien);
            this.pn_DanhSachBienLai.Items.Add(this.btn_DanhSachThuTienTheoNhomDichVu);
            this.pn_DanhSachBienLai.Text = "Danh sách biên lai";
            // 
            // btn_BienLaiDuocLap
            // 
            this.btn_BienLaiDuocLap.Image = ((System.Drawing.Image)(resources.GetObject("btn_BienLaiDuocLap.Image")));
            this.btn_BienLaiDuocLap.MinimumSize = new System.Drawing.Size(100, 50);
            this.btn_BienLaiDuocLap.SmallImage = ((System.Drawing.Image)(resources.GetObject("btn_BienLaiDuocLap.SmallImage")));
            this.btn_BienLaiDuocLap.Text = "Biên lai được lập";
            this.btn_BienLaiDuocLap.Click += new System.EventHandler(this.btn_BienLaiDuocLap_Click);
            // 
            // btn_BienLaiDuocThuTien
            // 
            this.btn_BienLaiDuocThuTien.Image = ((System.Drawing.Image)(resources.GetObject("btn_BienLaiDuocThuTien.Image")));
            this.btn_BienLaiDuocThuTien.MinimumSize = new System.Drawing.Size(100, 50);
            this.btn_BienLaiDuocThuTien.SmallImage = ((System.Drawing.Image)(resources.GetObject("btn_BienLaiDuocThuTien.SmallImage")));
            this.btn_BienLaiDuocThuTien.Text = "Biên lai thu tiền";
            this.btn_BienLaiDuocThuTien.Click += new System.EventHandler(this.btn_BienLaiDuocThuTien_Click);
            // 
            // btn_DanhSachThuTienTheoNhomDichVu
            // 
            this.btn_DanhSachThuTienTheoNhomDichVu.Image = ((System.Drawing.Image)(resources.GetObject("btn_DanhSachThuTienTheoNhomDichVu.Image")));
            this.btn_DanhSachThuTienTheoNhomDichVu.MinimumSize = new System.Drawing.Size(100, 50);
            this.btn_DanhSachThuTienTheoNhomDichVu.SmallImage = ((System.Drawing.Image)(resources.GetObject("btn_DanhSachThuTienTheoNhomDichVu.SmallImage")));
            this.btn_DanhSachThuTienTheoNhomDichVu.Text = "DS thu tiền theo nhóm";
            this.btn_DanhSachThuTienTheoNhomDichVu.Click += new System.EventHandler(this.btn_DanhSachThuTienTheoNhomDichVu_Click);
            // 
            // pn_DoanhThu
            // 
            this.pn_DoanhThu.Items.Add(this.btn_DoanhThu);
            this.pn_DoanhThu.Text = "Doanh thu";
            // 
            // btn_DoanhThu
            // 
            this.btn_DoanhThu.Image = global::GUI.Properties.Resources.baocaodoanhthu;
            this.btn_DoanhThu.MinimumSize = new System.Drawing.Size(100, 50);
            this.btn_DoanhThu.SmallImage = ((System.Drawing.Image)(resources.GetObject("btn_DoanhThu.SmallImage")));
            this.btn_DoanhThu.Text = "Doanh thu theo nhóm";
            this.btn_DoanhThu.Click += new System.EventHandler(this.btn_DoanhThu_Click);
            // 
            // tp_TroGiop
            // 
            this.tp_TroGiop.Panels.Add(this.ribbonPanel4);
            this.tp_TroGiop.Text = "Trợ giúp";
            // 
            // ribbonPanel4
            // 
            this.ribbonPanel4.Items.Add(this.btn_Help);
            this.ribbonPanel4.Items.Add(this.btn_About);
            this.ribbonPanel4.Text = null;
            // 
            // btn_Help
            // 
            this.btn_Help.Image = global::GUI.Properties.Resources.help;
            this.btn_Help.MinimumSize = new System.Drawing.Size(100, 0);
            this.btn_Help.SmallImage = ((System.Drawing.Image)(resources.GetObject("btn_Help.SmallImage")));
            this.btn_Help.Text = "Hướng dẩn sử dụng";
            // 
            // btn_About
            // 
            this.btn_About.Image = global::GUI.Properties.Resources.team;
            this.btn_About.MinimumSize = new System.Drawing.Size(100, 0);
            this.btn_About.SmallImage = ((System.Drawing.Image)(resources.GetObject("btn_About.SmallImage")));
            this.btn_About.Text = "Thông tin";
            this.btn_About.Click += new System.EventHandler(this.btn_About_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bar1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 566);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 25);
            this.panel1.TabIndex = 4;
            // 
            // bar1
            // 
            this.bar1.AntiAlias = true;
            this.bar1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bar1.DockSide = DevComponents.DotNetBar.eDockSide.Bottom;
            this.bar1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.lbl_TenBenhVien,
            this.lbl_UserName,
            this.lbl_NgayThang,
            this.lbl_NgayGio});
            this.bar1.Location = new System.Drawing.Point(0, 0);
            this.bar1.Name = "bar1";
            this.bar1.PaddingTop = 5;
            this.bar1.Size = new System.Drawing.Size(1370, 25);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
            this.bar1.TabIndex = 0;
            this.bar1.TabStop = false;
            this.bar1.Text = "bar1";
            // 
            // lbl_TenBenhVien
            // 
            this.lbl_TenBenhVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenBenhVien.Name = "lbl_TenBenhVien";
            this.lbl_TenBenhVien.PaddingRight = 100;
            this.lbl_TenBenhVien.Text = "Ten benh vien";
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.PaddingRight = 100;
            this.lbl_UserName.Text = "Username";
            // 
            // lbl_NgayThang
            // 
            this.lbl_NgayThang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NgayThang.Name = "lbl_NgayThang";
            this.lbl_NgayThang.PaddingLeft = 200;
            this.lbl_NgayThang.Text = "Ngay thang";
            // 
            // lbl_NgayGio
            // 
            this.lbl_NgayGio.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NgayGio.Name = "lbl_NgayGio";
            this.lbl_NgayGio.PaddingLeft = 100;
            this.lbl_NgayGio.Text = "Ngay  gio";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pic_Bacground);
            this.panel2.Controls.Add(this.tab_MainTab);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1370, 441);
            this.panel2.TabIndex = 5;
            // 
            // pic_Bacground
            // 
            this.pic_Bacground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_Bacground.Image = global::GUI.Properties.Resources.backround2;
            this.pic_Bacground.Location = new System.Drawing.Point(0, 0);
            this.pic_Bacground.Name = "pic_Bacground";
            this.pic_Bacground.Size = new System.Drawing.Size(1370, 441);
            this.pic_Bacground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Bacground.TabIndex = 7;
            this.pic_Bacground.TabStop = false;
            // 
            // tab_MainTab
            // 
            this.tab_MainTab.AutoCloseTabs = true;
            this.tab_MainTab.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tab_MainTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tab_MainTab.CanReorderTabs = true;
            this.tab_MainTab.CloseButtonOnTabsVisible = true;
            this.tab_MainTab.CloseButtonPosition = DevComponents.DotNetBar.eTabCloseButtonPosition.Right;
            this.tab_MainTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_MainTab.Location = new System.Drawing.Point(0, 0);
            this.tab_MainTab.Name = "tab_MainTab";
            this.tab_MainTab.SelectedTabFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_MainTab.SelectedTabIndex = -1;
            this.tab_MainTab.Size = new System.Drawing.Size(1370, 441);
            this.tab_MainTab.Style = DevComponents.DotNetBar.eTabStripStyle.Flat;
            this.tab_MainTab.TabIndex = 6;
            this.tab_MainTab.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tab_MainTab.Text = "tabControl1";
            this.tab_MainTab.TabRemoved += new System.EventHandler(this.tabControl1_TabRemoved);
            // 
            // ribbonButton1
            // 
            this.ribbonButton1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.Image")));
            this.ribbonButton1.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButton1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.SmallImage")));
            this.ribbonButton1.Text = "ribbonButton1";
            // 
            // ribbonButton2
            // 
            this.ribbonButton2.Image = global::GUI.Properties.Resources.cashier;
            this.ribbonButton2.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.SmallImage")));
            this.ribbonButton2.Text = "Thu ngân 1";
            this.ribbonButton2.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center;
            // 
            // ribbonButton3
            // 
            this.ribbonButton3.Image = global::GUI.Properties.Resources.inputdata;
            this.ribbonButton3.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton3.SmallImage")));
            this.ribbonButton3.Text = "Nhập liêu 1";
            this.ribbonButton3.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center;
            // 
            // frm_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 591);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ribbon1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_MainForm";
            this.Text = "Phần mềm quản lý bệnh viện";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_MainForm_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Bacground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab_MainTab)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Ribbon ribbon1;
        private System.Windows.Forms.RibbonTab tp_QuanTriHeThong;
        private System.Windows.Forms.RibbonPanel pn_NguoiDung;
        private System.Windows.Forms.RibbonTab tp_ThuNgan;
        private System.Windows.Forms.RibbonTab tp_BaoCao;
        private System.Windows.Forms.RibbonTab tp_TroGiop;
        private System.Windows.Forms.RibbonButton btn_CauHinh;
        private System.Windows.Forms.RibbonButton btn_Logout;
        private System.Windows.Forms.RibbonButton btn_Changepass;
        private System.Windows.Forms.RibbonPanel ribbonPanel4;
        private System.Windows.Forms.RibbonButton btn_Help;
        private System.Windows.Forms.RibbonButton btn_About;
        private System.Windows.Forms.RibbonButton btn_nguoidung;
        private System.Windows.Forms.RibbonButton btn_NhomNguoiDung;
        private System.Windows.Forms.RibbonButton ribbonButton1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RibbonPanel pn_DanhSachBienLai;
        private System.Windows.Forms.RibbonButton btn_BienLaiDuocLap;
        private System.Windows.Forms.RibbonButton btn_BienLaiDuocThuTien;
        private System.Windows.Forms.RibbonPanel pn_DoanhThu;
        private System.Windows.Forms.RibbonButton btn_DanhSachThuTienTheoNhomDichVu;
        private System.Windows.Forms.RibbonButton btn_DoanhThu;
        private System.Windows.Forms.RibbonButton ribbonButton2;
        private System.Windows.Forms.RibbonButton ribbonButton3;
        private System.Windows.Forms.RibbonPanel bn_TinhThanhPho;
        private System.Windows.Forms.RibbonButton btn_Quan;
        private System.Windows.Forms.RibbonButton btn_TinhThanhPho;
        private System.Windows.Forms.RibbonPanel pn_DanhMucPhongBan;
        private System.Windows.Forms.RibbonButton btn_LoaiPhongBan;
        private System.Windows.Forms.RibbonButton btn_PhongBan;
        private System.Windows.Forms.RibbonPanel pn_DanhMucDichVu;
        private System.Windows.Forms.RibbonButton btn_NhomDichVu;
        private System.Windows.Forms.RibbonButton btn_DichVu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pic_Bacground;
        private DevComponents.DotNetBar.TabControl tab_MainTab;
        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.LabelItem lbl_TenBenhVien;
        private DevComponents.DotNetBar.LabelItem lbl_UserName;
        private DevComponents.DotNetBar.LabelItem lbl_NgayThang;
        private DevComponents.DotNetBar.LabelItem lbl_NgayGio;
        private System.Windows.Forms.RibbonPanel pn_LamViec;
        private System.Windows.Forms.RibbonComboBox cbo_ChonBan;
        private System.Windows.Forms.RibbonComboBox cbo_ChonDonVi;
        private System.Windows.Forms.RibbonCheckBox chk_NhapLieu;
        private System.Windows.Forms.RibbonCheckBox chk_ThuNgan;
        private System.Windows.Forms.RibbonSeparator ribbonSeparator2;
        private System.Windows.Forms.RibbonButton btn_BatDau;
        private System.Windows.Forms.RibbonSeparator ribbonSeparator3;
    }
}