namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 6, P, S;
            GetArea(a, b, out P, out S);
            Console.WriteLine($"P = {P}");
            Console.WriteLine($"S = {S}");

        }

        static void GetArea(int a, int b, out int P, out int S)
        {
            P = 2 * (a + b);
            S = a * b;
        }
    }
}