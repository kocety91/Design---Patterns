
using InvestorStocks.ObserverModels;
using InvestorStocks.SubjectModels;

Stock ibm = new IBM(155.20M, "SomeSymbol");
IInvestor investor = new Investor("Conko");
IInvestor investor2 = new Investor("Conko2");
ibm.Attach(investor);
ibm.Attach(investor2);

ibm.Price = 222.22M;

Console.WriteLine();
ibm.Dettach(investor2);
ibm.Price = 189.99M;
