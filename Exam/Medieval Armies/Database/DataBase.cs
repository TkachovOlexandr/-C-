using System;
using System.Data.SqlClient;
using System.Text.Json;

namespace Medieval_Armies.Database
{
    internal class DataBase /* База данных */
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

        public DataBase(/*Singleton connection*/)
        {
            //this.Connection = connection;
            //this.SqlConnection = new SqlConnection(Connection.Connection);
            StringConnection stringConnection = new StringConnection();
            Connection = Singleton.GetInstance(JsonSerializer.Deserialize<StringConnection>(File.ReadAllText("Connection.JSON")).ToString());
            SqlConnection = new SqlConnection(Connection.Connection);
        }

        public SqlCommand Request(string sqlText)// Запрос
        {
            using (SqlCommand command = new SqlCommand(sqlText, this.SqlConnection))
                return command;
        }
    }
}