using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3ex
{

    public class ArrayOperations : ICalc2
    {
        private int[] array;


        public ArrayOperations(int[] inputArray)
        {
            array = inputArray;
        }

        public int CountDistinct()
        {
            return array.Distinct().Count();
        }

        public int EqualToValue(int valueToCompare)
        {
            return array.Count(x => x == valueToCompare);
        }
    }
}
