using BattleShip.BLL.GameLogic;
using BattleShip.BLL.Requests;
using BattleShip.BLL.Responses;
using System;

namespace BattleShip.UI
{
    class GameWorkflow
    {
        Random rng = new Random();

        public void Game()
        {
            ConsoleOutput.SplashScreen();

            Player P1 = SetupWorkflow.GetPlayer(1);
            Console.Clear();
            Player P2 = SetupWorkflow.GetPlayer(2);
            Console.Clear();

            PlayerTurns(P1, P2, WhoIsGoingFirst());
        }

        public int WhoIsGoingFirst()
        {
            int player = rng.Next(1, 3);

            return player;
        }

        public static void PlayerTurns(Player P1, Player P2, int firstTurn)
        {
            bool player1Victory = false;
            bool player2Victory = false;
            bool victory = false;


            int whoseTurn = firstTurn;
            while (!victory)
            {
                
                if (whoseTurn == 1)
                {
                    //player 1 turn
                    //Display p2 board
                    

                    //Fire shot
                    bool validShot = false;
                    while (!validShot)
                    {
                        ConsoleOutput.DisplayGameBoard(P2.PlayerGameBoard);
                        ConsoleOutput.WaveBorder(1);
                        ConsoleOutput.Player1Turn(P1.Name);
                        Coordinate c = ConsoleInput.GetPlayerCoordinate();

                        FireShotResponse response = P2.PlayerGameBoard.FireShot(c);
                        Console.Clear();
                        
                        ConsoleOutput.DisplayGameBoard(P2.PlayerGameBoard);
                        ConsoleOutput.WaveBorder(1);
                        if (response.ShotStatus != ShotStatus.Duplicate && response.ShotStatus != ShotStatus.Invalid)
                        {
                            validShot = true;
                            whoseTurn = 2;
                        }
                        if (response.ShotStatus == ShotStatus.Victory)
                        {
                            validShot = true;
                            victory = true;
                            player1Victory = true;
                        }
                        ConsoleOutput.ShotMessage(response, P1.Name, P2.Name, P2, c);
                    }


                }
                else
                {
                    //player 2 turn
                    //Display p1 board
                    

                    //Fire Shot
                    bool validShot = false;
                    while (!validShot)
                    {
                        ConsoleOutput.DisplayGameBoard(P1.PlayerGameBoard);
                        ConsoleOutput.WaveBorder(2);
                        ConsoleOutput.Player2Turn(P2.Name);
                        Coordinate c = ConsoleInput.GetPlayerCoordinate();

                        FireShotResponse response = P1.PlayerGameBoard.FireShot(c);
                        Console.Clear();

                        ConsoleOutput.DisplayGameBoard(P1.PlayerGameBoard);
                        ConsoleOutput.WaveBorder(2);

                        if (response.ShotStatus != ShotStatus.Duplicate && response.ShotStatus != ShotStatus.Invalid)
                        {
                            validShot = true;
                            whoseTurn = 1;
                        }
                        if (response.ShotStatus == ShotStatus.Victory)
                        {
                            validShot = true;
                            victory = true;
                            player2Victory = true;
                        }
                        ConsoleOutput.ShotMessage(response, P2.Name, P1.Name, P1, c);                       
                    }

                }
            }
            bool playAgain = false;
            playAgain = ConsoleOutput.EndGameMessage(player1Victory, player2Victory, P1.Name, P2.Name);

            if (playAgain)
            {
                //Create new game boards and go through the turns again
                Console.Clear();
                Board blank = new Board();
                ConsoleOutput.DisplayGameBoard(blank);
                ConsoleOutput.ShipKey();
                P1.PlayerGameBoard = ConsoleInput.PlaceShipLoop(P1.Name);

                Console.Clear();
                ConsoleOutput.DisplayGameBoard(blank);
                ConsoleOutput.ShipKey();
                P2.PlayerGameBoard = ConsoleInput.PlaceShipLoop(P2.Name);
                Console.Clear();
                GameWorkflow turn = new GameWorkflow();
                int ft = turn.WhoIsGoingFirst();
                PlayerTurns(P1, P2, ft);
            }

            ConsoleOutput.Credits();
        }
    }
}
