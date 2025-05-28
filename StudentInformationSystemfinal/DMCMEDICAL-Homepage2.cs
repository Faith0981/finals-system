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
using StudentInformationSystemfinal.Form.cs;

namespace StudentInformationSystemfinal
{
    public partial class DMCMEDICAL_Homepage2 : DevExpress.XtraEditors.XtraForm
    {
        public DMCMEDICAL_Homepage2()
        {
            InitializeComponent();
        }

        private int totalPatients;

        private readonly string _connectionString = @"Data Source=.\HealthMonitoringSystem.db;Version=3;";

        private void btnTotalPatients_Click(object sender, EventArgs e)
        {
            string query = "SELECT COUNT(*) FROM Patient"; // Adjust table name if needed
            using (SQLiteConnection conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    totalPatients = Convert.ToInt32(cmd.ExecuteScalar());
                    MessageBox.Show($"Total Patients: {totalPatients}");
                }
            }
        }

        private void ADDPATIENT_Click(object sender, EventArgs e)
        {
            DMCMEDICAL_Homepage mdiParent = this.MdiParent as DMCMEDICAL_Homepage;


            this.Close();

            PatientObject patientObject = new PatientObject();
            patientObject.MdiParent = mdiParent;
            patientObject.Show();

        }

        private void ADDNEWUSER2_Click(object sender, EventArgs e)
        {
            

        }

        private void btnCCMA_Click(object sender, EventArgs e)
        {
            DMCMEDICAL_Homepage mdiParent = this.MdiParent as DMCMEDICAL_Homepage;


            this.Close();

           CCMA ccma = new CCMA();
           ccma.MdiParent = mdiParent;
           ccma.Show();

        }

        private void toggleSwitch1_Toggled_1(object sender, EventArgs e)
        {
            

            if (toggleSwitch1.IsOn)
            {
                BackColor = Color.WhiteSmoke;

                ForeColor = Color.Black;

            }
            else{
                
                BackColor = Color.Black;

                ForeColor = Color. White;
            }
            
        }

        private void DMCMEDICAL_Homepage2_Load(object sender, EventArgs e)
        {
            string query = "SELECT COUNT(*) FROM Patient"; // Adjust table name if needed
            using (SQLiteConnection conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    totalPatients = Convert.ToInt32(cmd.ExecuteScalar());
                    btnTotalPatients.Text = $"Total Patients: {totalPatients.ToString()}";
                }
            }
            
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }
    }
}