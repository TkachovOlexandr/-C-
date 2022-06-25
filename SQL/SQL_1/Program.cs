using System.Data;
using System.Data.SqlClient;

string connStr = "Server=DESKTOP-32NV42E;Database=Phone_Book;Trusted_Connection=True;";
string sqlStr = "SELECT [Person_name], [Person_surname], [Phone_number] FROM (([Personal_date] INNER JOIN [Phone] ON [Personal_date].[Id] = [Phone].[Personal_date_id]) INNER JOIN [Phone_number] ON [Phone_number].[Id] = [Phone].[Phone_number_id]);";
SqlConnection sqlConnection = new SqlConnection(connStr);
sqlConnection.Open();
SqlCommand SqlCommand = new SqlCommand(sqlStr, sqlConnection);
SqlDataReader reader = SqlCommand.ExecuteReader();

//имена столба
for (int i = 0; i < reader.FieldCount; i++)
    Console.Write($"{reader.GetName(i).ToString()}\t");

Console.WriteLine($"\n{new String('-', 57)}");

//тип столба
for (int i = 0; i < reader.FieldCount; i++)
    Console.Write($"{reader.GetDataTypeName(i).ToString()}\t");

Console.WriteLine($"\n{new String('-', 57)}\n");

while (reader.Read())
{
    //значения
    for (int i = 0; i < reader.FieldCount; i++)
        Console.Write($"{reader.GetValue(i).ToString()}\t\t");
    Console.WriteLine();
}

Console.WriteLine($"\n{new String('-', 57)}");

reader.Close();
sqlConnection.Close();