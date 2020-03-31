using System;

namespace Loyalty2
{
    class PurchaseItem : IPrintable, IComparable<PurchaseItem>
    {
        public double Price { get; set; }
        public string Name { get; set; }
        public PurchaseItem()
        {

        }
        public PurchaseItem(double price, string name)
        {
            Price = price;
            Name = name;
        }

        public int CompareTo(PurchaseItem other)
        {

            if (other.Price > this.Price)
            {
                return -1;
            }
            else if (other.Price < this.Price)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public override string ToString()
        {
            return $"{Name} price is {Price}Eur";
        }
        public void Print()
        {
            PurchaseItem purchaseItem = new PurchaseItem(Price, Name);
            Console.WriteLine(purchaseItem);

        }
    }
}


