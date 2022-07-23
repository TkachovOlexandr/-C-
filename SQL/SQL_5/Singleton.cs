namespace SQL_5
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
}
