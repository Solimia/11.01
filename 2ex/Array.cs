using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ex
{
    public class ArrayOperations : IOutput2
    {
        private int[] array;

        public ArrayOperations(int[] inputArray)
        {
            array = inputArray;
        }

        public void ShowEven()
        {
            Console.WriteLine("Парні значення:");
            foreach (int item in array)
            {
                if (item % 2 == 0)
                {
                    Console.WriteLine(item);
                }
            }
        }

        public void ShowOdd()
        {
            Console.WriteLine("Непарні значення:");
            foreach (int item in array)
            {
                if (item % 2 != 0)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
