namespace Cafeteria
{
    public class CoffeeShop
    {
        private IDessertAddapter _adapter;
        public CoffeeShop()
        {
            _adapter = new DessertAddapter();
        }

        public void DisplayDesserts()
        {
           var desserts =  _adapter.GetDessertInfos();
            foreach (var dessert in desserts)
            {
                Console.WriteLine(dessert.Name + " " + dessert.Price);
            }
        }
    }
}
