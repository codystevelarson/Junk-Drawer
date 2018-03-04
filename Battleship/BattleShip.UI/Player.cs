using BattleShip.BLL.GameLogic;

namespace BattleShip.UI
{
    public class Player
    {       
        public string Name { get; set; }
        public Board PlayerGameBoard { get; set; }

        public Player(string name)
        {
            Name = name;
        }
    }
}
