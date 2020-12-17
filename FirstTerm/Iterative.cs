using System;

namespace ConsoleApp3
{
    class Program
          //Iterative
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете член от редицата: ");
            int n = int.Parse(Console.ReadLine());
            if (n==1)
            {
                Console.WriteLine(2);
            }
            else if(n==2)
            {
                Console.WriteLine(4);
            }
            else if (n==3)
            {
                Console.WriteLine(6);
            }
            else if (n>=4)
            {
                int a1 = 2;
                int a2 = 4;
                int a3 = 6;
                int res = 0;
                for(int i = 4;i<=n;++i)
                {
                    res = 3 * a1 + 4 * a2 - 7 * a3;
                    a1 = a2;
                    a2 = a3;
                    a3 = res;
                }
                Console.WriteLine("Членът е {0}", res);
            }
        }
    }
}
