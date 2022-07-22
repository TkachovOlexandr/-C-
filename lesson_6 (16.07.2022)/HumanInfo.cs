namespace WorkWithHuman
{
    internal class HumanInfo
    {
        private string personeName;
        private int age;
        Predicate<int> predicate = (x) => x >= 18;

        public string PersoneName
        {
            get { return personeName; }
            set { personeName = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public HumanInfo()
        {
            PersoneName = new String("Unknown");
            Age = 0;
        }
        public HumanInfo(string personeName, int age)
        {
            this.PersoneName = personeName;
            this.Age = age;
        }

        public void ShowAdults()
        {
            if (predicate(Age))
                Console.Write($"{PersoneName} ");
        }

        public void ShowHumans(Predicate<int> predicate_1)
        {
            if (predicate_1(Age))
                Console.Write($"{PersoneName} ");
        }
        public void ShowHumans(Predicate<string> predicate_1)
        {
            if (predicate_1(PersoneName))
                Console.Write($"{PersoneName} ");
        }
    }
}
