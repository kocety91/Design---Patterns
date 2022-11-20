using Cafeteria.Models;

namespace Cafeteria
{
    public class DessertAddapter : IDessertAddapter
    {
        private DessertStorage _dessertStorage;
        public DessertAddapter()
        {
            _dessertStorage = new DessertStorage();
        }

        public IList<DessertInfo> GetDessertInfos()
        {
            var dessertInfos = new List<DessertInfo>();

            foreach (var dessert in _dessertStorage.GetDesserts())
            {
                dessertInfos.Add(new DessertInfo { Name = dessert.Name,Price = dessert.Price});
            }

            return dessertInfos;
        }
    }
}
