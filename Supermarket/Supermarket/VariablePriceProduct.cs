

namespace Supermarket
{
    internal class VariablePriceProduct : Product
    {
        public string Measurement { get; set; }

        public float Quantity { get; set; }

        public override decimal ValueToPay()
        {
            decimal tax, price, price1;
            price = (decimal)Quantity * Price;
            tax = price * (decimal)Tax;
            price1 = tax + price;
            return price1;
        }

        public override string ToString()
        {
            return $"   {Id} {Description}"+
                   $"\n\tMeasurement:{$"{Measurement}",6}" + 
                   $"\n\tQuantity...:{$"{Quantity:F2}",14}"+
                   $"\n\tPrice......:{$"{Price:C2}",14}" +
                   $"\n\tTax........:{$"{Tax:P2}",14}" +
                   $"\n\tValue......:{$"{ValueToPay():C2}", 14}";
        }
    }
}
