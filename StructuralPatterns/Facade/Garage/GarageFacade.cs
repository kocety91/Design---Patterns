using Garage.Models;

namespace Garage
{
    public class GarageFacade
    {
        private readonly CarModel _carmodel;
        private readonly CarBody _carbody;
        private readonly CarEngine _carEngine;
        private readonly CarAccessories _caraccessories;

        public GarageFacade()
        {
            _carmodel = new CarModel();
            _carbody = new CarBody();
            _carEngine = new CarEngine();
            _caraccessories = new CarAccessories();
        }

        public void CreateCar()
        {
            Console.WriteLine(" * *******Creating a Car * *********\n");
            _carmodel.SetModel();
            _carbody.SetBody();
            _carEngine.SetEngine();
            _caraccessories.SetAccessories();
            Console.WriteLine("\n******** Car creation complete **********");
        }
    }
}
