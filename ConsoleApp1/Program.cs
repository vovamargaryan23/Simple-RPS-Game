using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] answers = { "stone", "paper", "scissors" };
            Console.Write("Enter Stone, Paper or Scissors: ");
            string input = Console.ReadLine();
            string user = input.ToLower();
            Random rnd = new Random();
            int a = rnd.Next(answers.Length);
            if (user == answers[0] || user == answers[1] || user == answers[2])
            {
                if(user == answers[a])
                {
                    Console.WriteLine("The Answer was the same try again");
                }
                else
                {
                    if ((user == "stone" && answers[a] == "scissors") || (user == "paper" && answers[a] == "stone") || (user == "scissors" && answers[a] == "paper"))
                    {
                        Console.WriteLine($"The answer of computer is {answers[a]}");
                        Console.WriteLine("User Won");
                    }
                    else
                    {
                        Console.WriteLine($"The answer of computer is {answers[a]}");
                        Console.WriteLine("Computer Won");
                    }
                }
            }
            else
            {
                Console.WriteLine("Enter Valid Answer");
            }

        }

    }
}
