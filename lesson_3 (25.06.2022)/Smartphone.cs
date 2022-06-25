using System;

namespace SmartPhone
{
    internal class Smartphone
    {
        public string Name { get; set; }
        public short Memory { get; set; }
        public string Color { get; set; }
        public short Width { get; set; }
        public short Height { get; set; }
        public int Price { get; set; }

        public Smartphone ()
        {
            this.Name = String.Empty;
            this.Memory = 0;
            this.Color = String.Empty;
            this.Width = 0;
            this.Height = 0;
            this.Price = 0;
        }

        public Smartphone(string name, short memory, string color, short width, short height, int price)
        {
            this.Name = name;
            this.Memory = memory;
            this.Color = color;
            this.Width = width;
            this.Height = height;
            this.Price = price;
        }

        public Smartphone(Smartphone smartphone)
        {
            this.Name = smartphone.Name;
            this.Memory = smartphone.Memory;
            this.Color = smartphone.Color;
            this.Width = smartphone.Width;
            this.Height = smartphone.Height;
            this.Price = smartphone.Price;
        }

        public override string ToString()
        {
            return $"{Name}, {Memory}Gb, {Color}, {Width}px, {Height}px, {Price}grn";
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() + Memory.GetHashCode() + Color.GetHashCode() + Width.GetHashCode() + Height.GetHashCode() + Price.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj is Smartphone) return (obj as Smartphone).GetHashCode().Equals(this.GetHashCode());
            return false;
        }
    }
}
