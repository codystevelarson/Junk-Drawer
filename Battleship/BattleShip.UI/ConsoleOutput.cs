using BattleShip.BLL.GameLogic;
using BattleShip.BLL.Requests;
using BattleShip.BLL.Responses;
using BattleShip.BLL.Ships;
using System;

namespace BattleShip.UI
{
    public static class ConsoleOutput
    {     
        public static void SplashScreen()
        {
            //Clear screen if playing again
            Console.Clear();
            // NAME ART MAKE THIS BETTER LOOKING!
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" ======================+[BATTLESHIP]+====================== ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("|                                                          |");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("|  BATTLE BATTLE BATTLE BATTLE BATTLE BATTLE BATTLE BATTLE |");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("|  SHIP SHIP SHIP SHIP SHIP SHIP SHIP SHIP SHIP SHIP SHIP  |");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("|  BATTLE BATTLE BATTLE BATTLE BATTLE BATTLE BATTLE BATTLE |");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("|  SHIP SHIP SHIP SHIP SHIP SHIP SHIP SHIP SHIP SHIP SHIP  |");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("|  BATTLE BATTLE BATTLE BATTLE BATTLE BATTLE BATTLE BATTLE |");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("|  SHIP SHIP SHIP SHIP SHIP SHIP SHIP SHIP SHIP SHIP SHIP  |");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("|  BATTLE BATTLE BATTLE BATTLE BATTLE BATTLE BATTLE BATTLE |");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("|  SHIP SHIP SHIP SHIP SHIP SHIP SHIP SHIP SHIP SHIP SHIP  |");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("|  BATTLE BATTLE BATTLE BATTLE BATTLE BATTLE BATTLE BATTLE |");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("|  SHIP SHIP SHIP SHIP SHIP SHIP SHIP SHIP SHIP SHIP SHIP  |");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("|  BATTLE BATTLE BATTLE BATTLE BATTLE BATTLE BATTLE BATTLE |");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("|  SHIP SHIP SHIP SHIP SHIP SHIP SHIP SHIP SHIP SHIP SHIP  |");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("|  BATTLE BATTLE BATTLE BATTLE BATTLE BATTLE BATTLE BATTLE |");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("|  SHIP SHIP SHIP SHIP SHIP SHIP SHIP SHIP SHIP SHIP SHIP  |");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("|  BATTLE BATTLE BATTLE BATTLE BATTLE BATTLE BATTLE BATTLE |");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("|  SHIP SHIP SHIP SHIP SHIP SHIP SHIP SHIP SHIP SHIP SHIP  |");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("|  BATTLE BATTLE BATTLE BATTLE BATTLE BATTLE BATTLE BATTLE |");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("|  SHIP SHIP SHIP SHIP SHIP SHIP SHIP SHIP SHIP SHIP SHIP  |");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("|  BATTLE BATTLE BATTLE BATTLE BATTLE BATTLE BATTLE BATTLE |");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("|  SHIP SHIP SHIP SHIP SHIP SHIP SHIP SHIP SHIP SHIP SHIP  |");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("|  BATTLE BATTLE BATTLE BATTLE BATTLE BATTLE BATTLE BATTLE |");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("|  SHIP SHIP SHIP SHIP SHIP SHIP SHIP SHIP SHIP SHIP SHIP  |");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("|  BATTLE BATTLE BATTLE BATTLE BATTLE BATTLE BATTLE BATTLE |");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("|  SHIP SHIP SHIP SHIP SHIP SHIP SHIP SHIP SHIP SHIP SHIP  |");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("|  BATTLE BATTLE BATTLE BATTLE BATTLE BATTLE BATTLE BATTLE |");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("|  SHIP SHIP SHIP SHIP SHIP SHIP SHIP SHIP SHIP SHIP SHIP  |");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("|  BATTLE BATTLE BATTLE BATTLE BATTLE BATTLE BATTLE BATTLE |");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("|  SHIP SHIP SHIP SHIP SHIP SHIP SHIP SHIP SHIP SHIP SHIP  |");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("|  BATTLE BATTLE BATTLE BATTLE BATTLE BATTLE BATTLE BATTLE |");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("|  SHIP SHIP SHIP SHIP SHIP SHIP SHIP SHIP SHIP SHIP SHIP  |");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("|  BATTLE BATTLE BATTLE BATTLE BATTLE BATTLE BATTLE BATTLE |");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("|  SHIP SHIP SHIP SHIP SHIP SHIP SHIP SHIP SHIP SHIP SHIP  |");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("|  BATTLE BATTLE BATTLE BATTLE BATTLE BATTLE BATTLE BATTLE |");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("|  SHIP SHIP SHIP SHIP SHIP SHIP SHIP SHIP SHIP SHIP SHIP  |");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("|                                                          |");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("|  Press any key..                                         |");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" ======================+[BATTLESHIP]+====================== ");
            Console.ForegroundColor = ConsoleColor.Black;


            //"Press any key"
            Console.ReadKey();
            Console.Clear();
        }
   
        public static void DisplayGameBoard(Board b)
        {                    
            Console.WriteLine("        1    2    3    4    5    6    7    8    9    10");
            Console.WriteLine("      __|____|____|____|____|____|____|____|____|____|__");

            for (int i = 1; i <= 10; i++)
            {
                char[] alphaY = new char[] {'A','B','C','D','E','F','G','H','I','J'};
                Console.Write($" {alphaY[i-1]}___|");
                
                for (int j = 1; j <= 10; j++)
                {
                    Coordinate c = new Coordinate(i, j);

                    if (b.CheckCoordinate(c) == BLL.Responses.ShotHistory.Hit)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("  H  ");
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    else if (b.CheckCoordinate(c) == BLL.Responses.ShotHistory.Miss)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("  M  ");
                        Console.ForegroundColor = ConsoleColor.Black;

                    }
                    else if (b.CheckCoordinate(c) == BLL.Responses.ShotHistory.Unknown)
                        Console.Write("  .  ");

                    if (i == 10 && j == 10)
                    {
                        Console.WriteLine("|");
                        Console.WriteLine("     |__________________________________________________|");

                    }
                    else if(j == 10 && i!= 10)
                    {
                        Console.WriteLine("|");
                        Console.Write("     |                                                  |");

                    }
                }
                if (i != 10)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }

        public static bool EndGameMessage(bool p1Win, bool p2Win, string p1, string p2)
        {
            bool play = false;
            bool yORn = false;
            while (!yORn)
            {
                if (p1Win == true)
                {
                    Console.Write($"{p2}, would you like a rematch with {p1}? (Y/N): ");
                }
                else
                {
                    Console.Write($"{p1}, would you like a rematch with {p2}? (Y/N): ");
                }

                string playAgain = Console.ReadLine().ToLower();
                if (playAgain == "n" || playAgain == "no")
                {
                    yORn = true;
                }

                if (playAgain == "y" || playAgain == "yes")
                {
                    play = true;
                    yORn = true;
                }
            }

             
                return play;
            
        }

        public static void ShotMessage(FireShotResponse response, string name1, string name2, Player player, Coordinate coord)
        {
            //DISPLAY CORRECT SHOT MESSAGES
            switch (response.ShotStatus)
            {              
                case ShotStatus.Invalid:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("NOT A VALID DIRECTION!!!");
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case ShotStatus.Duplicate:
                    Console.WriteLine($"Ehrm..{name1}... you've already shot there.");
                    break;
                case ShotStatus.Miss:
                    Console.WriteLine($"Nice try {name1}! You missed, but still, nice try!");
                    break;
                case ShotStatus.Hit:
                    Console.WriteLine($"Exccelent shot {name1}! You hit {name2}'s {response.ShipImpacted}");
                    break;
                case ShotStatus.HitAndSunk:
                    
                    if (response.ShipImpacted == ShipType.Battleship.ToString() )
                    {
                        Console.WriteLine($"\"You sunk my {response.ShipImpacted}!\" -{name2} {DateTime.Now}");
                    }
                    else
                    {
                        Console.WriteLine($"Exccelent shot {name1}! You SUNK {name2}'s {response.ShipImpacted}!");
                        Console.WriteLine($"A moment of silence for {name2}'s valient sailors");
                        Console.WriteLine($"of the S.S. {name2} {response.ShipImpacted}..");
                        Console.ReadKey();
                    }                   
                    break;
                case ShotStatus.Victory:
                    Console.Clear();
                    Console.WriteLine($"{name1}! YOU DESTROYED {name2.ToUpper()}'S ENTIRE FLEET!!");
                    Console.WriteLine();
                    Console.WriteLine($"{name1}, I would follow thee across the stars 100 times!");
                    Console.WriteLine("..and back again, twice as many!!");
                    break;
            }
            //ShotHistory validCheck = player.PlayerGameBoard.CheckCoordinate(coord);
            if (response.ShotStatus != ShotStatus.Duplicate && response.ShotStatus != ShotStatus.Victory && response.ShotStatus != ShotStatus.Invalid)
            {
                Console.WriteLine($"Is {name2} ready to give the orders?");
            }
            Console.ReadKey();
            Console.Clear();

        }

        public static void Player1Turn(string name)
        {
            Console.WriteLine($"Admiral {name}! Where shall we take aim?");
        }

        public static void Player2Turn(string name)
        {
            Console.WriteLine($"Mad Eye {name}, let's blast 'em tah bits!");
        }

        public static void ShipKey()
        {
            Console.WriteLine("|======================+[BATTLESHIP]+======================|");
            Console.WriteLine("|-------| Destroyer(2) | Cruiser(3) | Submarine(3) |-------|");
            Console.WriteLine("|--------------| Battleship(4) | Carrier(5) |--------------|");
            Console.WriteLine("|==========================================================|");
        }

        public static void WaveBorder(int player)
        {
            Console.WriteLine("|======================+[BATTLESHIP]+======================|");
            Console.WriteLine("|~ ~~~ ~~ ~~~~ ~ ~~  ~~ ~~ ~~ ~ ~~~ ~~~ ~~~ ~~ ~~ ~~~ ~ ~~ |");
            Console.WriteLine($"| ~~ ~~ ~~~~ ~ ~~ ~~~ ~ ~(Player {player})~~~ ~ ~~ ~ ~~ ~~ ~~~ ~~ |");
            Console.WriteLine("|~~ ~ ~~~ ~ ~~ ~~~ ~ ~~~ ~ ~~ ~~~~ ~ ~~~ ~ ~~ ~~~~ ~ ~~~ ~~|");
            Console.WriteLine("|==========================================================|");
        }

        public static void Credits()
        {
            Console.Clear();
            Console.WriteLine("Cody made this game.");
            Console.WriteLine("Would you like to leave him a message?");
            Console.ReadLine();
            Console.WriteLine("Im sure he would have love to hear that from you");
            Console.WriteLine();
            Console.WriteLine("Press any key to quit...");
            Console.ReadKey();
        }
    }
}
