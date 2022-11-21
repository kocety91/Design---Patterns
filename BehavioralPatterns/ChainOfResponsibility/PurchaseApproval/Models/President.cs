namespace PurchaseApproval.Models
{
    public class President : Approver
    {
        public override void ProccessPurchase(Purchase purchase)
        {
            if (purchase.Amount < 100000)
            {
                Console.WriteLine($"{GetType().Name} procced purchase with N= {purchase.Number}");
            }
            else if (Successor != null)
            {
                Successor.ProccessPurchase(purchase);
            }
            else
            {
                Console.WriteLine("Sorry purchase is too expensive :D ");
            }
        }
    }
}
