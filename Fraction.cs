namespace OverloadIndexerExtensionMehods;

public readonly struct Fraction
{
    public readonly int num { get; }
    public  readonly int Den { get; }

    public Fraction(int num, int den)
    {
        if (den == 0)
        {
            throw new ArgumentException("Den can not be zero", nameof(den));
        }
        this.num = num;
        this.Den = den;
    }



    public static Fraction operator +(Fraction a, Fraction b)
    {
        return new Fraction(a.num * b.Den + b.num * a.Den, a.Den * b.Den);

    }

    public static Fraction operator -(Fraction a, Fraction b)
    {
        return new Fraction(a.num * b.Den - b.num * a.Den, a.Den * b.Den);
    }

    public static Fraction operator +(Fraction a) => a;
    //Fraction fraction = new Fraction(3, 4);
    //Fraction result = +fraction; // result will be the same as 'fraction'

    public static Fraction operator -(Fraction a) => new Fraction(-(a.num), a.Den);
    //Fraction fraction = new Fraction(3, 4);
    //Fraction result = -fraction; // result will be a new Fraction with numerator -3 and denominator 4


    public static Fraction operator *(Fraction a, Fraction b)
    {
        return new Fraction(a.num * b.num, a.Den * b.Den);
    }

    public static Fraction operator /(Fraction a, Fraction b)
    {
        if (b.num == 0)
        {
            throw new DivideByZeroException();
        }

        return new Fraction(a.num * b.Den, a.Den * b.num);
    }


    public override string ToString() => $"{num} / {Den}";

    public static Fraction operator ~(Fraction a)
    {
        int gcd = GCD(Math.Abs(a.num), a.Den);

        if (gcd > 1)
        {
            // Reduce the fraction by dividing both numerator and denominator by the GCD
            return new Fraction(a.num / gcd, a.Den / gcd);
        }

        // If GCD is 1, the fraction is already in reduced form
        return a;
    }

    // Helper method to find the greatest common divisor (GCD) using Euclidean algorithm
    private static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }


}


