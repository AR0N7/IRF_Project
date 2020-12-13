using IRF_Project_GQOTXA;
using IRF_Project_GQOTXA.Unit_Test;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject
{
    public class Teszteles
    {
        [
            Test,
            TestCase("testemail.hu", false),
            TestCase("testemail123", false),
            TestCase("test@emailhu", false),
            TestCase("test@email.hu", true)
        ]
        public void emailTest(string email, bool result)
        {
            var testClass = new TestClass();
            var eredmeny = testClass.ValidateEmail(email);
            Assert.AreEqual(result, eredmeny);
        }

        [
            Test,
            TestCase("R@vid12", false),
            TestCase("N@KISBETU123", false),
            TestCase("nincsSZ@Mbenne", false),
            TestCase("nincsn@gybetu123", false),
            TestCase("NincsSpecial123", false),
            TestCase("J@Jelszo12345", true)
        ]
        public void passwordTest(string password, bool result)
        {
            var testClass = new TestClass();
            var eredmeny = testClass.ValidatePassword(password);
            Assert.AreEqual(result, eredmeny);
        }

        [
            Test,
            TestCase("eur", false),
            TestCase("EURO", false),
            TestCase("EU1", false),
            TestCase("EU", false),
            TestCase("EUR", true)
        ]
        public void currencyTest(string curr, bool result)
        {
            var testClass = new TestClass();
            var eredmeny = testClass.ValidateCurrency(curr);
            Assert.AreEqual(result, eredmeny);
        }
    }
}
