using AccountState.Models;

namespace AccountState
{
    public class Account
    {
        public Account(string owner)
        {
            Owner = owner;
            State = new SilverState(0, this);
        }

        public string Owner { get; set; }

        public State State { get; set; }

        public decimal Balance => State.Balance;

        public void Deposit(decimal money)
        {
            State.Deposit(money);
            Console.WriteLine($"Succesfull deposit : ${money}");
            Console.WriteLine($"------{State.GetType().Name}-----");
            Console.WriteLine($"Your current ballance is : ${Balance}");
        }

        public void Withdraw(decimal money)
        {
            State.Withdraw(money);
            Console.WriteLine($"Succesfull withdraw : ${money}");
            Console.WriteLine($"------{State.GetType().Name}-----");
            Console.WriteLine($"Your current ballance is : ${Balance}");
        }

    }
}
