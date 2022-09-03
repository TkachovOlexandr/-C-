using System.Data.SqlClient;
using System.Text.Json;

namespace DBSettings.DB
{
    internal class SingletonConnection
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

        public SingletonConnection()
        {
            StringConnection stringConnection = new StringConnection();
            Connection = Singleton.GetInstance(JsonSerializer.Deserialize<StringConnection>(File.ReadAllText("Connection.JSON")).ToString());
            SqlConnection = new SqlConnection(Connection.Connection);
        }
    }
}