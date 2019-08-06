using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorsLizardSpock
{
    class Game  
    {
        Player player1;
        Player player2;
        string gestureOne;
        string gestureTwo;
        string[] gestures = { "1. Rock", "2. Paper", "3. Scissors", "4. Lizard", "5. Spock" };
        int gameMode = 0;

        public void runGame() //Main Game
        {   
            Console.WriteLine("Welcome to Rock Papers Scissors Lizard Spock!");
            selectGameType();
            
            if (gameMode == 1)
            {
                enterNames();
                enterGestures();
            }
            else if (gameMode == 2)
            {
                enterNames();
                enterGestures();
            }
            else if (gameMode == 3)
            {
                enterNames();
                enterGestures();
            }
            else
            {
                Console.WriteLine("That is not a valid option.");
                runGame();
            }
            return;
        }
        public void enterGestures()
        {
            int n = 0;
            int m = 0;
            Console.WriteLine("Please select your move");

            foreach (string gesture in gestures)
            {
                Console.WriteLine(gesture.ToString());
            }

            while (player1.GetWins() < 3 && player2.GetWins() < 3)
            {
                if (gameMode == 1) //Human vs AI
                {
                    try
                    {
                        Console.WriteLine(player1.GetName() + "'s turn:");
                        n = int.Parse(Console.ReadLine());
                        Console.WriteLine(player1.GetName() + " chose " + gestures[n - 1]);
                        Random botChoice = new Random();
                        m = botChoice.Next(1, 5);
                        Console.WriteLine(player2.GetName() + " chose " + gestures[m - 1]);
                        compareGestures(n, m);
                    }
                    catch { };
                }
                else if (gameMode == 2)// Human Vs Human
                {
                    try
                    {
                        Console.WriteLine(player1.GetName() + "'s turn:");
                        n = int.Parse(Console.ReadLine());
                        Console.WriteLine(player1.GetName() + " chose " + gestures[n - 1]);
                        Console.WriteLine(player2.GetName() + "'s turn:");
                        m = int.Parse(Console.ReadLine());
                        Console.WriteLine(player2.GetName() + " chose " + gestures[m - 1]);
                        compareGestures(n, m);
                    }
                    catch { };
                }
                else //AI vs AI
                {
                    Random botChoice = new Random();
                    n = botChoice.Next(1, 5);
                    m = botChoice.Next(1, 5);
                    Console.WriteLine(player1.GetName() + " chose " + gestures[n - 1]);
                    Console.WriteLine(player2.GetName() + " chose " + gestures[m - 1]);
                    compareGestures(n, m);
                }
               
            }
            if (player1.GetWins() == 3)
            {
                Console.WriteLine(player1.name + " wins the game!");
            }else if (player2.GetWins() == 3)
            {
                Console.WriteLine(player2.GetName() + " wins the game!");
            }
        }
        public void selectGameType()
        {
            Console.WriteLine("Would you like to play against an AI, or another player? 1 for AI, 2 for another player, or 3 to pit AI against AI.");
            try
            {
                gameMode = int.Parse(Console.ReadLine());
            }
            catch { }
        }
        public void enterNames()
        {
            
            if (gameMode == 1)
            {
                Console.WriteLine("Please enter your name:");
                player1 = new Human(Console.ReadLine());
                player2 = new AI("Gertrude");
            }else if (gameMode == 2)
            {
                Console.WriteLine("Please enter your name:");
                player1 = new Human(Console.ReadLine());
                Console.WriteLine("Please enter your opponent's name:");
                player2 = new Human(Console.ReadLine());
            }else if (gameMode == 3)
            {
                player1 = new AI("Gertrude");
                player2 = new AI("Blase");
            }
            
            Console.WriteLine("PLayer 1's name is " + player1.GetName());
            Console.WriteLine("Player 2's name is " + player2.GetName());
        }
        public void compareGestures(int n, int m)
        {
            if ((n <= 5 && n > 0) && (m <= 5 && m > 0))
            {
                gestureOne = gestures[n - 1];
                gestureTwo = gestures[m - 1];

                if(n == 1)
                {
                    if (m == 3)
                    {
                        player1.addWin();
                    }else if (m == 2)
                    {
                        player2.addWin();
                    }else if (m == 4)
                    {
                        player1.addWin();
                    }else if (m == 5)
                    {
                        player2.addWin();
                    }
                    
                }else if (n == 2)
                {
                    if (m == 1)
                    {
                        player1.addWin();
                    }else if (m == 3)
                    {
                        player2.addWin();
                    }else if (m == 4)
                    {
                        player2.addWin();
                    }else if (m == 5)
                    {
                        player1.addWin();
                    }
                }else if (n == 3)
                {
                    if (m == 1)
                    {
                        player2.addWin();
                    }else if (m == 2)
                    {
                        player1.addWin();
                    }else if (m == 4)
                    {
                        player1.addWin();
                    }else if (m == 5)
                    {
                        player2.addWin();
                    }
                }else if (n == 4)
                {
                    if (m == 1)
                    {
                        player2.addWin();
                    }else if (m == 2)
                    {
                        player1.addWin();
                    }else if (m == 3)
                    {
                        player2.addWin();
                    }else if (m == 5)
                    {
                        player1.addWin();
                    }
                }else if (n == 5)
                {
                    if (m == 1)
                    {
                        player1.addWin();
                    }else if (m == 2)
                    {
                        player2.addWin();
                    }else if (m == 3)
                    {
                        player1.addWin();
                    }else if (m == 4)
                    {
                        player2.addWin();
                    }
                }
            }
            else
            {
                Console.WriteLine("One of the inputs was not valid. Try again.");
                enterGestures();
            }
        }
    }
}
