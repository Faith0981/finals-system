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
    public partial class CCMA : DevExpress.XtraEditors.XtraForm
    {
        public CCMA()
        {
            InitializeComponent();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void CCMA_Load(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click_1(object sender, EventArgs e)
        {

        }

        private void dateTimeOffsetEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void memoEdit4_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void memoEdit3_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void TEMPERATURE_Click(object sender, EventArgs e)
        {

        }

        private void PULSERATE_Click(object sender, EventArgs e)
        {

        }

        private void saveButton1_Click(object sender, EventArgs e)
        {
            {
                string connectionString = @"Data Source=.\HealthMonitoringSystem.db;Version=3;";
                string firstName = textBox4.Text.Trim();
                string lastName = textBox5.Text.Trim();

                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();

                    // Check if patient exists
                    string checkPatientQuery = "SELECT COUNT(*) FROM patients WHERE FirstName = @FirstName AND LastName = @LastName";
                    using (SQLiteCommand cmd = new SQLiteCommand(checkPatientQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@LastName", lastName);

                       int count = (int)cmd.ExecuteScalar();

                        if (count == 0)
                        {
                            MessageBox.Show("Patient does not exist in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Insert the visit/assessment data
                    string insertQuery = @"
            INSERT INTO Assessments 
            (FirstName, LastName, DateOfVisit, TimeOfVisit, Temperature, PulseRate, RespiratoryRate, BloodPressure, O2Saturation, InitialAssessment, ActionTaken, Recommendation, AttendingNurse)
            VALUES
            (@FirstName, @LastName, @DateOfVisit, @TimeOfVisit, @Temperature, @PulseRate, @RespiratoryRate, @BloodPressure, @O2Saturation, @InitialAssessment, @ActionTaken, @Recommendation, @AttendingNurse)";

                    using (SQLiteCommand cmd = new SQLiteCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@DateOfVisit", dateEdit1.EditValue);
                        cmd.Parameters.AddWithValue("@TimeOfVisit", dateTimeOffsetEdit1.EditValue);
                        cmd.Parameters.AddWithValue("@Temperature", spinEdit1.Value);
                        cmd.Parameters.AddWithValue("@PulseRate", numericUpDown1.Value);
                        cmd.Parameters.AddWithValue("@RespiratoryRate", textBox1.Text.Trim());
                        cmd.Parameters.AddWithValue("@BloodPressure", textBox2.Text.Trim());
                        cmd.Parameters.AddWithValue("@O2Saturation", textBox3.Text.Trim());
                        cmd.Parameters.AddWithValue("@InitialAssessment", memoEdit1.Text.Trim());
                        cmd.Parameters.AddWithValue("@ActionTaken", memoEdit2.Text.Trim());
                        cmd.Parameters.AddWithValue("@Recommendation", memoEdit3.Text.Trim());
                        cmd.Parameters.AddWithValue("@AttendingNurse", comboBoxEdit1.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Assessment saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
   