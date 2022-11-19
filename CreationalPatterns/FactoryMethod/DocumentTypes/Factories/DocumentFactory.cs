using DocumentTypes.Models;

namespace DocumentTypes.Factories
{
    public abstract class DocumentFactory
    {
        public DocumentFactory()
        {
            Pages = new List<Page>();
            CreatePages();
        }

        public List<Page> Pages { get; set; }

        public abstract void CreatePages();
    }
}
