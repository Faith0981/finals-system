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
using StudentInformationSystemfinal.Models;
using Dapper;
using System.Data.SQLite;
using DevExpress.XtraBars.Ribbon.Drawing;

namespace StudentInformationSystemfinal.Form.cs
{
    public partial class ADD_PATIENT : DevExpress.XtraEditors.XtraForm
    {
        public ADD_PATIENT()
        {
            InitializeComponent();
        }

        private readonly string _connectionString = @"Data Source=.\HealthMonitoringSystem.db;Version=3;";

        private void textEdit3_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void textEdit4_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void ADDPATIENT_Click(object sender, EventArgs e)
        {

        }

        private void FIRSTNAMEBUTTON_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void ADDPATIENT_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Collect patient information from input fields
                string patientName = teFirstName.Text.Trim();
                string lastName = teLastName.Text.Trim();
                int age;
                // Validate age input
                if (!int.TryParse(teAge.Text, out age))
                {
                    XtraMessageBox.Show("Please enter a valid age.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Exit the method
                }

                string birthDate = deBirthdate.EditValue.ToString();
                string parentGuardian = teParent.Text.Trim();
                string address = teAddress.Text.Trim();
                string contactNumber = teContactNumber.Text.Trim();

                long phoneNumber;
                // Validate phone number input
                if (!long.TryParse(teEmergencyPhoneNumber.Text, out phoneNumber))
                {
                    XtraMessageBox.Show("Please enter a valid phone number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Exit the method
                }

                string knownAllergies = meAllergies.Text.Trim();
                string course = cbe_Course.Text.Trim();

                // Check for validation: First name and last name cannot be the same
                if (patientName.Equals(lastName, StringComparison.OrdinalIgnoreCase))
                {
                    XtraMessageBox.Show("First name and last name cannot be the same.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Exit the method
                }

                using (var connection = new SQLiteConnection(_connectionString))
                {
                    // Check if patient with same full name exists
                    var existsQuery = @"SELECT COUNT(*) FROM Patient WHERE FirstName = @FirstName AND LastName = @LastName";
                    var count = connection.ExecuteScalar<int>(existsQuery, new { FirstName = patientName, LastName = lastName });
                    if (count > 0)
                    {
                        XtraMessageBox.Show("A patient with the same name already exists.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // Exit the method
                    }

                    // Create a new Patient object
                    Person patient = new Patient
                    {
                        FirstName = patientName,
                        LastName = lastName,
                        Age = age,
                        BirthDate = birthDate,
                        ParentGuardianName = parentGuardian,
                        ContactNumber = contactNumber,
                        //teEmergencyPhoneNumber = emergencyContactNumber,
                        KnownAllergies = knownAllergies,
                        FullName = $"{patientName} {lastName}",
                        Course = course,

                    };

                    // Insert patient into the databaseI
                    var insertQuery = @"INSERT INTO Patient(
                                FirstName, 
                                LastName,
                                Age,
                                BirthDate,
                                ParentGuardianName,
                                Address,   
                                KnownAllergies,  
                                FullName, 
                                Course,
                                ContactNumber) 
                              VALUES (@FirstName, @LastName, @Age, @BirthDate, @ParentGuardianName, @Address, @EmergencyContactPerson, @EmergencyContactNumber, @KnownAllergies, @FullName, @Course, @ContactNumber)";

                    connection.Execute(insertQuery, patient);
                    XtraMessageBox.Show("Patient successfully saved");
                    //PatientsInfo?.LoadPatients();
                    this.Close();

                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private PatientsInfo _patientsInfoForm = new PatientsInfo();







        private void ADD_PATIENT_Load(object sender, EventArgs e)
        {

        }

        private void textEdit7_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimeOffsetEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void deBirthdate_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void meAllergies_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxEdit2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void teContactNumber_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void teLastName_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}