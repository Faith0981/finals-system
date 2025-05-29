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
            this.btnAddPatients = new DevExpress.XtraEditors.SimpleButton();
            this.btnCCMA = new DevExpress.XtraEditors.SimpleButton();
            this.btnTotalPatients = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lblSubheader = new DevExpress.XtraEditors.LabelControl();
            this.lblWelcome = new DevExpress.XtraEditors.LabelControl();
            this.toggleSwitch1 = new DevExpress.XtraEditors.ToggleSwitch();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddPatients
            // 
            this.btnAddPatients.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPatients.Appearance.Options.UseFont = true;
            this.btnAddPatients.AppearancePressed.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAddPatients.AppearancePressed.Options.UseBackColor = true;
            this.btnAddPatients.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAddPatients.ImageOptions.SvgImage")));
            this.btnAddPatients.Location = new System.Drawing.Point(371, 279);
            this.btnAddPatients.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddPatients.Name = "btnAddPatients";
            this.btnAddPatients.Size = new System.Drawing.Size(269, 168);
            this.btnAddPatients.TabIndex = 0;
            this.btnAddPatients.Text = "ADD PATIENT";
            this.btnAddPatients.Click += new System.EventHandler(this.ADDPATIENT_Click);
            // 
            // btnCCMA
            // 
            this.btnCCMA.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCCMA.Appearance.Options.UseFont = true;
            this.btnCCMA.AppearancePressed.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnCCMA.AppearancePressed.Options.UseBackColor = true;
            this.btnCCMA.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCCMA.ImageOptions.SvgImage")));
            this.btnCCMA.Location = new System.Drawing.Point(688, 279);
            this.btnCCMA.Margin = new System.Windows.Forms.Padding(2);
            this.btnCCMA.Name = "btnCCMA";
            this.btnCCMA.Size = new System.Drawing.Size(375, 168);
            this.btnCCMA.TabIndex = 1;
            this.btnCCMA.Text = "          CHIEF COMPLAINT\r\n          MEDICAL ASSESSMENT";
            this.btnCCMA.Click += new System.EventHandler(this.btnCCMA_Click);
            // 
            // btnTotalPatients
            // 
            this.btnTotalPatients.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalPatients.Appearance.Options.UseFont = true;
            this.btnTotalPatients.AppearancePressed.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnTotalPatients.AppearancePressed.Options.UseBackColor = true;
            this.btnTotalPatients.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTotalPatients.ImageOptions.SvgImage")));
            this.btnTotalPatients.Location = new System.Drawing.Point(26, 279);
            this.btnTotalPatients.Margin = new System.Windows.Forms.Padding(2);
            this.btnTotalPatients.Name = "btnTotalPatients";
            this.btnTotalPatients.Size = new System.Drawing.Size(269, 168);
            this.btnTotalPatients.TabIndex = 13;
            this.btnTotalPatients.Text = "TOTAL PATIENTS";
            this.btnTotalPatients.Click += new System.EventHandler(this.btnTotalPatients_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.SeaGreen;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.lblSubheader);
            this.panelControl1.Controls.Add(this.lblWelcome);
            this.panelControl1.Location = new System.Drawing.Point(21, 35);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1037, 112);
            this.panelControl1.TabIndex = 14;
            // 
            // lblSubheader
            // 
            this.lblSubheader.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.lblSubheader.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblSubheader.Appearance.Options.UseFont = true;
            this.lblSubheader.Appearance.Options.UseForeColor = true;
            this.lblSubheader.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblSubheader.Location = new System.Drawing.Point(189, 59);
            this.lblSubheader.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lblSubheader.Name = "lblSubheader";
            this.lblSubheader.Size = new System.Drawing.Size(669, 40);
            this.lblSubheader.TabIndex = 1;
            this.lblSubheader.Text = "                 Providing quality healthcare services for our students and commu" +
    "nity";
            // 
            // lblWelcome
            // 
            this.lblWelcome.Appearance.BackColor = System.Drawing.Color.SeaGreen;
            this.lblWelcome.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblWelcome.Appearance.Options.UseBackColor = true;
            this.lblWelcome.Appearance.Options.UseFont = true;
            this.lblWelcome.Appearance.Options.UseForeColor = true;
            this.lblWelcome.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblWelcome.Location = new System.Drawing.Point(245, 3);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(558, 61);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "WELCOME TO DMC MEDICAL CLINIC";
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
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
            this.Controls.Add(this.btnCCMA);
            this.Controls.Add(this.btnTotalPatients);
            this.Controls.Add(this.btnAddPatients);
            this.Controls.Add(this.toggleSwitch1);
            this.Controls.Add(this.panelControl1);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("DMCMEDICAL_Homepage2.IconOptions.Image")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DMCMEDICAL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DMCMEDICAL";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DMCMEDICAL_Homepage2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnAddPatients;
        private DevExpress.XtraEditors.SimpleButton btnCCMA;
        private DevExpress.XtraEditors.SimpleButton btnTotalPatients;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl lblSubheader;
        private DevExpress.XtraEditors.LabelControl lblWelcome;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitch1;
    }
}