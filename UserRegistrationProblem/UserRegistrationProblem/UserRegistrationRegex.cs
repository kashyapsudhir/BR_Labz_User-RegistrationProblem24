﻿using System;
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
        public static string PhoneNumberRules = "^[0-9]{2}[ ][0-9]{10}$";



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
        //public bool validatEmail(String email)
        //{
        //    return Regex.IsMatch(email, EMAILPATTERN);
        //}

        //UC4
        public void validateMobileFormat(String PhoneNumber)
        {
            if (Regex.IsMatch(PhoneNumber, PhoneNumberRules))
                Console.WriteLine($"This is Valid PhoneNumber:{PhoneNumber}");
            else
                Console.WriteLine($"This is Invalid PhoneNumber:{PhoneNumber}");
        }

    }
}
