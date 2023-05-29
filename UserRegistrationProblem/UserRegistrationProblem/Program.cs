using System;

namespace UserRegistrationProblem
{
    class Program
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("welcome to UserRegistrationProblem day 24 assignment");


            
            Console.WriteLine("Enter the first name = ");
            
            UserRegistrationRegex userRegistrationRegex = new UserRegistrationRegex();

            string firstName = Console.ReadLine();
            Console.WriteLine(userRegistrationRegex.validateFirstName(firstName));
        }
    }
}