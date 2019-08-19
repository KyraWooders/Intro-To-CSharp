using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //output text
            Console.WriteLine("Hello. What is your name?");

            int playerScore = 0;
            string playerName = "";

            playerName = Console.ReadLine();

            int add = 0;

            while (playerScore < 10)
            {
                //request input
                Console.Write("Increment score: ");
                add = Convert.ToInt32(Console.ReadLine());
                //add score
                playerScore = playerScore + add;
                Console.Write("Current score: ");
                Console.WriteLine(playerScore);
            }

            Console.WriteLine("Score of " + playerName);
            Console.WriteLine(playerScore);

            //wait for user to press enter
            Console.ReadLine();
        }
    }
}
