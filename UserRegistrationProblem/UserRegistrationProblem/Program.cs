using System;

namespace UserRegistrationProblem
{
    class Program
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("welcome to UserRegistrationProblem day 24 assignment");

            //UC-1
            //Console.WriteLine("Enter the first name = ");
            //string firstName = Console.ReadLine();

            //UC-2
            //Console.WriteLine("Enter the last name = ");
            //string lastName = Console.ReadLine();

            // Console.WriteLine("Enter the valid email = ");
            //string email = Console.ReadLine();

            Console.WriteLine("Enter your Phone number, and check valid or not");
            Console.WriteLine("Enter the mobile number this Pattern=\n [0-9]{2}[ ][0-9]{10}$ ");
            
            

            UserRegistrationRegex userRegistrationRegex = new UserRegistrationRegex();
            //Console.WriteLine(userRegistrationRegex.validateFirstName(firstName));
            //Console.WriteLine(userRegistrationRegex.validatelastName(lastName));
            //Console.WriteLine(userRegistrationRegex.validatEmail(email));
            Console.WriteLine(userRegistrationRegex.validateMobileFormat);

            
            string TakeNumber = Console.ReadLine();
            userRegistrationRegex.validateMobileFormat(TakeNumber);



        }
    }
}