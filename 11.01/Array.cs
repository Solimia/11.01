using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._01
{

    public class ArrayOperations : ICalc
    {
        private int[] array;

        public ArrayOperations(int[] inputArray)
        {
            array = inputArray;
        }


        public int Less(int valueToCompare)
        {
            int count = 0;
            foreach (int item in array)
            {
                if (item < valueToCompare)
                {
                    count++;
                }
            }
            return count;
        }

        public int Greater(int valueToCompare)
        {
            int count = 0;
            foreach (int item in array)
            {
                if (item > valueToCompare)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
