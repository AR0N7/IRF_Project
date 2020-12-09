using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRF_Project_GQOTXA.Unit_Test
{
    public class BelepesiAdatok
    {
        [
            Test,
            TestCase("tesztemailkukacnelkul", false),
            TestCase("teszt@nincsenponthu", false),
            TestCase("nincsenkukac.hu", false),
            TestCase("teszt@validemail.hu", true)
        ]
        public void EmailEllenorzes(string email, bool result)
        {
            // Arrange lépés
            var validation = new AdatValidacio();
            // Act lépés
            var actualResult = validation.ValidateEmail(email);
            // Assert lépés
            Assert.AreEqual(result, actualResult);
        }

        [
            Test,
            TestCase("csakbetuk", false),
            TestCase("nincsnagybetu123", false),
            TestCase("NINCSKICSI12345", false),
            TestCase("Rovid12", false),
            TestCase("10KaRaKtEr", true)
        ]
        public void JelszoEllenorzes(string password, bool result)
        {
            var validation = new AdatValidacio();

            var actualResult = validation.ValidatePassword(password);

            Assert.AreEqual(result, actualResult);
        }
    }
}
