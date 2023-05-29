using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace UserRegistrationProblem
{
    class UserRegistrationRegex
    {
        public static string VALIDNAMEPATTERN = "^[A-Z]{1}[a-z]{2,}$";
        public bool validateFirstName(String firstName)
        {
            return Regex.IsMatch(firstName, VALIDNAMEPATTERN);
        }
    }
}
