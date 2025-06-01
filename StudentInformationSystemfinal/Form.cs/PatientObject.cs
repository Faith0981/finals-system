using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using StudentInformationSystemfinal.Form.cs;
using Dapper;
using System.Data.SQLite;
using StudentInformationSystemfinal.Models;
using DevExpress.Xpo.DB.Helpers;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.XtraGrid.Views.Grid;

namespace StudentInformationSystemfinal.Form.cs
{
    public partial class PatientObject : DevExpress.XtraEditors.XtraForm
    {
        public PatientObject()
        {
            InitializeComponent();
        }
        private readonly string _connectionString = @"Data Source=.\HealthMonitoringSystem.db;Version=3;";
        StudentHealthMonitoringSystemRepository studentHealthMonitoringSystemRepository = new StudentHealthMonitoringSystemRepository();
        private int _id;
        private void ADDPATIENT_Click(object sender, EventArgs e)
        {
            DMCMEDICAL_Homepage mdiParent = this.MdiParent as DMCMEDICAL_Homepage;

            this.Close();

            ADD_PATIENT addPatient = new ADD_PATIENT();
            addPatient.MdiParent = mdiParent;
            addPatient.Show();

        }

        private void gridControl1_Load(object sender, EventArgs e)
        {
            //useless code
        }
        private void LoadData()
        {
            studentHealthMonitoringSystemRepository.LoadData(gridControl1); //gitawag gikan sa repository class nga ni inherit sa interface
           
        }
        private void PatientObject_Load(object sender, EventArgs e)
        {
            using (var connection = new SQLiteConnection(_connectionString)) {
                var query = connection.Query<Patient>("SELECT * FROM Patient").ToList();
                gridControl1.DataSource = query;
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            //useless code
        }


        private void DeleteMethod(int id) 
        {
            try
            {
                using (var connection = new SQLiteConnection(_connectionString))
                {
                    var deleteQuery = @"DELETE FROM Patient WHERE Id = @Id";
                    var parameters = new DynamicParameters();
                    {
                        parameters.Add("Id", id);
                    }
                    ;
                    connection.Execute(deleteQuery, parameters);
                    XtraMessageBox.Show("Delete Successful!");
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
           // _id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("PatientID"));
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
           //useless code
        }
        private void searchControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void gridView1_ShowingEditor(object sender, CancelEventArgs e)
        {
            GridView view = sender as GridView;
            if (view.FocusedColumn.FieldName == "Action")
            {
                e.Cancel = false;
            }
        }
        private void repositoryItemButtonEdit2_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Caption == "DeleteButton")
            {
                // Ensure the correct row is focused
                var view = gridControl1.FocusedView as GridView;
                if (view != null)
                {
                    int rowHandle = view.FocusedRowHandle;
                    int id = Convert.ToInt32(view.GetRowCellValue(rowHandle, "Id"));
                    DialogResult result = XtraMessageBox.Show("Are you sure you want to delete this patient?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        DeleteMethod(id);
                        LoadData();
                    }

                    //this is a comment hehe
                }
            }
        }
    }
}