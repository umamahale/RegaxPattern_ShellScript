using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexOfPatternMatchingDemo
{
    class ValidateFirstName
    {
        public string RegexPattern = "^[A-Z][a-ZA-Z]*$";
        public bool PhoneNumberCheck(string firstname)
        {
            return Regex.IsMatch(firstname, RegexPattern);
        }

        internal static bool FirstNameCheck(string name)
        {
            throw new NotImplementedException();
        }
    }
}