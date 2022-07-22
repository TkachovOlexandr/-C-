namespace SQL_4
{
    internal class PhoneBook
    {
        public PhoneBook() { }

        public void Add(string person_name, string person_surname, int person_age, string person_number)
        {
            PersonInfo personInfo = new PersonInfo(person_name, person_surname, person_age, person_number);
            personInfo.Add();
        }

        public void Delete(int id)
        {
            PersonInfo personInfo = new PersonInfo();
            personInfo.Delete(id);
        }

        public void Show()
        {
            PersonInfo personInfo = new PersonInfo();
            Console.WriteLine();
            personInfo.Show();
        }
    }
}
