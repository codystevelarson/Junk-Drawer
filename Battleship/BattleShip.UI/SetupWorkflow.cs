using BattleShip.BLL.GameLogic;

namespace BattleShip.UI
{
    public static class SetupWorkflow
    {

        public static Player GetPlayer(int playerNumber)
        {

            Player player = new Player(ConsoleInput.EnterName(playerNumber));
            Board blank = new Board();
            ConsoleOutput.DisplayGameBoard(blank);
            ConsoleOutput.ShipKey();

            player.PlayerGameBoard = ConsoleInput.PlaceShipLoop(player.Name);
            return player;
        }
    }    
}
