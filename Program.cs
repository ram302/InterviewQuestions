using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            SolutionsCollection sol = new SolutionsCollection();

            // FindMinPositive(int[]) - smallest positive integer not existing in array
            int[] marks = new int[] { -1, -99, -98, -92, -97, -95, 1 };

            Console.WriteLine("Minimum int in array: " + sol.FindMinPositive(marks));

            // ReverseString(string) - Reverse a given string
            string StringToReverse = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam ultrices ligula egestas erat condimentum pellentesque. Curabitur sodales sit amet libero a dapibus. Praesent at lectus nec lectus porta facilisis. Suspendisse ornare convallis odio ut varius. Sed faucibus cursus nisl, eget imperdiet sem. Etiam mollis id nisl vel dictum. Donec dignissim.";
            Console.WriteLine("Reverse string is: {0}", sol.ReverseString(StringToReverse));
            Console.ReadKey();
        }
    }

    public class SolutionsCollection
    {
        public SolutionsCollection() { }

        public int FindMinPositive(int[] inArray)
        {
            int smallestPositiveInt = 1;

            Array.Sort(inArray);

            foreach (int i in inArray)
            {
                if (i <= smallestPositiveInt && i > 0)
                {
                    smallestPositiveInt = i + 1;
                }
            }

            // In case array consists of all negative int, return max of smallestInt and 1
            return Math.Max(smallestPositiveInt, 1);
        }

        public string ReverseString(string someString)
        {
            string outStr = null;

            foreach (char i in someString)
            {
                outStr = i + outStr;
            }

            return outStr;
        }
    }
}
