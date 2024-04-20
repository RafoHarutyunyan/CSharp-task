namespace FigureCalculator.Core.Exceptions;

public class TriangleException : ArgumentException
{
    public TriangleException() 
        : base("Triangle with this sides doesn't exists")
    {
    }
}
