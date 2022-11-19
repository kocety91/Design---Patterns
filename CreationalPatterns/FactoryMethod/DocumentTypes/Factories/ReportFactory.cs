using DocumentTypes.Models;

namespace DocumentTypes.Factories
{
    public class ReportFactory : DocumentFactory
    {
        public override void CreatePages()
        {
            base.Pages.Add(new ResultsPage());
            base.Pages.Add(new SummaryPage());
        }
    }
}
