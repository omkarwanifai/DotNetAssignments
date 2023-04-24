using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omkar_Assign
{
    class Assignment_03
    {
        static void Main(string[] args)
        {
            int inp;
            do
            {
                Console.WriteLine("Enter 1 to add two numbers");
                Console.WriteLine("Enter 2 to subtract two numbers");
                Console.WriteLine("Enter 3 to multiply two numbers");
                Console.WriteLine("Enter 4 to divide two numbers");
                Console.WriteLine("Enter 5 to modulo two numbers");
                Console.WriteLine("Enter 6 to exit");

                inp = Convert.ToInt32(Console.ReadLine());
                switch (inp)
                {
                    case 1:
                        Console.WriteLine("Enter the 2 numbers");
                        int a = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"The sum is {a + b}");
                        break;
                    case 2:
                        Console.WriteLine("Enter the 2 numbers");
                        var q = Convert.ToInt32(Console.ReadLine());
                        var w = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"The result is {q - w}");
                        break;
                    case 3:
                        Console.WriteLine("Enter the 2 numbers");
                        var t = Convert.ToInt32(Console.ReadLine());
                        var u = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"The multiplication is {t * u}");
                        break;
                    case 4:
                        Console.WriteLine("Enter the 2 numbers");
                        var x = Convert.ToDouble(Console.ReadLine());
                        var z = Convert.ToDouble(Console.ReadLine());
                        double ans = x / z;
                        Console.WriteLine($"The result is {ans}");
                        break;
                    case 5:
                        Console.WriteLine("Enter the 2 numbers");
                        var m = Convert.ToInt32(Console.ReadLine());
                        var n = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"The modulo is {m % n}");
                        break;
                    case 6:
                        Console.WriteLine("Byee!!!");
                        break;
                    default:
                        Console.WriteLine("Enter a valid value");
                        break;
                }
            }
            while (inp != 6);
        }
    }
}
