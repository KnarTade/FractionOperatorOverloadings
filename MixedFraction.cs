namespace OverloadIndexerExtensionMehods;

public readonly struct MixedFraction 
{
    private readonly int wholeNumber;
    private readonly Fraction fraction;
    //private readonly int num;
    //private readonly int den;

    //public MixedFraction(int a, int b, int c)
    //{
    //    if (a == 0 || c == 0)
    //    {
    //        throw new ArgumentException("Whole number and denominator cannot be zero.");
    //    }

    //    this.wholeNumber = a;
    //    this.num = b;
    //    this.den = c;
    //}

    public MixedFraction(int a, Fraction b)
    {
        if (a == 0 || b.Den == 0)
        {
            throw new ArgumentException("Whole number and denominator cannot be zero.");
        }

        this.wholeNumber = a;
        this.fraction = b;
    }

    public static Fraction operator *(MixedFraction first, MixedFraction second) 
    {
        Fraction firstFraction = new Fraction(first.wholeNumber * first.fraction.Den + first.fraction.num, first.fraction.Den);
        Fraction secondFraction = new Fraction(second.wholeNumber * second.fraction.Den + second.fraction.num, second.fraction.Den);
        return new Fraction (firstFraction.num * secondFraction.num, firstFraction.Den * secondFraction.Den);
    
    
    }
}

