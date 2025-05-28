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
        private List<Patient> patientsList; // Assume this holds all the patient data

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 3) // 3 = 'View' button column
            {
                // Get the patient from the list using the row index
                Patient selectedPatient = patientsList[e.RowIndex];

                // Open the PatientsInfo form and pass the patient
                PatientsInfo infoForm = new PatientsInfo(selectedPatient);
                infoForm.Show(); // or ShowDialog() if you want it modal
            }
        }

        private void DeleteMethod(int id) 
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                var deleteQuery = @"DELETE FROM Patient WHERE PatientID = @PatientID";
                var parameters = new DynamicParameters();
                {
                    parameters.Add("PatientID", id);
                };
                connection.Execute(deleteQuery, parameters);
                
            }

        }
     





        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            _id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("PatientID"));
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
           //useless code
        }

        private void searchControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void repositoryItemButtonEdit3_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Caption == "EditButton")
            {

            }
            else if (e.Button.Caption == "DeleteButton") {
                int id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("PatientID"));
                DialogResult result = XtraMessageBox.Show("Are you sure you want to delete this patient?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    DeleteMethod(id);
                    LoadData();
                }
            }
        }

        private void gridView1_ShowingEditor(object sender, CancelEventArgs e)
        {
            GridView view = sender as GridView;
            if (view.FocusedColumn.FieldName == "Action")
            {
                e.Cancel = false;
            }
        }
    }
}