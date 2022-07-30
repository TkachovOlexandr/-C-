using System.Data.SqlClient;

namespace SQL_6
{
    internal class PhoneBook
    {
        private List<string> allPhoneNumbers;

        public List<string> AllPhoneNumbers
        {
            get { return allPhoneNumbers; }
            set { allPhoneNumbers = value; }
        }

        public PhoneBook() 
        {
            this.AllPhoneNumbers = new List<string>();

            PersonInfo personInfo = new PersonInfo();
            int myLength = personInfo.HowManyRows();
            for (int i = 0; i < myLength; i++)
            {
                PersonInfo person = personInfo.Find(i);
                AllPhoneNumbers.Add(person.Person_number);
            }
        }

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
            personInfo.Show();
        }
    }
}