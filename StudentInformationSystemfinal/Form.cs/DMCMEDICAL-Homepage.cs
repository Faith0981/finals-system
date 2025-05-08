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

namespace StudentInformationSystemfinal.Form.cs
{
    public partial class DMCMEDICAL_Homepage : DevExpress.XtraEditors.XtraForm
    {
        public DMCMEDICAL_Homepage()
        {
            InitializeComponent();
        }

        private void HOME_Click(object sender, EventArgs e)
        {
            DMCMEDICAL_Homepage2 homepagetwo = new DMCMEDICAL_Homepage2();
            homepagetwo.MdiParent = this;
            homepagetwo.Show();
        }

        private void USER_Click(object sender, EventArgs e)
        {
            USER user = new USER();
            user.MdiParent = this;
            user.Show();

            //user.Show();
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

        private void DMCMEDICAL_Homepage_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            DMCMEDICAL_Homepage2 homepagetwo = new DMCMEDICAL_Homepage2();
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
    }
}