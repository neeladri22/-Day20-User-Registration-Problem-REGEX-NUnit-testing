using NUnit.Framework;
using System.Text.RegularExpressions;
using UserRegistration;


namespace TestProject
{
    
    public class Test
    {
        public Program program;

        [SetUp]
        public void Setup()
        {
            //Arrange 
            program = new Program();
        }

        [Test]
      
        public void Check_Validation_for_FirstName()
        {
            //Act
            string firstName = "Neeladri";
            var result = program.Validate_FirstName(firstName);
            //Assert
            Assert.IsTrue(result);
        }

        [Test]
        // validating the Last Name
        public void Check_Validation_for_LastName()
        {
            //Act
            string lastName = "Pulakala";
            var result = program.Validate_LastName(lastName);
            //Assert
            Assert.IsTrue(result);
        }
        [Test]
        // validating the Email
        public void Check_Validation_for_Email()
        {
            //Act
            string email = "prateek.pai@gmail.co.in";
            var result = program.Validate_Email(email);
            //Assert
            Assert.IsTrue(result);
        }
        [Test]
        //Validating the Mobile Number
        public void Check_Validation_for_MobileNumber()
        {
            //Act
            string mobileNumber = "91 7385645875";
            var result = program.Validate_MobileNumber(mobileNumber);
            //Assert
            Assert.IsTrue(result);
        }

        [Test]
        //Unit test for validating the Password
        public void Check_Validation_Password()
        {
            //Act
            string password = "Password";
            var result = program.Validate_Password(password);
            //Assert
            Assert.IsTrue(result);
        }
        [Test]
        // validating the Password with one upper case
        public void Check_Validation_for_password_Contains_Min_8_Characters_should_have_atleast_1_uppercase()
        {
            //Act
            string password = "passwoRd";

            var result = program.ValidatePasswordWithUpperCase(password);

            //Assert
            Assert.IsTrue(result);
        }
        [Test]
        //Unit test for validating the Password
        public void Check_Validation_for_password_Contains_uppercase_1_NumericNumber()
        {
            //Act
            string password = "paSSword1";

            var result = program.Validate_PasswordUppercaseAndNumericNumber(password);

            //Assert
            Assert.IsTrue(result);
        }
    }
}
