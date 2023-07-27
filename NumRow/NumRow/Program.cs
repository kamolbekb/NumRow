namespace Hometask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size: ");
            int n = int.Parse(Console.ReadLine());
            Treugolnik(n);
        }
        static void Treugolnik(int n)
        {
            for (int i = 0; i <=n; i++) {
                for(int j=1; j <= n-i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 2 * i - 1; j++) {
                    Console.Write("*");
                    
                }
                Console.WriteLine();
            }
        }
    }
}
