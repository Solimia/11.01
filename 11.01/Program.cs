using System;
using _11._01;

class Program
{
    static void Main()
    {

        int[] arr = { 1, 5, 8, 3, 10, 12, 7 };

        ArrayOperations operations = new ArrayOperations(arr);

        int lessThanValue = 7;
        int lessCount = operations.Less(lessThanValue);
        Console.WriteLine($"Кількість елементів, менших за {lessThanValue}: {lessCount}");

        int greaterThanValue = 7;
        int greaterCount = operations.Greater(greaterThanValue);
        Console.WriteLine($"Кількість елементів, більших за {greaterThanValue}: {greaterCount}");
    }
}