

namespace Supermarket
{
    internal class VariablePriceProduct : Product
    {
        public string Measurement { get; set; }

        public float Quantity { get; set; }

        public override decimal ValueToPay()
        {
            decimal tax, price;
            price = (decimal)Quantity * Price;
            tax = price * (decimal)Tax;
            return Price= tax+price;
        }

        public override string ToString()
        {
            return $"{Id} {Description}"+
                   $"\n\tMeasurement:{$"{Measurement}",13}" + 
                   $"\n\tQuantity...:{$"{Quantity:F2}",13}"+
                   $"\n\tPrice......:{$"{Price:C2}",13}" +
                   $"\n\tTax........:{$"{Tax:P2}",13}" +
                   $"\n\tValue......:{$"{ValueToPay():C2}", 13}";
        }
    }
}
