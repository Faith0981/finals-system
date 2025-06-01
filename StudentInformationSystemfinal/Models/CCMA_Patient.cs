using DevExpress.Xpo.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationSystemfinal.Models
{
    class CCMA_Patient
    {
        public string ccma_FirstName { get; set; }
        public string ccma_LastName { get; set; }
        public string ccma_DateOfVisit { get; set; }
        public string ccma_TimeOfVisit { get; set; }
        public string ccma_AcitonTaken { get; set; }
        public string ccma_Temperature { get; set; }
        public string ccma_PulseRate { get; set; }
        public string ccma_RespiratoryRate { get; set; }
        public string ccma_BloodPressure { get; set; }
        public string ccma02Saturation { get; set; }
        public string ccma_AttendingNurse { get; set; }
    }
}
