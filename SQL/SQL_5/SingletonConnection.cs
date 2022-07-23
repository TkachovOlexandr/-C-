using System.Data.SqlClient;

namespace SQL_5
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
            this.Connection = Singleton.GetInstance(File.ReadAllText("Connection.TXT"));
            this.SqlConnection = new SqlConnection(Connection.Connection);
        }
    }
}
