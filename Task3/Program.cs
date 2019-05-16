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
			bool statement = true;
			int intStart;
			int intEnd;
			int sum = 0;
			Console.WriteLine("Please enter a range of integer values with a difference greater than 10");
			do
			{
				intStart = GetIntigerValueFromConsole();
				intEnd = GetIntigerValueFromConsole();


				if (intEnd < intStart)
				{
					intEnd = intEnd + intStart;
					intStart = intEnd - intStart;
					intEnd = intEnd - intStart;
				}

				if ((intEnd - intStart) <= 10)
				{
					Console.WriteLine("Range should be more than 10");
				}
				else
				{
					statement = false;
				}
			} while (statement);


			int[] valueArray = new int[(intEnd - intStart + 1)];

            for (int i = intStart; i <= intEnd; i++)
            {
                valueArray[(i-intStart)] = i;
            }

            foreach (int value in valueArray)
                if (((value % 3) == 0) && ((value % 5) != 0)) 
            {
                    sum = sum + value;
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
