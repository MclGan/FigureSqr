using FigureSqr;
using System.Collections.Generic;

List<IFigure> figures = new List<IFigure> { new Circle(1), new Circle(3), new Triangle(4, 5, 6) };
foreach (var figure in figures)
{
    Console.WriteLine(figure.CalcSquare());
}
Console.ReadKey();

