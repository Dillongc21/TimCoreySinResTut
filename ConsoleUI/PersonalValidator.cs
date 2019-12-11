using System;
namespace ConsoleUI
{
    public class PersonalValidator
    {
        public static bool Validate(Person user)
        {
            // Checks to be sure the first and last names are valid
            if (string.IsNullOrWhiteSpace(user.FirstName))
            {
                StandardMessages.DisplayErrorMessage("first name");
                return false;
            }

            if (string.IsNullOrWhiteSpace(user.LastName))
            {
                StandardMessages.DisplayErrorMessage("last name");
                return false;
            }

            return true;
        }
    }
}
