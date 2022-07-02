using System;
using System.Data.SqlClient;

string choice = String.Empty;
int Appearance_id = 1;
do
{
    Console.Write("Write persone name: ");
    string Persone_name = Console.ReadLine();
    Console.Write("Write persone surname: ");
    string Persone_surname = Console.ReadLine();
    Console.Write("Write personeyour age: ");
    short Persone_age = short.Parse(Console.ReadLine());
    Console.Write("Write persone hair color: ");
    string Hair_color = Console.ReadLine();
    Console.Write("Write persone eye color: ");
    string Eye_color = Console.ReadLine();
    string connStr = @"Server=DESKTOP-32NV42E;Database=Persone_Data;Trusted_Connection=True;";
    string sqlText = String.Format(@"INSERT INTO [Persone_Data].[dbo].[Appearance]([Hair_color], [Eye_color]) VALUES ('{4}', '{5}'); INSERT INTO [Persone_Data].[dbo].[Main_info]([Person_name], [Person_surname], [Person_age], [Person_appearance_id]) VALUES ('{0}', '{1}', {2}, '{3}');", Persone_name, Persone_surname, Persone_age.ToString(), Appearance_id.ToString(), Hair_color, Eye_color);
    Appearance_id++;
    using (SqlConnection conn = new SqlConnection(connStr))
    {
        conn.Open();
        using (SqlCommand command = new SqlCommand(sqlText, conn))
        {
            if (command.ExecuteNonQuery() > 0)
                Console.WriteLine("Rows added!");
        }
    }
    Console.WriteLine("\nIf you want to add a person - write \"yes\"; if you don't want to add a person - write \"no\": ");
    choice = Console.ReadLine();
} while (choice.Equals("yes"));