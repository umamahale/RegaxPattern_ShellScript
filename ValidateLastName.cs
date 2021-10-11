using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexOfPatternMatchingDemo
{
    class ValidateLastName
    {

        public string RegexPattern = "^[A-Z][a-ZA-A]*$";
        public bool LastNameCheck(string lastname)
        {
            return Regex.IsMatch(lastname, RegexPattern);
        }

        internal static bool LastNameCheck()
        {
            throw new NotImplementedException();
        }
    }
}
