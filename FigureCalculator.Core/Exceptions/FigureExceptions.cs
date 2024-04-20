namespace FigureCalculator.Core.Exceptions;

public static class FigureExceptions
{
    public static void ThrowNegativeOrZero(double value, string parameter)
    {
        if (value < 0d)
            throw new NegativeException(parameter);
        if (value == 0d)
            throw new ZeroException(parameter);
    }
}
