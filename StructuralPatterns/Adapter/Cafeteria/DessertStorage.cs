using Cafeteria.Models;

namespace Cafeteria
{
    public class DessertStorage
    {
        private List<Dessert> _desserts;

        public DessertStorage()
        {
            _desserts = new List<Dessert>()
            {
                new Dessert("Cake",30.50M,2),
                new Dessert("Donut",30.50M,2)
            };
        }

        public List<Dessert> GetDesserts() => _desserts;
    }
}
