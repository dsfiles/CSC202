namespace CSC202
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(100));
        }

        public static int Sum(int n)
        {
            if (n == 1)
                return 1;
            else
                return n + Sum(n - 1);
        }
    }
}
