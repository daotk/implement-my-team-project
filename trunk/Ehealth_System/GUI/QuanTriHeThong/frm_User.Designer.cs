namespace GUI.QuanTriHeThong
{
    partial class frm_User
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.grd_User = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhomNguoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
            this.UserTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_Title = new DevComponents.DotNetBar.LabelX();
            this.lbl_MaNhanVien = new DevComponents.DotNetBar.LabelX();
            this.txt_MaNhanVien = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbl_HoTen = new DevComponents.DotNetBar.LabelX();
            this.txt_HoTen = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbl_NhomNguoiDung = new DevComponents.DotNetBar.LabelX();
            this.lbl_Note = new DevComponents.DotNetBar.LabelX();
            this.cbo_NhomNguoiDung = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lbl_Note1 = new DevComponents.DotNetBar.LabelX();
            this.labelX16 = new DevComponents.DotNetBar.LabelX();
            this.lbl_Note3 = new DevComponents.DotNetBar.LabelX();
            this.lbl_Email = new DevComponents.DotNetBar.LabelX();
            this.txt_Email = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbl_Note2 = new DevComponents.DotNetBar.LabelX();
            this.lbl_Password = new DevComponents.DotNetBar.LabelX();
            this.btn_ThemMoi = new DevComponents.DotNetBar.ButtonX();
            this.btn_ChinhSua = new DevComponents.DotNetBar.ButtonX();
            this.lbl_TrangThai = new DevComponents.DotNetBar.LabelX();
            this.chk_TrangThai = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.lbl_NoteInformation = new DevComponents.DotNetBar.LabelX();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.txt_MatKhau = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_TaiKhoan = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbl_TaiKhoan = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.panelEx2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_User)).BeginInit();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.grd_User);
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx2.Location = new System.Drawing.Point(0, 0);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(965, 550);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 7;
            // 
            // grd_User
            // 
            this.grd_User.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grd_User.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd_User.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.grd_User.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_User.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaNhanVien,
            this.NhomNguoiDung,
            this.HoTen,
            this.TaiKhoan,
            this.TrangThai,
            this.UserTypeID,
            this.Email,
            this.Password,
            this.Autho});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grd_User.DefaultCellStyle = dataGridViewCellStyle12;
            this.grd_User.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_User.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.grd_User.Location = new System.Drawing.Point(0, 0);
            this.grd_User.MultiSelect = false;
            this.grd_User.Name = "grd_User";
            this.grd_User.ReadOnly = true;
            this.grd_User.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd_User.Size = new System.Drawing.Size(965, 550);
            this.grd_User.TabIndex = 0;
            this.grd_User.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_User_CellClick);
            this.grd_User.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.grd_User_RowsAdded);
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.STT.DataPropertyName = "STT";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.STT.DefaultCellStyle = dataGridViewCellStyle8;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 61;
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MaNhanVien.DataPropertyName = "_USERID";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.MaNhanVien.DefaultCellStyle = dataGridViewCellStyle9;
            this.MaNhanVien.HeaderText = "Mã nhân viên";
            this.MaNhanVien.Name = "MaNhanVien";
            this.MaNhanVien.ReadOnly = true;
            this.MaNhanVien.Width = 150;
            // 
            // NhomNguoiDung
            // 
            this.NhomNguoiDung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NhomNguoiDung.DataPropertyName = "_GROUPUSERNAME";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.NhomNguoiDung.DefaultCellStyle = dataGridViewCellStyle10;
            this.NhomNguoiDung.HeaderText = "Nhóm người dùng";
            this.NhomNguoiDung.Name = "NhomNguoiDung";
            this.NhomNguoiDung.ReadOnly = true;
            this.NhomNguoiDung.Width = 180;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "_USERNAME";
            this.HoTen.HeaderText = "Họ tên";
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            // 
            // TaiKhoan
            // 
            this.TaiKhoan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TaiKhoan.DataPropertyName = "_ACCOUNT";
            this.TaiKhoan.HeaderText = "Tài khoản";
            this.TaiKhoan.Name = "TaiKhoan";
            this.TaiKhoan.ReadOnly = true;
            this.TaiKhoan.Width = 150;
            // 
            // TrangThai
            // 
            this.TrangThai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TrangThai.Checked = true;
            this.TrangThai.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.TrangThai.CheckValue = null;
            this.TrangThai.DataPropertyName = "_STATUS";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TrangThai.DefaultCellStyle = dataGridViewCellStyle11;
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            // 
            // UserTypeID
            // 
            this.UserTypeID.DataPropertyName = "_UserTypeID";
            this.UserTypeID.HeaderText = "UserTypeID";
            this.UserTypeID.Name = "UserTypeID";
            this.UserTypeID.ReadOnly = true;
            this.UserTypeID.Visible = false;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "_Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Visible = false;
            // 
            // Password
            // 
            this.Password.DataPropertyName = "_Password";
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            this.Password.Visible = false;
            // 
            // Autho
            // 
            this.Autho.DataPropertyName = "_Autho";
            this.Autho.HeaderText = "Autho";
            this.Autho.Name = "Autho";
            this.Autho.ReadOnly = true;
            this.Autho.Visible = false;
            // 
            // lbl_Title
            // 
            // 
            // 
            // 
            this.lbl_Title.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Title.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(63, 15);
            this.lbl_Title.Margin = new System.Windows.Forms.Padding(5);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(209, 37);
            this.lbl_Title.TabIndex = 2;
            this.lbl_Title.Text = "Thông tin người dùng";
            // 
            // lbl_MaNhanVien
            // 
            this.lbl_MaNhanVien.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_MaNhanVien.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_MaNhanVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaNhanVien.Location = new System.Drawing.Point(12, 90);
            this.lbl_MaNhanVien.Name = "lbl_MaNhanVien";
            this.lbl_MaNhanVien.Size = new System.Drawing.Size(98, 23);
            this.lbl_MaNhanVien.TabIndex = 47;
            this.lbl_MaNhanVien.Text = "Mã nhân viên";
            // 
            // txt_MaNhanVien
            // 
            // 
            // 
            // 
            this.txt_MaNhanVien.Border.Class = "TextBoxBorder";
            this.txt_MaNhanVien.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_MaNhanVien.Enabled = false;
            this.txt_MaNhanVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaNhanVien.Location = new System.Drawing.Point(138, 87);
            this.txt_MaNhanVien.Name = "txt_MaNhanVien";
            this.txt_MaNhanVien.Size = new System.Drawing.Size(155, 26);
            this.txt_MaNhanVien.TabIndex = 48;
            // 
            // lbl_HoTen
            // 
            this.lbl_HoTen.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_HoTen.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_HoTen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HoTen.Location = new System.Drawing.Point(12, 135);
            this.lbl_HoTen.Name = "lbl_HoTen";
            this.lbl_HoTen.Size = new System.Drawing.Size(86, 23);
            this.lbl_HoTen.TabIndex = 49;
            this.lbl_HoTen.Text = "Họ tên";
            // 
            // txt_HoTen
            // 
            // 
            // 
            // 
            this.txt_HoTen.Border.Class = "TextBoxBorder";
            this.txt_HoTen.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_HoTen.Enabled = false;
            this.txt_HoTen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HoTen.Location = new System.Drawing.Point(139, 131);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(155, 26);
            this.txt_HoTen.TabIndex = 50;
            // 
            // lbl_NhomNguoiDung
            // 
            this.lbl_NhomNguoiDung.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_NhomNguoiDung.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_NhomNguoiDung.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NhomNguoiDung.Location = new System.Drawing.Point(12, 225);
            this.lbl_NhomNguoiDung.Name = "lbl_NhomNguoiDung";
            this.lbl_NhomNguoiDung.Size = new System.Drawing.Size(129, 23);
            this.lbl_NhomNguoiDung.TabIndex = 51;
            this.lbl_NhomNguoiDung.Text = "Nhóm người dùng";
            // 
            // lbl_Note
            // 
            this.lbl_Note.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_Note.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Note.ForeColor = System.Drawing.Color.Red;
            this.lbl_Note.Location = new System.Drawing.Point(299, 87);
            this.lbl_Note.Name = "lbl_Note";
            this.lbl_Note.Size = new System.Drawing.Size(28, 23);
            this.lbl_Note.TabIndex = 55;
            this.lbl_Note.Text = "(*)";
            // 
            // cbo_NhomNguoiDung
            // 
            this.cbo_NhomNguoiDung.DisplayMember = "Text";
            this.cbo_NhomNguoiDung.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_NhomNguoiDung.Enabled = false;
            this.cbo_NhomNguoiDung.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_NhomNguoiDung.FormattingEnabled = true;
            this.cbo_NhomNguoiDung.ItemHeight = 20;
            this.cbo_NhomNguoiDung.Location = new System.Drawing.Point(139, 222);
            this.cbo_NhomNguoiDung.Name = "cbo_NhomNguoiDung";
            this.cbo_NhomNguoiDung.Size = new System.Drawing.Size(155, 26);
            this.cbo_NhomNguoiDung.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbo_NhomNguoiDung.TabIndex = 54;
            // 
            // lbl_Note1
            // 
            this.lbl_Note1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_Note1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Note1.ForeColor = System.Drawing.Color.Red;
            this.lbl_Note1.Location = new System.Drawing.Point(299, 134);
            this.lbl_Note1.Name = "lbl_Note1";
            this.lbl_Note1.Size = new System.Drawing.Size(32, 23);
            this.lbl_Note1.TabIndex = 56;
            this.lbl_Note1.Text = "(*)";
            // 
            // labelX16
            // 
            this.labelX16.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX16.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX16.ForeColor = System.Drawing.Color.Red;
            this.labelX16.Location = new System.Drawing.Point(517, 554);
            this.labelX16.Name = "labelX16";
            this.labelX16.Size = new System.Drawing.Size(32, 23);
            this.labelX16.TabIndex = 57;
            this.labelX16.Text = "(*)";
            // 
            // lbl_Note3
            // 
            this.lbl_Note3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_Note3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Note3.ForeColor = System.Drawing.Color.Red;
            this.lbl_Note3.Location = new System.Drawing.Point(299, 266);
            this.lbl_Note3.Name = "lbl_Note3";
            this.lbl_Note3.Size = new System.Drawing.Size(32, 23);
            this.lbl_Note3.TabIndex = 58;
            this.lbl_Note3.Text = "(*)";
            // 
            // lbl_Email
            // 
            this.lbl_Email.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_Email.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Email.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(12, 180);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(86, 23);
            this.lbl_Email.TabIndex = 59;
            this.lbl_Email.Text = "Email";
            // 
            // txt_Email
            // 
            // 
            // 
            // 
            this.txt_Email.Border.Class = "TextBoxBorder";
            this.txt_Email.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_Email.Enabled = false;
            this.txt_Email.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.Location = new System.Drawing.Point(139, 177);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(155, 26);
            this.txt_Email.TabIndex = 61;
            // 
            // lbl_Note2
            // 
            this.lbl_Note2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_Note2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Note2.ForeColor = System.Drawing.Color.Red;
            this.lbl_Note2.Location = new System.Drawing.Point(299, 223);
            this.lbl_Note2.Name = "lbl_Note2";
            this.lbl_Note2.Size = new System.Drawing.Size(32, 23);
            this.lbl_Note2.TabIndex = 64;
            this.lbl_Note2.Text = "(*)";
            // 
            // lbl_Password
            // 
            this.lbl_Password.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_Password.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Password.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(12, 315);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(98, 23);
            this.lbl_Password.TabIndex = 65;
            this.lbl_Password.Text = "Mật khẩu";
            // 
            // btn_ThemMoi
            // 
            this.btn_ThemMoi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_ThemMoi.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_ThemMoi.Image = global::GUI.Properties.Resources.Actions_list_add_icon;
            this.btn_ThemMoi.Location = new System.Drawing.Point(44, 439);
            this.btn_ThemMoi.Name = "btn_ThemMoi";
            this.btn_ThemMoi.Size = new System.Drawing.Size(120, 35);
            this.btn_ThemMoi.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
            this.btn_ThemMoi.TabIndex = 67;
            this.btn_ThemMoi.Text = "Thêm mới";
            this.btn_ThemMoi.Click += new System.EventHandler(this.btn_ThemMoi_Click);
            // 
            // btn_ChinhSua
            // 
            this.btn_ChinhSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_ChinhSua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_ChinhSua.Image = global::GUI.Properties.Resources.Edit_icon;
            this.btn_ChinhSua.Location = new System.Drawing.Point(170, 439);
            this.btn_ChinhSua.Name = "btn_ChinhSua";
            this.btn_ChinhSua.Size = new System.Drawing.Size(120, 35);
            this.btn_ChinhSua.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
            this.btn_ChinhSua.TabIndex = 68;
            this.btn_ChinhSua.Text = "Chỉnh sửa";
            this.btn_ChinhSua.Click += new System.EventHandler(this.btn_ChinhSua_Click);
            // 
            // lbl_TrangThai
            // 
            this.lbl_TrangThai.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_TrangThai.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_TrangThai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TrangThai.Location = new System.Drawing.Point(12, 361);
            this.lbl_TrangThai.Name = "lbl_TrangThai";
            this.lbl_TrangThai.Size = new System.Drawing.Size(83, 23);
            this.lbl_TrangThai.TabIndex = 69;
            this.lbl_TrangThai.Text = "Trạng thái";
            // 
            // chk_TrangThai
            // 
            // 
            // 
            // 
            this.chk_TrangThai.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chk_TrangThai.Enabled = false;
            this.chk_TrangThai.Location = new System.Drawing.Point(139, 361);
            this.chk_TrangThai.Name = "chk_TrangThai";
            this.chk_TrangThai.Size = new System.Drawing.Size(100, 23);
            this.chk_TrangThai.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chk_TrangThai.TabIndex = 70;
            this.chk_TrangThai.Text = "Có sử dụng";
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
            this.lbl_NoteInformation.Location = new System.Drawing.Point(12, 488);
            this.lbl_NoteInformation.Name = "lbl_NoteInformation";
            this.lbl_NoteInformation.Size = new System.Drawing.Size(190, 23);
            this.lbl_NoteInformation.TabIndex = 71;
            this.lbl_NoteInformation.Text = "(*) là những thông tin bắc buộc";
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.labelX1);
            this.panelEx1.Controls.Add(this.txt_MatKhau);
            this.panelEx1.Controls.Add(this.txt_TaiKhoan);
            this.panelEx1.Controls.Add(this.lbl_TaiKhoan);
            this.panelEx1.Controls.Add(this.lbl_NoteInformation);
            this.panelEx1.Controls.Add(this.chk_TrangThai);
            this.panelEx1.Controls.Add(this.lbl_TrangThai);
            this.panelEx1.Controls.Add(this.btn_ChinhSua);
            this.panelEx1.Controls.Add(this.btn_ThemMoi);
            this.panelEx1.Controls.Add(this.lbl_Password);
            this.panelEx1.Controls.Add(this.lbl_Note2);
            this.panelEx1.Controls.Add(this.txt_Email);
            this.panelEx1.Controls.Add(this.lbl_Email);
            this.panelEx1.Controls.Add(this.lbl_Note3);
            this.panelEx1.Controls.Add(this.labelX16);
            this.panelEx1.Controls.Add(this.lbl_Note1);
            this.panelEx1.Controls.Add(this.cbo_NhomNguoiDung);
            this.panelEx1.Controls.Add(this.lbl_Note);
            this.panelEx1.Controls.Add(this.lbl_NhomNguoiDung);
            this.panelEx1.Controls.Add(this.txt_HoTen);
            this.panelEx1.Controls.Add(this.lbl_HoTen);
            this.panelEx1.Controls.Add(this.txt_MaNhanVien);
            this.panelEx1.Controls.Add(this.lbl_MaNhanVien);
            this.panelEx1.Controls.Add(this.lbl_Title);
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
            this.panelEx1.TabIndex = 6;
            // 
            // txt_MatKhau
            // 
            // 
            // 
            // 
            this.txt_MatKhau.Border.Class = "TextBoxBorder";
            this.txt_MatKhau.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_MatKhau.Enabled = false;
            this.txt_MatKhau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MatKhau.Location = new System.Drawing.Point(138, 312);
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.Size = new System.Drawing.Size(155, 26);
            this.txt_MatKhau.TabIndex = 77;
            // 
            // txt_TaiKhoan
            // 
            // 
            // 
            // 
            this.txt_TaiKhoan.Border.Class = "TextBoxBorder";
            this.txt_TaiKhoan.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_TaiKhoan.Enabled = false;
            this.txt_TaiKhoan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TaiKhoan.Location = new System.Drawing.Point(138, 267);
            this.txt_TaiKhoan.Name = "txt_TaiKhoan";
            this.txt_TaiKhoan.Size = new System.Drawing.Size(155, 26);
            this.txt_TaiKhoan.TabIndex = 75;
            // 
            // lbl_TaiKhoan
            // 
            this.lbl_TaiKhoan.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_TaiKhoan.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_TaiKhoan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TaiKhoan.Location = new System.Drawing.Point(12, 270);
            this.lbl_TaiKhoan.Name = "lbl_TaiKhoan";
            this.lbl_TaiKhoan.Size = new System.Drawing.Size(98, 23);
            this.lbl_TaiKhoan.TabIndex = 74;
            this.lbl_TaiKhoan.Text = "Tài khoản";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ForeColor = System.Drawing.Color.Red;
            this.labelX1.Location = new System.Drawing.Point(295, 315);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(32, 23);
            this.labelX1.TabIndex = 78;
            this.labelX1.Text = "(*)";
            // 
            // frm_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1300, 550);
            this.Controls.Add(this.panelEx2);
            this.Controls.Add(this.panelEx1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_User";
            this.Text = "NguoiDung";
            this.Load += new System.EventHandler(this.frm_User_Load);
            this.panelEx2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_User)).EndInit();
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.Controls.DataGridViewX grd_User;
        private DevComponents.DotNetBar.LabelX lbl_Title;
        private DevComponents.DotNetBar.LabelX lbl_MaNhanVien;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_MaNhanVien;
        private DevComponents.DotNetBar.LabelX lbl_HoTen;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_HoTen;
        private DevComponents.DotNetBar.LabelX lbl_NhomNguoiDung;
        private DevComponents.DotNetBar.LabelX lbl_Note;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbo_NhomNguoiDung;
        private DevComponents.DotNetBar.LabelX lbl_Note1;
        private DevComponents.DotNetBar.LabelX labelX16;
        private DevComponents.DotNetBar.LabelX lbl_Note3;
        private DevComponents.DotNetBar.LabelX lbl_Email;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_Email;
        private DevComponents.DotNetBar.LabelX lbl_Note2;
        private DevComponents.DotNetBar.LabelX lbl_Password;
        private DevComponents.DotNetBar.ButtonX btn_ThemMoi;
        private DevComponents.DotNetBar.ButtonX btn_ChinhSua;
        private DevComponents.DotNetBar.LabelX lbl_TrangThai;
        private DevComponents.DotNetBar.Controls.CheckBoxX chk_TrangThai;
        private DevComponents.DotNetBar.LabelX lbl_NoteInformation;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_TaiKhoan;
        private DevComponents.DotNetBar.LabelX lbl_TaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhomNguoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaiKhoan;
        private DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn TrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autho;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_MatKhau;
        private DevComponents.DotNetBar.LabelX labelX1;




    }
}