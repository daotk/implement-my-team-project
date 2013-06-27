namespace GUI
{
    partial class frm_Config
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Config));
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txt_TenBenhVien = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btn_Luu = new DevComponents.DotNetBar.ButtonX();
            this.btn_HuyBo = new DevComponents.DotNetBar.ButtonX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.lbl_GiaoDienLon = new DevComponents.DotNetBar.LabelX();
            this.checkBoxX1 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(157, 13);
            this.labelX1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(171, 33);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Cấu hình hệ thống";
            // 
            // txt_TenBenhVien
            // 
            // 
            // 
            // 
            this.txt_TenBenhVien.Border.Class = "TextBoxBorder";
            this.txt_TenBenhVien.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_TenBenhVien.Location = new System.Drawing.Point(187, 68);
            this.txt_TenBenhVien.Name = "txt_TenBenhVien";
            this.txt_TenBenhVien.Size = new System.Drawing.Size(191, 26);
            this.txt_TenBenhVien.TabIndex = 1;
            // 
            // btn_Luu
            // 
            this.btn_Luu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Luu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Luu.Location = new System.Drawing.Point(98, 292);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(120, 35);
            this.btn_Luu.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
            this.btn_Luu.TabIndex = 2;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_HuyBo
            // 
            this.btn_HuyBo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_HuyBo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_HuyBo.Location = new System.Drawing.Point(267, 292);
            this.btn_HuyBo.Name = "btn_HuyBo";
            this.btn_HuyBo.Size = new System.Drawing.Size(120, 35);
            this.btn_HuyBo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_HuyBo.TabIndex = 3;
            this.btn_HuyBo.Text = "Hủy bỏ";
            this.btn_HuyBo.Click += new System.EventHandler(this.btn_HuyBo_Click);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(53, 71);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(119, 23);
            this.labelX2.TabIndex = 4;
            this.labelX2.Text = "Tên bệnh viện";
            // 
            // lbl_GiaoDienLon
            // 
            // 
            // 
            // 
            this.lbl_GiaoDienLon.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_GiaoDienLon.Location = new System.Drawing.Point(53, 124);
            this.lbl_GiaoDienLon.Name = "lbl_GiaoDienLon";
            this.lbl_GiaoDienLon.Size = new System.Drawing.Size(119, 23);
            this.lbl_GiaoDienLon.TabIndex = 5;
            this.lbl_GiaoDienLon.Text = "Mở giao diện lớn";
            // 
            // checkBoxX1
            // 
            // 
            // 
            // 
            this.checkBoxX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxX1.Location = new System.Drawing.Point(187, 123);
            this.checkBoxX1.Name = "checkBoxX1";
            this.checkBoxX1.Size = new System.Drawing.Size(100, 23);
            this.checkBoxX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxX1.TabIndex = 6;
            this.checkBoxX1.Text = "Có";
            // 
            // frm_Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.checkBoxX1);
            this.Controls.Add(this.lbl_GiaoDienLon);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.btn_HuyBo);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.txt_TenBenhVien);
            this.Controls.Add(this.labelX1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frm_Config";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cấu hình";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_TenBenhVien;
        private DevComponents.DotNetBar.ButtonX btn_Luu;
        private DevComponents.DotNetBar.ButtonX btn_HuyBo;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX lbl_GiaoDienLon;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxX1;


    }
}