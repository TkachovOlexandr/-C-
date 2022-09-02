namespace SQL_7
{
    internal class StringConnection
    {
        private string connectionString;

        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }

        public StringConnection() { }
    }
}