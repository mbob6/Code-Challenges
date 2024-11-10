using System;

namespace CodeChallenge
{
    class Challenge
    {
        public static void Main(string[] args)
        {
            TriangleValidator();
            
            
            Console.ReadLine();
        }
        static void ReverseString()
        {
            //For a given string, show the string in reversed form

            Console.WriteLine("Enter a word to reverse: ");
            string word = Console.ReadLine()!;

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
    
        static void PasswordChecker()
        {
            Console.WriteLine("Enter Password : ");
            string password = Console.ReadLine()!;

            Console.WriteLine("Confirm Password : ");
            string passwordConfirm = Console.ReadLine()!;


            if (!password.Equals(string.Empty))
            {
                if (!passwordConfirm.Equals(string.Empty))
                {
                    if (password.Length >= 6)
                    {
                        if (passwordConfirm.Length >= 6)
                        {
                            if (password == passwordConfirm)
                            {
                                Console.WriteLine("Password Matched");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Password Confirmation less than 6"); 
                        }
                    }
                    else
                    {
                        Console.WriteLine("Password less than 6 characters");
                    }

                }
                else
                {
                    Console.WriteLine("Password Confirmation Empty!");
                }
            }    
            else
            {
                Console.WriteLine("Password Empty!");
            }
        }
    
        static void TriangleValidatorWithArrays()
        {

            const int angleCount = 3;
            int[] angles = new int[angleCount];

            for (int i = 0; i < angleCount; i++)
            {
                Console.WriteLine($"Enter angle {i + 1}");
                angles[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();

            int angleSum = 0;

            foreach (var angle in angles)
            {
                angleSum += angle;
            }

            Console.WriteLine(angleSum == 180 ? "Valid" : "Invalid");
        }
    
        static void TriangleValidator()
        {
            int angleSum = 0;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Enter angle {i + 1}");
                angleSum += Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(angleSum == 180 ? "Valid" : "Invalid");
        }
    }
}