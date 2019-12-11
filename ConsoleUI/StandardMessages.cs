﻿using System;
namespace ConsoleUI
{
    public class StandardMessages
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to my application!");
        }

        public static void EndApplication()
        {
            Console.ReadLine();
        }

        public static void DisplayErrorMessage(string fieldname)
        {
            Console.WriteLine($"You did not give us a valid { fieldname }!");
        }
    }
}
