namespace StudentInformationSystemfinal.Form.cs
{
    partial class PatientObject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientObject));
            this.PATIENT1 = new DevExpress.XtraEditors.LabelControl();
            this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
            this.EDIT = new DevExpress.XtraEditors.SimpleButton();
            this.DELETE = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ADDPATIENT = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // PATIENT1
            // 
            this.PATIENT1.Appearance.Font = new System.Drawing.Font("Stencil", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PATIENT1.Appearance.Options.UseFont = true;
            this.PATIENT1.Location = new System.Drawing.Point(24, 44);
            this.PATIENT1.Name = "PATIENT1";
            this.PATIENT1.Size = new System.Drawing.Size(117, 34);
            this.PATIENT1.TabIndex = 1;
            this.PATIENT1.Text = "Patient";
            // 
            // searchControl1
            // 
            this.searchControl1.Location = new System.Drawing.Point(12, 99);
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Properties.AutoHeight = false;
            this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl1.Size = new System.Drawing.Size(1337, 67);
            this.searchControl1.TabIndex = 2;
            // 
            // EDIT
            // 
            this.EDIT.Appearance.BackColor = System.Drawing.Color.White;
            this.EDIT.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.EDIT.Appearance.Font = new System.Drawing.Font("Stencil", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EDIT.Appearance.Options.UseBackColor = true;
            this.EDIT.Appearance.Options.UseBorderColor = true;
            this.EDIT.Appearance.Options.UseFont = true;
            this.EDIT.AppearancePressed.BackColor = System.Drawing.Color.CornflowerBlue;
            this.EDIT.AppearancePressed.BorderColor = System.Drawing.Color.AliceBlue;
            this.EDIT.AppearancePressed.Font = new System.Drawing.Font("Stencil", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EDIT.AppearancePressed.Options.UseBackColor = true;
            this.EDIT.AppearancePressed.Options.UseBorderColor = true;
            this.EDIT.AppearancePressed.Options.UseFont = true;
            this.EDIT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("EDIT.ImageOptions.Image")));
            this.EDIT.Location = new System.Drawing.Point(1406, 101);
            this.EDIT.Name = "EDIT";
            this.EDIT.Size = new System.Drawing.Size(101, 62);
            this.EDIT.TabIndex = 4;
            this.EDIT.Text = "Edit";
            // 
            // DELETE
            // 
            this.DELETE.Appearance.BackColor = System.Drawing.Color.White;
            this.DELETE.Appearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.DELETE.Appearance.Font = new System.Drawing.Font("Stencil", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DELETE.Appearance.Options.UseBackColor = true;
            this.DELETE.Appearance.Options.UseBorderColor = true;
            this.DELETE.Appearance.Options.UseFont = true;
            this.DELETE.AppearancePressed.BackColor = System.Drawing.Color.SeaGreen;
            this.DELETE.AppearancePressed.BorderColor = System.Drawing.Color.AliceBlue;
            this.DELETE.AppearancePressed.Font = new System.Drawing.Font("Stencil", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DELETE.AppearancePressed.Options.UseBackColor = true;
            this.DELETE.AppearancePressed.Options.UseBorderColor = true;
            this.DELETE.AppearancePressed.Options.UseFont = true;
            this.DELETE.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("DELETE.ImageOptions.Image")));
            this.DELETE.Location = new System.Drawing.Point(1542, 102);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(127, 64);
            this.DELETE.TabIndex = 5;
            this.DELETE.Text = "Delete";
            this.DELETE.Click += new System.EventHandler(this.DELETE_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(34, 172);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(2871, 1310);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Load += new System.EventHandler(this.gridControl1_Load);
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "PatientID";
            this.gridColumn1.FieldName = "PatientID";
            this.gridColumn1.MinWidth = 40;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 150;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "FirstName";
            this.gridColumn2.FieldName = "FirstName";
            this.gridColumn2.MinWidth = 40;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 150;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "LastName";
            this.gridColumn3.FieldName = "LastName";
            this.gridColumn3.MinWidth = 40;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 150;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Age";
            this.gridColumn4.FieldName = "Age";
            this.gridColumn4.MinWidth = 40;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 150;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "BirthDate";
            this.gridColumn5.FieldName = "BirthDate";
            this.gridColumn5.MinWidth = 40;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 150;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "ParentGuardianName";
            this.gridColumn6.FieldName = "ParentGuardianName";
            this.gridColumn6.MinWidth = 40;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 150;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Address";
            this.gridColumn7.FieldName = "Address";
            this.gridColumn7.MinWidth = 40;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            this.gridColumn7.Width = 150;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "EmergencyContactPerson";
            this.gridColumn8.FieldName = "EmergencyContactPerson";
            this.gridColumn8.MinWidth = 40;
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 7;
            this.gridColumn8.Width = 150;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "EmergencyContactNumber";
            this.gridColumn9.FieldName = "EmergencyContactNumber";
            this.gridColumn9.MinWidth = 40;
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 8;
            this.gridColumn9.Width = 150;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "KnownAllergies";
            this.gridColumn10.FieldName = "KnownAllergies";
            this.gridColumn10.MinWidth = 40;
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 9;
            this.gridColumn10.Width = 150;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "GeneralInformation";
            this.gridColumn11.FieldName = "GeneralInformation";
            this.gridColumn11.MinWidth = 40;
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 10;
            this.gridColumn11.Width = 150;
            // 
            // ADDPATIENT
            // 
            this.ADDPATIENT.Appearance.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ADDPATIENT.Appearance.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADDPATIENT.Appearance.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText;
            this.ADDPATIENT.Appearance.Options.UseBackColor = true;
            this.ADDPATIENT.Appearance.Options.UseFont = true;
            this.ADDPATIENT.Appearance.Options.UseForeColor = true;
            this.ADDPATIENT.AppearancePressed.BorderColor = System.Drawing.Color.DimGray;
            this.ADDPATIENT.AppearancePressed.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.ADDPATIENT.AppearancePressed.Options.UseBorderColor = true;
            this.ADDPATIENT.AppearancePressed.Options.UseForeColor = true;
            this.ADDPATIENT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ADDPATIENT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ADDPATIENT.ImageOptions.Image")));
            this.ADDPATIENT.Location = new System.Drawing.Point(1710, 102);
            this.ADDPATIENT.Name = "ADDPATIENT";
            this.ADDPATIENT.Size = new System.Drawing.Size(453, 64);
            this.ADDPATIENT.TabIndex = 6;
            this.ADDPATIENT.Text = "Add Patient";
            this.ADDPATIENT.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.ADDPATIENT.Click += new System.EventHandler(this.ADDPATIENT_Click);
            // 
            // PatientObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2488, 1242);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.ADDPATIENT);
            this.Controls.Add(this.DELETE);
            this.Controls.Add(this.EDIT);
            this.Controls.Add(this.searchControl1);
            this.Controls.Add(this.PATIENT1);
            this.Name = "PatientObject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient";
            this.Load += new System.EventHandler(this.PatientObject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl PATIENT1;
        private DevExpress.XtraEditors.SearchControl searchControl1;
        private DevExpress.XtraEditors.SimpleButton EDIT;
        private DevExpress.XtraEditors.SimpleButton DELETE;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton ADDPATIENT;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
    }
}