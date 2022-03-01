
namespace Supermarket
{
    internal class FixedPriceProduct : Product
    {

       
        public override decimal ValueToPay()
        {
            decimal price = 0;
            price = (Price * (decimal)Tax) + Price;
            return price;
             
        }

        public override string ToString()
        {
            return $"   {base.ToString()}"+
                $"\n\tValue......: {$"{ValueToPay():C2}",14}";
        }
    }
}
