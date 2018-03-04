using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MageHoarder.BLL.Potions
{
    public abstract class Potion : Item
    {
        public Potion(string name, int size)
            : base(name, size, ItemType.Potion)
        {

        }

        public bool Drink(Potion potion)
        {
            return true;
        }

        public abstract void PotionEffect(Potion potion);
        
    }
}
