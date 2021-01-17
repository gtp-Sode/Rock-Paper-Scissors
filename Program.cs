using System;
using System.Collections;
using System.Collections.Generic;

namespace RockPapperScissorsNew
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is V2 of my rock, papper, scissors game!");

            List<string> Actions = new List<string>();
            Actions.Add("Rock");
            Actions.Add("Papper");
            Actions.Add("Scissors");
            Actions.Add("EXIT");


            Random rnd = new Random();


            int Points = 0;

            bool GameLoop = true;
            while (GameLoop)
            {
                bool getInput = true;
                string UserInput = "";
                while (getInput)
                {
                    Console.Write("Rock, Papper, Scissors: ");
                    UserInput = Console.ReadLine();

                    if (Actions.Contains(UserInput))
                    {
                        getInput = false;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect input! ");
                    }
                }

                string BotInput = Actions[rnd.Next(0, 2)];

                Console.WriteLine("Bot: {0}", BotInput);

                switch (BotInput, UserInput)
                {

                    case ("Rock", "Rock"):
                    case ("Papper", "Papper"):
                    case ("Scissors", "Scissors"):
                        Console.WriteLine("Tie!\n");
                        break;

                    case ("Rock", "Scissors"):
                    case ("Papper", "Rock"):
                    case ("Scissors", "Papper"):
                        Console.WriteLine("Bot winns! \n");
                        Points -= 1;
                        break;

                    case ("Rock", "Papper"):
                    case ("Papper", "Scissors"):
                    case ("Scissors", "Rock"):
                        Console.WriteLine("You win!\n");
                        Points += 1;
                        break;

                    default:
                        Console.WriteLine("Error... \n");
                        break;

                }

                if (UserInput == "EXIT")
                {
                    GameLoop = false;
                }


            }


            Console.WriteLine("Your points: {0}", Points);
        }
    }
}
