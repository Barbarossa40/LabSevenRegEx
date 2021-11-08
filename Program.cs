using System;
using System.Text.RegularExpressions;

namespace LabSevenRegularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();
            string message = ValidateName(userInput);
            Console.WriteLine(message);

            string userEmail = Console.ReadLine();
            Console.WriteLine(ValidateEmail(userEmail));

            string userPhoneNumber = Console.ReadLine();
            Console.WriteLine(ValidatePhoneNumber(userPhoneNumber));

            string userDate = Console.ReadLine();
            Console.WriteLine(ValidateDate(userDate));
        }

        public static string ValidateName(string userInput)
        {
            string namePattern = "^[A-Z][a-zA-Z]{0,30}$";
            Regex nameRegex = new Regex(namePattern);
            bool isRegexMatch = nameRegex.IsMatch(userInput);


            while (isRegexMatch == false)
            {
                Console.WriteLine("Invalid Input. Please try again");
                userInput = Console.ReadLine();
                isRegexMatch = nameRegex.IsMatch(userInput);
            }

            return $"Hello, {userInput}! Nice to meet you.";
        }

        public static string ValidateEmail(string userEmail)
        {
            string emailPattern = "^[A-Za-z0-9}]{5,30}@[A-Za-z0-9}]{5,10}.[A-Za-z0-9}]{2,3}$";
            Regex validEmail = new Regex(emailPattern);
         

            while(validEmail.IsMatch(userEmail) == false)
            {

                Console.WriteLine("Please enter a valid input, Bro!");
                userEmail = Console.ReadLine();
                validEmail.IsMatch(userEmail);
            }
            return $"{userEmail} is valid. Thank you!";
        }

        public static string ValidatePhoneNumber(string userPhoneNumber)
        {
            string phoneNumberPattern = "^[0-9]{3}-[0-9]{3}-[0-9]{4}$";
            Regex validPhoneNumber = new Regex(phoneNumberPattern);


            while (validPhoneNumber.IsMatch(userPhoneNumber) == false)
            {

                Console.WriteLine("Please enter a valid input, Bro!");
                userPhoneNumber = Console.ReadLine();
                validPhoneNumber.IsMatch(userPhoneNumber);
            }
            return $"{userPhoneNumber} is valid. Thank you!";

        }

        public static string ValidateDate(string userDate)
        {
            string regexPattern = @"^[0-9]{2}\/[0-9]{2}\/[0-9]{4}$";
            Regex validDate = new Regex(regexPattern);

            while (validDate.IsMatch(userDate) == false)
            {

                Console.WriteLine("Please enter a valid input, Bro!");
                userDate = Console.ReadLine();
                validDate.IsMatch(userDate);
            }
            return $"{userDate} is valid. Thank you!";
        }
    }
}
