using RestaurantComplaint.Enums;

namespace RestaurantComplaint.Models
{
    public class Cook : Employee
    {
        public Cook(Priority priority)
        {
            _priority = priority;
        }
    }
}
