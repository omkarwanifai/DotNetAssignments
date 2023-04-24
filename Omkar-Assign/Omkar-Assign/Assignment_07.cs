using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omkar_Assign
{
    
    class Assignment_07
    {
        private static bool IsPrimeNumber(int num)
        {
            bool flag = true;
            for (int i = 2; i < num / 2; i++)
            {
                if (num % i == 0)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to check for Prime or not");
            int n = int.Parse(Console.ReadLine());
            bool ans = IsPrimeNumber(n);
            if(ans)
                Console.WriteLine($"{n} is Prime Number");
            else
                Console.WriteLine($"{n} is not a Prime Number");

        }
    }
}
