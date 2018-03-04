namespace MageHoarder.BLL.Containers
{
    public abstract class Container : Item
    {
        public int Capacity { get; set; }

        public Container(string name, int size, int capacity) 
            : base(name, size, ItemType.Container)
        {
            Capacity = capacity;
        }
    }
}
