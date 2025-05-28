namespace StudentInformationSystemfinal.Form.cs
{
    partial class ADD_PATIENT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADD_PATIENT));
            this.teFirstName = new DevExpress.XtraEditors.TextEdit();
            this.teLastName = new DevExpress.XtraEditors.TextEdit();
            this.teParent = new DevExpress.XtraEditors.TextEdit();
            this.teAddress = new DevExpress.XtraEditors.TextEdit();
            this.FIRSTNAME = new DevExpress.XtraEditors.LabelControl();
            this.teEmergencyPhoneNumber = new DevExpress.XtraEditors.TextEdit();
            this.teAge = new DevExpress.XtraEditors.TextEdit();
            this.btnAddPatient = new DevExpress.XtraEditors.SimpleButton();
            this.deBirthdate = new DevExpress.XtraEditors.DateEdit();
            this.meAllergies = new DevExpress.XtraEditors.MemoEdit();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbe_Course = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.teContactNumber = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.teFirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teParent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teEmergencyPhoneNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teAge.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deBirthdate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deBirthdate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meAllergies.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbe_Course.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teContactNumber.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // teFirstName
            // 
            this.teFirstName.Location = new System.Drawing.Point(138, 83);
            this.teFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.teFirstName.Name = "teFirstName";
            this.teFirstName.Properties.Appearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.teFirstName.Properties.Appearance.Options.UseBorderColor = true;
            this.teFirstName.Size = new System.Drawing.Size(278, 34);
            this.teFirstName.TabIndex = 2;
            this.teFirstName.EditValueChanged += new System.EventHandler(this.FIRSTNAMEBUTTON_EditValueChanged);
            // 
            // teLastName
            // 
            this.teLastName.Location = new System.Drawing.Point(527, 81);
            this.teLastName.Margin = new System.Windows.Forms.Padding(2);
            this.teLastName.Name = "teLastName";
            this.teLastName.Properties.Appearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.teLastName.Properties.Appearance.Options.UseBorderColor = true;
            this.teLastName.Size = new System.Drawing.Size(278, 34);
            this.teLastName.TabIndex = 3;
            this.teLastName.EditValueChanged += new System.EventHandler(this.teLastName_EditValueChanged);
            // 
            // teParent
            // 
            this.teParent.Location = new System.Drawing.Point(629, 145);
            this.teParent.Margin = new System.Windows.Forms.Padding(2);
            this.teParent.Name = "teParent";
            this.teParent.Properties.Appearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.teParent.Properties.Appearance.Options.UseBorderColor = true;
            this.teParent.Size = new System.Drawing.Size(272, 34);
            this.teParent.TabIndex = 4;
            this.teParent.EditValueChanged += new System.EventHandler(this.textEdit3_EditValueChanged);
            // 
            // teAddress
            // 
            this.teAddress.Location = new System.Drawing.Point(929, 206);
            this.teAddress.Margin = new System.Windows.Forms.Padding(2);
            this.teAddress.Name = "teAddress";
            this.teAddress.Properties.Appearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.teAddress.Properties.Appearance.Options.UseBorderColor = true;
            this.teAddress.Size = new System.Drawing.Size(280, 34);
            this.teAddress.TabIndex = 5;
            this.teAddress.EditValueChanged += new System.EventHandler(this.textEdit4_EditValueChanged);
            // 
            // FIRSTNAME
            // 
            this.FIRSTNAME.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FIRSTNAME.Appearance.Options.UseFont = true;
            this.FIRSTNAME.Location = new System.Drawing.Point(29, 85);
            this.FIRSTNAME.Margin = new System.Windows.Forms.Padding(2);
            this.FIRSTNAME.Name = "FIRSTNAME";
            this.FIRSTNAME.Size = new System.Drawing.Size(97, 23);
            this.FIRSTNAME.TabIndex = 11;
            this.FIRSTNAME.Text = "First Name :";
            // 
            // teEmergencyPhoneNumber
            // 
            this.teEmergencyPhoneNumber.Location = new System.Drawing.Point(260, 206);
            this.teEmergencyPhoneNumber.Margin = new System.Windows.Forms.Padding(2);
            this.teEmergencyPhoneNumber.Name = "teEmergencyPhoneNumber";
            this.teEmergencyPhoneNumber.Properties.Appearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.teEmergencyPhoneNumber.Properties.Appearance.Options.UseBorderColor = true;
            this.teEmergencyPhoneNumber.Size = new System.Drawing.Size(272, 34);
            this.teEmergencyPhoneNumber.TabIndex = 17;
            this.teEmergencyPhoneNumber.EditValueChanged += new System.EventHandler(this.textEdit7_EditValueChanged);
            // 
            // teAge
            // 
            this.teAge.Location = new System.Drawing.Point(888, 83);
            this.teAge.Margin = new System.Windows.Forms.Padding(2);
            this.teAge.Name = "teAge";
            this.teAge.Properties.Appearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.teAge.Properties.Appearance.Options.UseBorderColor = true;
            this.teAge.Size = new System.Drawing.Size(103, 34);
            this.teAge.TabIndex = 25;
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.Appearance.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAddPatient.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPatient.Appearance.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText;
            this.btnAddPatient.Appearance.Options.UseBackColor = true;
            this.btnAddPatient.Appearance.Options.UseFont = true;
            this.btnAddPatient.Appearance.Options.UseForeColor = true;
            this.btnAddPatient.AppearancePressed.BorderColor = System.Drawing.Color.DimGray;
            this.btnAddPatient.AppearancePressed.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddPatient.AppearancePressed.Options.UseBorderColor = true;
            this.btnAddPatient.AppearancePressed.Options.UseForeColor = true;
            this.btnAddPatient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddPatient.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddPatient.ImageOptions.Image")));
            this.btnAddPatient.Location = new System.Drawing.Point(1073, 534);
            this.btnAddPatient.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(223, 44);
            this.btnAddPatient.TabIndex = 27;
            this.btnAddPatient.Text = "Add Patient";
            this.btnAddPatient.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.btnAddPatient.Click += new System.EventHandler(this.ADDPATIENT_Click_1);
            // 
            // deBirthdate
            // 
            this.deBirthdate.EditValue = null;
            this.deBirthdate.Location = new System.Drawing.Point(138, 150);
            this.deBirthdate.Name = "deBirthdate";
            this.deBirthdate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deBirthdate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deBirthdate.Size = new System.Drawing.Size(272, 34);
            this.deBirthdate.TabIndex = 29;
            this.deBirthdate.EditValueChanged += new System.EventHandler(this.deBirthdate_EditValueChanged);
            // 
            // meAllergies
            // 
            this.meAllergies.Location = new System.Drawing.Point(260, 259);
            this.meAllergies.Name = "meAllergies";
            this.meAllergies.Size = new System.Drawing.Size(418, 130);
            this.meAllergies.TabIndex = 30;
            this.meAllergies.EditValueChanged += new System.EventHandler(this.meAllergies_EditValueChanged);
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.EditValue = "";
            this.comboBoxEdit1.Location = new System.Drawing.Point(629, 206);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Properties.DropDownRows = 2;
            this.comboBoxEdit1.Properties.Items.AddRange(new object[] {
            "SEVER INJURED",
            "MINOR INJURED"});
            this.comboBoxEdit1.Size = new System.Drawing.Size(207, 34);
            this.comboBoxEdit1.TabIndex = 37;
            this.comboBoxEdit1.SelectedIndexChanged += new System.EventHandler(this.comboBoxEdit1_SelectedIndexChanged);
            // 
            // cbe_Course
            // 
            this.cbe_Course.EditValue = "";
            this.cbe_Course.Location = new System.Drawing.Point(1085, 83);
            this.cbe_Course.Name = "cbe_Course";
            this.cbe_Course.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbe_Course.Properties.DropDownRows = 2;
            this.cbe_Course.Properties.Items.AddRange(new object[] {
            "BACHELOR OF SCIENCE IN ACCOUNTANCY",
            "BACHELOR OF SCIENCE IN BUSINESS ADMINISTRATION",
            "BACHELOR OF SCIENCE IN HOTEL, RESTAURANT AND MANAGEMENT",
            "BACHELOR OF SCIENCE IN INFORMATION TECHNOLOGY",
            "BACHELOR OF SCIENCE IN MEDICAL TECHNOLOGY",
            "BACHELOR OF SCIENCE IN MIDWIFERY",
            "BACHELOR OF SCIENCE IN NURSING",
            "BACHELOR OF SCIENCE IN PHARMACY",
            "BACHELOR OF SCIENCE IN PHYSICAL THERAPY",
            "BACHELOR OF SECONDARY EDUCATION",
            "BACHELOR OF ELEMENTARY EDUCATION",
            "BACHELOR OF SCIENCE IN RADIOLOGIC TECHNOLOGY"});
            this.cbe_Course.Size = new System.Drawing.Size(157, 34);
            this.cbe_Course.TabIndex = 38;
            this.cbe_Course.SelectedIndexChanged += new System.EventHandler(this.comboBoxEdit2_SelectedIndexChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(18, 20);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(250, 28);
            this.labelControl3.TabIndex = 40;
            this.labelControl3.Text = "STUDENT INFORMATION :";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(429, 87);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(94, 23);
            this.labelControl4.TabIndex = 41;
            this.labelControl4.Text = "Last Name :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(831, 85);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(42, 23);
            this.labelControl1.TabIndex = 42;
            this.labelControl1.Text = "Age :";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(18, 154);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(115, 23);
            this.labelControl5.TabIndex = 43;
            this.labelControl5.Text = "Date of Birth :";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(1016, 85);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(64, 23);
            this.labelControl6.TabIndex = 44;
            this.labelControl6.Text = "Course :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(429, 154);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(195, 23);
            this.labelControl2.TabIndex = 45;
            this.labelControl2.Text = "Perent/Guardian Name :";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(20, 215);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(236, 23);
            this.labelControl7.TabIndex = 46;
            this.labelControl7.Text = "Emergency Contact Number :";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(18, 268);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(234, 23);
            this.labelControl8.TabIndex = 47;
            this.labelControl8.Text = "Known Allergies/Symptoms :";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(559, 215);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(65, 23);
            this.labelControl9.TabIndex = 48;
            this.labelControl9.Text = "Status : ";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(851, 210);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(74, 23);
            this.labelControl10.TabIndex = 49;
            this.labelControl10.Text = "Address :";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(914, 149);
            this.labelControl11.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(143, 23);
            this.labelControl11.TabIndex = 50;
            this.labelControl11.Text = "Contact Number :";
            // 
            // teContactNumber
            // 
            this.teContactNumber.Location = new System.Drawing.Point(1072, 140);
            this.teContactNumber.Margin = new System.Windows.Forms.Padding(2);
            this.teContactNumber.Name = "teContactNumber";
            this.teContactNumber.Properties.Appearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.teContactNumber.Properties.Appearance.Options.UseBorderColor = true;
            this.teContactNumber.Size = new System.Drawing.Size(224, 34);
            this.teContactNumber.TabIndex = 51;
            this.teContactNumber.EditValueChanged += new System.EventHandler(this.teContactNumber_EditValueChanged);
            // 
            // ADD_PATIENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 618);
            this.Controls.Add(this.teContactNumber);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.cbe_Course);
            this.Controls.Add(this.comboBoxEdit1);
            this.Controls.Add(this.meAllergies);
            this.Controls.Add(this.deBirthdate);
            this.Controls.Add(this.btnAddPatient);
            this.Controls.Add(this.teAge);
            this.Controls.Add(this.teEmergencyPhoneNumber);
            this.Controls.Add(this.FIRSTNAME);
            this.Controls.Add(this.teAddress);
            this.Controls.Add(this.teParent);
            this.Controls.Add(this.teLastName);
            this.Controls.Add(this.teFirstName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ADD_PATIENT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADD_PATIENT";
            this.Load += new System.EventHandler(this.ADD_PATIENT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teFirstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teParent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teEmergencyPhoneNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teAge.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deBirthdate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deBirthdate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meAllergies.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbe_Course.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teContactNumber.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit teFirstName;
        private DevExpress.XtraEditors.TextEdit teLastName;
        private DevExpress.XtraEditors.TextEdit teParent;
        private DevExpress.XtraEditors.TextEdit teAddress;
        private DevExpress.XtraEditors.LabelControl FIRSTNAME;
        private DevExpress.XtraEditors.TextEdit teEmergencyPhoneNumber;
        private DevExpress.XtraEditors.TextEdit teAge;
        private DevExpress.XtraEditors.SimpleButton btnAddPatient;
        private DevExpress.XtraEditors.DateEdit deBirthdate;
        private DevExpress.XtraEditors.MemoEdit meAllergies;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraEditors.ComboBoxEdit cbe_Course;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit teContactNumber;
    }
}