namespace Shop
{
    internal class Product
    {
        private int productId;
        private string productName;
        private int productPrice;

        public int ProductId
        {
            get { return productId; }
            set { productId = value; }
        }
        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }
        public int ProductPrice
        {
            get { return productPrice; }
            set { productPrice = value; }
        }

        public Product()
        {
            ProductId = 0;
            ProductName = new String("New Product");
            ProductPrice = 0;
        }
        public Product(int productId, string productName, int productPrice)
        {
            ProductId = productId;
            ProductName = productName;
            ProductPrice = productPrice;
        }

        public override string ToString()
        {
            return $"{ProductId}) {ProductName} ({ProductPrice} grn)";
        }
    }
}
