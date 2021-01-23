using System;
using System.IO;
using System.Text;


namespace upr
{
    class StartUp
    {
        static void Main()
        {

            /*: Да се състави програма, която използва квадратна матрица с елементи от тип int и с
             * размери 0<N<10 и реализира следните операции. (20 т.)
	           Осигурява въвеждане от клавиатурата на горна триъгълна матрица от цели числа 
            (елементите под главния диагонал са нули и НЕ се въвеждат от потребителя). 
            Размерът на матрицата се въвежда от клавиатурата предварително (М<=N). (10 т.)
	        Намира максималният елемент за всеки стълб и го поставя в друг едномерен масив. (5 т.)
	        Намира максималната и минимална стойност в получения по т.1.2. масив и отпечатва намерените стойности. (5 т)
            */         

            Console.Write("Matrix size: ");

            int n = int.Parse(Console.ReadLine());     
            int[,] matrix = new int[n, n];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (row <= col)
                    {
                        Console.Write($"matrix[{row},{col}]: ");
                        matrix[row, col] = int.Parse(Console.ReadLine());
                    }
                    else
                    {
                        matrix[row, col] = 0;
                    }                 
                }
            }
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(matrix[row,col] + "\t");
                }
                Console.WriteLine();
            }
            // Намира максималният елемент за всеки стълб и го поставя в друг едномерен масив. (5 т.)
            int[] maxes = new int[n];
            
            for (int col = 0; col < n; col++)
            {
                int max = matrix[0, col];

                for (int row = 0; row < n; row++)
                {
                    max = Math.Max(max, matrix[row, col]);
                }
                maxes[col] = max;
                Console.WriteLine($"Максималния елемент за {col} стълб = {max}.");

            }           
            int largest = 0;
            int smallest = 0;
            foreach (var el in maxes)
            {
                Console.Write(el + ", ");            
            }
            Console.WriteLine();

            for (int i = 0; i < maxes.Length; i++)
            {
               if(maxes[i]>maxes[0])
                {
                    largest = maxes[i];
                }
                else
                {
                    smallest = maxes[i];
                }
            }
            Console.WriteLine($"Максималната стойност в масива е {largest} ");
            Console.WriteLine($"Минималната стойност в масива е {smallest} ");           
            //    Намира максималната и минимална стойност в получения по т.1.2. масив и отпечатва намерените стойности.          
        }
    }         
}
