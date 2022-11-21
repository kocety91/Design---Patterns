using InvestorStocks.SubjectModels;

namespace InvestorStocks.ObserverModels
{
    public class Investor : IInvestor
    {
        public Investor(string name)
        {
            Name = name;
        }
        public string Name { get; init; }


        public void Update(Stock stock)
        {
            Console.WriteLine($"{Name} -- {stock.Symbol} - ${stock.Price}");
        }
    }
}
