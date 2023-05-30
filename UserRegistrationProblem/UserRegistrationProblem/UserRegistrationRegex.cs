using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Xml.Linq;


namespace UserRegistrationProblem
{
    class UserRegistrationRegex
    {
        //public static string VALIDNAMEPATTERN = "^[A-Z]{1}[a-z]{2,}$"; //UC-1
        //public static string EMAILPATTERN = "^[0-9a-zA-z]+([._+-][0-9a-zA-z]+)*@[a-zA-Z0-9]+.[a-zA-Z]{2,4}([.][a-zA-Z]{2})$";
        //public static string PhoneNumberRules = "^[0-9]{2}[ ][0-9]{10}$";
        //public static string PASSWORDRULE1 = "[A-Za-z]{8,}";//UC5
        //public static string PASSWORDRULE1 = "^[A-Z]{1}[a-z]{7,}";//UC6
        //public static string PASSWORDRULE = "^[A-Z]{1}[0-9]{1}[a-z]{6,}";//UC7
        //public static string PASSWORDRULE = "^(?=.*[0 - 9])(?=.*[a - z])(?=.*[A - Z])(?=.*[!@#&()–[{}]:;',?/*~$^+=<>]).{8,}$"; //UC8
        public static string EMAILPATTERN = "^[\\w!#$%&'*+/=?`{|}~^-]+(?:\\.[\\w!#$%&'*+/=?`{|}~^-]+)*@(?:[a-zA-Z0-9-]+\\.)+[a-zA-Z0-9]{2,6}$";//UC9



        //UC-1
        //public bool validateFirstName(String firstName)
        //{
        //    return Regex.IsMatch(firstName, VALIDNAMEPATTERN);
        //}


        //UC-2
        //public bool validatelastName(String firstName)
        //{
        //    return Regex.IsMatch(firstName, VALIDNAMEPATTERN);
        //}

        //UC-3
        public bool validatEmail(String email)
        {
            return Regex.IsMatch(email, EMAILPATTERN);
        }

        //UC4
        //public void validateMobileFormat(String PhoneNumber)
        //{
        //    if (Regex.IsMatch(PhoneNumber, PhoneNumberRules))
        //        Console.WriteLine($"This is Valid PhoneNumber:{PhoneNumber}");
        //    else
        //        Console.WriteLine($"This is Invalid PhoneNumber:{PhoneNumber}");
        //}

        //UC6
        //public bool validatePreDefinedPassword(String preDefinedPassword)
        //{
        //    return Regex.IsMatch(preDefinedPassword, PASSWORDRULE);
        //}




    }
}
