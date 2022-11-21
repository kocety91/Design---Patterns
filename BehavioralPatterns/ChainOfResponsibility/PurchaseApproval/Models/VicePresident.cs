namespace PurchaseApproval.Models
{
    public class VicePresident : Approver
    {
        public override void ProccessPurchase(Purchase purchase)
        {
            if (purchase.Amount < 50000)
            {
                Console.WriteLine($"{GetType().Name} procced purchase with N= {purchase.Number}");
            }
            else if (Successor != null)
            {
                Successor.ProccessPurchase(purchase);
            }
        }
    }
}
