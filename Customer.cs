using System;

namespace Loyalty2
{
    class Customer : IPrintable, IComparable<Customer>
    {
        public string Name { get; set; }
        public double LoyaltyPoint { get; private set; }
        public Customer()
        {

        }

        public Customer(string name)
        {
            Name = name;
        }
        public Customer(double loyaltyPoint, string name)
        {
            this.LoyaltyPoint = loyaltyPoint;
            Name = name;
        }

        public int CompareTo(Customer other)
        {
            if (other.LoyaltyPoint > this.LoyaltyPoint)
            {
                return -1;
            }
            else if (other.LoyaltyPoint < this.LoyaltyPoint)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public void Print()
        {
            Customer customer = new Customer(LoyaltyPoint, Name);
            Console.WriteLine(customer);

        }

        public void RegisterPurchase(PurchaseItem item)
        {
            if (LoyaltyPoint < 100)
            {
                double newLoyalPoint = item.Price;
                AddNewLoyalPoint(newLoyalPoint);
                PrintNewLoyalPointa(newLoyalPoint);

            }
            else if (LoyaltyPoint > 100)
            {
                double newLoyalPoint = item.Price * 1.1;
                AddNewLoyalPoint(newLoyalPoint);
                PrintNewLoyalPointa(newLoyalPoint);

            }
            else if (LoyaltyPoint > 500)
            {
                double newLoyalPoint = item.Price * 1.2;
                AddNewLoyalPoint(newLoyalPoint);
                PrintNewLoyalPointa(newLoyalPoint);

            }
            else
            {
                Console.WriteLine("Cannot add Loyalty Points");
            }

        }

        private void AddNewLoyalPoint(double newLoyalPoint)
        {
            LoyaltyPoint += newLoyalPoint;
        }

        private static void PrintNewLoyalPointa(double newLoyalPoint)
        {
            Console.WriteLine($"You got {newLoyalPoint} points");
        }
        public override string ToString()
        {
            return $"{Name} has {LoyaltyPoint} points";
        }


    }
}

}
