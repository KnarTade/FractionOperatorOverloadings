using ConsoleFractionCalculation;
using System.Security.Cryptography.X509Certificates;

namespace OverloadIndexerExtensionMehods;

internal class Program
{
    static void Main(string[] args)
    {
        //    Console.WriteLine("Write 2 numbers");

        //    string x = Console.ReadLine();

        //    string[] y = x.Split('/');

        //    Fraction fractionFirst = new Fraction(char.Parse(y[0]), char.Parse(y[1]));


        //    Console.WriteLine("Write 2 numbers");

        //    string second = Console.ReadLine();

        //    string[] s = x.Split('/');

        //    Fraction fractionSecond = new Fraction(char.Parse(y[0]), char.Parse(y[1]));

        //    char symboll = '+';

        //  static double Gumarum (Fraction fractionFirst, Fraction fractionSecond,char symboll)
        //    {
        //        double x =


        //        return fractionFirst + fractionSecond;
        //    }
        //}
        ReadOnlyStruct readOnlyStruct = new ReadOnlyStruct(5, "arajin");
        ReadOnlyStruct readOnlyStruct2 = new ReadOnlyStruct(6, "erkrord");
         
        readOnlyStruct2 = readOnlyStruct;
        Console.WriteLine($"{readOnlyStruct2.ReadonlyField}");


    }
}



