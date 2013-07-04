namespace GUI.QuanTriHeThong
{
    partial class frm_ViewDetailDepartment
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

            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();

            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();

            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.grd_Ban = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenVietTat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENBAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRANGTHAI = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
            this.MaPhongBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.btn_huy = new DevComponents.DotNetBar.ButtonX();
            this.btn_Luu = new DevComponents.DotNetBar.ButtonX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.lbl_NoteInformation = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.lbl_Note2 = new DevComponents.DotNetBar.LabelX();
            this.btn_ChinhSua = new DevComponents.DotNetBar.ButtonX();
            this.btn_ThemMoi = new DevComponents.DotNetBar.ButtonX();
            this.chk_TrangThai = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.txt_TenBan = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_TenVietTat = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Ban)).BeginInit();
            this.panelEx2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.grd_Ban);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Margin = new System.Windows.Forms.Padding(4);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(544, 411);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // grd_Ban
            // 
            this.grd_Ban.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grd_Ban.BackgroundColor = System.Drawing.Color.White;
            this.grd_Ban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_Ban.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.TenVietTat,
            this.TENBAN,
            this.TRANGTHAI,
            this.MaPhongBan});

            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grd_Ban.DefaultCellStyle = dataGridViewCellStyle4;

            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grd_Ban.DefaultCellStyle = dataGridViewCellStyle6;

            this.grd_Ban.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_Ban.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.grd_Ban.Location = new System.Drawing.Point(0, 0);
            this.grd_Ban.Margin = new System.Windows.Forms.Padding(4);
            this.grd_Ban.MultiSelect = false;
            this.grd_Ban.Name = "grd_Ban";
            this.grd_Ban.ReadOnly = true;
            this.grd_Ban.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd_Ban.Size = new System.Drawing.Size(544, 411);
            this.grd_Ban.TabIndex = 0;
            this.grd_Ban.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_Ban_CellClick);
            this.grd_Ban.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_Ban_CellContentClick);
            this.grd_Ban.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.grd_Ban_RowsAdded);
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 61;
            // 
            // TenVietTat
            // 
            this.TenVietTat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TenVietTat.DataPropertyName = "_DESKID";
            this.TenVietTat.HeaderText = "Tên viết tắt";
            this.TenVietTat.Name = "TenVietTat";
            this.TenVietTat.ReadOnly = true;
            this.TenVietTat.Width = 150;
            // 
            // TENBAN
            // 
            this.TENBAN.DataPropertyName = "_DESKNAME";
            this.TENBAN.HeaderText = "Tên bàn";
            this.TENBAN.Name = "TENBAN";
            this.TENBAN.ReadOnly = true;
            // 
            // TRANGTHAI
            // 
            this.TRANGTHAI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TRANGTHAI.Checked = true;
            this.TRANGTHAI.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.TRANGTHAI.CheckValue = null;
            this.TRANGTHAI.DataPropertyName = "_DESKSTATUS";

            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TRANGTHAI.DefaultCellStyle = dataGridViewCellStyle3;

            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TRANGTHAI.DefaultCellStyle = dataGridViewCellStyle5;

            this.TRANGTHAI.HeaderText = "Trạng thái";
            this.TRANGTHAI.Name = "TRANGTHAI";
            this.TRANGTHAI.ReadOnly = true;
            // 
            // MaPhongBan
            // 
            this.MaPhongBan.DataPropertyName = "_DEPARTMENTID";
            this.MaPhongBan.HeaderText = "maphongban";
            this.MaPhongBan.Name = "MaPhongBan";
            this.MaPhongBan.ReadOnly = true;
            this.MaPhongBan.Visible = false;
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.btn_huy);
            this.panelEx2.Controls.Add(this.btn_Luu);
            this.panelEx2.Controls.Add(this.labelX5);
            this.panelEx2.Controls.Add(this.lbl_NoteInformation);
            this.panelEx2.Controls.Add(this.labelX1);
            this.panelEx2.Controls.Add(this.lbl_Note2);
            this.panelEx2.Controls.Add(this.btn_ChinhSua);
            this.panelEx2.Controls.Add(this.btn_ThemMoi);
            this.panelEx2.Controls.Add(this.chk_TrangThai);
            this.panelEx2.Controls.Add(this.txt_TenBan);
            this.panelEx2.Controls.Add(this.txt_TenVietTat);
            this.panelEx2.Controls.Add(this.labelX4);
            this.panelEx2.Controls.Add(this.labelX3);
            this.panelEx2.Controls.Add(this.labelX2);
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx2.Location = new System.Drawing.Point(544, 0);
            this.panelEx2.Margin = new System.Windows.Forms.Padding(4);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(340, 411);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 1;
            // 
            // btn_huy
            // 
            this.btn_huy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_huy.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_huy.Image = global::GUI.Properties.Resources.cancel1;
            this.btn_huy.Location = new System.Drawing.Point(180, 296);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(120, 35);
            this.btn_huy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_huy.TabIndex = 75;
            this.btn_huy.Text = "Hủy Bỏ";
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Luu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Luu.Image = global::GUI.Properties.Resources.Save_icon;
            this.btn_Luu.Location = new System.Drawing.Point(40, 296);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(120, 35);
            this.btn_Luu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Luu.TabIndex = 74;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.Location = new System.Drawing.Point(56, 27);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(228, 34);
            this.labelX5.TabIndex = 73;
            this.labelX5.Text = "Danh mục bàn thu ngân";
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
            this.lbl_NoteInformation.Location = new System.Drawing.Point(40, 345);
            this.lbl_NoteInformation.Name = "lbl_NoteInformation";
            this.lbl_NoteInformation.Size = new System.Drawing.Size(190, 23);
            this.lbl_NoteInformation.TabIndex = 72;
            this.lbl_NoteInformation.Text = "(*) là những thông tin bắt buộc";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ForeColor = System.Drawing.Color.Red;
            this.labelX1.Location = new System.Drawing.Point(305, 153);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(32, 23);
            this.labelX1.TabIndex = 66;
            this.labelX1.Text = "(*)";
            // 
            // lbl_Note2
            // 
            this.lbl_Note2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_Note2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Note2.ForeColor = System.Drawing.Color.Red;
            this.lbl_Note2.Location = new System.Drawing.Point(305, 110);
            this.lbl_Note2.Name = "lbl_Note2";
            this.lbl_Note2.Size = new System.Drawing.Size(32, 23);
            this.lbl_Note2.TabIndex = 65;
            this.lbl_Note2.Text = "(*)";
            // 
            // btn_ChinhSua
            // 

            this.btn_ChinhSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_ChinhSua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_ChinhSua.Image = global::GUI.Properties.Resources.Edit_icon;
            this.btn_ChinhSua.Location = new System.Drawing.Point(180, 246);
            this.btn_ChinhSua.Name = "btn_ChinhSua";
            this.btn_ChinhSua.Size = new System.Drawing.Size(120, 35);
            this.btn_ChinhSua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_ChinhSua.TabIndex = 4;
            this.btn_ChinhSua.Text = "Chỉnh sửa";

            this.btn_ChinhSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_ChinhSua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_ChinhSua.Image = global::GUI.Properties.Resources.Edit_icon;
            this.btn_ChinhSua.Location = new System.Drawing.Point(180, 246);
            this.btn_ChinhSua.Name = "btn_ChinhSua";
            this.btn_ChinhSua.Size = new System.Drawing.Size(120, 35);
            this.btn_ChinhSua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_ChinhSua.TabIndex = 4;
            this.btn_ChinhSua.Text = "Chỉnh sửa";
            this.btn_ChinhSua.Click += new System.EventHandler(this.btn_ChinhSua_Click);

            // 
            // btn_ThemMoi
            // 

            this.btn_ThemMoi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_ThemMoi.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_ThemMoi.Image = global::GUI.Properties.Resources.Actions_list_add_icon;
            this.btn_ThemMoi.Location = new System.Drawing.Point(40, 246);
            this.btn_ThemMoi.Name = "btn_ThemMoi";
            this.btn_ThemMoi.Size = new System.Drawing.Size(120, 35);
            this.btn_ThemMoi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_ThemMoi.TabIndex = 3;
            this.btn_ThemMoi.Text = "Thêm mới";

            this.btn_ThemMoi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_ThemMoi.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_ThemMoi.Image = global::GUI.Properties.Resources.Actions_list_add_icon;
            this.btn_ThemMoi.Location = new System.Drawing.Point(40, 246);
            this.btn_ThemMoi.Name = "btn_ThemMoi";
            this.btn_ThemMoi.Size = new System.Drawing.Size(120, 35);
            this.btn_ThemMoi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_ThemMoi.TabIndex = 3;
            this.btn_ThemMoi.Text = "Thêm mới";
            this.btn_ThemMoi.Click += new System.EventHandler(this.btn_ThemMoi_Click);

            // 
            // chk_TrangThai
            // 
            // 
            // 
            // 
            this.chk_TrangThai.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chk_TrangThai.Location = new System.Drawing.Point(150, 212);
            this.chk_TrangThai.Name = "chk_TrangThai";
            this.chk_TrangThai.Size = new System.Drawing.Size(134, 23);
            this.chk_TrangThai.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chk_TrangThai.TabIndex = 2;
            this.chk_TrangThai.Text = "Có";
            // 
            // txt_TenBan
            // 
            // 
            // 
            // 
            this.txt_TenBan.Border.Class = "TextBoxBorder";
            this.txt_TenBan.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_TenBan.Location = new System.Drawing.Point(150, 154);
            this.txt_TenBan.Name = "txt_TenBan";
            this.txt_TenBan.Size = new System.Drawing.Size(134, 26);
            this.txt_TenBan.TabIndex = 1;
            this.txt_TenBan.TextChanged += new System.EventHandler(this.txt_TenBan_TextChanged);
            // 
            // txt_TenVietTat
            // 
            // 
            // 
            // 
            this.txt_TenVietTat.Border.Class = "TextBoxBorder";
            this.txt_TenVietTat.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_TenVietTat.Location = new System.Drawing.Point(150, 107);
            this.txt_TenVietTat.MaxLength = 2;
            this.txt_TenVietTat.Name = "txt_TenVietTat";
            this.txt_TenVietTat.Size = new System.Drawing.Size(134, 26);
            this.txt_TenVietTat.TabIndex = 1;
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(56, 213);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 0;
            this.labelX4.Text = "Trạng thái";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(56, 157);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 0;
            this.labelX3.Text = "Tên bàn";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(56, 110);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "Tên viết tắt";
            // 
            // btn_huy
            // 
            this.btn_huy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_huy.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_huy.Image = global::GUI.Properties.Resources.cancel1;
            this.btn_huy.Location = new System.Drawing.Point(180, 296);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(120, 35);
            this.btn_huy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_huy.TabIndex = 75;
            this.btn_huy.Text = "Hủy Bỏ";
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Luu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Luu.Image = global::GUI.Properties.Resources.Save_icon;
            this.btn_Luu.Location = new System.Drawing.Point(40, 296);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(120, 35);
            this.btn_Luu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Luu.TabIndex = 74;
            this.btn_Luu.Text = "Lưu";
            // 
            // frm_ViewDetailDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(884, 411);
            this.Controls.Add(this.panelEx2);
            this.Controls.Add(this.panelEx1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frm_ViewDetailDepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh muc bàn thu ngân";
            this.Load += new System.EventHandler(this.frm_ViewDetailDepartment_Load);
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_Ban)).EndInit();
            this.panelEx2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.Controls.DataGridViewX grd_Ban;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.ButtonX btn_ChinhSua;
        private DevComponents.DotNetBar.ButtonX btn_ThemMoi;
        private DevComponents.DotNetBar.Controls.CheckBoxX chk_TrangThai;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_TenBan;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_TenVietTat;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX lbl_Note2;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX lbl_NoteInformation;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenVietTat;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENBAN;
        private DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn TRANGTHAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhongBan;
        private DevComponents.DotNetBar.ButtonX btn_huy;
        private DevComponents.DotNetBar.ButtonX btn_Luu;
    }
}