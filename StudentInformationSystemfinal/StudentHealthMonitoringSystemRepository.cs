using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SQLite;
using DevExpress.XtraGrid;

namespace StudentInformationSystemfinal
{
    public class StudentHealthMonitoringSystemRepository : IDataAccess //ang repository nga ni inherit sa interface diri butngan ug implementation ang mga methods nga naa sa interface
    {
        private readonly string _connectionString = @"Data Source=.\HealthMonitoringSystem.db;Version=3;"; //ABSTRACTION
        public void LoadData(GridControl gridControl1) {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                var query = connection.Query("SELECT * FROM Patient").ToList();
                gridControl1.DataSource = query;
            }

            //naay duha ka way pag abstraction thru abstract class and thru interface gagamit mi ug interface para matago ang implementation sa code since 
            //ang abstract class kay for shared code
        }
    }
}
