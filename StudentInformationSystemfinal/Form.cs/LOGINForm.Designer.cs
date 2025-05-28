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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbeUserTypes = new DevExpress.XtraEditors.ComboBoxEdit();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.teUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeUserTypes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // teUserName
            // 
            this.teUserName.Location = new System.Drawing.Point(531, 97);
            this.teUserName.Margin = new System.Windows.Forms.Padding(2);
            this.teUserName.Name = "teUserName";
            this.teUserName.Properties.AdvancedModeOptions.Label = "UserName";
            this.teUserName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(242)))), ((int)(((byte)(226)))));
            this.teUserName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teUserName.Properties.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.teUserName.Properties.Appearance.Options.UseBackColor = true;
            this.teUserName.Properties.Appearance.Options.UseFont = true;
            this.teUserName.Properties.Appearance.Options.UseForeColor = true;
            this.teUserName.Properties.AutoHeight = false;
            this.teUserName.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("teUserName.Properties.ContextImageOptions.Image")));
            this.teUserName.Properties.ContextImageOptions.ImageUri.Uri = "outlook%20inspired/miss";
            this.teUserName.Size = new System.Drawing.Size(285, 50);
            this.teUserName.TabIndex = 1;
            this.teUserName.EditValueChanged += new System.EventHandler(this.teUserName_EditValueChanged);
            // 
            // tePassword
            // 
            this.tePassword.EditValue = "";
            this.tePassword.Location = new System.Drawing.Point(531, 173);
            this.tePassword.Margin = new System.Windows.Forms.Padding(2);
            this.tePassword.Name = "tePassword";
            this.tePassword.Properties.AdvancedModeOptions.Label = "Password";
            this.tePassword.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(242)))), ((int)(((byte)(226)))));
            this.tePassword.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tePassword.Properties.Appearance.Options.UseBackColor = true;
            this.tePassword.Properties.Appearance.Options.UseFont = true;
            this.tePassword.Properties.AutoHeight = false;
            this.tePassword.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tePassword.Properties.ContextImageOptions.Image")));
            this.tePassword.Properties.ContextImageOptions.ImageUri.Uri = "business%20objects/bo_security_permission";
            this.tePassword.Properties.PasswordChar = '*';
            this.tePassword.Properties.UseSystemPasswordChar = true;
            this.tePassword.Size = new System.Drawing.Size(285, 50);
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
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlTop.Size = new System.Drawing.Size(841, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 494);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlBottom.Size = new System.Drawing.Size(841, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 494);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(841, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 494);
            // 
            // LOGIN
            // 
            this.LOGIN.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(138)))), ((int)(((byte)(102)))));
            this.LOGIN.Appearance.BorderColor = System.Drawing.Color.Black;
            this.LOGIN.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOGIN.Appearance.ForeColor = System.Drawing.Color.Black;
            this.LOGIN.Appearance.Options.UseBackColor = true;
            this.LOGIN.Appearance.Options.UseBorderColor = true;
            this.LOGIN.Appearance.Options.UseFont = true;
            this.LOGIN.Appearance.Options.UseForeColor = true;
            this.LOGIN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LOGIN.Location = new System.Drawing.Point(579, 312);
            this.LOGIN.Margin = new System.Windows.Forms.Padding(2);
            this.LOGIN.Name = "LOGIN";
            this.LOGIN.Size = new System.Drawing.Size(176, 45);
            this.LOGIN.TabIndex = 12;
            this.LOGIN.Text = "LOGIN";
            this.LOGIN.Click += new System.EventHandler(this.LOGIN_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Appearance.Options.UseForeColor = true;
            this.panelControl1.AutoSize = true;
            this.panelControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelControl1.Controls.Add(this.pictureBox1);
            this.panelControl1.Controls.Add(this.cbeUserTypes);
            this.panelControl1.Controls.Add(this.LOGIN);
            this.panelControl1.Controls.Add(this.tePassword);
            this.panelControl1.Controls.Add(this.teUserName);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(841, 494);
            this.panelControl1.TabIndex = 17;
            this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(497, 494);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cbeUserTypes
            // 
            this.cbeUserTypes.Location = new System.Drawing.Point(531, 250);
            this.cbeUserTypes.Margin = new System.Windows.Forms.Padding(2);
            this.cbeUserTypes.MenuManager = this.barManager1;
            this.cbeUserTypes.Name = "cbeUserTypes";
            this.cbeUserTypes.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(242)))), ((int)(((byte)(226)))));
            this.cbeUserTypes.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbeUserTypes.Properties.Appearance.Options.UseBackColor = true;
            this.cbeUserTypes.Properties.Appearance.Options.UseFont = true;
            this.cbeUserTypes.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeUserTypes.Properties.Items.AddRange(new object[] {
            "Administrator",
            "Nurse"});
            this.cbeUserTypes.Size = new System.Drawing.Size(285, 42);
            this.cbeUserTypes.TabIndex = 18;
            // 
            // LOGINForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(230)))), ((int)(((byte)(210)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(841, 494);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.DoubleBuffered = true;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("LOGINForm.IconOptions.Image")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LOGINForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STUDENT HEALTH MONITORING SYSTEM";
            this.Load += new System.EventHandler(this.StudentInformationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeUserTypes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
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
        private DevExpress.XtraEditors.ComboBoxEdit cbeUserTypes;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

