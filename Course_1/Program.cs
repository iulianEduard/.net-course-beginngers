﻿using System;

namespace Course_1
{
    /// <summary>
    /// This is a class. It contains: attributes, properties and methods
    /// </summary>
    class Program
    {
        static string globalMessage = "I am the root!";

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int x = 19;
            int y = 6;
            Console.WriteLine($"Am {x} ani si locuiesc aici de {y} ani!");

            var class1 = new Class1();
            class1.ShowMessage();
            class1.ShowMessageWithParams("Afiseaza mesajul asta!");

            string message = "Mesaj diferit";
            class1.ShowMessageWithParams(message);

            string valueToDisplay = "Alt mesaj diferit";
            class1.ShowMessageWithParams(valueToDisplay);

            var sumValue = class1.Sum();

            Console.ReadKey();
        }

        /// <summary>
        /// This is a method in C#
        /// </summary>
        static void WorkingWithMethods()
        {
            Console.WriteLine("This message is from a method!");
        }

        /// <summary>
        /// This is a method that accepts a parameter
        /// </summary>
        /// <param name="messageToDisplay">Object that contains the value we want to display</param>
        static void WorkingWithMethodsAndParameters(string messageToDisplay)
        {
            Console.WriteLine("The following message is passed on by a parameter:");
            Console.WriteLine(messageToDisplay);
        }

        /// <summary>
        /// Understanding variables and how they are declared
        /// These variables will be only visible inside the method they are created
        /// </summary>
        static void WorkingWithLocalVariables()
        {
            int x = 20;
            long y = 4343243241234;
            string z = "20";
            string k = "My name is Joe!";
            bool b1 = true, b2 = false;
            DateTime date = DateTime.Now;

            Console.WriteLine($"This is an integer: {x}");
            Console.WriteLine($"This is a long: {y}");
            Console.WriteLine($"This is a string (it may look as an int, but its not): {z}");
            Console.WriteLine($"This is another string: {k}");
            Console.WriteLine($"Boolean values: b1 - {b1} and b2 - {b2}");
            Console.WriteLine($"Your date and time: {date}");
        }

        static void WorkingWithVariablesExtended()
        {
            Console.WriteLine($"Int range: FROM {int.MinValue} TO: {int.MaxValue}");
            Console.WriteLine($"long range: FROM {long.MinValue} TO: {long.MaxValue}");
            Console.WriteLine($"Double range: FROM {double.MinValue} TO: {double.MaxValue}");

            char c1 = 'c';
            string c2 = "c";

            Console.WriteLine("There is a difference between char and string");

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine("They are both converted to string when displayed on the console");
        }

        static void WorkingWithGlobalVariables()
        {
            Console.WriteLine($"The following message is default one: {globalMessage}");

            // Let's change the global value
            globalMessage = "Oh no, they changed me!";

            Console.WriteLine($"The following message is default one: {globalMessage}");
        }
    }

    public class Class1
    {
        public void ShowMessage()
        {
            Console.WriteLine("Message from Class 1!");
        }

        public void ShowMessageWithParams(string valueToDisplay)
        {
            Console.WriteLine("Custom message to display:");
            Console.WriteLine(valueToDisplay);
        }

        public int Sum()
        {
            int a = 1;
            int b = 2;

            int sum = a + b;

            return sum;
        }

    }

    class Class2
    {

    }
}
