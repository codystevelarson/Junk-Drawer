using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MageHoarder.BLL.Weapons
{
    public abstract class Weapon : Item
    {
        public int Damage { get; set; }
        
        public Weapon(string name, int size, int damage)
            : base(name, size, ItemType.Weapon)
        {
            Damage = damage;
        }
    }
}
