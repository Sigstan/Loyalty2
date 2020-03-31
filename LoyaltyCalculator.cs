namespace Loyalty2
{
    public class LoyaltyCalculator
    {

        private Customer customer;
        private PurchaseItem purchaseItem;

        public LoyaltyCalculator(string customerName, string itemName, double price)
        {
            this.customer = new Customer(customerName);
            this.purchaseItem = new PurchaseItem(price, itemName);

        }

        public void RegisterPurchase(Customer customer, PurchaseItem purchaseItem)
        {
            customer.RegisterPurchase(purchaseItem);
        }

        public void PrintCustomers()
        {
            Customer customer = new Customer();
            customer.Print();
        }
        public void PrintItems()
        {
            PurchaseItem purchaseItem = new PurchaseItem();
            purchaseItem.Print();

        }
        //public LoyaltyCalculator(Customer customer)
        //{

        //}
        //public LoyaltyCalculator(PurchaseItem purchaseItem)
        //{

        //}
    }
}

}
