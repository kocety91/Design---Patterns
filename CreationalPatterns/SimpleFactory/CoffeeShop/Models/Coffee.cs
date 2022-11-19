namespace CoffeeShop.Models
{
    public abstract class Coffee
    {
        public abstract string Name { get; }

        public abstract int CoffeeContent { get;}

        public abstract int MilkContent { get;}
    }
}
