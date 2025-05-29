using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationSystemfinal.Models
{
    public class UserCredentials //ENCAPSULATION
    {
        private string _username = "dmc";
        private string _password = "dmc";
        public string Username { get { return _username; } private set { _username = value; } }
        public string Password { get { return _password; } private set { _password = value; } }
    }
}
