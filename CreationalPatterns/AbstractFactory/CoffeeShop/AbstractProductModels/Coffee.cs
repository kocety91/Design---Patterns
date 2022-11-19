namespace CoffeeShop.AbstractProductModels
{
    public abstract class Coffee
    {
        public abstract string Name { get; }

        public abstract int CoffeeContent { get; }

        public abstract int MilkContent { get; }

        public void Print()
        {
            
            Console.WriteLine($"{this.Name} contains {this.CoffeeContent} ml coffee and {this.MilkContent} ml milk");
        }
    }
}
