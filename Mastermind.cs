using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rdm = new Random();
            int first = rdm.Next(1, 6);
            int second = rdm.Next(1, 6);
            int third = rdm.Next(1, 6);
            int fourth = rdm.Next(1, 6);
            int i;
            string final = (first * 1000 + second * 100 + third * 10 + fourth).ToString();
            bool win = false;

            for( int index = 0; index < 10; index++)
            {
                string guess;
                Console.WriteLine("Enter four digits: ");
                Console.WriteLine(final);
                guess = Console.ReadLine();
                while(guess.Length != 4 || guess.Contains('7') || guess.Contains('8') || guess.Contains('9') || guess.Contains('0'))
                {
                    Console.WriteLine("Invalid input.");
                    Console.WriteLine("Enter new digits: ");
                    guess = Console.ReadLine();
                }

                
                string output_1 = "";
                string output_2 = "";
                for (int idx = 0; idx < 4; idx++)
                {
                    if (guess[idx] == final[idx])
                    {
                        output_1 += "+";
                        output_2 += " ";
                    }
                    else if (final.Contains(guess[idx]))
                    {
                        output_1 += " ";
                        output_2 += "-";
                    }
                    else
                    {
                        output_1 += " ";
                        output_2 += " ";
                    }
                }
                i = index;
                Console.WriteLine(output_1);
                Console.WriteLine(output_2);
                if (output_1 == "++++")
                {
                    win = true;
                    break;
                }

            }
            if (win)
            {
                Console.WriteLine("Congratulations.");
            }
            else if (!win)
            {

                Console.WriteLine("You Lost.");
            }

            Console.ReadKey();
        }
    }
}
