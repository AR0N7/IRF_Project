using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace IRF_Project_GQOTXA.Unit_Test
{
    public class AdatValidacio
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
                @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{10,}");

        }
    }
}
