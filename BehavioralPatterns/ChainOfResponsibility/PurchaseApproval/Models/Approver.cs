namespace PurchaseApproval.Models
{
    public abstract class Approver
    {
        protected Approver()
        {
        }

        public Approver Successor { get; set; }

        public void SetSuccessor(Approver successor)
        {
            this.Successor = successor;
        }

        public abstract void ProccessPurchase(Purchase purchase);
    }
}
