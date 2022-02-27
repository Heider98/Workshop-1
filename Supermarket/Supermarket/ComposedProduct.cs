using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    internal class ComposedProduct : Product
    {
        public float Discount { get; set; }

        //to solve
        //public string Products { get; set; }
        // to solve
        List<Product> Products = new List<Product>();

        public override decimal ValueToPay()
        {
            return Price;
        }
        public override string ToString()
        {
            return base.ToString();
        }

    }
}
