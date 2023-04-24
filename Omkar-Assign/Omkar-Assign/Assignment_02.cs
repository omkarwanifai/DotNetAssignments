using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omkar_Assign
{
    class Assignment_02
    {
        static void Main(string[] args)
        {
            int[] nums = { 23,45,55,10,2,34,22,66,100,7,88,99 };
            for(int i=0;i<nums.Length;i++)
            {
                if(nums[i]%2==0)
                {
                    Console.WriteLine($"The even numbers are {nums[i]}");
                }
            }

            for(int h=0;h<nums.Length;h++)
            {
                if (nums[h] % 2 != 0)
                {
                    Console.WriteLine($"The odd numbers are {nums[h]}");

                }
            }
        }
    }
}
