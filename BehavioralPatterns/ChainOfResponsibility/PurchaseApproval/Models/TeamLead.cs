namespace PurchaseApproval.Models
{
    public class TeamLead : Approver
    {
        public override void ProccessPurchase(Purchase purchase)
        {
            if (purchase.Amount < 10000)
            {
                Console.WriteLine($"{this.GetType().Name} procced purchase with N= {purchase.Number}");
            }
            else if (Successor != null)
            {
                Successor.ProccessPurchase(purchase);
            }
        }
    }
}
