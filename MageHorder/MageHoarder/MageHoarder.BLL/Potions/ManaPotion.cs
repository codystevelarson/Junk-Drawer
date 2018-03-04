using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MageHoarder.BLL.Potions
{
    public class ManaPotion : Potion
    {
        public ManaPotion(string name, int size)
            : base(name, size)
        {

        }

        public override void PotionEffect(Potion potion)
        {
            //int mana = 5;
            //mana += mana; 
        }
    }
}
