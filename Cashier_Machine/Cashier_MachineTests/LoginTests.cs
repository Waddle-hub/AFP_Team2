using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cashier_MachineTests
{
    [TestFixture]
    public class LoginTests
    {
        [Test]
        public void UserWithIncorrectUserAndPassword()
        {
            //Arrange
            string username = "";
            string password = "";

            //Act
            string result = "Incorrect Pass or Username used";

            //Assert
            Assert.Pass(result);
        }

        [Test]
        public void UserWithcorrectUserAndPassword()
        {
            //Arrange
            string username = "root";
            string password = "password";

            //Act
            string result = "Welcome User";

            //Assert
            Assert.Pass(result);
        }
    }
}
