using RestaurantComplaint.Enums;

namespace RestaurantComplaint.Models
{
    public class Complaint
    {
        public Complaint(string customerName,Priority priority)
        {
            CustomerName = customerName;
            Priority = priority;
        }
        public string CustomerName { get; set; }

        public Priority Priority { get; set; }
    }
}
