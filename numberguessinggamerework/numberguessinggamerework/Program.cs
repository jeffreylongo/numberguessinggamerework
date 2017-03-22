using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberguessinggamerework
{
    class Program
    {
        static List<int> AlreadyGuessedNumbers = new List<int>();
        static void AlreadyGuessed(int guess)
        {
            AlreadyGuessedNumbers.Add(guess);
        }

        static int PromptAndOutput()
        {
            Console.WriteLine("Give me your best guess");
            var input = Console.ReadLine();
            int.TryParse(input, out int guess);
            return guess;
        }

        static string EndingCredit(int counter)
        {
            if (counter > 4)
            {
                return "You Lose";
            }
            else
            {
                return "You Win";
            }
        }
        static void Main(string[] args)
        {
            int rnd = new Random().Next(1, 101);
            Console.WriteLine(rnd);

            var myguess = PromptAndOutput();
            var counter = 0;
            Console.WriteLine(EndingCredit(counter));

            counter++;

            Console.ReadLine();
        }
    }
}