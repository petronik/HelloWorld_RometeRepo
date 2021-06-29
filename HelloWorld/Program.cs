using System;
using System.Runtime.InteropServices;

namespace HelloWorld
{
    class Program
    {
        static void PrintInfo<T>()
        {
            const int w = 7;
            const int w2 = 35;
            var minValue = typeof(T).GetField("MinValue").GetValue(null);
            var maxValue = typeof(T).GetField("MaxValue").GetValue(null);
            Console.WriteLine($"|{typeof(T),-w + 25}|{Marshal.SizeOf(typeof(T)), w}|{minValue,w2}|{maxValue,w2}|");
        }

        static void Main(string[] args)
        {
            //PrintInfo<sbyte>();
            //PrintInfo<int>();
            //PrintInfo<double>();
            //PrintInfo<decimal>();
            //int zero = 0;
            int r = 100 / 8;
            Console.WriteLine("r = " + r);

            try
            {
                int a = 25;
                int b = 300;

                if (b < 0 || b > 255)
                    throw new ArgumentOutOfRangeException();

                //int c = a / b;

                string value1 = "babanas"; // FormatException
                int intValue1 = Convert.ToInt32(value1);
                //int intValue1 = Int32.Parse(value1);
                //double doubleValue1 = Double.Parse(value1);
                //double doubleValue1 = Convert.ToDouble(value1);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("0: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("1: " + e.Message);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("2: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("3: " + e.Message);
            }

            Console.WriteLine("Have a nice day!!");
        }
    }
}
