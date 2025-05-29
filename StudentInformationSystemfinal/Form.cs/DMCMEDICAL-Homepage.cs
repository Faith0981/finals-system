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
using StudentInformationSystemfinal.Forms;
using StudentInformationSystemfinal.Models;

namespace StudentInformationSystemfinal.Form.cs
{
    public partial class DMCMEDICAL_Homepage : DevExpress.XtraEditors.XtraForm
    {

        private AddPatient _addpatient;
        public DMCMEDICAL_Homepage()
        {
            InitializeComponent();
        }

        private void HOME_Click(object sender, EventArgs e)
        {
            DMCMEDICAL homepagetwo = new DMCMEDICAL();
            homepagetwo.MdiParent = this;
            homepagetwo.Show();
        }
        private void DMCMEDICAL_Homepage_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            DMCMEDICAL homepagetwo = new DMCMEDICAL();
            homepagetwo.MdiParent = this;
            homepagetwo.Show();
        }

        private void PATIENTS_Click(object sender, EventArgs e)
        {

            PatientObject patient= new PatientObject();
            patient.MdiParent = this;
            patient.Show();
        }

        private void CC_MA_Click(object sender, EventArgs e)
        {
            CCMA ccma = new CCMA();
            ccma.MdiParent = this;
            ccma.Show();
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout",
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Perform logout actions (e.g., closing forms, clearing session data)
                this.Close(); // Closes the current form
            }
        }

        private void accHomePage_Click(object sender, EventArgs e)
        {
            DMCMEDICAL patient = new DMCMEDICAL();
            patient.MdiParent = this;
            patient.Show();

            if (_addpatient == null) //Ensure it's initialized only once
            {
                _addpatient = new AddPatient();
            }

            //panelBody.Controls.Clear();
            //_addpatient.Dock = DockStyle.Fill;
            //panelBody.Controls.Add(_addpatient);
        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {

        }
        private void USER_Click(object sender, EventArgs e)
        {

        }
        private void labelControl1_Click(object sender, EventArgs e)
        {

        }
        private void labelControl3_Click(object sender, EventArgs e)
        {

        }
        private void labelControl2_Click(object sender, EventArgs e)
        {

        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }
        private void accordionControl1_Click(object sender, EventArgs e)
        {


        }
    }
}