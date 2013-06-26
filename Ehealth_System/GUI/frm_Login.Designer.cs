namespace GUI
{
    partial class frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            this.btn_Cancel = new DevComponents.DotNetBar.ButtonX();
            this.txt_UserName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbl_Username = new DevComponents.DotNetBar.LabelX();
            this.lbl_Password = new DevComponents.DotNetBar.LabelX();
            this.txt_Password = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btn_Submit = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Cancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Image = global::GUI.Properties.Resources.cancel1;
            this.btn_Cancel.Location = new System.Drawing.Point(220, 174);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(120, 35);
            this.btn_Cancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
            this.btn_Cancel.TabIndex = 3;
            this.btn_Cancel.Text = "Hủy bỏ";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // txt_UserName
            // 
            // 
            // 
            // 
            this.txt_UserName.Border.Class = "TextBoxBorder";
            this.txt_UserName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UserName.Location = new System.Drawing.Point(172, 35);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(188, 26);
            this.txt_UserName.TabIndex = 0;
            // 
            // lbl_Username
            // 
            // 
            // 
            // 
            this.lbl_Username.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.Location = new System.Drawing.Point(48, 38);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(118, 23);
            this.lbl_Username.TabIndex = 3;
            this.lbl_Username.Text = "Tên đăng nhập";
            // 
            // lbl_Password
            // 
            // 
            // 
            // 
            this.lbl_Password.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(48, 90);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(105, 23);
            this.lbl_Password.TabIndex = 3;
            this.lbl_Password.Text = "Mật khẩu";
            // 
            // txt_Password
            // 
            // 
            // 
            // 
            this.txt_Password.Border.Class = "TextBoxBorder";
            this.txt_Password.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.Location = new System.Drawing.Point(172, 90);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(188, 26);
            this.txt_Password.TabIndex = 1;
            this.txt_Password.UseSystemPasswordChar = true;
            // 
            // btn_Submit
            // 
            this.btn_Submit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Submit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.Image = global::GUI.Properties.Resources.login;
            this.btn_Submit.Location = new System.Drawing.Point(72, 174);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(120, 35);
            this.btn_Submit.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
            this.btn_Submit.TabIndex = 2;
            this.btn_Submit.Text = "Đăng nhập";
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // frm_Login
            // 
            this.AcceptButton = this.btn_Submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(408, 244);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_UserName);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Submit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.frm_Login_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btn_Submit;
        private DevComponents.DotNetBar.ButtonX btn_Cancel;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_UserName;
        private DevComponents.DotNetBar.LabelX lbl_Username;
        private DevComponents.DotNetBar.LabelX lbl_Password;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_Password;
    }
}

