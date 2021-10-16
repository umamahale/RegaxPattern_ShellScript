using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace PasswordValidate
{
     public enum PasswordPolicyIssue
    {
        MustHaveNumber,
        MustHaveCapitalLetter,
        MustHaveSmallLetter,
        MustBeAtLeast8Characters,
        MustHaveSymbol
    }
    
        public bool PasswordPolicyIssue(string password, out List<PasswordPolicyIssue> issues)
        {
            var input = password;
            issues = new List<PasswordPolicyIssue>();

            if (string.IsNullOrWhiteSpace(input))
                throw new Exception("Password should not be empty");

            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            //var hasMiniMaxChars = new Regex(@".{8,15}");
            var hasMinChars = new Regex(@".{8,}");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            if (!hasLowerChar.IsMatch(input))
                issues.Add(PasswordPolicyIssue.MustHaveSmallLetter);

            if (!hasUpperChar.IsMatch(input))
                issues.Add(PasswordPolicyIssue.MustHaveCapitalLetter);

            if (!hasMinChars.IsMatch(input))
                issues.Add(PasswordPolicyIssue.MustBeAtLeast8Characters);

            if (!hasNumber.IsMatch(input))
                issues.Add(PasswordPolicyIssue.MustHaveNumber);
            if(!hasSymbols.IsMatch(input))
             issues.Add(PasswordPolicyIssue.MustHaveSymbol);

            return issues.Count() == 0;
        }
    }
