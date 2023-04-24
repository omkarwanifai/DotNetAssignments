using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omkar_Assign
{
    class Assignment_11
    {
        public static double InterestAmount(double P,double R,int T)
        {
            double InterestAmount = (P * R * T) / 100;
            return InterestAmount;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Principle Amount");
            double Principle = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Rate Of Interest");
            double ROI = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Term in years only");
            int Term = int.Parse(Console.ReadLine());

            Console.WriteLine($"The interest amount is {InterestAmount(Principle,ROI,Term)}");
        }
    }
}
