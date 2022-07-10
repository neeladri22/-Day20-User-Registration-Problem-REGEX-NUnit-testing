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
    }
}
