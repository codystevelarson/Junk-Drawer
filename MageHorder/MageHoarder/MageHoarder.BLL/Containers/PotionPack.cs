using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MageHoarder.BLL.Potions;

namespace MageHoarder.BLL.Containers
{
    public class PotionPack : Container
    {
        private Item[] items;
        private int currentIndex = 0;
        private int currentWeight = 0;

        public PotionPack(string name, int size, int capacity)
            : base(name, size, capacity)
        {
            items = new Item[capacity];
        }

        public bool Add(Potion item)
        {
            bool success = false;
            if (item.Size + currentWeight <= Capacity)
            {
                items[currentIndex] = item;
                currentIndex++;
                currentWeight += item.Size;
                success = true;

            }
            return success;
        }
    }
}
