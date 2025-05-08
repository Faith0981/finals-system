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

namespace StudentInformationSystemfinal
{
    public partial class DMCMEDICAL_Homepage2 : DevExpress.XtraEditors.XtraForm
    {
        public DMCMEDICAL_Homepage2()
        {
            InitializeComponent();
        }

    

        private void simpleButton1_Click(object sender, EventArgs e)
        {
           
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
            DMCMEDICAL_Homepage mdiParent = this.MdiParent as DMCMEDICAL_Homepage;


            this.Close();

           USER user = new USER();
            user.MdiParent = mdiParent;
            user.Show();
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

                ForeColor = Color.Green;
            }
            
        }

        private void DMCMEDICAL_Homepage2_Load(object sender, EventArgs e)
        {

        }
    }
}