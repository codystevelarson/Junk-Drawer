using System;

namespace BattleShip.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WindowWidth = 60;
            Console.WindowHeight = 40;
            GameWorkflow game = new GameWorkflow();
            game.Game();
                      
        }
    }
}
