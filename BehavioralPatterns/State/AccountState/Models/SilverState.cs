namespace AccountState.Models
{
    public class SilverState : State
    {

        public SilverState(State state)
           : this(state.Balance, state.Account)
        {
        }
        public SilverState(decimal balance, Account account)
        {
            Balance = balance;
            Account = account;
            Initialize();
        }

        public override void Deposit(decimal money)
        {
            Balance += money;
            if (Balance > UpperLimit)
            {
                Account.State = new GoldState(this);
            }
        }

        public override void Withdraw(decimal money)
        {
            Balance -= money;
            if (Balance < LowerLimit)
            {
                Account.State = new RedState(this);
            }
        }

        private void Initialize()
        {
            UpperLimit = 1000;
            LowerLimit = 0;
        }
    }
}
