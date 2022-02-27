
namespace Supermarket
{
    internal class FixedPriceProduct : Product
    {

       
        public override decimal ValueToPay()
        {
            return Price=(Price*(decimal)Tax)+Price;
             
        }

        public override string ToString()
        {
            return $"{base.ToString()}"+
                $"\n\tValue......: {$"{ValueToPay():C2}",14}";
        }
    }
}
