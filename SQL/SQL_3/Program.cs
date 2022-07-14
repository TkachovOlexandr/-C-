using System;
using System.Data.SqlClient;

namespace TestNamespace
{
    public sealed class Singleton
    {
        private string connection;

        public string Connection
        {
            get { return connection; }
            set { connection = value; }
        }

        private Singleton(string connection) { this.connection = connection; }

        private static Singleton _instance;

        public static Singleton GetInstance(string connection)
        {
            if (_instance == null)
            {
                _instance = new Singleton(connection);
            }
            return _instance;
        }
    }

    class DataBase
    {
        private Singleton connection;
        private SqlConnection sqlConnection;

        public SqlConnection SqlConnection
        {
            get { return sqlConnection; }
            set { sqlConnection = value; }
        }
        public Singleton Connection
        {
            get { return connection; }
            set { connection = value; }
        }

        public DataBase(Singleton connection)
        {
            this.Connection = connection;
            this.SqlConnection = new SqlConnection(Connection.Connection);
        }

        public void Add()
        {
            string sqlText = "SELECT TOP 1 * FROM Main_info ORDER BY ID DESC;";
            SqlConnection.Open();
            SqlCommand SqlCommand = new SqlCommand(sqlText, SqlConnection);
            SqlDataReader reader = SqlCommand.ExecuteReader();
            short number = 0;
            while (reader.Read())
                number = Convert.ToInt16(reader.GetValue(4));
            reader.Close();
            sqlConnection.Close();
            ++number;

            Console.Write("Write persone name: ");
            string Persone_name = Console.ReadLine();
            Console.Write("Write persone surname: ");
            string Persone_surname = Console.ReadLine();
            Console.Write("Write persone age: ");
            short Persone_age = short.Parse(Console.ReadLine());
            Console.Write("Write persone hair color: ");
            string Hair_color = Console.ReadLine();
            Console.Write("Write persone eye color: ");
            string Eye_color = Console.ReadLine();

            string sqlStr = String.Format(@"INSERT INTO [Persone_Data].[dbo].[Appearance]([Hair_color], [Eye_color]) VALUES ('{4}', '{5}'); INSERT INTO [Persone_Data].[dbo].[Main_info]([Person_name], [Person_surname], [Person_age], [Person_appearance_id]) VALUES ('{0}', '{1}', {2}, '{3}');", Persone_name, Persone_surname, Persone_age.ToString(), number.ToString(), Hair_color, Eye_color);
            using (this.SqlConnection)
            {
                this.SqlConnection.Open();
                using (SqlCommand command = new SqlCommand(sqlStr, this.SqlConnection))
                {
                    if (command.ExecuteNonQuery() > 0)
                        Console.WriteLine("Rows added!");
                }
                this.SqlConnection.Close();
            }
        }
        public void Delete(int id)
        {
            string sqlStr = String.Format(@"delete from Main_info where Person_appearance_id = {0}; delete from Appearance where Id = {0};", id.ToString());
            using (this.SqlConnection)
            {
                this.SqlConnection.Open();
                using (SqlCommand command = new SqlCommand(sqlStr, this.SqlConnection))
                {
                    if (command.ExecuteNonQuery() > 0)
                        Console.WriteLine("Rows deleted!");
                }
                this.SqlConnection.Close();
            }
        }
        public void Show()
        {
            string sqlStr = "SELECT * FROM (Appearance INNER JOIN Main_info ON Appearance.Id = Main_info.Person_appearance_id);";
            using (this.SqlConnection)
            {
                this.SqlConnection.Open();
                using (SqlCommand command = new SqlCommand(sqlStr, this.SqlConnection))
                {
                    if (command.ExecuteNonQuery() > 0)
                    {
                        SqlDataReader reader = command.ExecuteReader();

                        //имена столба
                        for (int i = 0; i < reader.FieldCount; i++)
                            Console.Write($"{reader.GetName(i).ToString()}\t");

                        Console.WriteLine($"\n{new String('-', 57)}");

                        while (reader.Read())
                        {
                            //значения
                            for (int i = 0; i < reader.FieldCount; i++)
                                Console.Write($"{reader.GetValue(i).ToString()}\t\t");
                            Console.WriteLine();
                        }

                        Console.WriteLine($"\n{new String('-', 57)}");

                        reader.Close();
                        this.SqlConnection.Close();
                    }
                }
                this.SqlConnection.Close();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Клиентский код.
            //Singleton s1 = Singleton.GetInstance();
            //Singleton s2 = Singleton.GetInstance();

            //if (s1 == s2)
            //{
            //    Console.WriteLine("Singleton works, both variables contain the same instance.");
            //}
            //else
            //{
            //    Console.WriteLine("Singleton failed, variables contain different instances.");
            //}

            //Singleton connection = Singleton.GetInstance(@"Server=DESKTOP-32NV42E;Database=Persone_Data;Trusted_Connection=True;");
            //string sqlStr = "SELECT TOP 1 * FROM Results ORDER BY ID DESC;";
            //SqlConnection sqlConnection = new SqlConnection(connection.Connection);
            //sqlConnection.Open();
            //SqlCommand SqlCommand = new SqlCommand(sqlStr, sqlConnection);
            //SqlDataReader reader = SqlCommand.ExecuteReader();
            //short number = 0;
            //while (reader.Read())
            //    number = Convert.ToInt16(reader.GetValue(1));
            //reader.Close();
            //sqlConnection.Close();
            //Console.WriteLine(number.ToString());

            Singleton connection = Singleton.GetInstance(@"Server=DESKTOP-32NV42E;Database=Persone_Data;Trusted_Connection=True;");
            DataBase dataBase = new DataBase(connection);
            dataBase.Add();
            dataBase.Show();
            dataBase.Add();
            dataBase.Show();
            dataBase.Delete(2);
            dataBase.Show();
        }
    }
}