using SQL_7;
using Dapper;
using System.Data.SqlClient;

short choice = 0;
const string connStr = "Server=DESKTOP-32NV42E;Database=Products;Trusted_Connection=True;";
using (SqlConnection conn = new SqlConnection(connStr))
{
    conn.Open();

    do
    {
        do
        {
            Console.WriteLine("\nIf you want to add product to the table - enter '1';");
            Console.WriteLine("if you want to remove product from the table - enter '2';");
            Console.WriteLine("if you want to edit product - enter '3';");
            Console.Write("if you want to exit the program - enter '4': ");
            choice = short.Parse(Console.ReadLine());
        } while (choice < 1 || choice > 4);
        if (choice == 1)
        {
            Console.Write("\nEnter the product name: ");
            string name = Console.ReadLine();
            Console.Write("Enter the product category: ");
            string category = Console.ReadLine();
            Console.Write("Enter the product price: ");
            float price = float.Parse(Console.ReadLine());
            Product product = new Product(-1, name, category, price);
            int rows = conn.Execute(String.Format("insert into Product(Product_Name, Product_Category, Product_Price) values ('{0}', '{1}', {2});", product.Product_Name, product.Product_Category, product.Product_Price.ToString().Replace(',', '.')));
            if (rows > 0) Console.WriteLine($"{product.ToString()} has been successfully added!");
        }
        else if (choice == 2)
        {
            Console.Write("\nEnter the name of product you want to remove: ");
            string searching_name = Console.ReadLine();
            int rows = conn.Execute(String.Format("delete from Product where Product_Name='{0}';", searching_name));
            if (rows > 0) Console.WriteLine("The deletion was successful!");
        }
        else if (choice == 3)
        {
            Console.Write("\nEnter the name of product you want to edit: ");
            string searching_name = Console.ReadLine();
            short edit_choice = 0;
            do
            {
                Console.WriteLine("If you want to edit the product name - enter '1';");
                Console.WriteLine("if you want to edit the product category - enter '2';");
                Console.Write("if you want to edit the product price - enter '3': ");
                edit_choice = short.Parse(Console.ReadLine());
            } while (edit_choice < 1 || edit_choice > 3);
            int rows = 0;
            if (edit_choice == 1)
            {
                Console.Write("Enter the changed product name: ");
                string editing_name = Console.ReadLine();
                rows = conn.Execute(String.Format("update Product set Product_Name='{0}' where Product_Name='{1}';", editing_name, searching_name));
            }
            else if (edit_choice == 2)
            {
                Console.Write("Enter the changed product category: ");
                string editing_category = Console.ReadLine();
                rows = conn.Execute(String.Format("update Product set Product_Category='{0}' where Product_Name='{1}';", editing_category, searching_name));
            }
            else if (edit_choice == 3)
            {
                Console.Write("Enter the changed product price: ");
                string editing_price = Console.ReadLine();
                rows = conn.Execute(String.Format("update Product set Product_Price='{0}' where Product_Name='{1}';", editing_price.ToString().Replace(',', '.'), searching_name));
            }
            if (rows > 0) Console.WriteLine("The change was successful!");
        }
    } while (choice != 4);

    conn.Close();
}