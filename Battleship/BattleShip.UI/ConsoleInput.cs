using BattleShip.BLL.GameLogic;
using BattleShip.BLL.Requests;
using BattleShip.BLL.Responses;
using BattleShip.BLL.Ships;
using System;

namespace BattleShip.UI
{
    public static class ConsoleInput
    {
        //Get Player name
        public static string EnterName(int playerNumber)
        {
            string name = "";
            Console.Write($"Player {playerNumber}, Enter your name: ");
            name = Console.ReadLine();
            if (name == "")
            {
                Console.Clear();
                Console.WriteLine("Please enter a name.");
                EnterName(playerNumber);
            }
            Console.Clear();
            return name;
        }

        //Get direction from input
        public static ShipDirection GetPlayerDirection()
        {
            ShipDirection direction = ShipDirection.Down;
            bool isValid = false;
            string input = "";

            //loop until valid input
            while (!isValid)
            {
                //Get input
                Console.Write("Enter a direction (Up, Down, Left, Right): ");
                input = Console.ReadLine().ToLower();

                //set direction
                switch (input)
                {
                    case "up":
                        direction = ShipDirection.Up;
                        isValid = true;
                        break;
                    case "down":
                        direction = ShipDirection.Down;
                        isValid = true;
                        break;
                    case "left":
                        direction = ShipDirection.Left;
                        isValid = true;
                        break;
                    case "right":
                        direction = ShipDirection.Right;
                        isValid = true;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please Enter a valid direction.");
                        Console.ForegroundColor = ConsoleColor.Black;
                        break;
                }
            }
            return direction;
        }

        //Creat a coordinate object from input
        public static Coordinate GetPlayerCoordinate()
        {
            Coordinate playerCoordinate;
            int x = int.MinValue;
            int y = int.MinValue;
            bool validInput = false;

            do
            {
                string userInput = "";
                //get user input
                Console.Write("Enter a coordinate (ex. A1 - J10): ");
                userInput = Console.ReadLine().ToLower();

                //validate input length
                if (userInput.Length < 2 && userInput.Length > 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Not a valid coordinate");
                    Console.ForegroundColor = ConsoleColor.Black;

                }
                else
                {
                    //seperate first and second coords
                    string first = userInput.Substring(0, 1);
                    string second = userInput.Substring(1, userInput.Length - 1);

                    //turn first and second into ints
                    int xCoord = first[0] - 'a' + 1;
                    int yCoord;

                    // if y coord is not an int and try parse fails, 
                    // OR x coord is not between 1-10 
                    // prompt and loop back to enter coord
                    if (!int.TryParse(second, out yCoord) || xCoord < 1 || xCoord > 10)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Could not find second coordinate");
                        Console.ForegroundColor = ConsoleColor.Black;

                    }
                    else
                    {
                        int.TryParse(second, out yCoord);
                        x = xCoord;
                        y = yCoord;
                        validInput = true;
                    }                    
                }               
            } while (!validInput);

            playerCoordinate = new Coordinate(x, y);
            return playerCoordinate;
        }

        //Place ships on board via player input
        public static Board PlaceShipLoop(string name)
        {
            Board playerBoard = new Board();

            for (ShipType s = ShipType.Destroyer; s <= ShipType.Carrier; s++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{name}, place {s} on your board:");
                Console.ForegroundColor = ConsoleColor.Black;
                PlaceShipRequest ship = new PlaceShipRequest();
                ship.Coordinate = GetPlayerCoordinate();
                ship.Direction = GetPlayerDirection();
                ship.ShipType = s;

                ShipPlacement result = playerBoard.PlaceShip(ship);

                if (result != ShipPlacement.Ok)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid ship placement.");
                    Console.ForegroundColor = ConsoleColor.Black;
                    s--;
                }               
            }
            return playerBoard;
        }
    }
}
