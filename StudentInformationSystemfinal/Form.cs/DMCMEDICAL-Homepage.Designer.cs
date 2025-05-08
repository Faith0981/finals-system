namespace StudentInformationSystemfinal.Form.cs
{
    partial class DMCMEDICAL_Homepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMCMEDICAL_Homepage));
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.HOME = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSeparator2 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.accordionControlSeparator3 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.USER = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSeparator1 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.PATIENTS = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.CC_MA = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.HOME,
            this.USER,
            this.accordionControlSeparator1,
            this.PATIENTS,
            this.CC_MA});
            this.accordionControl1.Location = new System.Drawing.Point(0, 0);
            this.accordionControl1.Margin = new System.Windows.Forms.Padding(4);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.OptionsMinimizing.State = DevExpress.XtraBars.Navigation.AccordionControlState.Minimized;
            this.accordionControl1.Size = new System.Drawing.Size(96, 1142);
            this.accordionControl1.TabIndex = 4;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // HOME
            // 
            this.HOME.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlSeparator2,
            this.accordionControlSeparator3});
            this.HOME.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("HOME.ImageOptions.Image")));
            this.HOME.Name = "HOME";
            this.HOME.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.HOME.Text = "Home";
            this.HOME.Click += new System.EventHandler(this.HOME_Click);
            // 
            // accordionControlSeparator2
            // 
            this.accordionControlSeparator2.Name = "accordionControlSeparator2";
            this.accordionControlSeparator2.Visible = false;
            // 
            // accordionControlSeparator3
            // 
            this.accordionControlSeparator3.Name = "accordionControlSeparator3";
            this.accordionControlSeparator3.Visible = false;
            // 
            // USER
            // 
            this.USER.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("USER.ImageOptions.Image")));
            this.USER.Name = "USER";
            this.USER.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.USER.Text = "User";
            this.USER.Click += new System.EventHandler(this.USER_Click);
            // 
            // accordionControlSeparator1
            // 
            this.accordionControlSeparator1.Name = "accordionControlSeparator1";
            // 
            // PATIENTS
            // 
            this.PATIENTS.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("PATIENTS.ImageOptions.Image")));
            this.PATIENTS.Name = "PATIENTS";
            this.PATIENTS.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.PATIENTS.Text = "Patients";
            this.PATIENTS.Click += new System.EventHandler(this.PATIENTS_Click);
            // 
            // CC_MA
            // 
            this.CC_MA.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("CC_MA.ImageOptions.Image")));
            this.CC_MA.Name = "CC_MA";
            this.CC_MA.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.CC_MA.Text = "CC&MA";
            this.CC_MA.Click += new System.EventHandler(this.CC_MA_Click);
            // 
            // DMCMEDICAL_Homepage
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2370, 1142);
            this.Controls.Add(this.accordionControl1);
            this.Font = new System.Drawing.Font("Tahoma", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("DMCMEDICAL_Homepage.IconOptions.Image")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DMCMEDICAL_Homepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DMCMEDICAL_Homepage";
            this.Load += new System.EventHandler(this.DMCMEDICAL_Homepage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement HOME;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator2;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator3;
        private DevExpress.XtraBars.Navigation.AccordionControlElement USER;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement PATIENTS;
        private DevExpress.XtraBars.Navigation.AccordionControlElement CC_MA;
    }
}