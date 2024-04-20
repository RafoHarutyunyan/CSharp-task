namespace FigureCalculator.Core.Exceptions;

public class ZeroException : ArgumentException
{
    public ZeroException(string? name) 
        : base("This parameter can't have a value equal to zero", name)
    {
    }
}
