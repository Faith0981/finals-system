using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;
using System.Text.RegularExpressions;
using DevExpress.XtraEditors;

namespace StudentInformationSystemfinal.Models
{
    public class Patient : Person //INHERITANCE
    {
    public string BirthDate { get; set; }
    public string ParentGuardianName { get; set; }
    public string Address { get; set; }
    public string KnownAllergies { get; set; }
    public string Course { get; set; }
    public string MyProperty { get; set; }
    public int ContactNumber { get; set; }



    }
}
