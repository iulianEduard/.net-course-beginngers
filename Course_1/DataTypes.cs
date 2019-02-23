using System;

namespace Course_1
{
    class DataTypes
    {
        public void NumericOperations()
        {
            int x1 = 2;
            int x2 = 4;

            Console.WriteLine($"Value of x1: {x1}, x2: {x2}");
            Console.ReadKey();

            int sum = x1 + x2;
            Console.WriteLine($"Their sum is: {sum}");
            Console.ReadKey();

            Console.WriteLine("Another way to calculate the sum");
            Console.WriteLine($"Sum value: {x1 + x2}");
            Console.WriteLine("This value is only displayed on the console and no variable is storing it!");
            Console.ReadKey();

            var diff = x1 - x2;
            Console.WriteLine($"Difference is: {diff}");
            Console.ReadKey();

            var inmultire = x1 * x2;
            Console.WriteLine($"Multipling these numbers: {inmultire}");
            Console.ReadKey();

            var divide = x1 / x2;
            Console.WriteLine($"Dividing these numbers: {divide}");
            Console.ReadKey();
        }

        public void NumericOperationsFromKeyboard()
        {
            int x, y;

            Console.WriteLine("Introduceti un numar:");
            var number1 = Console.ReadLine();

            x = Convert.ToInt32(number1);

            Console.WriteLine("Introduceti al doilea numar:");
            var number2 = Console.ReadLine();

            y = Convert.ToInt32(number2);

            Console.ReadKey();

            Console.WriteLine($"Suma numerelor este: {x + y}");
            Console.WriteLine($"Diferenta numerelor este: {x - y}");
            Console.WriteLine($"Produsul numerelor este: {x * y}");
            Console.WriteLine($"Valoarea impartirii este: {x / y}");
        }

        public void DoubleOperations()
        {
            double x = 2.312;
            double y = 6.6554;
            double z = -4.32437;

            Console.WriteLine($"Sum of numbers is : {x + y + z}");
            Console.WriteLine($"Diference of the numbers is: {x + y + z}");
            Console.WriteLine($"Multiplying these numbers: {x * y * z}");
            Console.WriteLine($"Dividing these numbers: {x / y / z}");
        }

        public void StringOperations()
        {
            Console.WriteLine("Please enter your name:");
            string userName = Console.ReadLine();

            Console.WriteLine("Please eneter your age:");
            string userAge = Console.ReadLine();

            Console.WriteLine("Thank you for submitting this data! Below is what you entered:");

            Console.WriteLine("Display data using option 1 -> Name: {0}, Age: {1}", userName, userAge);
            Console.ReadKey();

            Console.WriteLine($"Display data using option 2 -> Name: {userName}, Age: {userAge}");
            Console.ReadKey();

            Console.WriteLine($"Name upper case: {userName.ToUpper()}");
            Console.ReadKey();

            Console.WriteLine($"Name lower case: {userName.ToLower()}");
            Console.ReadKey();

            Console.WriteLine($"Lenght of {userName.Length}");
            Console.ReadKey();

            Console.WriteLine($"Replacing 'a' with 'b' from {userName} results in {userName.Replace('a', 'b')}");
            Console.ReadKey();

            var contains = userName.Contains("a");
            Console.WriteLine($"{userName} contains 'a': {contains}");
        }
    }
}
