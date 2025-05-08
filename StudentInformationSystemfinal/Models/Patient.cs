using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;

namespace StudentInformationSystemfinal.Models
{
    public class Patient : Person //INHERITANCE
    {
        public int PatientID { get; set; }

        //public string FirstName { get; set; }

        //public string LastName { get; set; }
        //public int Age { get; set; }
        public string BirthDate { get; set; }

        public string ParentGuardianName{get;set;}

        public string Address { get; set; }
        public string EmergencyContactPerson { get; set; }

        public long EmergencyContactNumber { get; set; }

        public string KnownAllergies { get; set; }
        public string GeneralInformation { get; set; }

        
    }
}
