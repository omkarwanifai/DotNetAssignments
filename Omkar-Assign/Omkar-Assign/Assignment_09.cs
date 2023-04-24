using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omkar_Assign
{
    class Assignment_09
    {
        public static string ReverseByWords(string sentance)
        {
            string[] arr = sentance.Split(' ');
            string[] ans = new string[arr.Length];
            int p = arr.Length - 1;
            for (int i=p,j=0;i>=0;i--,j++)
            {
                ans[j] = arr[i];
            }
            
            string str = "";
            foreach(var v in ans)
            {
                str += v+" ";
            }
            //Console.WriteLine(str);
            return str;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string s = Console.ReadLine();
            string answer = ReverseByWords(s);
            Console.WriteLine(answer);
        }
    }
}
