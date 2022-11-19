using DocumentTypes.Factories;

DocumentFactory[] documents = new DocumentFactory[2];
documents[0] = new CVFactory();
documents[1] = new ReportFactory();

foreach (var document in documents)
{
    Console.WriteLine("\n" + document.GetType().Name + "--");

    foreach (var page in document.Pages)
    {
        Console.WriteLine(" " + page.GetType().Name);
    }
}