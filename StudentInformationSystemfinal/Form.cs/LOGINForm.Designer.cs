    namespace StudentInformationSystemfinal
{
    partial class LOGINForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOGINForm));
            this.teUserName = new DevExpress.XtraEditors.TextEdit();
            this.tePassword = new DevExpress.XtraEditors.TextEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.LOGIN = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cbeUserTypes = new DevExpress.XtraEditors.ComboBoxEdit();
            this.ALREADYHAVEANACCOUNT = new DevExpress.XtraEditors.SimpleButton();
            this.CREATEANACCOUNT = new DevExpress.XtraEditors.SimpleButton();
            this.FORGOTPASSWORD = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.teUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbeUserTypes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // teUserName
            // 
            this.teUserName.Location = new System.Drawing.Point(755, 98);
            this.teUserName.Name = "teUserName";
            this.teUserName.Properties.AdvancedModeOptions.Label = "UserName";
            this.teUserName.Properties.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.teUserName.Properties.Appearance.Options.UseForeColor = true;
            this.teUserName.Properties.AutoHeight = false;
            this.teUserName.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("teUserName.Properties.ContextImageOptions.Image")));
            this.teUserName.Properties.ContextImageOptions.ImageUri.Uri = "outlook%20inspired/miss";
            this.teUserName.Size = new System.Drawing.Size(489, 60);
            this.teUserName.TabIndex = 1;
            this.teUserName.EditValueChanged += new System.EventHandler(this.teUserName_EditValueChanged);
            // 
            // tePassword
            // 
            this.tePassword.EditValue = "";
            this.tePassword.Location = new System.Drawing.Point(755, 181);
            this.tePassword.Name = "tePassword";
            this.tePassword.Properties.AdvancedModeOptions.Label = "Password";
            this.tePassword.Properties.AutoHeight = false;
            this.tePassword.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tePassword.Properties.ContextImageOptions.Image")));
            this.tePassword.Properties.ContextImageOptions.ImageUri.Uri = "business%20objects/bo_security_permission";
            this.tePassword.Properties.PasswordChar = '*';
            this.tePassword.Properties.UseSystemPasswordChar = true;
            this.tePassword.Size = new System.Drawing.Size(489, 62);
            this.tePassword.TabIndex = 2;
            this.tePassword.EditValueChanged += new System.EventHandler(this.tePassword_EditValueChanged);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1441, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 772);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1441, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 772);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1441, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 772);
            // 
            // LOGIN
            // 
            this.LOGIN.Appearance.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOGIN.Appearance.Options.UseFont = true;
            this.LOGIN.Location = new System.Drawing.Point(843, 398);
            this.LOGIN.Name = "LOGIN";
            this.LOGIN.Size = new System.Drawing.Size(302, 71);
            this.LOGIN.TabIndex = 12;
            this.LOGIN.Text = "LOGIN";
            this.LOGIN.Click += new System.EventHandler(this.LOGIN_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelControl1.ContentImage = ((System.Drawing.Image)(resources.GetObject("panelControl1.ContentImage")));
            this.panelControl1.Controls.Add(this.cbeUserTypes);
            this.panelControl1.Controls.Add(this.ALREADYHAVEANACCOUNT);
            this.panelControl1.Controls.Add(this.CREATEANACCOUNT);
            this.panelControl1.Controls.Add(this.FORGOTPASSWORD);
            this.panelControl1.Controls.Add(this.pictureEdit1);
            this.panelControl1.Controls.Add(this.LOGIN);
            this.panelControl1.Controls.Add(this.tePassword);
            this.panelControl1.Controls.Add(this.teUserName);
            this.panelControl1.Location = new System.Drawing.Point(-6, -3);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1870, 771);
            this.panelControl1.TabIndex = 17;
            // 
            // cbeUserTypes
            // 
            this.cbeUserTypes.Location = new System.Drawing.Point(755, 285);
            this.cbeUserTypes.MenuManager = this.barManager1;
            this.cbeUserTypes.Name = "cbeUserTypes";
            this.cbeUserTypes.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeUserTypes.Properties.Items.AddRange(new object[] {
            "Administrator",
            "Nurse"});
            this.cbeUserTypes.Size = new System.Drawing.Size(489, 56);
            this.cbeUserTypes.TabIndex = 18;
            // 
            // ALREADYHAVEANACCOUNT
            // 
            this.ALREADYHAVEANACCOUNT.AppearancePressed.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ALREADYHAVEANACCOUNT.AppearancePressed.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.ALREADYHAVEANACCOUNT.AppearancePressed.ForeColor = System.Drawing.Color.Black;
            this.ALREADYHAVEANACCOUNT.AppearancePressed.Options.UseBackColor = true;
            this.ALREADYHAVEANACCOUNT.AppearancePressed.Options.UseBorderColor = true;
            this.ALREADYHAVEANACCOUNT.AppearancePressed.Options.UseForeColor = true;
            this.ALREADYHAVEANACCOUNT.Location = new System.Drawing.Point(706, 541);
            this.ALREADYHAVEANACCOUNT.Name = "ALREADYHAVEANACCOUNT";
            this.ALREADYHAVEANACCOUNT.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.ALREADYHAVEANACCOUNT.Size = new System.Drawing.Size(269, 39);
            this.ALREADYHAVEANACCOUNT.TabIndex = 17;
            this.ALREADYHAVEANACCOUNT.Text = "Already Have an Account?";
            // 
            // CREATEANACCOUNT
            // 
            this.CREATEANACCOUNT.AppearancePressed.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.CREATEANACCOUNT.AppearancePressed.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.CREATEANACCOUNT.AppearancePressed.ForeColor = System.Drawing.Color.Black;
            this.CREATEANACCOUNT.AppearancePressed.Options.UseBackColor = true;
            this.CREATEANACCOUNT.AppearancePressed.Options.UseBorderColor = true;
            this.CREATEANACCOUNT.AppearancePressed.Options.UseForeColor = true;
            this.CREATEANACCOUNT.Location = new System.Drawing.Point(1028, 541);
            this.CREATEANACCOUNT.Name = "CREATEANACCOUNT";
            this.CREATEANACCOUNT.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.CREATEANACCOUNT.Size = new System.Drawing.Size(269, 39);
            this.CREATEANACCOUNT.TabIndex = 16;
            this.CREATEANACCOUNT.Text = "Sign Up";
            // 
            // FORGOTPASSWORD
            // 
            this.FORGOTPASSWORD.Appearance.ForeColor = System.Drawing.Color.Black;
            this.FORGOTPASSWORD.Appearance.Options.UseForeColor = true;
            this.FORGOTPASSWORD.AppearancePressed.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.FORGOTPASSWORD.AppearancePressed.ForeColor = System.Drawing.Color.Black;
            this.FORGOTPASSWORD.AppearancePressed.Options.UseBackColor = true;
            this.FORGOTPASSWORD.AppearancePressed.Options.UseForeColor = true;
            this.FORGOTPASSWORD.Location = new System.Drawing.Point(900, 484);
            this.FORGOTPASSWORD.Name = "FORGOTPASSWORD";
            this.FORGOTPASSWORD.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.FORGOTPASSWORD.Size = new System.Drawing.Size(186, 41);
            this.FORGOTPASSWORD.TabIndex = 14;
            this.FORGOTPASSWORD.Text = "Forgot Password?";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(0, 0);
            this.pictureEdit1.MenuManager = this.barManager1;
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(700, 771);
            this.pictureEdit1.TabIndex = 13;
            // 
            // LOGINForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1441, 772);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.DoubleBuffered = true;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("LOGINForm.IconOptions.Image")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "LOGINForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STUDENT HEALTH MONITORING SYSTEM";
            this.Load += new System.EventHandler(this.StudentInformationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbeUserTypes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion  
        private DevExpress.XtraEditors.TextEdit teUserName;
        private DevExpress.XtraEditors.TextEdit tePassword;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.SimpleButton LOGIN;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.SimpleButton FORGOTPASSWORD;
        private DevExpress.XtraEditors.SimpleButton CREATEANACCOUNT;
        private DevExpress.XtraEditors.SimpleButton ALREADYHAVEANACCOUNT;
        private DevExpress.XtraEditors.ComboBoxEdit cbeUserTypes;
    }
}

