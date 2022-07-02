using System;

namespace GeometricFigure
{
    internal class Figure
    {
        private float perimeter;
        private float square;

        public float Square
        {
            get { return square; }
            set { square = value; }
        }
        public float Perimeter
        {
            get { return perimeter; }
            set { perimeter = value; }
        }

        public Figure()
        {
            Perimeter = 0;
            Square = 0;
        }
        public Figure(float perimeter, float square)
        {
            this.Perimeter = perimeter;
            this.Square = square;
        }
        public Figure(Figure figure)
        {
            this.Perimeter = figure.Perimeter;
            this.Square = figure.Square;
        }

        public override string ToString()
        {
            return $"Perimeter: {Perimeter}\tSquare: {Square}";
        }
    }
}