using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using StudentInformationSystemfinal.Models;

namespace StudentInformationSystemfinal.Forms
{
    public partial class AddPatient : DevExpress.XtraEditors.XtraUserControl
    {
        public AddPatient()
        {
            InitializeComponent();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
        private List<Patient> patientsList; // Assume this holds all the patient data

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0 && e.ColumnIndex == 3) // 3 = 'View' button column
            //{
            //    // Get the patient from the list using the row index
            //    Patient selectedPatient = patientsList[e.RowIndex];

            //    // Open the PatientsInfo form and pass the patient
            //    PatientsInfo infoForm = new PatientsInfo(selectedPatient);
            //    infoForm.Show(); // or ShowDialog() if you want it modal
        }
    }
}