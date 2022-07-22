namespace SQL_4
{
    internal class PersonInfo
    {
        private int id;
        private string person_name;
        private string person_surname;
        private int person_age;
        private string person_number;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
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

        private PersonInfo() { }
        public PersonInfo(int id, string person_name, string person_surname, int person_age, string person_number)
        {
            this.Id = id;
            this.Person_name = person_name;
            this.Person_surname = person_surname;
            this.Person_age = person_age;
            this.person_number = person_number;
        }

        public override string ToString()
        {
            return $"#{Id} Name: {Person_name}; Surname: {Person_surname}; Age: {Person_age}; Phone number: {Person_number}\n";
        }
    }
}
