namespace Supermarket
{
    public class Invoice : IPay
    {
        public Invoice() { }

        private List<Product> _products = new List<Product>();
         public decimal ValueToPay()
        {
            decimal AccumoProducts = 0;
            foreach (Product product in _products)
            {
                AccumoProducts += product.ValueToPay();
            }
              return AccumoProducts;
        }
        
        public override string ToString()
        {
            Console.WriteLine("RECEIPT");
            Console.WriteLine("------------------------------------------------");
            foreach (Product product in _products)
            {
                Console.WriteLine(product.ToString());
            } 
            return $"                       ============" +
                   $"\n\tTOTAL:        {$"{ValueToPay():C2}",14}";
        }
        
        

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

    }
}
