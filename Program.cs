

namespace OverloadIndexerExtensionMehods;

internal class Program
{
    static void Main(string[] args)
    {


        /* {
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

             MixedFraction mFirst = new MixedFraction(12, fractionFirst);

             MixedFraction mSecond = new MixedFraction(34, fractionSecond);

             Fraction mthi = mFirst * mSecond;
             Console.WriteLine(mthi);

         } */

        string a = "hello";
        string b = "123";

        var c = 4234525.144444d;
        var d = 53445.555555f;
        var e = 44566543.345678765m;

        //int f = (int)b;// int f = (int)a; error can not convert
        bool g = int.TryParse(b, out  int f);
        Console.WriteLine(f);

    }
}




