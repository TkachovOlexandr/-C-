using System;

namespace GeometricFigure
{
    internal class Line : Figure
    {
        private float length;

        public float Length
        {
            get { return length; }
            set { length = value; }
        }

        public Line() : base()
        {
            Length = 0;
        }
        public Line(float length) : base(length, 0)
        {
            this.Length = length;
        }
        public Line(Line line)
        {
            this.Perimeter = line.Perimeter;
            this.Square = line.Square;
            this.Length = line.Length;
        }

        public override string ToString()
        {
            return $"Length: {Length}\t{base.ToString()}";
        }
    }
}