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
			EnterValue:
            Console.WriteLine("Please enter a range of integer values with a difference greater than 10");


            int intRangeStart = GetIntigerValueFromConsole();
            int intRangeEnd = GetIntigerValueFromConsole();
            int sum = 0;
			
            if (intRangeEnd < intRangeStart)
            {
                intRangeEnd = intRangeEnd + intRangeStart;
                intRangeStart = intRangeEnd - intRangeStart;
                intRangeEnd = intRangeEnd - intRangeStart;
            }

            if ((intRangeEnd - intRangeStart) <= 10)
            {
                Console.WriteLine("Range should be more than 10");
                goto EnterValue; 
            }

            int[] valueArray = new int[(intRangeEnd - intRangeStart + 1)];

            for (int i = intRangeStart; i <= intRangeEnd; i++)
            {
                valueArray[(i-intRangeStart)] = i;
            }

            foreach (int i in valueArray)
                if (((i % 3) == 0) && ((i % 5) != 0)) 
            {
                    sum = sum + i;
            }

            Console.WriteLine($"Sum is {sum}.");
            Console.Read();
        }

		private static int GetIntigerValueFromConsole()
		{
			int enteredValue;
			while (true)
			{
				if (int.TryParse(Console.ReadLine(), out enteredValue))
				{
					break;
				}
				else
				{
					Console.WriteLine("Value should be integer");
				}
			}
			return enteredValue;

		}
	}
	
}
