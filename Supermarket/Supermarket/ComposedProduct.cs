using System.Collections;

namespace Supermarket
{
    internal class ComposedProduct : Product
    {
        public float Discount { get; set; }

        public ICollection Products { get; set; }

        
        public override decimal ValueToPay()
        {
            decimal acomulation = 0;
            foreach (Product product in Products)
            {
                acomulation += product.ValueToPay();
            }
            //decimal tDiscount = acomulation * (decimal)Discount;
            //decimal pvalue = acomulation - tDiscount;
            return acomulation;
        }
        public override string ToString()
        {
            string asisten = "";
            foreach (Product productd in Products)
            {
                asisten += productd.Description + (",");
            }
            return $"{Id} {Description}" +
                   $"\n\tProducts...: {$"{asisten}",9}" +
                   $"\n\tDiscount...: {$"{Discount:P2}",9}" +
                   $"\n\tValue......: {$"{ValueToPay():C2}",9}";
        }



    }
}
