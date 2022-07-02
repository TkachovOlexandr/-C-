using System;

namespace GeometricFigure
{
    internal class Circle : Figure
    {
        private float radius;

        public float Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public Circle() : base()
        {
            Radius = 0;
        }
        public Circle(float radius) : base(2 * (float)Math.PI * radius, (float)Math.PI * radius * radius)
        {
            this.Radius = radius;
        }
        public Circle(Circle square)
        {
            this.Perimeter = square.Perimeter;
            this.Square = square.Square;
            this.Radius = square.Radius;
        }

        public override string ToString()
        {
            return $"Radius: {Radius}\t{base.ToString()}";
        }
    }
}