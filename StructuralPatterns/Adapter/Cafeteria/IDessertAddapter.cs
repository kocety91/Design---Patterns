using Cafeteria.Models;

namespace Cafeteria
{
    public interface IDessertAddapter
    {
        IList<DessertInfo> GetDessertInfos();
    }
}
