using System;

namespace  DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1_000_000;
            Console.WriteLine(num);
            
            //creating an string Array 
            string[] myArray = new string[2];
            myArray[0]="walid";
            myArray[1]="Omar";

            foreach(string value in myArray)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine("**************************");

            //creating an int array
            int[] myIntArray = {0,1,2,3,4,5};

            foreach(int value in myIntArray)
            {
                Console.WriteLine(value);
            }

            var slicie_1 = myIntArray[..3];   // 0,1,2
            var slicie_2 = myIntArray[1..3];  // 1,2
            var slicie_3 = myIntArray[1..^3]; // 1,2

            Console.WriteLine("**************************");
            //creating jagged array ==> it's an array inside array

            var jagged = new int[][]
            {
                new int[] {1,2},
                new int[] {1,2,3,4},
                new int[] {1}
            };


            Console.WriteLine(jagged[0][1]);

            Console.WriteLine("**************************");

            // Creating a string list

            List<string> myStringList = new List<string>(){"walid"};

            myStringList.Add("Khalaf");

            Console.WriteLine(myStringList[0]);

            Console.WriteLine("**************************");

            //Dictionary 

            Dictionary<string,int> myDict= new Dictionary<string,int>(){{"python",50},{"C#",60}};


            //we use var keyword with dictionary
            foreach(var value in myDict)
            {
                Console.WriteLine($"key={value.Key} ==> value={value.Value}");
            } 

            Console.WriteLine("**************************");

        }
    }
}