using System;
using SmartPhone;

namespace ShowCase
{
    internal class Showcase
    {
        private const short NumOfPhones = 10;
        private Smartphone[] PhonesArray;
        private short OccupiedCellsNumber;

        public Showcase()
        {
            PhonesArray = new Smartphone[NumOfPhones];
            OccupiedCellsNumber = 0;
        }

        public void Add(Smartphone smartphone)
        {
            if (OccupiedCellsNumber <= 10)
            {
                PhonesArray[OccupiedCellsNumber] = smartphone;
                OccupiedCellsNumber++;
            }
            else
                Console.WriteLine("Smartphones no longer fit on the showcase!");
        }

        public void Delete(short num_of_phone)
        {
            if (num_of_phone <= 10)
            {
                Console.WriteLine($"You took this smartphone: {PhonesArray[num_of_phone]}");
                for (int i = num_of_phone; i < PhonesArray.Length - 1; i++)
                    PhonesArray[i] = PhonesArray[i + 1];
                Array.Resize(ref PhonesArray, PhonesArray.Length - 1);
                Console.WriteLine("Remained on the showcase:");
                Console.WriteLine(this);
            }
            else
                Console.WriteLine("There is no smartphone with such a number on the showcase!");
        }

        public override string ToString()
        {
            if (OccupiedCellsNumber == 0)
                return "None";
            string answer = String.Empty;
            for (short i = 0; i < PhonesArray.Length; i++)
                answer += $"{PhonesArray[i].Name}, {PhonesArray[i].Memory}Gb, {PhonesArray[i].Color}, {PhonesArray[i].Width}px, {PhonesArray[i].Height}px, {PhonesArray[i].Price}grn";
            return answer;
        }
    }
}
