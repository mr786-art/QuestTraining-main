using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class Program
    {
        //Printing natural numbers.
        static void Main(string[] args)
        {
            Console.Write("Enter the limit:");
            int limit = int.Parse(Console.ReadLine());
            for(int i = 1; i <= limit; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
