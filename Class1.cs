using System;

namespace OverloadIndexerExtensionMehods;

internal static class Class1
{
    public static void ValidationMessage()
    {
        Console.WriteLine("Invalid input. Please enter a valid integer.");
    }

    public static int ReadIntegerWithValidation()
    {
        int num;
        while (!int.TryParse(Console.ReadLine(), out num))
        {
            ValidationMessage();
        }
        return num;
    }


    public static int ReadNonzeroIntegerWithValidation()
    {
        int den;
        while (!int.TryParse(Console.ReadLine(), out den) || den == 0)
        {
            ValidationMessage();
        }
        return den; 
    }
}

