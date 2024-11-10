using System;

namespace CodeChallenge
{
    class Challenge
    {
        public static void Main(string[] args)
        {
            ReverseString();
            
            
            Console.ReadLine();
        }
        
        static void ReverseString()
        {
            Console.WriteLine("Enter a word to reverse: ");
            string? word = Console.ReadLine();

            Console.WriteLine();

            for (int i = 0; i < word.Length; i++)
            {
                Console.Write(word[i]);
            }

            Console.WriteLine("\n");

            for (int i = word.Length - 1; i >= 0; i--)
            {
                Console.Write(word[i]);
            }

            Console.ReadLine();
        }
    }
}