namespace Models.Civilization
{
    internal class Human
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public short age { get; set; }
        public string number { get; set; }

        public Human()
        {
            firstName = string.Empty;
            lastName = string.Empty;
            gender = string.Empty;
            age = 0;
            number = string.Empty;
        }

        public Human(string _firstName, string _lastName, string _gender, short _age, string _number)
        {
            firstName = _firstName;
            lastName = _lastName;
            gender = _gender;
            age = _age;
            number = _number;
        }

        public override string ToString()
        {
            return $"{firstName} {lastName} ({gender}, {age}yo, phone number: {number})";
        }
    }
}
