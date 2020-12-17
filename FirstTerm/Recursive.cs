using System;

namespace hw
{
    class Program
    {
    
        //recursive
        static int memofnum(int n)
        {
            int a1 = 2;
            int a2 = 4;
            int a3 = 6;
            int an;
            if (n == 1)
            {
                return a1;
            }
            if (n == 2)
            {
                return a2;
            }
            if (n == 3)
            {
                return a3;
            }
            else
            {
                return an = 3 * memofnum(n - 3) + 4 * memofnum(n - 2) - 7 * memofnum(n - 1);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Въведете кой член търсите:");
            int n = int.Parse(Console.ReadLine());
            int num = memofnum(n);
            Console.WriteLine("Член {0} e {1}", n, num);
            Console.ReadLine();

        }
    }
}
