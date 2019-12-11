using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            StandardMessages.WelcomeMessage();

            Person user = PersonDataCapture.Capture();

            bool isUserValid = PersonalValidator.Validate(user);

            if (isUserValid == false)
            {
                StandardMessages.EndApplication();
                return;
            }

            AccountGenerator.CreateAccount(user);

            StandardMessages.EndApplication();
        }
    }
}
