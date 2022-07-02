using System;

namespace GeometricFigure
{
    internal class Square : Figure
    {
        private float side;

        public float Side
        {
            get { return side; }
            set { side = value; }
        }

        public Square() : base()
        {
            Side = 0;
        }
        public Square(float side) : base(side * 4, side * side)
        {
            this.Side = side;
        }
        public Square(Square square)
        {
            this.Perimeter = square.Perimeter;
            this.Square = square.Square;
            this.Side = square.Side;
        }

        public override string ToString()
        {
            return $"Side: {Side}\t{base.ToString()}";
        }
    }
}