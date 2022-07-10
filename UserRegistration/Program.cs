using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Problem - Regex Unit Testing");
            Console.WriteLine("\n");

            Program P = new Program();
            // validate first name
            P.Validate_FirstName("Neeladri");

            //Validate last name
            P.Validate_FirstName("Pulakala");
            //Validation for Email
            P.Validate_Email("neeladr.pul@gmail.co.in");
        }

        public bool Validate_FirstName(string firstName)
        {
            //First name starts with capital and should have min 3 characters
            string FirstNamePattern = @"^[A-Z]{1}[a-zA-Z]{2,}$";

            return Regex.IsMatch(firstName, FirstNamePattern);
        }

        public bool Validate_LastName(string lastName)
        {
            //Last name starts with capital and should have min 3 characters
            string LastNamePattern = @"^[A-Z]{1}[a-zA-Z]{2,}$";

            return Regex.IsMatch(lastName, LastNamePattern);
        }
        public bool Validate_Email(string email)
        {
            //Email Pattern 
            string EmailPattern = @"^([A-Za-z]{3,}([.a-z]*)[@][a-z]{2,}[.][a-z]{2,3}([.a-z]*))$";

            return Regex.IsMatch(email, EmailPattern);
        }

    }
}
