namespace N22_HT1
{
    class Program
    {
        static void Main()
        {
            var numbers = new List<int> { 11, 4, 1, 5, 67, 5, 7, 13, 90 };

            numbers.Where(number => IsPrime(number)).ToList().OrderDescending().ToList().ForEach(Console.WriteLine);
        }

        static bool IsPrime(int number)
        {
            for (var i = 2; i < Math.Sqrt(number) + 1; i++)
                if (number % i == 0)
                    return false;
            return true;
        }
    }
}