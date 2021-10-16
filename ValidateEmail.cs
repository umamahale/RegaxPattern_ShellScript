using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexOfPatternMatchingDemo
{
    class ValidateEmail
    {
        public string RegexPattern = (@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        public bool EmailCheck(string email)
        {
            return Regex.IsMatch(email, RegexPattern);
        }

        internal static bool EmailCheck()
        {
            throw new NotImplementedException();
        }
    }
}
