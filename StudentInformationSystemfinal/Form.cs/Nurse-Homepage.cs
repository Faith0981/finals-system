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
using DevExpress.XtraEditors;

namespace StudentInformationSystemfinal.Form.cs
{
    public partial class Nurse_Homepage : DevExpress.XtraEditors.XtraForm
    {
        public Nurse_Homepage()
        {
            InitializeComponent();
        }

        private void CCMA_Click(object sender, EventArgs e)
        {
            CCMA CCMAForm = new CCMA();
           CCMAForm.ShowDialog();
        }

        private void ADDPATIENT_Click(object sender, EventArgs e)
        {
            //ADD_PATIENT mdiParent = this.MdiParent as ADD_PATIENT;

            ADD_PATIENT addPatientForm = new ADD_PATIENT();
            addPatientForm.ShowDialog();
           

      
          
        }

        private void Nurse_Homepage_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {    
             this.Hide();
        }

        private void ADDNEWPATIENPANEL_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection("@\"Data Source=.\\HealthMonitoringSystem.db;Version=3;"))    //KANI NGA LINE GA ERRORRRRRRRRRRRRRRRRRRRRR       
            {
                conn.Open();  // Ensure it's inside the same block
                string query = "SELECT COUNT(*) FROM Patients"; // Assuming 'Patients' is your table name
                SQLiteCommand cmd = new SQLiteCommand(query, conn);

                object result = cmd.ExecuteScalar();
                int totalPatients = result != null ? Convert.ToInt32(result) : 0;

                MessageBox.Show($"Total Patients: {totalPatients}", "Patient Count", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } // `conn` goes out of scope here
        }



        private void simpleButton2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout",
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Perform logout actions (e.g., closing forms, clearing session data)
                this.Close(); // Closes the current form
            }

        }
    }
}