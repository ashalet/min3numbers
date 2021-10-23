using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace min3numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstValue, secondValue, thirdValue, result;

            firstValue = int.Parse(Console.ReadLine());
            secondValue = int.Parse(Console.ReadLine());
            thirdValue = int.Parse(Console.ReadLine());

            if ((firstValue < secondValue) && (firstValue < thirdValue)) Console.WriteLine(firstValue);
            else if ((secondValue < firstValue) && (secondValue < thirdValue)) 
            {
                Console.WriteLine(secondValue);
            }
            else
            {
                Console.WriteLine(thirdValue);
            }
            Console.ReadLine();
        }   
    }
}
