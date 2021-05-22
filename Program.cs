using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inheritance;

namespace InterviewQuestions
{
    class Program
    {
        static void Main(string[] args)
        {

            Pet pet = new Cat();
            Shape shape = new Ball();

            Console.WriteLine(string.Format("My {0} is playing with a {1}", pet.GetName(), shape.GetName()));

            PerfectBinaryStringWithMinimumBitFlips TestPerfectBinaryString = new PerfectBinaryStringWithMinimumBitFlips();

            Console.WriteLine("Minimum: " + Math.Min(TestPerfectBinaryString.CountFlipsWithStartingCharacter("0001010111", '0'), TestPerfectBinaryString.CountFlipsWithStartingCharacter("0001010111", '1')));
            

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
    
    // I like to be descriptive with my naming...
    public class PerfectBinaryStringWithMinimumBitFlips
    {
        // Empty constructor; but here's the story:
        public PerfectBinaryStringWithMinimumBitFlips()
        {
            /*
             * We're trying to keep a binary string in an alternating format (e.g., 010101, 101010, etc.).
             * We're given the task of trying to determine the minimum number of bit swaps it will take to maintain an alternating pattern.
             * 
             * Examples:
             *      0101: output should be 0; this is in alternating format desired.
             *      0011: output should be 1; we would swap index 0 and index 3 to get 1010.
             * 
             * Plan of action:
             *      - Count number of 0s in odd index positions, store in OddIndex_0_Count; number of 0s in even index positions, store in EvenIndex_0_Count.
             *      - Count number of 1s in odd index positions, store in OddIndex_1_Count; number of 1s in even index positions, store in EvenIndex_1_Count.
             *      - Output:
             *          - If input string starts with 0, return Math.Min(EvenIndex_0_Count, OddIndex_1_Count)
             *          - If input string starts with 1, return Math.Min(OddIndex_0_Count, EvenIndex_1_Count)
             */
        }

        public int CountFlipsWithStartingCharacter(String Str, char Expected)
        {
            int FlipCount = 0;

            for(int i = 0; i < Str.Length; i++)
            {
                if(Str[i] != Expected)
                {
                    FlipCount++;
                }

                Expected = FlipBit(Expected);
            }

            return FlipCount;
        }

        public static char FlipBit(char ch)
        {
            return (ch == '0') ? '1' : '0';
        }

    }

}
