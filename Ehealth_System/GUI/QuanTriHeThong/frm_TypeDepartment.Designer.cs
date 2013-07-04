namespace GUI.QuanTriHeThong
{
    partial class frm_TypeDepartment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.btn_huy = new DevComponents.DotNetBar.ButtonX();
            this.btn_luu = new DevComponents.DotNetBar.ButtonX();
            this.txt_TenVietTat = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.chk_TrangThai = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.lbl_TrangThai = new DevComponents.DotNetBar.LabelX();
            this.lbl_NoteInformation = new DevComponents.DotNetBar.LabelX();
            this.btn_ChinhSua = new DevComponents.DotNetBar.ButtonX();
            this.btn_ThemMoi = new DevComponents.DotNetBar.ButtonX();
            this.lbl_Title = new DevComponents.DotNetBar.LabelX();
            this.lbl_Note1 = new DevComponents.DotNetBar.LabelX();
            this.lbl_Note = new DevComponents.DotNetBar.LabelX();
            this.txt_MoTa = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbl_MoTa = new DevComponents.DotNetBar.LabelX();
            this.txt_LoaiPhongBan = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbl_LoaiPhongBan = new DevComponents.DotNetBar.LabelX();
            this.lbl_TenVietTat = new DevComponents.DotNetBar.LabelX();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.grd_LoaiPhongBan = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEPARTMENTTYPEID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEPARTMENTNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEPARTMENTDESCRIPTION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEPARTMENTSTATUS = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
            this.panelEx3 = new DevComponents.DotNetBar.PanelEx();
            this.lbl_KetQua = new DevComponents.DotNetBar.LabelX();
            this.txt_TimKiem = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbl_TimKiem = new DevComponents.DotNetBar.LabelX();
            this.panelEx1.SuspendLayout();
            this.panelEx2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_LoaiPhongBan)).BeginInit();
            this.panelEx3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.btn_huy);
            this.panelEx1.Controls.Add(this.btn_luu);
            this.panelEx1.Controls.Add(this.txt_TenVietTat);
            this.panelEx1.Controls.Add(this.chk_TrangThai);
            this.panelEx1.Controls.Add(this.lbl_TrangThai);
            this.panelEx1.Controls.Add(this.lbl_NoteInformation);
            this.panelEx1.Controls.Add(this.btn_ChinhSua);
            this.panelEx1.Controls.Add(this.btn_ThemMoi);
            this.panelEx1.Controls.Add(this.lbl_Title);
            this.panelEx1.Controls.Add(this.lbl_Note1);
            this.panelEx1.Controls.Add(this.lbl_Note);
            this.panelEx1.Controls.Add(this.txt_MoTa);
            this.panelEx1.Controls.Add(this.lbl_MoTa);
            this.panelEx1.Controls.Add(this.txt_LoaiPhongBan);
            this.panelEx1.Controls.Add(this.lbl_LoaiPhongBan);
            this.panelEx1.Controls.Add(this.lbl_TenVietTat);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelEx1.Location = new System.Drawing.Point(965, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(335, 550);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // btn_huy
            // 
            this.btn_huy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_huy.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_huy.Image = global::GUI.Properties.Resources.cancel1;
            this.btn_huy.Location = new System.Drawing.Point(180, 395);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(120, 35);
            this.btn_huy.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
            this.btn_huy.TabIndex = 9;
            this.btn_huy.Text = "Hủy Bỏ";
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_luu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_luu.Image = global::GUI.Properties.Resources.Save_icon;
            this.btn_luu.Location = new System.Drawing.Point(35, 395);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(120, 35);
            this.btn_luu.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
            this.btn_luu.TabIndex = 8;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // txt_TenVietTat
            // 
            // 
            // 
            // 
            this.txt_TenVietTat.Border.Class = "TextBoxBorder";
            this.txt_TenVietTat.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_TenVietTat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenVietTat.Location = new System.Drawing.Point(116, 138);
            this.txt_TenVietTat.MaxLength = 2;
            this.txt_TenVietTat.Name = "txt_TenVietTat";
            this.txt_TenVietTat.Size = new System.Drawing.Size(173, 26);
            this.txt_TenVietTat.TabIndex = 2;
            // 
            // chk_TrangThai
            // 
            // 
            // 
            // 
            this.chk_TrangThai.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chk_TrangThai.Location = new System.Drawing.Point(116, 346);
            this.chk_TrangThai.Name = "chk_TrangThai";
            this.chk_TrangThai.Size = new System.Drawing.Size(136, 23);
            this.chk_TrangThai.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chk_TrangThai.TabIndex = 5;
            this.chk_TrangThai.Text = "Có sử dụng";
            // 
            // lbl_TrangThai
            // 
            this.lbl_TrangThai.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_TrangThai.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_TrangThai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TrangThai.Location = new System.Drawing.Point(6, 346);
            this.lbl_TrangThai.Name = "lbl_TrangThai";
            this.lbl_TrangThai.Size = new System.Drawing.Size(83, 23);
            this.lbl_TrangThai.TabIndex = 63;
            this.lbl_TrangThai.Text = "Trạng thái";
            // 
            // lbl_NoteInformation
            // 
            this.lbl_NoteInformation.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_NoteInformation.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_NoteInformation.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NoteInformation.ForeColor = System.Drawing.Color.Red;
            this.lbl_NoteInformation.Location = new System.Drawing.Point(6, 458);
            this.lbl_NoteInformation.Name = "lbl_NoteInformation";
            this.lbl_NoteInformation.Size = new System.Drawing.Size(190, 23);
            this.lbl_NoteInformation.TabIndex = 62;
            this.lbl_NoteInformation.Text = "(*) là những thông tin bắt buộc";
            // 
            // btn_ChinhSua
            // 
            this.btn_ChinhSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_ChinhSua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_ChinhSua.Image = global::GUI.Properties.Resources.Edit_icon;
            this.btn_ChinhSua.Location = new System.Drawing.Point(180, 394);
            this.btn_ChinhSua.Name = "btn_ChinhSua";
            this.btn_ChinhSua.Size = new System.Drawing.Size(120, 35);
            this.btn_ChinhSua.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
            this.btn_ChinhSua.TabIndex = 7;
            this.btn_ChinhSua.Text = "Chỉnh sửa";
            this.btn_ChinhSua.Click += new System.EventHandler(this.btn_ChinhSua_Click);
            // 
            // btn_ThemMoi
            // 
            this.btn_ThemMoi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_ThemMoi.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_ThemMoi.Image = global::GUI.Properties.Resources.Actions_list_add_icon;
            this.btn_ThemMoi.Location = new System.Drawing.Point(35, 394);
            this.btn_ThemMoi.Name = "btn_ThemMoi";
            this.btn_ThemMoi.Size = new System.Drawing.Size(120, 35);
            this.btn_ThemMoi.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
            this.btn_ThemMoi.TabIndex = 6;
            this.btn_ThemMoi.Text = "Thêm mới";
            this.btn_ThemMoi.Click += new System.EventHandler(this.btn_ThemMoi_Click);
            // 
            // lbl_Title
            // 
            // 
            // 
            // 
            this.lbl_Title.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Title.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(47, 36);
            this.lbl_Title.Margin = new System.Windows.Forms.Padding(5);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(240, 37);
            this.lbl_Title.TabIndex = 59;
            this.lbl_Title.Text = "Danh mục loại phòng ban";
            // 
            // lbl_Note1
            // 
            this.lbl_Note1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_Note1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Note1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Note1.ForeColor = System.Drawing.Color.Red;
            this.lbl_Note1.Location = new System.Drawing.Point(297, 182);
            this.lbl_Note1.Name = "lbl_Note1";
            this.lbl_Note1.Size = new System.Drawing.Size(32, 23);
            this.lbl_Note1.TabIndex = 58;
            this.lbl_Note1.Text = "(*)";
            // 
            // lbl_Note
            // 
            this.lbl_Note.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_Note.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Note.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Note.ForeColor = System.Drawing.Color.Red;
            this.lbl_Note.Location = new System.Drawing.Point(297, 140);
            this.lbl_Note.Name = "lbl_Note";
            this.lbl_Note.Size = new System.Drawing.Size(32, 23);
            this.lbl_Note.TabIndex = 57;
            this.lbl_Note.Text = "(*)";
            // 
            // txt_MoTa
            // 
            // 
            // 
            // 
            this.txt_MoTa.Border.Class = "TextBoxBorder";
            this.txt_MoTa.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_MoTa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MoTa.Location = new System.Drawing.Point(114, 232);
            this.txt_MoTa.MaxLength = 400;
            this.txt_MoTa.Multiline = true;
            this.txt_MoTa.Name = "txt_MoTa";
            this.txt_MoTa.Size = new System.Drawing.Size(173, 92);
            this.txt_MoTa.TabIndex = 4;
            // 
            // lbl_MoTa
            // 
            this.lbl_MoTa.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_MoTa.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_MoTa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MoTa.Location = new System.Drawing.Point(6, 231);
            this.lbl_MoTa.Name = "lbl_MoTa";
            this.lbl_MoTa.Size = new System.Drawing.Size(116, 23);
            this.lbl_MoTa.TabIndex = 55;
            this.lbl_MoTa.Text = "Mô tả";
            // 
            // txt_LoaiPhongBan
            // 
            // 
            // 
            // 
            this.txt_LoaiPhongBan.Border.Class = "TextBoxBorder";
            this.txt_LoaiPhongBan.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_LoaiPhongBan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LoaiPhongBan.Location = new System.Drawing.Point(114, 183);
            this.txt_LoaiPhongBan.MaxLength = 50;
            this.txt_LoaiPhongBan.Name = "txt_LoaiPhongBan";
            this.txt_LoaiPhongBan.Size = new System.Drawing.Size(173, 26);
            this.txt_LoaiPhongBan.TabIndex = 3;
            // 
            // lbl_LoaiPhongBan
            // 
            this.lbl_LoaiPhongBan.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_LoaiPhongBan.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_LoaiPhongBan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LoaiPhongBan.Location = new System.Drawing.Point(6, 186);
            this.lbl_LoaiPhongBan.Name = "lbl_LoaiPhongBan";
            this.lbl_LoaiPhongBan.Size = new System.Drawing.Size(116, 23);
            this.lbl_LoaiPhongBan.TabIndex = 53;
            this.lbl_LoaiPhongBan.Text = "Loại phòng ban";
            // 
            // lbl_TenVietTat
            // 
            this.lbl_TenVietTat.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_TenVietTat.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_TenVietTat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenVietTat.Location = new System.Drawing.Point(6, 141);
            this.lbl_TenVietTat.Name = "lbl_TenVietTat";
            this.lbl_TenVietTat.Size = new System.Drawing.Size(83, 23);
            this.lbl_TenVietTat.TabIndex = 52;
            this.lbl_TenVietTat.Text = "Tên viết tắt";
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.grd_LoaiPhongBan);
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx2.Location = new System.Drawing.Point(0, 35);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(965, 515);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 1;
            // 
            // grd_LoaiPhongBan
            // 
            this.grd_LoaiPhongBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grd_LoaiPhongBan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.grd_LoaiPhongBan.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd_LoaiPhongBan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.grd_LoaiPhongBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_LoaiPhongBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.DEPARTMENTTYPEID,
            this.DEPARTMENTNAME,
            this.DEPARTMENTDESCRIPTION,
            this.DEPARTMENTSTATUS});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grd_LoaiPhongBan.DefaultCellStyle = dataGridViewCellStyle15;
            this.grd_LoaiPhongBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_LoaiPhongBan.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.grd_LoaiPhongBan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.grd_LoaiPhongBan.Location = new System.Drawing.Point(0, 0);
            this.grd_LoaiPhongBan.MultiSelect = false;
            this.grd_LoaiPhongBan.Name = "grd_LoaiPhongBan";
            this.grd_LoaiPhongBan.ReadOnly = true;
            this.grd_LoaiPhongBan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd_LoaiPhongBan.Size = new System.Drawing.Size(965, 515);
            this.grd_LoaiPhongBan.TabIndex = 0;
            this.grd_LoaiPhongBan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_LoaiPhongBan_CellClick);
            this.grd_LoaiPhongBan.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.grd_LoaiPhongBan_RowsAdded);
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.STT.DefaultCellStyle = dataGridViewCellStyle12;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 61;
            // 
            // DEPARTMENTTYPEID
            // 
            this.DEPARTMENTTYPEID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DEPARTMENTTYPEID.DataPropertyName = "_DEPARTMENTTYPEID";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DEPARTMENTTYPEID.DefaultCellStyle = dataGridViewCellStyle13;
            this.DEPARTMENTTYPEID.HeaderText = "Tên viết tắt";
            this.DEPARTMENTTYPEID.Name = "DEPARTMENTTYPEID";
            this.DEPARTMENTTYPEID.ReadOnly = true;
            // 
            // DEPARTMENTNAME
            // 
            this.DEPARTMENTNAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DEPARTMENTNAME.DataPropertyName = "_DEPARTMENTNAME";
            this.DEPARTMENTNAME.HeaderText = "Loại phòng ban";
            this.DEPARTMENTNAME.Name = "DEPARTMENTNAME";
            this.DEPARTMENTNAME.ReadOnly = true;
            this.DEPARTMENTNAME.Width = 250;
            // 
            // DEPARTMENTDESCRIPTION
            // 
            this.DEPARTMENTDESCRIPTION.DataPropertyName = "_DEPARTMENTDESCRIPTION";
            this.DEPARTMENTDESCRIPTION.HeaderText = "Mô tả";
            this.DEPARTMENTDESCRIPTION.Name = "DEPARTMENTDESCRIPTION";
            this.DEPARTMENTDESCRIPTION.ReadOnly = true;
            // 
            // DEPARTMENTSTATUS
            // 
            this.DEPARTMENTSTATUS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DEPARTMENTSTATUS.Checked = true;
            this.DEPARTMENTSTATUS.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.DEPARTMENTSTATUS.CheckValue = null;
            this.DEPARTMENTSTATUS.DataPropertyName = "_DEPARTMENTTYPESTATUS";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DEPARTMENTSTATUS.DefaultCellStyle = dataGridViewCellStyle14;
            this.DEPARTMENTSTATUS.HeaderText = "Trạng thái";
            this.DEPARTMENTSTATUS.Name = "DEPARTMENTSTATUS";
            this.DEPARTMENTSTATUS.ReadOnly = true;
            this.DEPARTMENTSTATUS.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DEPARTMENTSTATUS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // panelEx3
            // 
            this.panelEx3.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx3.Controls.Add(this.lbl_KetQua);
            this.panelEx3.Controls.Add(this.txt_TimKiem);
            this.panelEx3.Controls.Add(this.lbl_TimKiem);
            this.panelEx3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx3.Location = new System.Drawing.Point(0, 0);
            this.panelEx3.Name = "panelEx3";
            this.panelEx3.Size = new System.Drawing.Size(965, 35);
            this.panelEx3.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx3.Style.GradientAngle = 90;
            this.panelEx3.TabIndex = 0;
            // 
            // lbl_KetQua
            // 
            // 
            // 
            // 
            this.lbl_KetQua.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_KetQua.Location = new System.Drawing.Point(599, 6);
            this.lbl_KetQua.Name = "lbl_KetQua";
            this.lbl_KetQua.Size = new System.Drawing.Size(383, 23);
            this.lbl_KetQua.TabIndex = 7;
            this.lbl_KetQua.Text = "Kết quả: tìm được 3 trong tổng số 100";
            // 
            // txt_TimKiem
            // 
            // 
            // 
            // 
            this.txt_TimKiem.Border.Class = "TextBoxBorder";
            this.txt_TimKiem.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_TimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TimKiem.Location = new System.Drawing.Point(100, 4);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(150, 26);
            this.txt_TimKiem.TabIndex = 1;
            this.txt_TimKiem.TextChanged += new System.EventHandler(this.txt_TimKiem_TextChanged);
            // 
            // lbl_TimKiem
            // 
            // 
            // 
            // 
            this.lbl_TimKiem.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_TimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TimKiem.Location = new System.Drawing.Point(20, 5);
            this.lbl_TimKiem.Name = "lbl_TimKiem";
            this.lbl_TimKiem.Size = new System.Drawing.Size(75, 23);
            this.lbl_TimKiem.TabIndex = 2;
            this.lbl_TimKiem.Text = "Tìm kiếm";
            // 
            // frm_TypeDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1300, 550);
            this.Controls.Add(this.panelEx2);
            this.Controls.Add(this.panelEx3);
            this.Controls.Add(this.panelEx1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_TypeDepartment";
            this.Load += new System.EventHandler(this.frm_TypeDepartment_Load);
            this.panelEx1.ResumeLayout(false);
            this.panelEx2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_LoaiPhongBan)).EndInit();
            this.panelEx3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.PanelEx panelEx3;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_TimKiem;
        private DevComponents.DotNetBar.LabelX lbl_TimKiem;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_TenVietTat;
        private DevComponents.DotNetBar.Controls.CheckBoxX chk_TrangThai;
        private DevComponents.DotNetBar.LabelX lbl_TrangThai;
        private DevComponents.DotNetBar.LabelX lbl_NoteInformation;
        private DevComponents.DotNetBar.ButtonX btn_ChinhSua;
        private DevComponents.DotNetBar.ButtonX btn_ThemMoi;
        private DevComponents.DotNetBar.LabelX lbl_Title;
        private DevComponents.DotNetBar.LabelX lbl_Note1;
        private DevComponents.DotNetBar.LabelX lbl_Note;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_MoTa;
        private DevComponents.DotNetBar.LabelX lbl_MoTa;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_LoaiPhongBan;
        private DevComponents.DotNetBar.LabelX lbl_LoaiPhongBan;
        private DevComponents.DotNetBar.LabelX lbl_TenVietTat;
        private DevComponents.DotNetBar.LabelX lbl_KetQua;
        private DevComponents.DotNetBar.ButtonX btn_huy;
        private DevComponents.DotNetBar.ButtonX btn_luu;
        private DevComponents.DotNetBar.Controls.DataGridViewX grd_LoaiPhongBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEPARTMENTTYPEID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEPARTMENTNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEPARTMENTDESCRIPTION;
        private DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn DEPARTMENTSTATUS;

    }
}