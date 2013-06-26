namespace GUI
{
    partial class PhanQuyen
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Cấu hình hệ thống");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Hệ thống", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Nhóm người dùng");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Người dùng");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Danh mục Tỉnh-Thành phố");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Danh mục Quận-Huyện");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Danh mục loại phòng ban");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Danh mục phòng ban");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Danh mục nhóm dịch vụ");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Danh mục dịch vụ");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Quản trị hệ thống", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Thu ngân");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("DS biên lai được lập");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("DS biên lai được thu tiền");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("DS thu tiền");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Doanh thu");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Báo cáo", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16});
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.trv_PhanQuyen = new System.Windows.Forms.TreeView();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.panelEx4 = new DevComponents.DotNetBar.PanelEx();
            this.grd_NhomNguoiDung = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenVietTat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhomNguoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
            this.panelEx3 = new DevComponents.DotNetBar.PanelEx();
            this.lbl_Title = new DevComponents.DotNetBar.LabelX();
            this.btn_Huy = new DevComponents.DotNetBar.ButtonX();
            this.grb_ThongTinNhomNguoiDung = new System.Windows.Forms.GroupBox();
            this.txt_NhomNguoiDung = new DevComponents.DotNetBar.LabelX();
            this.txt_MoTa = new DevComponents.DotNetBar.LabelX();
            this.lbl_MoTa = new DevComponents.DotNetBar.LabelX();
            this.txt_TenVietTac = new DevComponents.DotNetBar.LabelX();
            this.lbl_TenVietTat = new DevComponents.DotNetBar.LabelX();
            this.lbl_NhomNGuoiDung = new DevComponents.DotNetBar.LabelX();
            this.btn_Luu = new DevComponents.DotNetBar.ButtonX();
            this.panelEx1.SuspendLayout();
            this.panelEx2.SuspendLayout();
            this.panelEx4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_NhomNguoiDung)).BeginInit();
            this.panelEx3.SuspendLayout();
            this.grb_ThongTinNhomNguoiDung.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.trv_PhanQuyen);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelEx1.Location = new System.Drawing.Point(640, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(300, 567);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // trv_PhanQuyen
            // 
            this.trv_PhanQuyen.CheckBoxes = true;
            this.trv_PhanQuyen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trv_PhanQuyen.Location = new System.Drawing.Point(0, 0);
            this.trv_PhanQuyen.Name = "trv_PhanQuyen";
            treeNode1.Name = "Cấu hình hệ thống";
            treeNode1.Text = "Cấu hình hệ thống";
            treeNode2.Name = "Hệ Thống";
            treeNode2.Text = "Hệ thống";
            treeNode3.Name = "Nhóm người dùng";
            treeNode3.Text = "Nhóm người dùng";
            treeNode4.Name = "Người dùng";
            treeNode4.Text = "Người dùng";
            treeNode5.Name = "Danh mục Tỉnh-Thành phố";
            treeNode5.Text = "Danh mục Tỉnh-Thành phố";
            treeNode6.Name = "Danh mục Quận-Huyện";
            treeNode6.Text = "Danh mục Quận-Huyện";
            treeNode7.Name = "Danh mục loại phòng ban";
            treeNode7.Text = "Danh mục loại phòng ban";
            treeNode8.Name = "Danh mục phòng ban";
            treeNode8.Text = "Danh mục phòng ban";
            treeNode9.Name = "Danh mục nhóm dịch vụ";
            treeNode9.Text = "Danh mục nhóm dịch vụ";
            treeNode10.Name = "Danh mục dịch vụ";
            treeNode10.Text = "Danh mục dịch vụ";
            treeNode11.Name = "Quản trị hệ thống";
            treeNode11.Text = "Quản trị hệ thống";
            treeNode12.Name = "Thu ngân";
            treeNode12.Text = "Thu ngân";
            treeNode13.Name = "DS biên lai được lập";
            treeNode13.Text = "DS biên lai được lập";
            treeNode14.Name = "DS biên lai được thu tiền";
            treeNode14.Text = "DS biên lai được thu tiền";
            treeNode15.Name = "DS thu tiền";
            treeNode15.Text = "DS thu tiền";
            treeNode16.Name = "Doanh thu";
            treeNode16.Text = "Doanh thu";
            treeNode17.Name = "Báo cáo";
            treeNode17.Text = "Báo cáo";
            this.trv_PhanQuyen.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode11,
            treeNode12,
            treeNode17});
            this.trv_PhanQuyen.Size = new System.Drawing.Size(300, 567);
            this.trv_PhanQuyen.TabIndex = 1;
            this.trv_PhanQuyen.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.HandleOnTreeViewAfterCheck);
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.panelEx4);
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx2.Location = new System.Drawing.Point(0, 0);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(640, 567);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 1;
            // 
            // panelEx4
            // 
            this.panelEx4.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx4.Controls.Add(this.grd_NhomNguoiDung);
            this.panelEx4.Controls.Add(this.panelEx3);
            this.panelEx4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx4.Location = new System.Drawing.Point(0, 0);
            this.panelEx4.Name = "panelEx4";
            this.panelEx4.Size = new System.Drawing.Size(640, 567);
            this.panelEx4.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx4.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx4.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx4.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx4.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx4.Style.GradientAngle = 90;
            this.panelEx4.TabIndex = 1;
            // 
            // grd_NhomNguoiDung
            // 
            this.grd_NhomNguoiDung.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grd_NhomNguoiDung.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.grd_NhomNguoiDung.BackgroundColor = System.Drawing.Color.White;
            this.grd_NhomNguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_NhomNguoiDung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.TenVietTat,
            this.NhomNguoiDung,
            this.Mota,
            this.Quyen,
            this.TrangThai});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grd_NhomNguoiDung.DefaultCellStyle = dataGridViewCellStyle2;
            this.grd_NhomNguoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_NhomNguoiDung.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.grd_NhomNguoiDung.Location = new System.Drawing.Point(0, 212);
            this.grd_NhomNguoiDung.MultiSelect = false;
            this.grd_NhomNguoiDung.Name = "grd_NhomNguoiDung";
            this.grd_NhomNguoiDung.ReadOnly = true;
            this.grd_NhomNguoiDung.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd_NhomNguoiDung.Size = new System.Drawing.Size(640, 355);
            this.grd_NhomNguoiDung.TabIndex = 1;
            this.grd_NhomNguoiDung.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_NhomNguoiDung_CellContentClick);
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.STT.DefaultCellStyle = dataGridViewCellStyle1;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 61;
            // 
            // TenVietTat
            // 
            this.TenVietTat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TenVietTat.DataPropertyName = "tenviettat_";
            this.TenVietTat.HeaderText = "Tên viết tắt";
            this.TenVietTat.Name = "TenVietTat";
            this.TenVietTat.ReadOnly = true;
            // 
            // NhomNguoiDung
            // 
            this.NhomNguoiDung.DataPropertyName = "tennhom_";
            this.NhomNguoiDung.HeaderText = "Nhóm người dùng";
            this.NhomNguoiDung.Name = "NhomNguoiDung";
            this.NhomNguoiDung.ReadOnly = true;
            // 
            // Mota
            // 
            this.Mota.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Mota.DataPropertyName = "mota_";
            this.Mota.HeaderText = "Mô tả";
            this.Mota.Name = "Mota";
            this.Mota.ReadOnly = true;
            this.Mota.Width = 250;
            // 
            // Quyen
            // 
            this.Quyen.DataPropertyName = "author_";
            this.Quyen.HeaderText = "Quyền";
            this.Quyen.Name = "Quyen";
            this.Quyen.ReadOnly = true;
            this.Quyen.Visible = false;
            // 
            // TrangThai
            // 
            this.TrangThai.Checked = true;
            this.TrangThai.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.TrangThai.CheckValue = "N";
            this.TrangThai.DataPropertyName = "trangthai";
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            this.TrangThai.Visible = false;
            // 
            // panelEx3
            // 
            this.panelEx3.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx3.Controls.Add(this.lbl_Title);
            this.panelEx3.Controls.Add(this.btn_Huy);
            this.panelEx3.Controls.Add(this.grb_ThongTinNhomNguoiDung);
            this.panelEx3.Controls.Add(this.btn_Luu);
            this.panelEx3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx3.Location = new System.Drawing.Point(0, 0);
            this.panelEx3.Name = "panelEx3";
            this.panelEx3.Size = new System.Drawing.Size(640, 212);
            this.panelEx3.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx3.Style.GradientAngle = 90;
            this.panelEx3.TabIndex = 0;
            // 
            // lbl_Title
            // 
            // 
            // 
            // 
            this.lbl_Title.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Title.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(176, 1);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(282, 29);
            this.lbl_Title.TabIndex = 17;
            this.lbl_Title.Text = "Phân quyền nhóm người dùng";
            // 
            // btn_Huy
            // 
            this.btn_Huy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Huy.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Huy.Enabled = false;
            this.btn_Huy.Image = global::GUI.Properties.Resources.cancel1;
            this.btn_Huy.Location = new System.Drawing.Point(342, 166);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(120, 35);
            this.btn_Huy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Huy.TabIndex = 16;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // grb_ThongTinNhomNguoiDung
            // 
            this.grb_ThongTinNhomNguoiDung.Controls.Add(this.txt_NhomNguoiDung);
            this.grb_ThongTinNhomNguoiDung.Controls.Add(this.txt_MoTa);
            this.grb_ThongTinNhomNguoiDung.Controls.Add(this.lbl_MoTa);
            this.grb_ThongTinNhomNguoiDung.Controls.Add(this.txt_TenVietTac);
            this.grb_ThongTinNhomNguoiDung.Controls.Add(this.lbl_TenVietTat);
            this.grb_ThongTinNhomNguoiDung.Controls.Add(this.lbl_NhomNGuoiDung);
            this.grb_ThongTinNhomNguoiDung.Location = new System.Drawing.Point(9, 32);
            this.grb_ThongTinNhomNguoiDung.Name = "grb_ThongTinNhomNguoiDung";
            this.grb_ThongTinNhomNguoiDung.Size = new System.Drawing.Size(622, 123);
            this.grb_ThongTinNhomNguoiDung.TabIndex = 14;
            this.grb_ThongTinNhomNguoiDung.TabStop = false;
            this.grb_ThongTinNhomNguoiDung.Text = "Thông tin nhóm người dùng";
            // 
            // txt_NhomNguoiDung
            // 
            // 
            // 
            // 
            this.txt_NhomNguoiDung.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_NhomNguoiDung.Location = new System.Drawing.Point(151, 40);
            this.txt_NhomNguoiDung.Name = "txt_NhomNguoiDung";
            this.txt_NhomNguoiDung.Size = new System.Drawing.Size(132, 23);
            this.txt_NhomNguoiDung.TabIndex = 10;
            // 
            // txt_MoTa
            // 
            // 
            // 
            // 
            this.txt_MoTa.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_MoTa.Location = new System.Drawing.Point(131, 79);
            this.txt_MoTa.Name = "txt_MoTa";
            this.txt_MoTa.Size = new System.Drawing.Size(450, 23);
            this.txt_MoTa.TabIndex = 9;
            // 
            // lbl_MoTa
            // 
            // 
            // 
            // 
            this.lbl_MoTa.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_MoTa.Location = new System.Drawing.Point(6, 79);
            this.lbl_MoTa.Name = "lbl_MoTa";
            this.lbl_MoTa.Size = new System.Drawing.Size(132, 23);
            this.lbl_MoTa.TabIndex = 6;
            this.lbl_MoTa.Text = "Mô tả";
            // 
            // txt_TenVietTac
            // 
            // 
            // 
            // 
            this.txt_TenVietTac.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_TenVietTac.Location = new System.Drawing.Point(465, 40);
            this.txt_TenVietTac.Name = "txt_TenVietTac";
            this.txt_TenVietTac.Size = new System.Drawing.Size(132, 23);
            this.txt_TenVietTac.TabIndex = 5;
            // 
            // lbl_TenVietTat
            // 
            // 
            // 
            // 
            this.lbl_TenVietTat.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_TenVietTat.Location = new System.Drawing.Point(317, 40);
            this.lbl_TenVietTat.Name = "lbl_TenVietTat";
            this.lbl_TenVietTat.Size = new System.Drawing.Size(132, 23);
            this.lbl_TenVietTat.TabIndex = 4;
            this.lbl_TenVietTat.Text = "Tên viết tắt:";
            // 
            // lbl_NhomNGuoiDung
            // 
            // 
            // 
            // 
            this.lbl_NhomNGuoiDung.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_NhomNGuoiDung.Location = new System.Drawing.Point(6, 40);
            this.lbl_NhomNGuoiDung.Name = "lbl_NhomNGuoiDung";
            this.lbl_NhomNGuoiDung.Size = new System.Drawing.Size(132, 23);
            this.lbl_NhomNGuoiDung.TabIndex = 0;
            this.lbl_NhomNGuoiDung.Text = "Nhóm người dùng";
            // 
            // btn_Luu
            // 
            this.btn_Luu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Luu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Luu.Enabled = false;
            this.btn_Luu.Image = global::GUI.Properties.Resources.Save_icon;
            this.btn_Luu.Location = new System.Drawing.Point(172, 166);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(120, 35);
            this.btn_Luu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Luu.TabIndex = 15;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // PhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(940, 567);
            this.Controls.Add(this.panelEx2);
            this.Controls.Add(this.panelEx1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "PhanQuyen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phân Quyền";
            this.Load += new System.EventHandler(this.PhanQuyen_Load);
            this.panelEx1.ResumeLayout(false);
            this.panelEx2.ResumeLayout(false);
            this.panelEx4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_NhomNguoiDung)).EndInit();
            this.panelEx3.ResumeLayout(false);
            this.grb_ThongTinNhomNguoiDung.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private System.Windows.Forms.TreeView trv_PhanQuyen;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.PanelEx panelEx4;
        private DevComponents.DotNetBar.Controls.DataGridViewX grd_NhomNguoiDung;
        private DevComponents.DotNetBar.PanelEx panelEx3;
        private DevComponents.DotNetBar.LabelX lbl_Title;
        private DevComponents.DotNetBar.ButtonX btn_Huy;
        private System.Windows.Forms.GroupBox grb_ThongTinNhomNguoiDung;
        private DevComponents.DotNetBar.LabelX txt_NhomNguoiDung;
        private DevComponents.DotNetBar.LabelX txt_MoTa;
        private DevComponents.DotNetBar.LabelX lbl_MoTa;
        private DevComponents.DotNetBar.LabelX txt_TenVietTac;
        private DevComponents.DotNetBar.LabelX lbl_TenVietTat;
        private DevComponents.DotNetBar.LabelX lbl_NhomNGuoiDung;
        private DevComponents.DotNetBar.ButtonX btn_Luu;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenVietTat;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhomNguoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quyen;
        private DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn TrangThai;

    }
}