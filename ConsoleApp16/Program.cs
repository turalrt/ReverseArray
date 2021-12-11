using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Program /*task2*/
    {
        static void Main()
        {
            int[] arr = { 10, 18, 27, 2, 100, 0, -5, 77, -24, 99 };
            Array.Reverse(arr);
            Console.WriteLine("Reversed Array:");
            foreach (int value in arr)
            {
                Console.Write(value + " ");
            }
        }
    }
}
