using SQL_7;
using Dapper;
using System.Data.SqlClient;
using System.Text.Json;

const string connStr = "Server=DESKTOP-32NV42E;Database=Products;Trusted_Connection=True;";
using (SqlConnection conn = new SqlConnection(connStr))
{
    conn.Open();

    //insert or delete or update
    Product product = new Product(-1, "Knife", "Cutlery", 399.99);
    int rows = conn.Execute($"insert into Product(Product_Name, Product_Category, Product_Price) values ('{product.Product_Name}', '{product.Product_Category}', {product.Product_Price});");
    if (rows > 0) Console.WriteLine($"{rows} added!");

    //select *
    var products = conn.Query<Product>("select * from Product;");
    products.ToList().ForEach(Console.WriteLine);

    conn.Close();
}