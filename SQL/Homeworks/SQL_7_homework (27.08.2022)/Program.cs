using DBSettings.DB;
using SQL_7;
using Dapper;
using System.Data.SqlClient;

MyLogger.Log("Program start", LogLevel.Information);
short choice = 0;
SingletonConnection connection = new SingletonConnection();
using (connection.SqlConnection)
{
    connection.SqlConnection.Open();
    MyLogger.Log("Connect to the database", LogLevel.Information);

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
            MyLogger.Log($"Start adding", LogLevel.Information);
            try
            {
                Console.Write("\nEnter the product name: ");
                string name = Console.ReadLine();
                Console.Write("Enter the product category: ");
                string category = Console.ReadLine();
                Console.Write("Enter the product provider: ");
                string provider = Console.ReadLine();
                Console.Write("Enter the product price: ");
                float price = float.Parse(Console.ReadLine());
                Product product = new Product(-1, name, category, provider, price);
                string command = String.Format("insert into Product(Product_Name, Product_Category, Product_Provider, Product_Price) values ('{0}', '{1}', '{2}', {3});", product.Product_Name, product.Product_Category, product.Product_Provider, product.Product_Price.ToString().Replace(',', '.'));
                MyLogger.Log($"Try to insert using the command {command}", LogLevel.Information);
                int rows = connection.SqlConnection.Execute(command);
                if (rows > 0) Console.WriteLine($"{product.ToString()} has been successfully added!");
            }
            catch (Exception ex)
            {
                MyLogger.Log(ex.Message);
            }
            MyLogger.Log($"End of adding", LogLevel.Information);
        }
        else if (choice == 2)
        {
            MyLogger.Log($"Start removing", LogLevel.Information);
            try
            {
                Console.Write("\nEnter the name of product you want to remove: ");
                string searching_name = Console.ReadLine();
                string command = String.Format("delete from Product where Product_Name='{0}';", searching_name);
                MyLogger.Log($"Try to delete using the command {command}", LogLevel.Information);
                int rows = connection.SqlConnection.Execute(command);
                if (rows > 0) Console.WriteLine("The deletion was successful!");
            }
            catch (Exception ex)
            {
                MyLogger.Log(ex.Message);
            }
            MyLogger.Log($"End of removing", LogLevel.Information);
        }
        else if (choice == 3)
        {
            MyLogger.Log($"Start editing", LogLevel.Information);
            try
            {
                Console.Write("\nEnter the name of product you want to edit: ");
                string searching_name = Console.ReadLine();
                short edit_choice = 0;
                do
                {
                    Console.WriteLine("If you want to edit the product name - enter '1';");
                    Console.WriteLine("if you want to edit the product category - enter '2';");
                    Console.WriteLine("if you want to edit the product provider - enter '3';");
                    Console.Write("if you want to edit the product price - enter '4': ");
                    edit_choice = short.Parse(Console.ReadLine());
                } while (edit_choice < 1 || edit_choice > 4);
                int rows = 0;
                if (edit_choice == 1)
                {
                    Console.Write("Enter the changed product name: ");
                    string editing_name = Console.ReadLine();
                    string command = String.Format("update Product set Product_Name='{0}' where Product_Name='{1}';", editing_name, searching_name);
                    MyLogger.Log($"Try to update using the command {command}", LogLevel.Information);
                    rows = connection.SqlConnection.Execute(command);
                }
                else if (edit_choice == 2)
                {
                    Console.Write("Enter the changed product category: ");
                    string editing_category = Console.ReadLine();
                    string command = String.Format("update Product set Product_Category='{0}' where Product_Name='{1}';", editing_category, searching_name);
                    MyLogger.Log($"Try to update using the command {command}", LogLevel.Information);
                    rows = connection.SqlConnection.Execute(command);
                }
                else if (edit_choice == 3)
                {
                    Console.Write("Enter the changed product provider: ");
                    string editing_provider = Console.ReadLine();
                    string command = String.Format("update Product set Product_Provider='{0}' where Product_Name='{1}';", editing_provider, searching_name);
                    MyLogger.Log($"Try to update using the command {command}", LogLevel.Information);
                    rows = connection.SqlConnection.Execute(command);
                }
                else if (edit_choice == 4)
                {
                    Console.Write("Enter the changed product price: ");
                    string editing_price = Console.ReadLine();
                    string command = String.Format("update Product set Product_Price='{0}' where Product_Name='{1}';", editing_price.ToString().Replace(',', '.'), searching_name);
                    MyLogger.Log($"Try to update using the command {command}", LogLevel.Information);
                    rows = connection.SqlConnection.Execute(command);
                }
                if (rows > 0) Console.WriteLine("The change was successful!");
            }
            catch (Exception ex)
            {
                MyLogger.Log(ex.Message);
            }
            MyLogger.Log($"End of editing", LogLevel.Information);
        }
    } while (choice != 4);

    connection.SqlConnection.Close();
    MyLogger.Log("Disconnect from the database", LogLevel.Information);
}
MyLogger.Log("Program end\n", LogLevel.Information);