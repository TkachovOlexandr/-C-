using GeometricFigure;

Console.WriteLine("Line:\n");
Line line_1 = new Line();
Console.WriteLine(line_1);

Line line_2 = new Line((float)3.5);
Console.WriteLine(line_2);

Line line_3 = new Line(line_2);
Console.WriteLine(line_3);

Console.WriteLine("\nSquare:\n");
Square square_1 = new Square();
Console.WriteLine(square_1);

Square square_2 = new Square((float)5.5);
Console.WriteLine(square_2);

Square square_3 = new Square(square_2);
Console.WriteLine(square_3);

Console.WriteLine("\nCircle:\n");
Circle circle_1 = new Circle();
Console.WriteLine(circle_1);

Circle circle_2 = new Circle((float)8.1);
Console.WriteLine(circle_2);

Circle circle_3 = new Circle(circle_2);
Console.WriteLine(circle_3);

Console.WriteLine("\nArray of figures:\n");
Figure[] array_of_figures = new Figure[3];
array_of_figures[0] = new Line(line_3); ;
array_of_figures[1] = new Square(square_3); ;
array_of_figures[2] = new Circle(circle_3); ;

for (short i = 0; i < array_of_figures.Length; i++)
    Console.WriteLine(array_of_figures[i]);