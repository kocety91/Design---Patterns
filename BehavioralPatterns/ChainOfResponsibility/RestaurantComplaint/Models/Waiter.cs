using RestaurantComplaint.Enums;

namespace RestaurantComplaint.Models
{
    public class Waiter : Employee
    {
        public Waiter(Priority priority)
        {
            _priority = priority;
        }
    }
}
