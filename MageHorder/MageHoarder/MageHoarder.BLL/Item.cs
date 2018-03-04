namespace MageHoarder.BLL
{
    public abstract class Item
    {
        public string Name { get; set; }
        public int Size { get; set; }
        public ItemType TypeOfItem { get; set; }

        public Item(string name, int size, ItemType typeOfItem)
        {
            Name = name;
            Size = size;
            TypeOfItem = typeOfItem;
        }
    }
}
