namespace OverloadIndexerExtensionMehods;

internal class Program
{
    static void Main(string[] args)
    {
        Fraction fractionFirst = new Fraction(75, 45);
        Fraction fractionSecond = new Fraction(66, 11);

        Fraction fractionThird = fractionFirst + fractionSecond;
        Console.WriteLine(fractionThird);

        Fraction fractionFourth = fractionFirst - fractionSecond;
        Console.WriteLine(fractionFourth);

        Fraction fractionFiveth = fractionFirst * fractionSecond;
        Console.WriteLine(fractionFiveth);

        Fraction fractionSixth = fractionFirst / fractionSecond;
        Console.WriteLine(fractionSixth);

        Fraction fractionSeventh = ~fractionFirst;
        Console.WriteLine(fractionSeventh);

        MixedFraction mFirst = new MixedFraction( 12, fractionFirst);

        MixedFraction mSecond = new MixedFraction( 34, fractionSecond);

        Fraction mthi = mFirst * mSecond;
        Console.WriteLine(mthi);


    }



}




