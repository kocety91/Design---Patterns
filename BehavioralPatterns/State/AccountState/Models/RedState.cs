namespace AccountState.Models
{
    public class RedState : State
    {
        public RedState(State state)
            : this(state.Balance, state.Account)
        {
        }
        public RedState(decimal balance, Account account)
        {
            Balance = balance;
            Account = account;
            Initialize();
        }
        public override void Deposit(decimal money)
        {
            Balance += money;
            if(Balance > UpperLimit)
            {
                Account.State = new SilverState(this);
            }
        }

        public override void Withdraw(decimal money)
        {
            Console.WriteLine("You dont have enough funds in your account !");
        }

        private void Initialize()
        {
            UpperLimit = 0;
            LowerLimit = -100;
        }
    }
}
