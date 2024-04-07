namespace App
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Enter your Word: ");
                string? word = Console.ReadLine();
               

                bool isPlindrome = true;

                for(int i = 0; i < word.Length/2; i++)
                {
                    if(char.ToLower(word[i]) != char.ToLower(word[word.Length - i - 1]))
                    {
                        isPlindrome = false;
                        break;
                    }
                }
                Console.WriteLine("Word is " + (isPlindrome ? "palindrome" : "not palindrome"));
            }

        }
    }
}