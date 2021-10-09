using System;

namespace RegexOfPatternMatchingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string phone;
            bool result;
            ValidatePhoneNumber validatePhoneNumber = new ValidatePhoneNumber();
            Console.WriteLine("enter phone number");
            phone = Console.ReadLine();
            result = validatePhoneNumber.PhoneNumberCheck(phone);
            Console.WriteLine(result);

        }
    }
}
