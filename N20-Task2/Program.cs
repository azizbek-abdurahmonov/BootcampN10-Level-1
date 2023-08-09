namespace Task2
{
    class Program
    {
        static void Main()
        {
            var numbers = new int[] { 4, 1, 6, 2, 18 };
            FindMinMax(out var Min, out var Max, numbers);
            Console.WriteLine("Min: " + Min);
            Console.WriteLine("Max: " + Max);

        }

        static void FindMinMax(out int min, out int max, params int[] numbers)
        {
            min = numbers.Min();
            max = numbers.Max();
        }
    }
}
