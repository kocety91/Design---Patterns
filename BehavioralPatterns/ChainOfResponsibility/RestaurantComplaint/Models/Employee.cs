using RestaurantComplaint.Enums;

namespace RestaurantComplaint.Models
{
    public abstract class Employee
    {
        protected Priority _priority;

        public void SetSuccesor(Employee successor)
        {
            Successor = successor;
        }

        public Employee Successor { get; set; }

        public void ProcessComplaint(Complaint complaint)
        {
            if(complaint.Priority <= _priority)
            {
                Respond(complaint);
            }
            else if(Successor != null)
            {
                Successor.ProcessComplaint(complaint);
            }
            else
            {
                Console.WriteLine("Complaint cannot be handled!");
            }
        }

        protected virtual void Respond(Complaint complaint)
        {
            Console.WriteLine($"Mr/Mrs {complaint.CustomerName}, your complaint will be handled by the {GetType().Name}");
        }
    }
}
