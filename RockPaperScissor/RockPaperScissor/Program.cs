using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROCKPAPERSCISSORS
{
    class RPS
    {
        static void Main(string[] args)
        {
            string playerInput, computerInput;
            int randomInt;

            bool playAgain = true;

            while (playAgain)
            {

                int playerScore = 0;
                int computerScore = 0;

                while (playerScore < 3 && computerScore < 3)
                {


                    Console.Write("Choose between ROCK, PAPER and SCISSORS:  ");
                    playerInput = Console.ReadLine();
                    playerInput = playerInput.ToUpper();

                    Random rnd = new Random();

                    randomInt = rnd.Next(1, 4);

                    switch (randomInt)
                    {
                        case 1:
                            computerInput = "ROCK";
                            Console.WriteLine("Computer chose ROCK");
                            if (playerInput == "ROCK")
                            {
                                Console.WriteLine("DRAW");
                            }
                            else if (playerInput == "PAPER")
                            {
                                Console.WriteLine("PLAYER WINS");
                                playerScore++;
                            }
                            else if (playerInput == "SCISSORS")
                            {
                                Console.WriteLine("Computer WINS");
                                computerScore++;
                            }
                            break;
                        case 2:
                            computerInput = "PAPER";
                            Console.WriteLine("Computer chose PAPER");
                            if (playerInput == "PAPER")
                            {
                                Console.WriteLine("DRAW");
                            }
                            else if (playerInput == "ROCK")
                            {
                                Console.WriteLine("Computer WINS");
                                computerScore++;
                            }
                            else if (playerInput == "SCISSORS")
                            {
                                Console.WriteLine("PLAYER WINS");
                                playerScore++;
                            }
                            break;
                        case 3:
                            computerInput = "SCISSORS";
                            Console.WriteLine("Computer chose SCISSORS");
                            if (playerInput == "SCISSORS")
                            {
                                Console.WriteLine("DRAW");
                            }
                            else if (playerInput == "ROCK")
                            {
                                Console.WriteLine("PLAYER WINS");
                                playerScore++;
                            }
                            else if (playerInput == "PAPER")
                            {
                                Console.WriteLine("Computer WINS");
                                computerScore++;
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid entry");
                            break;
                    }

                }

                if (playerScore == 3)
                {
                    Console.WriteLine("Player WON!");
                }
                else if (computerScore == 3)
                {
                    Console.WriteLine("Computer WON!");
                }
                else
                {

                }

                Console.WriteLine("Do you want to play again? (y/n)");
                string loop = Console.ReadLine();
                if (loop == "y")
                {
                    playAgain = true;
                    Console.Clear();
                }
                else if (loop == "n")
                {
                    playAgain = false;
                }
                else
                {

                }

            }
        }
    }
}