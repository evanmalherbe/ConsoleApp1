// See https://aka.ms/new-console-template for more information
using CSharpFundamentals.Math;
using System;

namespace CSharpFundamentals
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }

    class Program
    {
        static void Main(string[] args)
        {
            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);

            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);

            Console.WriteLine(method.ToString());

            var numbers = new int[3];
            numbers[0] = 1;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            var flags = new bool[3];
            flags[0] = true;

            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);

            var names = new string[3] { "John", "Bob", "Mary" };
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);

            var john = new Person();
            john.FirstName = "John";
            john.LastName = "Smith";
            john.Introduce();

            var calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);

            var firstName = "Jon";
            var lastName = "Smit";

            var fullName = firstName + " " + lastName;
            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);
            Console.WriteLine(myFullName);

            var namez = new string[3] { "Jack", "Mary", "Susan" };
            var formattedNames = string.Join(",", namez);
            Console.WriteLine(formattedNames);

            var text = @"Hi Jack
            Looking into the following
            c:\folder1\folder2
            c:\folder3\folder4";

            Console.WriteLine(text);
        }
    }
}