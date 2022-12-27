namespace hw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, r2, r4, r6;
            n = int.Parse(Console.ReadLine());

            r2 = (n / 10000) % 10;
            r4 = (n / 100) % 10;
            r6 = n % 10;
            double pow_r2 = Math.Pow(r2, 2);
            double pow_r4 = Math.Pow(r4, 2);
            double pow_r6 = Math.Pow(r6, 2);
            double sum = pow_r2 + pow_r4 + pow_r6;
            Console.WriteLine(sum);
        }
    }
}