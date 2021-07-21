using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binary_search
{
    class Program
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] integers = input.Split(' ');
            int[] data = new int[integers.Length];
            for (int i = 0; i < data.Length; i++)
                data[i] = int.Parse(integers[i]);
            Console.ReadKey();


        }
    }
}