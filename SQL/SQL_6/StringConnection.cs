namespace SQL_6
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
