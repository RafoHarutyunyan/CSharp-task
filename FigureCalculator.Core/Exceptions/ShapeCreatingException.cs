namespace FigureCalculator.Core.Exceptions;

public class ShapeCreatingException : ArgumentException
{
    public ShapeCreatingException(string name, string type) 
        : base($"Can't create Shape of this type '{type}'",
        name)
    {
    }
}
