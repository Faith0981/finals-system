using System;
//using System.Collections.ObjectModel;
using System.Windows.Forms;
//using DevExpress.Utils.About;
//using DevExpress.Utils.Win.Hook;
//using DevExpress.XtraEditors;
//using StudentInformationSystemfinal.StudentInformationSystemFormcs;
//using static DevExpress.XtraEditors.Mask.MaskSettings;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
//using DevExpress.Office.Crypto;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data.SqlClient;
//using System.Reflection;
using StudentInformationSystemfinal.Form.cs;
using DevExpress.XtraEditors;
using StudentInformationSystemfinal.Models;
using StudentInformationSystemfinal;

namespace StudentInformationSystemfinal
{
    public partial class LOGINForm : DevExpress.XtraEditors.XtraForm
    {
        public LOGINForm()
        {
            InitializeComponent();
        }

        
            private string HashPassword(string password)
            {
                using (var sha256 = System.Security.Cryptography.SHA256.Create())
                {
                    byte[] bytes = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                    var builder = new System.Text.StringBuilder();
                    foreach (var b in bytes)
                    {
                        builder.Append(b.ToString("x2"));
                    }
                    return builder.ToString();
                }
            }

            
           
            
      
        private object GetStudents()
        {
            throw new NotImplementedException();
        }

       

        UserCredentials userCredentials = new UserCredentials();

        private void LOGIN_Click(object sender, EventArgs e)
        {

            string inputUsername = teUserName.Text;
            string inputPassword = tePassword.Text;

            if (string.IsNullOrEmpty(inputUsername) || string.IsNullOrEmpty(inputPassword)) {
                XtraMessageBox.Show("Please fill up all the fields!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
                if (inputUsername == userCredentials.Username && inputPassword == userCredentials.Password)
                {
                    this.Hide();
                    DMCMEDICAL_Homepage dMCMEDICAL_ = new DMCMEDICAL_Homepage();
                    dMCMEDICAL_.Show();
                }
                else {
                    XtraMessageBox.Show("Incorrect username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        

        private void teUserName_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void ALREADYHAVEANACCOUNT_Click(object sender, EventArgs e)
        {

        }

        private void CREATEANACCOUNT_Click(object sender, EventArgs e)
        {

        }


        private void panelControl1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void richEditControl1_Click(object sender, EventArgs e)
        {

        }

        private void StudentInformationForm_Load(object sender, EventArgs e)
        {

        }

        private void tePassword_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LOGIN2_Click(object sender, EventArgs e)
        {


        }
    }
    }

