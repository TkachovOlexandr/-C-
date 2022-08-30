using SQL_7;
using Dapper;
using System.Data.SqlClient;

MyLogger.Log("Program start", LogLevel.Information);
const string connStr = "Server=DESKTOP-32NV42E;Database=Products;Trusted_Connection=True;";
using (SqlConnection conn = new SqlConnection(connStr))
{
    conn.Open();

    try
    {
        Product product = new Product(-1, "Bowl", "Crockery", (Double)399.99);
        string command = String.Format("insert into Product(Product_Name, Product_Category, Product_Price) values ('{0}', '{1}', {2});", product.Product_Name, product.Product_Category, product.Product_Price.ToString().Replace(',', '.'));
        MyLogger.Log($"Try to insert using the command {command}", LogLevel.Information);
        int rows = conn.Execute(command);
        if (rows > 0) Console.WriteLine($"{rows} added!");
    }
    catch (Exception ex)
    {
        MyLogger.Log(ex.Message);
    }

    try
    {
        string command = new string("select * from Product;");
        MyLogger.Log($"Try to select using the command {command}", LogLevel.Information);
        var products = conn.Query<Product>(command);
    }
    catch (Exception ex)
    {
        MyLogger.Log(ex.Message);
    }

    conn.Close();
}
MyLogger.Log("Program end", LogLevel.Information);

Console.WriteLine("\nAll events:");
MyAnalyzer.Analyze();
Console.WriteLine("\nJust Information:");
MyAnalyzer.Analyze(AnalysisLevel.JustInformation);
Console.WriteLine("\nJust Warning:");
MyAnalyzer.Analyze(AnalysisLevel.JustWarning);
Console.WriteLine("\nJust Error:");
MyAnalyzer.Analyze(AnalysisLevel.JustError);
Console.WriteLine("\nAll events reversed:");
MyAnalyzer.Analyze(AnalysisLevel.AllEvents, DataOrder.Reverse);
Console.WriteLine("\nJust Information reversed:");
MyAnalyzer.Analyze(AnalysisLevel.JustInformation, DataOrder.Reverse);
Console.WriteLine("\nJust Warning reversed:");
MyAnalyzer.Analyze(AnalysisLevel.JustWarning, DataOrder.Reverse);
Console.WriteLine("\nJust Error reversed:");
MyAnalyzer.Analyze(AnalysisLevel.JustError, DataOrder.Reverse);
Console.WriteLine("\nSearch by word 'insert':");
MyAnalyzer.SearchByWord("insert");
Console.WriteLine("\nSearch by word 'program':");
MyAnalyzer.SearchByWord("program");
Console.WriteLine("\nSearch by word 'program' reversed:");
MyAnalyzer.SearchByWord("program", DataOrder.Reverse);