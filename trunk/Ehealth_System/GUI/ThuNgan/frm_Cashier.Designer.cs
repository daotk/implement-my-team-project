namespace GUI.ThuNgan
{
    partial class frm_Cashier
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.grd_HoaDon = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.txt_TimKiemHoaDon = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbl_TimKiemHoaDon = new DevComponents.DotNetBar.LabelX();
            this.panelEx3 = new DevComponents.DotNetBar.PanelEx();
            this.txt_MaHoaDon = new DevComponents.DotNetBar.LabelX();
            this.txt_MabenhNhan = new DevComponents.DotNetBar.LabelX();
            this.lbl_MaBenhNhan = new DevComponents.DotNetBar.LabelX();
            this.txt_SDT = new DevComponents.DotNetBar.LabelX();
            this.txt_DiaChi = new DevComponents.DotNetBar.LabelX();
            this.txt_Tuoi = new DevComponents.DotNetBar.LabelX();
            this.txt_GioiTinh = new DevComponents.DotNetBar.LabelX();
            this.txt_TenBenhNhan = new DevComponents.DotNetBar.LabelX();
            this.lbl_SDT = new DevComponents.DotNetBar.LabelX();
            this.lbl_DiaChi = new DevComponents.DotNetBar.LabelX();
            this.lbl_Tuoi = new DevComponents.DotNetBar.LabelX();
            this.lbl_GioiTinh = new DevComponents.DotNetBar.LabelX();
            this.lbl_TenBenhNhan = new DevComponents.DotNetBar.LabelX();
            this.lbl_MaHoaDon = new DevComponents.DotNetBar.LabelX();
            this.panelEx4 = new DevComponents.DotNetBar.PanelEx();
            this.btn_XacNhan = new DevComponents.DotNetBar.ButtonX();
            this.txt_SoTienHoanLai = new DevComponents.DotNetBar.LabelX();
            this.txt_TongSoTien = new DevComponents.DotNetBar.LabelX();
            this.txt_SoTienNhan = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbl_SoTienHoanLai = new DevComponents.DotNetBar.LabelX();
            this.lbl_SoTienNhan = new DevComponents.DotNetBar.LabelX();
            this.lbl_TongSoTien = new DevComponents.DotNetBar.LabelX();
            this.grd_DichVu = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.STT1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiduchvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dichvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_HoaDon)).BeginInit();
            this.panelEx2.SuspendLayout();
            this.panelEx3.SuspendLayout();
            this.panelEx4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_DichVu)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.grd_HoaDon);
            this.panelEx1.Controls.Add(this.panelEx2);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(350, 550);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // grd_HoaDon
            // 
            this.grd_HoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grd_HoaDon.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.grd_HoaDon.BackgroundColor = System.Drawing.Color.White;
            this.grd_HoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_HoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaHoaDon});
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grd_HoaDon.DefaultCellStyle = dataGridViewCellStyle32;
            this.grd_HoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_HoaDon.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.grd_HoaDon.Location = new System.Drawing.Point(0, 40);
            this.grd_HoaDon.Name = "grd_HoaDon";
            this.grd_HoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd_HoaDon.Size = new System.Drawing.Size(350, 510);
            this.grd_HoaDon.TabIndex = 1;
            this.grd_HoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_HoaDon_CellClick);
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.STT.DefaultCellStyle = dataGridViewCellStyle31;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Width = 61;
            // 
            // MaHoaDon
            // 
            this.MaHoaDon.DataPropertyName = "tenbenhnhan_";
            this.MaHoaDon.HeaderText = "Tên bệnh nhân";
            this.MaHoaDon.Name = "MaHoaDon";
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.txt_TimKiemHoaDon);
            this.panelEx2.Controls.Add(this.lbl_TimKiemHoaDon);
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx2.Location = new System.Drawing.Point(0, 0);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(350, 40);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 0;
            // 
            // txt_TimKiemHoaDon
            // 
            // 
            // 
            // 
            this.txt_TimKiemHoaDon.Border.Class = "TextBoxBorder";
            this.txt_TimKiemHoaDon.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_TimKiemHoaDon.Location = new System.Drawing.Point(171, 7);
            this.txt_TimKiemHoaDon.Name = "txt_TimKiemHoaDon";
            this.txt_TimKiemHoaDon.Size = new System.Drawing.Size(140, 26);
            this.txt_TimKiemHoaDon.TabIndex = 3;
            this.txt_TimKiemHoaDon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_TimKiemHoaDon_KeyDown);
            // 
            // lbl_TimKiemHoaDon
            // 
            // 
            // 
            // 
            this.lbl_TimKiemHoaDon.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_TimKiemHoaDon.Location = new System.Drawing.Point(40, 10);
            this.lbl_TimKiemHoaDon.Name = "lbl_TimKiemHoaDon";
            this.lbl_TimKiemHoaDon.Size = new System.Drawing.Size(125, 23);
            this.lbl_TimKiemHoaDon.TabIndex = 2;
            this.lbl_TimKiemHoaDon.Text = "Tìm kiếm hóa đơn";
            // 
            // panelEx3
            // 
            this.panelEx3.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx3.Controls.Add(this.txt_MaHoaDon);
            this.panelEx3.Controls.Add(this.txt_MabenhNhan);
            this.panelEx3.Controls.Add(this.lbl_MaBenhNhan);
            this.panelEx3.Controls.Add(this.txt_SDT);
            this.panelEx3.Controls.Add(this.txt_DiaChi);
            this.panelEx3.Controls.Add(this.txt_Tuoi);
            this.panelEx3.Controls.Add(this.txt_GioiTinh);
            this.panelEx3.Controls.Add(this.txt_TenBenhNhan);
            this.panelEx3.Controls.Add(this.lbl_SDT);
            this.panelEx3.Controls.Add(this.lbl_DiaChi);
            this.panelEx3.Controls.Add(this.lbl_Tuoi);
            this.panelEx3.Controls.Add(this.lbl_GioiTinh);
            this.panelEx3.Controls.Add(this.lbl_TenBenhNhan);
            this.panelEx3.Controls.Add(this.lbl_MaHoaDon);
            this.panelEx3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx3.Location = new System.Drawing.Point(350, 0);
            this.panelEx3.Name = "panelEx3";
            this.panelEx3.Size = new System.Drawing.Size(950, 100);
            this.panelEx3.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx3.Style.GradientAngle = 90;
            this.panelEx3.TabIndex = 1;
            // 
            // txt_MaHoaDon
            // 
            // 
            // 
            // 
            this.txt_MaHoaDon.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_MaHoaDon.Location = new System.Drawing.Point(220, 10);
            this.txt_MaHoaDon.Name = "txt_MaHoaDon";
            this.txt_MaHoaDon.Size = new System.Drawing.Size(130, 23);
            this.txt_MaHoaDon.TabIndex = 28;
            this.txt_MaHoaDon.Text = "130621-00001-AB";
            // 
            // txt_MabenhNhan
            // 
            // 
            // 
            // 
            this.txt_MabenhNhan.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_MabenhNhan.Location = new System.Drawing.Point(664, 10);
            this.txt_MabenhNhan.Name = "txt_MabenhNhan";
            this.txt_MabenhNhan.Size = new System.Drawing.Size(102, 23);
            this.txt_MabenhNhan.TabIndex = 27;
            this.txt_MabenhNhan.Text = "A130000001";
            // 
            // lbl_MaBenhNhan
            // 
            // 
            // 
            // 
            this.lbl_MaBenhNhan.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_MaBenhNhan.Location = new System.Drawing.Point(534, 10);
            this.lbl_MaBenhNhan.Name = "lbl_MaBenhNhan";
            this.lbl_MaBenhNhan.Size = new System.Drawing.Size(102, 23);
            this.lbl_MaBenhNhan.TabIndex = 26;
            this.lbl_MaBenhNhan.Text = "Mã bệnh nhân:";
            // 
            // txt_SDT
            // 
            // 
            // 
            // 
            this.txt_SDT.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_SDT.Location = new System.Drawing.Point(740, 68);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(99, 23);
            this.txt_SDT.TabIndex = 25;
            this.txt_SDT.Text = "01234567890";
            // 
            // txt_DiaChi
            // 
            // 
            // 
            // 
            this.txt_DiaChi.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_DiaChi.Location = new System.Drawing.Point(220, 68);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(311, 23);
            this.txt_DiaChi.TabIndex = 24;
            this.txt_DiaChi.Text = "45 Nguyễn Khắc nhu, Quận 1, Hồ Chí Minh";
            // 
            // txt_Tuoi
            // 
            // 
            // 
            // 
            this.txt_Tuoi.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_Tuoi.Location = new System.Drawing.Point(814, 39);
            this.txt_Tuoi.Name = "txt_Tuoi";
            this.txt_Tuoi.Size = new System.Drawing.Size(25, 23);
            this.txt_Tuoi.TabIndex = 23;
            this.txt_Tuoi.Text = "25";
            // 
            // txt_GioiTinh
            // 
            // 
            // 
            // 
            this.txt_GioiTinh.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_GioiTinh.Location = new System.Drawing.Point(633, 39);
            this.txt_GioiTinh.Name = "txt_GioiTinh";
            this.txt_GioiTinh.Size = new System.Drawing.Size(40, 23);
            this.txt_GioiTinh.TabIndex = 22;
            this.txt_GioiTinh.Text = "Nam";
            // 
            // txt_TenBenhNhan
            // 
            // 
            // 
            // 
            this.txt_TenBenhNhan.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_TenBenhNhan.Location = new System.Drawing.Point(220, 39);
            this.txt_TenBenhNhan.Name = "txt_TenBenhNhan";
            this.txt_TenBenhNhan.Size = new System.Drawing.Size(102, 23);
            this.txt_TenBenhNhan.TabIndex = 21;
            this.txt_TenBenhNhan.Text = "Nguyễn Văn B";
            // 
            // lbl_SDT
            // 
            // 
            // 
            // 
            this.lbl_SDT.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_SDT.Location = new System.Drawing.Point(663, 68);
            this.lbl_SDT.Name = "lbl_SDT";
            this.lbl_SDT.Size = new System.Drawing.Size(44, 23);
            this.lbl_SDT.TabIndex = 18;
            this.lbl_SDT.Text = "SĐT:";
            // 
            // lbl_DiaChi
            // 
            // 
            // 
            // 
            this.lbl_DiaChi.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_DiaChi.Location = new System.Drawing.Point(112, 68);
            this.lbl_DiaChi.Name = "lbl_DiaChi";
            this.lbl_DiaChi.Size = new System.Drawing.Size(63, 23);
            this.lbl_DiaChi.TabIndex = 19;
            this.lbl_DiaChi.Text = "Địa chỉ:";
            // 
            // lbl_Tuoi
            // 
            // 
            // 
            // 
            this.lbl_Tuoi.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Tuoi.Location = new System.Drawing.Point(751, 39);
            this.lbl_Tuoi.Name = "lbl_Tuoi";
            this.lbl_Tuoi.Size = new System.Drawing.Size(39, 23);
            this.lbl_Tuoi.TabIndex = 17;
            this.lbl_Tuoi.Text = "Tuổi:";
            // 
            // lbl_GioiTinh
            // 
            // 
            // 
            // 
            this.lbl_GioiTinh.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_GioiTinh.Location = new System.Drawing.Point(534, 39);
            this.lbl_GioiTinh.Name = "lbl_GioiTinh";
            this.lbl_GioiTinh.Size = new System.Drawing.Size(71, 23);
            this.lbl_GioiTinh.TabIndex = 15;
            this.lbl_GioiTinh.Text = "Giới tính:";
            // 
            // lbl_TenBenhNhan
            // 
            // 
            // 
            // 
            this.lbl_TenBenhNhan.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_TenBenhNhan.Location = new System.Drawing.Point(112, 39);
            this.lbl_TenBenhNhan.Name = "lbl_TenBenhNhan";
            this.lbl_TenBenhNhan.Size = new System.Drawing.Size(102, 23);
            this.lbl_TenBenhNhan.TabIndex = 16;
            this.lbl_TenBenhNhan.Text = "Tên bệnh nhân:";
            // 
            // lbl_MaHoaDon
            // 
            // 
            // 
            // 
            this.lbl_MaHoaDon.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_MaHoaDon.Location = new System.Drawing.Point(112, 10);
            this.lbl_MaHoaDon.Name = "lbl_MaHoaDon";
            this.lbl_MaHoaDon.Size = new System.Drawing.Size(102, 23);
            this.lbl_MaHoaDon.TabIndex = 14;
            this.lbl_MaHoaDon.Text = "Mã hóa đơn:";
            // 
            // panelEx4
            // 
            this.panelEx4.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx4.Controls.Add(this.btn_XacNhan);
            this.panelEx4.Controls.Add(this.txt_SoTienHoanLai);
            this.panelEx4.Controls.Add(this.txt_TongSoTien);
            this.panelEx4.Controls.Add(this.txt_SoTienNhan);
            this.panelEx4.Controls.Add(this.lbl_SoTienHoanLai);
            this.panelEx4.Controls.Add(this.lbl_SoTienNhan);
            this.panelEx4.Controls.Add(this.lbl_TongSoTien);
            this.panelEx4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEx4.Location = new System.Drawing.Point(350, 450);
            this.panelEx4.Name = "panelEx4";
            this.panelEx4.Size = new System.Drawing.Size(950, 100);
            this.panelEx4.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx4.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx4.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx4.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx4.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx4.Style.GradientAngle = 90;
            this.panelEx4.TabIndex = 2;
            // 
            // btn_XacNhan
            // 
            this.btn_XacNhan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_XacNhan.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_XacNhan.Image = global::GUI.Properties.Resources.accept;
            this.btn_XacNhan.Location = new System.Drawing.Point(485, 11);
            this.btn_XacNhan.Name = "btn_XacNhan";
            this.btn_XacNhan.Size = new System.Drawing.Size(120, 80);
            this.btn_XacNhan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_XacNhan.TabIndex = 4;
            this.btn_XacNhan.Text = "Xác nhận";
            this.btn_XacNhan.Click += new System.EventHandler(this.btn_XacNhan_Click);
            // 
            // txt_SoTienHoanLai
            // 
            // 
            // 
            // 
            this.txt_SoTienHoanLai.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_SoTienHoanLai.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoTienHoanLai.ForeColor = System.Drawing.Color.Red;
            this.txt_SoTienHoanLai.Location = new System.Drawing.Point(190, 68);
            this.txt_SoTienHoanLai.Name = "txt_SoTienHoanLai";
            this.txt_SoTienHoanLai.Size = new System.Drawing.Size(100, 23);
            this.txt_SoTienHoanLai.TabIndex = 3;
            this.txt_SoTienHoanLai.Text = "0";
            // 
            // txt_TongSoTien
            // 
            // 
            // 
            // 
            this.txt_TongSoTien.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_TongSoTien.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TongSoTien.ForeColor = System.Drawing.Color.Red;
            this.txt_TongSoTien.Location = new System.Drawing.Point(190, 7);
            this.txt_TongSoTien.Name = "txt_TongSoTien";
            this.txt_TongSoTien.Size = new System.Drawing.Size(100, 23);
            this.txt_TongSoTien.TabIndex = 2;
            // 
            // txt_SoTienNhan
            // 
            // 
            // 
            // 
            this.txt_SoTienNhan.Border.Class = "TextBoxBorder";
            this.txt_SoTienNhan.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_SoTienNhan.Location = new System.Drawing.Point(190, 36);
            this.txt_SoTienNhan.Name = "txt_SoTienNhan";
            this.txt_SoTienNhan.Size = new System.Drawing.Size(119, 26);
            this.txt_SoTienNhan.TabIndex = 1;
            this.txt_SoTienNhan.TextChanged += new System.EventHandler(this.txt_SoTienNhan_TextChanged);
            this.txt_SoTienNhan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SoTienNhan_KeyPress);
            // 
            // lbl_SoTienHoanLai
            // 
            // 
            // 
            // 
            this.lbl_SoTienHoanLai.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_SoTienHoanLai.Location = new System.Drawing.Point(75, 68);
            this.lbl_SoTienHoanLai.Name = "lbl_SoTienHoanLai";
            this.lbl_SoTienHoanLai.Size = new System.Drawing.Size(109, 23);
            this.lbl_SoTienHoanLai.TabIndex = 0;
            this.lbl_SoTienHoanLai.Text = "Số tiền hoàn lại:";
            // 
            // lbl_SoTienNhan
            // 
            // 
            // 
            // 
            this.lbl_SoTienNhan.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_SoTienNhan.Location = new System.Drawing.Point(75, 39);
            this.lbl_SoTienNhan.Name = "lbl_SoTienNhan";
            this.lbl_SoTienNhan.Size = new System.Drawing.Size(100, 23);
            this.lbl_SoTienNhan.TabIndex = 0;
            this.lbl_SoTienNhan.Text = "Số tiền nhận:";
            // 
            // lbl_TongSoTien
            // 
            // 
            // 
            // 
            this.lbl_TongSoTien.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_TongSoTien.Location = new System.Drawing.Point(75, 10);
            this.lbl_TongSoTien.Name = "lbl_TongSoTien";
            this.lbl_TongSoTien.Size = new System.Drawing.Size(100, 23);
            this.lbl_TongSoTien.TabIndex = 0;
            this.lbl_TongSoTien.Text = "Tổng số tiền:";
            // 
            // grd_DichVu
            // 
            this.grd_DichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grd_DichVu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.grd_DichVu.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle33.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle33.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd_DichVu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle33;
            this.grd_DichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_DichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT1,
            this.loaiduchvu,
            this.dichvu,
            this.DonGia,
            this.Thanhtien});
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle35.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle35.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grd_DichVu.DefaultCellStyle = dataGridViewCellStyle35;
            this.grd_DichVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_DichVu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.grd_DichVu.Location = new System.Drawing.Point(350, 100);
            this.grd_DichVu.Name = "grd_DichVu";
            this.grd_DichVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd_DichVu.Size = new System.Drawing.Size(950, 350);
            this.grd_DichVu.TabIndex = 3;
            this.grd_DichVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_DichVu_CellClick);
            // 
            // STT1
            // 
            this.STT1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle34.NullValue = "1";
            this.STT1.DefaultCellStyle = dataGridViewCellStyle34;
            this.STT1.HeaderText = "STT";
            this.STT1.Name = "STT1";
            this.STT1.Width = 61;
            // 
            // loaiduchvu
            // 
            this.loaiduchvu.DataPropertyName = "mahoadon_";
            this.loaiduchvu.HeaderText = "Mã hóa đơn";
            this.loaiduchvu.Name = "loaiduchvu";
            // 
            // dichvu
            // 
            this.dichvu.DataPropertyName = "loaidichvu_";
            this.dichvu.HeaderText = "Loại dịch vụ";
            this.dichvu.Name = "dichvu";
            // 
            // DonGia
            // 
            this.DonGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DonGia.DataPropertyName = "dongia_";
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.Name = "DonGia";
            // 
            // Thanhtien
            // 
            this.Thanhtien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Thanhtien.HeaderText = "Thành tiền";
            this.Thanhtien.Name = "Thanhtien";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frm_Cashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1300, 550);
            this.Controls.Add(this.grd_DichVu);
            this.Controls.Add(this.panelEx4);
            this.Controls.Add(this.panelEx3);
            this.Controls.Add(this.panelEx1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_Cashier";
            this.Text = "cashier";
            this.Load += new System.EventHandler(this.frm_Cashier_Load);
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_HoaDon)).EndInit();
            this.panelEx2.ResumeLayout(false);
            this.panelEx3.ResumeLayout(false);
            this.panelEx4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_DichVu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.Controls.DataGridViewX grd_HoaDon;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_TimKiemHoaDon;
        private DevComponents.DotNetBar.LabelX lbl_TimKiemHoaDon;
        private DevComponents.DotNetBar.PanelEx panelEx3;
        private DevComponents.DotNetBar.LabelX txt_MaHoaDon;
        private DevComponents.DotNetBar.LabelX txt_MabenhNhan;
        private DevComponents.DotNetBar.LabelX lbl_MaBenhNhan;
        private DevComponents.DotNetBar.LabelX txt_SDT;
        private DevComponents.DotNetBar.LabelX txt_DiaChi;
        private DevComponents.DotNetBar.LabelX txt_Tuoi;
        private DevComponents.DotNetBar.LabelX txt_GioiTinh;
        private DevComponents.DotNetBar.LabelX txt_TenBenhNhan;
        private DevComponents.DotNetBar.LabelX lbl_SDT;
        private DevComponents.DotNetBar.LabelX lbl_DiaChi;
        private DevComponents.DotNetBar.LabelX lbl_Tuoi;
        private DevComponents.DotNetBar.LabelX lbl_GioiTinh;
        private DevComponents.DotNetBar.LabelX lbl_TenBenhNhan;
        private DevComponents.DotNetBar.LabelX lbl_MaHoaDon;
        private DevComponents.DotNetBar.PanelEx panelEx4;
        private DevComponents.DotNetBar.LabelX txt_SoTienHoanLai;
        private DevComponents.DotNetBar.LabelX txt_TongSoTien;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_SoTienNhan;
        private DevComponents.DotNetBar.LabelX lbl_SoTienHoanLai;
        private DevComponents.DotNetBar.LabelX lbl_SoTienNhan;
        private DevComponents.DotNetBar.LabelX lbl_TongSoTien;
        private DevComponents.DotNetBar.ButtonX btn_XacNhan;
        private DevComponents.DotNetBar.Controls.DataGridViewX grd_DichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT1;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiduchvu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dichvu;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thanhtien;
        private System.Windows.Forms.Timer timer1;




    }
}