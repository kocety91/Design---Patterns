namespace CoffeeShop.Models
{
    public class Macchiato : Coffee
    {
        public override string Name => "Macchiato";
        public override int CoffeeContent => 100;
        public override int MilkContent => 100;
    }
}
