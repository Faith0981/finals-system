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
using Dapper;
using System.Data.SQLite;
using StudentInformationSystemfinal.Models;
using DevExpress.Xpo.DB.Helpers;

namespace StudentInformationSystemfinal.Form.cs
{
    public partial class PatientObject : DevExpress.XtraEditors.XtraForm
    {
        public PatientObject()
        {
            InitializeComponent();
        }
        private readonly string _connectionString = @"Data Source=.\HealthMonitoringSystem.db;Version=3;";
        StudentHealthMonitoringSystemRepository studentHealthMonitoringSystemRepository = new StudentHealthMonitoringSystemRepository();
        private int _id;
        private void ADDPATIENT_Click(object sender, EventArgs e)
        {

            ADD_PATIENT addPatient = new ADD_PATIENT();
            addPatient.Show();

        }

        private void gridControl1_Load(object sender, EventArgs e)
        {
            //useless code
        }
        private void LoadData()
        {
            studentHealthMonitoringSystemRepository.LoadData(gridControl1); //gitawag gikan sa repository class nga ni inherit sa interface
           
        }
        private void PatientObject_Load(object sender, EventArgs e)
        {
            using (var connection = new SQLiteConnection(_connectionString)) {
                var query = connection.Query("SELECT * FROM Patient").ToList();
                gridControl1.DataSource = query;
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            //useless code
        }
        private void DeleteMethod(int id) 
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                var deleteQuery = @"DELETE FROM Patient WHERE PatientID = @PatientID";
                var parameters = new DynamicParameters();
                {
                    parameters.Add("PatientID", id);
                };
                connection.Execute(deleteQuery, parameters);
                
            }

        }
        private void DELETE_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("PatientID"));
            DeleteMethod(id);
            LoadData();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            //_id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("PatientID"));


        }
    }
}