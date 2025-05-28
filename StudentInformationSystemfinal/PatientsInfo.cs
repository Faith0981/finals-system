using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentInformationSystemfinal.Models;
using Dapper;

//private Patient _patient;

namespace StudentInformationSystemfinal
{
    public partial class PatientsInfo : DevExpress.XtraEditors.XtraForm
    {
        public PatientsInfo()
        {
          InitializeComponent();
            //private Patient _patient; // Declare within the class

        }
      

        public PatientsInfo(Patient patient)
        {
            InitializeComponent();
            //gridControl1.DataSource = new List<Patient> { _patient };

            // Optional: LoadPatientDetails(patient);
            LoadPatientData();
        }
        private void LoadPatientData()
        {
            // Show data in labels, grid, or textboxes
            // Example if you have labels:
            // Or bind to a grid
            //gridControl1.DataSource = new List<Patient> { _patient};
            // Use _patientId to load data from DB or list
            // e.g., labelName.Text = GetPatientNameById(_patientId);
        }
        public void LoadPatients()
{
    using (var connection = new SQLiteConnection(@"Data Source=.\HealthMonitoringSystem.db;Version=3;"))
    {
        var patients = connection.Query<Patient>("SELECT * FROM Patient").ToList();
        gridControl1.DataSource = patients; // Use your actual GridControl name
    }
}
        private void PatientsInfo_Load(object sender, EventArgs e)
        {

        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Column.FieldName == "View")
            {
                var selectedPatient = gridView1.GetRow(e.RowHandle) as Patient;
                if (selectedPatient != null)
                {
                    PatientsInfo viewForm = new PatientsInfo(selectedPatient);
                    viewForm.ShowDialog();
                }
            }
        }

    }
}

