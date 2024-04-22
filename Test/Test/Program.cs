using System.Dynamic;
using System.Linq;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string pangram = "The quick brown fox jumps over the lazy dog";


            //string[] words = pangram.Split(' ');
            //string[] reverseWords = new string[words.Length];

            //for(int i=0; i<words.Length;i++)
            //{
            //    char[] wordChars = words[i].ToCharArray();
            //    Array.Reverse(wordChars);
            //    reverseWords[i] = string.Join("",wordChars);
            //    //Console.WriteLine(reverseWords[i]);
            //}

            //string result = string.Join(" ",reverseWords);
            //Console.WriteLine(result);

            //string message = "What is the value <span> between the tags </span>?";

            //const string openSpan = "<span>";
            //const string closeSpan = "</span>";

            //int openingPosition = message.IndexOf(openSpan); 
            //int closingPosition = message.IndexOf(closeSpan);

            //openingPosition += openSpan.Length;
            //int length = closingPosition - openingPosition;
            //Console.WriteLine(message.Substring(openingPosition, length));


            string var = "5";
            int num = Convert.ToInt(var);

            int num2 = int.Parse(var);

            Console.WriteLine(num);
            Console.WriteLine(num2);

            int[] numbers = { 1, 2, 3 };

            int[] numbers_2 = new int[] { 1, 2, 3 };

            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            

        }
    }
}
