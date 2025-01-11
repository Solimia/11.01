using _2ex;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 5, 8, 3, 10, 12, 7 };

        ArrayOperations operations = new ArrayOperations(arr);

        operations.ShowEven();
        operations.ShowOdd();
    }
}
