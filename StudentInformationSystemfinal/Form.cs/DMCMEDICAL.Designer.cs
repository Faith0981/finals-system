namespace StudentInformationSystemfinal
{
    partial class DMCMEDICAL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMCMEDICAL));
            this.btnAddPatientsc = new DevExpress.XtraEditors.SimpleButton();
            this.btnCCMAc = new DevExpress.XtraEditors.SimpleButton();
            this.btnTotalPatientsc = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1c = new DevExpress.XtraEditors.PanelControl();
            this.lblSubheaderc = new DevExpress.XtraEditors.LabelControl();
            this.lblWelcomec = new DevExpress.XtraEditors.LabelControl();
            this.toggleSwitch1 = new DevExpress.XtraEditors.ToggleSwitch();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1c)).BeginInit();
            this.panelControl1c.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddPatientsc
            // 
            this.btnAddPatientsc.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPatientsc.Appearance.Options.UseFont = true;
            this.btnAddPatientsc.AppearancePressed.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAddPatientsc.AppearancePressed.Options.UseBackColor = true;
            this.btnAddPatientsc.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAddPatients.ImageOptions.SvgImage")));
            this.btnAddPatientsc.Location = new System.Drawing.Point(371, 279);
            this.btnAddPatientsc.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddPatientsc.Name = "btnAddPatientsc";
            this.btnAddPatientsc.Size = new System.Drawing.Size(269, 168);
            this.btnAddPatientsc.TabIndex = 0;
            this.btnAddPatientsc.Text = "ADD PATIENT";
            this.btnAddPatientsc.Click += new System.EventHandler(this.ADDPATIENT_Click);
            // 
            // btnCCMAc
            // 
            this.btnCCMAc.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCCMAc.Appearance.Options.UseFont = true;
            this.btnCCMAc.AppearancePressed.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnCCMAc.AppearancePressed.Options.UseBackColor = true;
            this.btnCCMAc.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCCMA.ImageOptions.SvgImage")));
            this.btnCCMAc.Location = new System.Drawing.Point(688, 279);
            this.btnCCMAc.Margin = new System.Windows.Forms.Padding(2);
            this.btnCCMAc.Name = "btnCCMAc";
            this.btnCCMAc.Size = new System.Drawing.Size(375, 168);
            this.btnCCMAc.TabIndex = 1;
            this.btnCCMAc.Text = "          CHIEF COMPLAINT\r\n          MEDICAL ASSESSMENT";
            this.btnCCMAc.Click += new System.EventHandler(this.btnCCMA_Click);
            // 
            // btnTotalPatientsc
            // 
            this.btnTotalPatientsc.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalPatientsc.Appearance.Options.UseFont = true;
            this.btnTotalPatientsc.AppearancePressed.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnTotalPatientsc.AppearancePressed.Options.UseBackColor = true;
            this.btnTotalPatientsc.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTotalPatients.ImageOptions.SvgImage")));
            this.btnTotalPatientsc.Location = new System.Drawing.Point(26, 279);
            this.btnTotalPatientsc.Margin = new System.Windows.Forms.Padding(2);
            this.btnTotalPatientsc.Name = "btnTotalPatientsc";
            this.btnTotalPatientsc.Size = new System.Drawing.Size(269, 168);
            this.btnTotalPatientsc.TabIndex = 13;
            this.btnTotalPatientsc.Text = "TOTAL PATIENTS";
            this.btnTotalPatientsc.Click += new System.EventHandler(this.btnTotalPatients_Click);
            // 
            // panelControl1c
            // 
            this.panelControl1c.Appearance.BackColor = System.Drawing.Color.SeaGreen;
            this.panelControl1c.Appearance.Options.UseBackColor = true;
            this.panelControl1c.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1c.Controls.Add(this.lblSubheaderc);
            this.panelControl1c.Controls.Add(this.lblWelcomec);
            this.panelControl1c.Location = new System.Drawing.Point(21, 35);
            this.panelControl1c.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelControl1c.Name = "panelControl1c";
            this.panelControl1c.Size = new System.Drawing.Size(1037, 112);
            this.panelControl1c.TabIndex = 14;
            // 
            // lblSubheaderc
            // 
            this.lblSubheaderc.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.lblSubheaderc.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblSubheaderc.Appearance.Options.UseFont = true;
            this.lblSubheaderc.Appearance.Options.UseForeColor = true;
            this.lblSubheaderc.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblSubheaderc.Location = new System.Drawing.Point(189, 59);
            this.lblSubheaderc.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lblSubheaderc.Name = "lblSubheaderc";
            this.lblSubheaderc.Size = new System.Drawing.Size(669, 40);
            this.lblSubheaderc.TabIndex = 1;
            this.lblSubheaderc.Text = "                 Providing quality healthcare services for our students and commu" +
    "nity";
            // 
            // lblWelcomec
            // 
            this.lblWelcomec.Appearance.BackColor = System.Drawing.Color.SeaGreen;
            this.lblWelcomec.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomec.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblWelcomec.Appearance.Options.UseBackColor = true;
            this.lblWelcomec.Appearance.Options.UseFont = true;
            this.lblWelcomec.Appearance.Options.UseForeColor = true;
            this.lblWelcomec.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblWelcomec.Location = new System.Drawing.Point(245, 3);
            this.lblWelcomec.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lblWelcomec.Name = "lblWelcomec";
            this.lblWelcomec.Size = new System.Drawing.Size(558, 61);
            this.lblWelcomec.TabIndex = 0;
            this.lblWelcomec.Text = "WELCOME TO DMC MEDICAL CLINIC";
            this.lblWelcomec.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // toggleSwitch1
            // 
            this.toggleSwitch1.Location = new System.Drawing.Point(956, -1);
            this.toggleSwitch1.Margin = new System.Windows.Forms.Padding(2);
            this.toggleSwitch1.Name = "toggleSwitch1";
            this.toggleSwitch1.Properties.AutoHeight = false;
            this.toggleSwitch1.Properties.OffText = "Off";
            this.toggleSwitch1.Properties.OnText = "On";
            this.toggleSwitch1.Size = new System.Drawing.Size(102, 31);
            this.toggleSwitch1.TabIndex = 20;
            this.toggleSwitch1.Toggled += new System.EventHandler(this.toggleSwitch1_Toggled_1);
            // 
            // DMCMEDICAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 559);
            this.Controls.Add(this.btnCCMAc);
            this.Controls.Add(this.btnTotalPatientsc);
            this.Controls.Add(this.btnAddPatientsc);
            this.Controls.Add(this.toggleSwitch1);
            this.Controls.Add(this.panelControl1c);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("DMCMEDICAL.IconOptions.Image")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DMCMEDICAL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DMCMEDICAL";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DMCMEDICAL_Homepage2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1c)).EndInit();
            this.panelControl1c.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnAddPatientsc;
        private DevExpress.XtraEditors.SimpleButton btnCCMAc;
        private DevExpress.XtraEditors.SimpleButton btnTotalPatientsc;
        private DevExpress.XtraEditors.PanelControl panelControl1c;
        private DevExpress.XtraEditors.LabelControl lblSubheaderc;
        private DevExpress.XtraEditors.LabelControl lblWelcomec;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitch1;
    }
}