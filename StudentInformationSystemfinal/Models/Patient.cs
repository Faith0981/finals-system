using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;
using System.Text.RegularExpressions;

namespace StudentInformationSystemfinal.Models
{
    public class Patient : Person //INHERITANCE
    {
        public string ContactNumber { get; set; }

        public int PatientID { get; set; }

        public string FullName { get; set; }
        public string BirthDate { get; set; }

        public string ParentGuardianName{get;set;}

        public string Address { get; set; }
        public string EmergencyContactPerson { get; set; }

        public long EmergencyContactNumber { get; set; }

        public string KnownAllergies { get; set; }
        public string GeneralInformation { get; set; }
        public string Course { get; internal set; }

    }
}
