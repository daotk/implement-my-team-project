namespace GUI.BaoCao
{
    partial class frm_ListBill
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.btn_InBaoCao = new DevComponents.DotNetBar.ButtonX();
            this.btn_XemBaoCao = new DevComponents.DotNetBar.ButtonX();
            this.cbo_Theo = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.comboItem4 = new DevComponents.Editors.ComboItem();
            this.dp_ChonNgay = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.lbl_Theo = new DevComponents.DotNetBar.LabelX();
            this.lbl_ChonNgay = new DevComponents.DotNetBar.LabelX();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaylap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dp_ChonNgay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.btn_InBaoCao);
            this.panelEx1.Controls.Add(this.btn_XemBaoCao);
            this.panelEx1.Controls.Add(this.cbo_Theo);
            this.panelEx1.Controls.Add(this.dp_ChonNgay);
            this.panelEx1.Controls.Add(this.lbl_Theo);
            this.panelEx1.Controls.Add(this.lbl_ChonNgay);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(1300, 40);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 4;
            // 
            // btn_InBaoCao
            // 
            this.btn_InBaoCao.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_InBaoCao.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_InBaoCao.Image = global::GUI.Properties.Resources.print_icon;
            this.btn_InBaoCao.Location = new System.Drawing.Point(931, 5);
            this.btn_InBaoCao.Name = "btn_InBaoCao";
            this.btn_InBaoCao.Size = new System.Drawing.Size(90, 30);
            this.btn_InBaoCao.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_InBaoCao.TabIndex = 8;
            // 
            // btn_XemBaoCao
            // 
            this.btn_XemBaoCao.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_XemBaoCao.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_XemBaoCao.Image = global::GUI.Properties.Resources.viewdoanhthu;
            this.btn_XemBaoCao.Location = new System.Drawing.Point(817, 5);
            this.btn_XemBaoCao.Name = "btn_XemBaoCao";
            this.btn_XemBaoCao.Size = new System.Drawing.Size(90, 30);
            this.btn_XemBaoCao.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_XemBaoCao.TabIndex = 7;
            // 
            // cbo_Theo
            // 
            this.cbo_Theo.DisplayMember = "Text";
            this.cbo_Theo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_Theo.FormattingEnabled = true;
            this.cbo_Theo.ItemHeight = 20;
            this.cbo_Theo.Items.AddRange(new object[] {
            this.comboItem3,
            this.comboItem4});
            this.cbo_Theo.Location = new System.Drawing.Point(331, 7);
            this.cbo_Theo.Name = "cbo_Theo";
            this.cbo_Theo.Size = new System.Drawing.Size(145, 26);
            this.cbo_Theo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbo_Theo.TabIndex = 6;
            // 
            // comboItem3
            // 
            this.comboItem3.Text = "Nhóm dịch vụ";
            // 
            // comboItem4
            // 
            this.comboItem4.Text = "Đơn vị thu ngân";
            // 
            // dp_ChonNgay
            // 
            // 
            // 
            // 
            this.dp_ChonNgay.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dp_ChonNgay.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dp_ChonNgay.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dp_ChonNgay.ButtonDropDown.Visible = true;
            this.dp_ChonNgay.IsPopupCalendarOpen = false;
            this.dp_ChonNgay.Location = new System.Drawing.Point(608, 7);
            // 
            // 
            // 
            this.dp_ChonNgay.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dp_ChonNgay.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dp_ChonNgay.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dp_ChonNgay.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dp_ChonNgay.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dp_ChonNgay.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dp_ChonNgay.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dp_ChonNgay.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dp_ChonNgay.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dp_ChonNgay.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dp_ChonNgay.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dp_ChonNgay.MonthCalendar.DisplayMonth = new System.DateTime(2013, 6, 1, 0, 0, 0, 0);
            this.dp_ChonNgay.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dp_ChonNgay.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dp_ChonNgay.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dp_ChonNgay.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dp_ChonNgay.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dp_ChonNgay.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dp_ChonNgay.MonthCalendar.TodayButtonVisible = true;
            this.dp_ChonNgay.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dp_ChonNgay.Name = "dp_ChonNgay";
            this.dp_ChonNgay.Size = new System.Drawing.Size(110, 26);
            this.dp_ChonNgay.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dp_ChonNgay.TabIndex = 4;
            // 
            // lbl_Theo
            // 
            // 
            // 
            // 
            this.lbl_Theo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Theo.Location = new System.Drawing.Point(279, 9);
            this.lbl_Theo.Name = "lbl_Theo";
            this.lbl_Theo.Size = new System.Drawing.Size(75, 23);
            this.lbl_Theo.TabIndex = 0;
            this.lbl_Theo.Text = "Theo";
            // 
            // lbl_ChonNgay
            // 
            // 
            // 
            // 
            this.lbl_ChonNgay.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_ChonNgay.Location = new System.Drawing.Point(523, 9);
            this.lbl_ChonNgay.Name = "lbl_ChonNgay";
            this.lbl_ChonNgay.Size = new System.Drawing.Size(75, 23);
            this.lbl_ChonNgay.TabIndex = 0;
            this.lbl_ChonNgay.Text = "Chọn ngày";
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewX1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewX1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewX1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaHoaDon,
            this.ngaylap,
            this.GioLap,
            this.MaBN,
            this.SoTien});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewX1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(0, 40);
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewX1.Size = new System.Drawing.Size(1300, 510);
            this.dataGridViewX1.TabIndex = 5;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // MaHoaDon
            // 
            this.MaHoaDon.HeaderText = "Mã hóa đơn";
            this.MaHoaDon.Name = "MaHoaDon";
            // 
            // ngaylap
            // 
            this.ngaylap.HeaderText = "Ngày lập";
            this.ngaylap.Name = "ngaylap";
            // 
            // GioLap
            // 
            this.GioLap.HeaderText = "Giờ lập";
            this.GioLap.Name = "GioLap";
            // 
            // MaBN
            // 
            this.MaBN.HeaderText = "Mã BN";
            this.MaBN.Name = "MaBN";
            // 
            // SoTien
            // 
            this.SoTien.HeaderText = "Tổng tiền";
            this.SoTien.Name = "SoTien";
            // 
            // frm_ListBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1300, 550);
            this.Controls.Add(this.dataGridViewX1);
            this.Controls.Add(this.panelEx1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_ListBill";
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dp_ChonNgay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.ButtonX btn_InBaoCao;
        private DevComponents.DotNetBar.ButtonX btn_XemBaoCao;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbo_Theo;
        private DevComponents.Editors.ComboItem comboItem3;
        private DevComponents.Editors.ComboItem comboItem4;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dp_ChonNgay;
        private DevComponents.DotNetBar.LabelX lbl_Theo;
        private DevComponents.DotNetBar.LabelX lbl_ChonNgay;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaylap;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTien;


    }
}