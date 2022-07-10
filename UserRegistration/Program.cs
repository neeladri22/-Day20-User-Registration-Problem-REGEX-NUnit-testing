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

            //Validation for Mobile Number
            P.Validate_MobileNumber("91 7385645875");

            //Validation for Password
            P.Validate_Password("Password");

            //Validation for Password with upper case
            P.Validate_Password("paswoRd");

            //Validation for Password with upper case and numeric number
            P.Validate_Password("paswoRd1");
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
        public bool Validate_MobileNumber(string mobileNumber)
        {
            //Mobile Number  - Country code follwed by space and 10 Digit Number
            string MobileNumberPattern = @"^[1-9]{2,}[\s][6-9]{1}[0-9]{9}$";

            return Regex.IsMatch(mobileNumber, MobileNumberPattern);
        }
        public bool Validate_Password(string password)
        {
            //Password  - Min 8 Characters
            string PasswordPattern = @"^[a-zA-Z]{8,}$";

            return Regex.IsMatch(password, PasswordPattern);
        }
        public bool ValidatePasswordWithUpperCase(string password)
        {
            //Password  - Min 8 Characters and should have atleast 1 upeer case
            string PasswordPattern = @"^(?=.*[A-Z])[a-zA-Z]{8,}$";

            return Regex.IsMatch(password, PasswordPattern);
        }

        public bool Validate_PasswordUppercaseAndNumericNumber(string password)
        {
            //Password  - Min 8 Characters and should have atleast 1 upeer case, 1 Numeric Number 
            string PasswordPattern = @"^(?=.*[A-Z])(?=.*[0-9])(?=.*[a-z]).{8,}$";

            return Regex.IsMatch(password, PasswordPattern);
        }

       

    }
}
