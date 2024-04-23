using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 11, 7, 8 };

            Array.Sort(arr);
            Array.Reverse(arr);

            Console.WriteLine(arr[2]);

       
        }
    }
}
