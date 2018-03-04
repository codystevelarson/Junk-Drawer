namespace MageHoarder.BLL.Containers
{
    public class Backpack : Container
    {
        private Item[] items;
        private int currentIndex = 0;
        private int currentWeight = 0;

        public Backpack(string name, int size, int capacity) 
            : base(name, size, capacity)
        {
            items = new Item[capacity];
        }

        public bool Add(Item item)
        {
            bool success = false;
            if(item.Size + currentWeight <= Capacity)
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
