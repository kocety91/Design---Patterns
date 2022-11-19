using DocumentTypes.Models;

namespace DocumentTypes.Factories
{
    public class CVFactory : DocumentFactory
    {
        public override void CreatePages()
        {
            base.Pages.Add(new BioPage());
            base.Pages.Add(new SkillsPage());
        }
    }
}
