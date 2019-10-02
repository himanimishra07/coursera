using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace KnapsackAlgo
{
    class KnapsackAlgorithm
    {
        static void Main(string[] args)
        {
            string scope = Console.ReadLine();
            string[] scope_list = scope.Split(' ');
            int itemsCount = int.Parse(scope_list[0]);
            int capacity = int.Parse(scope_list[1]);
            List<int> values = new List<int>();
            List<int> weights = new List<int>();
            for (float v = 0; v < itemsCount; v++)
            {
                string variable = Console.ReadLine();
                string[] randam_value = variable.Split(' ');
                int value = int.Parse(randam_value[0]);
                int weight = int.Parse(randam_value[1]);
                values.Add(value);
                weights.Add(weight);
            }
            int result = KnapSack(capacity, weights, values, itemsCount);
            Console.WriteLine(result);
            Console.ReadKey();


        }
        public static int KnapSack(int capacity, List<int> weights, List<int> values
            , int itemsCount)
        {
            int[,] K = new int[itemsCount + 1, capacity + 1];

            for (int i = 0; i <= itemsCount; ++i)
            {
                for (int w = 0; w <= capacity; ++w)
                {
                    if (i == 0 || w == 0)
                        K[i, w] = 0;
                    else if (weights[i - 1] <= w) 
                        K[i, w] = Math.Max(values[i - 1] + K[i - 1, w - weights[i - 1]], K[i - 1, w]);
                    else
                        K[i, w] = K[i - 1, w];
                }
            }
            return K[itemsCount, capacity];
        }

    }
}