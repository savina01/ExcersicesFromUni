using System;
using System.IO;
using System.Text;


namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            /* Създайте приложение, което работи с матрица от цели числа с размер N x N (N се въвежда от потребителя), като приложението прави следното:

            v Инициализира елементите на матрицата от текстови файл по следния начин: всеки ред от файла се състои от 
            3 числа разделени от символа tab ('\t'); първите две числа представят номер на ред и стълб, а третото стойността на елемента; 
            ако за даден елемент няма ред със стойност, стойността на елемента да е равна на -1.
            v Отпечатва матрицата на екрана
            v Намира сумата на четните и сумата на нечетните елементи на матрицата
            v Намира сумата на елементите от четните редове на матрицата и сумата на елементите от нечетните колони

            */

            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            for (int row = 0; row < n; row++)
                for (int col = 0; col < n; col++)
                    matrix[row, col] = -1;

           using(var f=File.OpenText(@"matrix.txt"))
            {
                var valuesSTr = f.ReadLine().Split('\t');
                int r = int.Parse(valuesSTr[0]);
                int c = int.Parse(valuesSTr[1]);
                int value = int.Parse(valuesSTr[2]);
            }

           for(int row =0;row<n;++row)
            {
                for (int col=0;col<n;++col)
                {
                    Console.Write(matrix[row,col] + '\t');
                }
                Console.WriteLine();
            }
            int sumEven = 0;
            int sumOdd = 0;
            int sumOnEvenRows = 0;
            int sumOnOddCols = 0;

            for (int row = 0; row < n; row++)
            
                for(int col=0;col<n;++col)
                {
                    if (matrix[row, col] % 2 == 0)
                    {
                        sumEven += matrix[row, col];
                    }
                    else
                        sumOdd += matrix[row, col];
                    if (row % 2 == 0)
                        sumOnEvenRows += matrix[row, col];
                    else if (col % 2 != 0)
                        sumOnOddCols += matrix[row, col];
                }

            Console.WriteLine($"SumEven: {sumEven}, SumOdd: {sumOdd}, SumOnEvenrows: {sumOnEvenRows}, SumOnOddCol: {sumOnOddCols}");
            
        }


    }
}
