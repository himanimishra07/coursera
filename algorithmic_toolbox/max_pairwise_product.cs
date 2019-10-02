using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public class Program
    {
        static void Main(string[] args)
        {
            int x = Int32.Parse(Console.ReadLine()); /* the integer given by the user will be stored in x */
            string y = Console.ReadLine(); /* user will give the number of integers which will be eqal to the value of x */

            string[] tokens = y.Split(' '); /* all the spaces between the integers will be removed and they will assign into an array accordingly */

            List<int> nums = new List<int>();
            int oneNum;
            foreach (string s in tokens)       /* nums is the list of integers of an array */

            {
                if (Int32.TryParse(s, out oneNum))
                    nums.Add(oneNum);
            }

            nums.Sort();      /* .sort method is used to sort the list in to ascending order*/

            Double max2;      /* max2 is the second last element of the list which is the sceond largest number*/

            Double max1;      /* max1 is the second last element of the list which is the largest number*/


            max1 = nums[nums.Count - 1];   /* the method to finding the largest number*/



            max2 = nums[nums.Count - 2];   /* the method to finding the 2nd largest number*/

            Console.WriteLine(max1 * max2); /*the maximun pairwise product*/

            Console.ReadKey();



        }


    }

}
