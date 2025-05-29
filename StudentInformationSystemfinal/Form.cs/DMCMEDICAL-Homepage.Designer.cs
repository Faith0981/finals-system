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
            this.accordionControlSeparator1 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.accHomePage = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.PATIENTS = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.CC_MA = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlSeparator1,
            this.accHomePage,
            this.PATIENTS,
            this.CC_MA});
            this.accordionControl1.Location = new System.Drawing.Point(0, 0);
            this.accordionControl1.Margin = new System.Windows.Forms.Padding(4);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.Size = new System.Drawing.Size(311, 633);
            this.accordionControl1.TabIndex = 4;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            this.accordionControl1.Click += new System.EventHandler(this.accordionControl1_Click);
            // 
            // accordionControlSeparator1
            // 
            this.accordionControlSeparator1.Name = "accordionControlSeparator1";
            // 
            // accHomePage
            // 
            this.accHomePage.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accHomePage.ImageOptions.SvgImage")));
            this.accHomePage.Name = "accHomePage";
            this.accHomePage.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accHomePage.Text = "Home Page";
            this.accHomePage.Click += new System.EventHandler(this.accHomePage_Click);
            // 
            // PATIENTS
            // 
            this.PATIENTS.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("PATIENTS.ImageOptions.SvgImage")));
            this.PATIENTS.Name = "PATIENTS";
            this.PATIENTS.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.PATIENTS.Text = "Patients";
            this.PATIENTS.Click += new System.EventHandler(this.PATIENTS_Click);
            // 
            // CC_MA
            // 
            this.CC_MA.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("CC_MA.ImageOptions.SvgImage")));
            this.CC_MA.Name = "CC_MA";
            this.CC_MA.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.CC_MA.Text = "CCMA";
            this.CC_MA.Click += new System.EventHandler(this.CC_MA_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(12, 553);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(262, 77);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "LOGOUT";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // DMCMEDICAL_Homepage
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 633);
            this.Controls.Add(this.simpleButton1);
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
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement PATIENTS;
        private DevExpress.XtraBars.Navigation.AccordionControlElement CC_MA;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accHomePage;
    }
}