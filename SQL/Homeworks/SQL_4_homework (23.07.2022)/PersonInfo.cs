using System.Data.SqlClient;

namespace SQL_4
{
    internal class PersonInfo
    {
        private Singleton connection;
        private SqlConnection sqlConnection;

        //private int id;
        private string person_name;
        private string person_surname;
        private int person_age;
        private string person_number;

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

        //public int Id
        //{
        //    get { return id; }
        //    set { id = value; }
        //}
        public string Person_name
        {
            get { return person_name; }
            set { person_name = value; }
        }
        public string Person_surname
        {
            get { return person_surname; }
            set { person_surname = value; }
        }
        public int Person_age
        {
            get { return person_age; }
            set { person_age = value; }
        }
        public string Person_number
        {
            get { return person_number; }
            set { person_number = value; }
        }

        public PersonInfo(/*int id,*/ string person_name, string person_surname, int person_age, string person_number)
        {
            this.Connection = Singleton.GetInstance(@"Server=DESKTOP-32NV42E;Database=PhoneBook_SQL_4_homework;Trusted_Connection=True;");
            this.SqlConnection = new SqlConnection(Connection.Connection);

            //this.Id = id;
            this.Person_name = person_name;
            this.Person_surname = person_surname;
            this.Person_age = person_age;
            this.person_number = person_number;
        }
        public PersonInfo()
        {
            this.Connection = Singleton.GetInstance(@"Server=DESKTOP-32NV42E;Database=PhoneBook_SQL_4_homework;Trusted_Connection=True;");
            this.SqlConnection = new SqlConnection(Connection.Connection);
        }

        public override string ToString()
        {
            return $"Name: {Person_name}; Surname: {Person_surname}; Age: {Person_age}; Phone number: {Person_number}\n";//#{Id} 
        }

        public void Add()
        {
            string sqlText = "SELECT TOP 1 * FROM Phone ORDER BY ID DESC;";
            SqlConnection.Open();
            SqlCommand SqlCommand = new SqlCommand(sqlText, SqlConnection);
            SqlDataReader reader = SqlCommand.ExecuteReader();
            short number = 0;
            while (reader.Read())
                number = Convert.ToInt16(reader.GetValue(1));
            reader.Close();
            SqlConnection.Close();
            ++number;

            string sqlStr = String.Format(@"insert into Phone_number(Phone_number) values ('{0}'); insert into Personal_date(Person_name, Person_surname, Person_age) values ('{1}', '{2}', {3}); insert into Phone(Phone_number_id, Personal_date_id) values ({4}, {4});", person_number, person_name, person_surname, person_age, number.ToString());
            using (this.SqlConnection)
            {
                this.SqlConnection.Open();
                using (SqlCommand command = new SqlCommand(sqlStr, this.SqlConnection))
                {
                    if (command.ExecuteNonQuery() > 0)
                    {
                        Console.WriteLine("\nAfter adding:\n");
                        this.SqlConnection.Close();
                        Show();
                    }
                }
            }
        }

        public void Delete(int id)
        {
            string sqlText = String.Format("SELECT * FROM Phone Order BY ID ASC OFFSET {0} ROWS FETCH NEXT 1 ROWS ONLY;", id - 1);//String.Format("SELECT TOP (1) * FROM (SELECT TOP ({0}) * FROM Phone ORDER BY ID ASC) ORDER BY ID DESC;", id)
            SqlConnection.Open();
            SqlCommand SqlCommand = new SqlCommand(sqlText, SqlConnection);
            SqlDataReader reader_1 = SqlCommand.ExecuteReader();
            short number = 0;
            while (reader_1.Read())
                number = Convert.ToInt16(reader_1.GetValue(1));
            reader_1.Close();

            using (SqlCommand cmd = new SqlCommand(String.Format("delete from Phone where Id={0}; delete from Personal_date where Id={0}; delete from Phone_number where Id={0};", number), SqlConnection))
            {
                if (cmd.ExecuteNonQuery() > 0)
                {
                    Console.WriteLine("After removal:\n");
                    SqlConnection.Close();
                    Show();
                }
            }
        }

        public void Show()
        {
            string sqlText = "SELECT TOP 1 * FROM Phone ORDER BY ID DESC;";
            SqlConnection.Open();
            SqlCommand SqlCommand = new SqlCommand(sqlText, SqlConnection);
            SqlDataReader reader_1 = SqlCommand.ExecuteReader();
            short number = 0;
            while (reader_1.Read())
                number = Convert.ToInt16(reader_1.GetValue(1));
            reader_1.Close();

            PersonInfo[] people = new PersonInfo[0];
            if (number > 1000)
                number = 1000;
            using (SqlCommand cmd = new SqlCommand(String.Format("SELECT TOP ({0}) [Personal_date].[Id], [Person_name], [Person_surname], [Person_age], [Phone_number] FROM (([Personal_date] INNER JOIN [Phone] ON [Personal_date].[Id] = [Phone].[Personal_date_id]) INNER JOIN [Phone_number] ON [Phone_number].[Id] = [Phone].[Phone_number_id]);", number), SqlConnection))
            {
                SqlDataReader reader_2 = cmd.ExecuteReader();
                int tempLength = 0;
                while (reader_2.Read())
                {
                    Array.Resize(ref people, people.Length + 1);
                    people[tempLength] = new PersonInfo(/*reader.GetInt32(0), */reader_2.GetString(1), reader_2.GetString(2), reader_2.GetInt32(3), reader_2.GetString(4));
                    tempLength++;
                }
            }
            SqlConnection.Close();

            for (int i = 0; i < people.Length; i++)
                Console.WriteLine($"{i + 1}) {people[i].ToString()}");
        }
    }
}
