using System;
using System.Linq;
using System.Globalization;
using System.Runtime.InteropServices;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Enter your first name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter your last name:");
            string lastName = Console.ReadLine();

            // Console.WriteLine("Hello " + firstName + "!");
            Console.WriteLine("Hello {1} {0} {1}!", firstName, lastName);
            Console.Write($"Hello {firstName} {lastName}");

            Console.WriteLine("!");
            */

            /*
            var date = DateTime.Now;
            Console.WriteLine($"Today is {date.DayOfWeek}, {date:dd-MM-yyyy}");

            string name = "Mark";
            int age = 32; 
            Console.WriteLine($"{name} is {age} year{(age == 1 ? "" : "s")} old.");

            decimal salary = 1500.55m;
            Console.WriteLine($"{name}'s salary is {salary.ToString("C2", CultureInfo.CreateSpecificCulture("ja-JP"))}");


            int i = 123456;
            Console.WriteLine($"i = {i:D}");
            Console.WriteLine($"i = {i:N2}");

            float f = 0.5f;
            Console.WriteLine($"p = {f:P}");

            int c = 255;
            Console.WriteLine($"c = {c:X}");
            */
            const int w = 7;
            Console.WriteLine($"|{"sbyte",-w}|{sizeof(sbyte),w}|{sbyte.MinValue,w}|{sbyte.MaxValue,w}|");
            Console.WriteLine($"|{"int",-w}|{sizeof(int),w}|{int.MinValue,w}|{int.MaxValue,w}|");
        }
    }
}
