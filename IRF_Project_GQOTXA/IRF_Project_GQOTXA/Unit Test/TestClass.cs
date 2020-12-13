using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace IRF_Project_GQOTXA.Unit_Test
{
    public class TestClass
    {
        public bool ValidateEmail(string email)
        {
            return Regex.IsMatch(
                email,
                @"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?");
        }

        public bool ValidatePassword(string password)
        {
            return Regex.IsMatch(
                password,
                @"^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[*@$%&]).{8,32}$");

        }

        public bool ValidateCurrency(string curr)
        {
            return Regex.IsMatch(
                curr,
                @"^([A-Z]{3})$");
        }
    }
}
