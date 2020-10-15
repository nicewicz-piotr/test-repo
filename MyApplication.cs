using static System.Console;
using System;

namespace Arguments
{

class Program
{

    static void Main(string[] args)
    {
        WriteLine($"Otrzymano {args.Length} argumentów");

        foreach (var item in args)
        {
            WriteLine($"Argument {item}");
        }

        try
        {
            ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), args[0], true);
            BackgroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), args[1], true);
            WindowWidth = int.Parse(args[2]);
            WindowHeight = int.Parse(args[3]);
        }

        catch(System.IndexOutOfRangeException)
        {
              WriteLine("Index was outside the bounds of the array.");  
        }

        WriteLine($"Typ int zajmuje {sizeof(int)} bajtów i może przechowywać liczby z zakresu:\n {int.MaxValue} do {int.MinValue}");
        WriteLine($"Typ double zajmuje {sizeof(double)} bajtów i może przechowywać liczby z zakresu:\n {double.MaxValue:NO} do {double.MinValue:NO}");
        WriteLine($"Typ decimal zajmuje {sizeof(decimal)} bajtów i może przechowywać liczby z zakresu:\n {decimal.MaxValue:NO} do {decimal.MinValue:NO}");



    }

}

}