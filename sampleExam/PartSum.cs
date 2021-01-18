using System;
using System.IO;
using System.Text;


namespace ConsoleApp4
{
    class StartUp
    {
        static void Main()
        {

            /*Да се състави програма, която пресмята частична сума на първите
              k члена на реда R (k е неизвестно), определен по следното правило:

            R = ∑Ai
            където     Ai= 1/(1+i^2)           i = 1..
            и където е изпълнено    Rk-R(k-1)<0.0001
             */
            double Rsum = 0;
            double aI = 0;
            Console.Write("Въведете: ");
            int k = int.Parse(Console.ReadLine());
            CheckComprasion(k);
            for (double i = 1; i <= k; i++)
            {
                aI = 1 / (1 + (i * i));
                Rsum += aI;             
            }
            Console.WriteLine("Сумата е {0}",Rsum);
            Console.ReadLine();
        }
       static bool CheckComprasion(double k)
        {
            bool check = false;
            if (k - (k - 1) < 0.0001)
            {
                check = true;
            }

            return check;
            
        }
    }
}
