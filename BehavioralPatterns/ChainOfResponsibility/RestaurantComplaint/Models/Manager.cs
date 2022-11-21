using RestaurantComplaint.Enums;

namespace RestaurantComplaint.Models
{
    public class Manager : Employee
    {
        public Manager(Priority priority)
        {
            _priority = priority;
        }
    }
}
