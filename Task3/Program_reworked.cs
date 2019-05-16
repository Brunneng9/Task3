using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a range of integer values with a difference greater than 10");

            string start = Console.ReadLine();
            string end = Console.ReadLine();

            int intStart;
            int intEnd;
            int sum = 0;

            try
            {
                intStart = int.Parse(start);
                intEnd = int.Parse(end);
            }
            catch
            {
                Console.WriteLine("It's supposed to be range of integer values");
                return;
            }

            if (intEnd < intStart)
            {
                intEnd = intEnd + intStart;
                intStart = intEnd - intStart;
                intEnd = intEnd - intStart;
            }

            if ((intEnd - intStart) <= 10)
            {
                Console.WriteLine("Range should be more than 10");
                return;
            }

            int[] valueArray = new int[(intEnd - intStart + 1)];

            for (int i = intStart; i <= intEnd; i++)
            {
                valueArray[(i-intStart)] = i;
            }

            foreach (int i in valueArray)
                if (((i % 3) == 0) && ((i % 5) != 0)) 
            {
                    sum = sum + i;
            }

            Console.WriteLine($"Sum is {sum}.");
            Console.Read();
        }   
    }
}
