using System;

namespace _3ex
{


    class Program
    {
        static void Main()
        {
            int[] arr = { 1, 5, 8, 3, 10, 12, 7, 5, 8 };

            ArrayOperations operations = new ArrayOperations(arr);

            int distinctCount = operations.CountDistinct();
            Console.WriteLine($"Кількість унікальних значень: {distinctCount}");

            int valueToCompare = 8;
            int equalCount = operations.EqualToValue(valueToCompare);
            Console.WriteLine($"Кількість значень, рівних {valueToCompare}: {equalCount}");
        }
    }

}