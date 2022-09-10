namespace Medieval_Armies.Database
{
    internal class StringConnection
    {
        private string server;
        private string database;
        private string trustedConnection;

        public string TrustedConnection
        {
            get { return trustedConnection; }
            set { trustedConnection = value; }
        }


        public string Database
        {
            get { return database; }
            set { database = value; }
        }


        public string Server
        {
            get { return server; }
            set { server = value; }
        }

        public StringConnection() { }
        public StringConnection(string server, string database, string trustedConnection)
        {
            Server = server;
            Database = database;
            TrustedConnection = trustedConnection;
        }

        public override string ToString()
        {
            return $"Server={Server};Database={Database};Trusted_Connection={TrustedConnection};";
        }
    }
}