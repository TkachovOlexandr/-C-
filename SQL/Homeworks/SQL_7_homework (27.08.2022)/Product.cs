namespace SQL_7
{
    internal class Product
    {
        private int id;
        private string product_Name;
        private string product_Category;
        private string product_Provider;
        private float product_Price;

        public float Product_Price
        {
            get { return product_Price; }
            set { product_Price = value; }
        }
        public string Product_Category
        {
            get { return product_Category; }
            set { product_Category = value; }
        }
        public string Product_Provider
        {
            get { return product_Provider; }
            set { product_Provider = value; }
        }
        public string Product_Name
        {
            get { return product_Name; }
            set { product_Name = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public Product()
        {
            Id = 0;
            Product_Name = String.Empty;
            Product_Category = String.Empty;
            Product_Provider = String.Empty;
            Product_Price = 0;
        }
        public Product(int id, string product_Name, string product_Category, string product_Provider, float product_Price)
        {
            Id = id;
            Product_Name = product_Name;
            Product_Category = product_Category;
            Product_Provider = product_Provider;
            Product_Price = product_Price;
        }

        public override string ToString()
        {
            return $"{Product_Name} ({Product_Category}, {Product_Price}grn, provider:\"{Product_Provider}\")";
        }

    }
}
