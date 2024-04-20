namespace FigureCalculator.Core.Exceptions;

public class NegativeException : ArgumentException
{
    public NegativeException(string? name) 
        : base(
        "This parameter can't have a value less than zero.", name)
    {
    }
}
