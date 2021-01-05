using System;

using System.IO;



namespace Nxn_matrix

{

    class Program

    {
        static void ReadMatrix(double[,] matrix)

        {

            for (int i = 0; i < matrix.GetLength(0); i++)

            {

                for (int k = 0; k < matrix.GetLength(1); k++)

                {

                    matrix[i, k] = -1;

                }

            }

            using var s = File.OpenText(@"‪C:\Users\Raya\source\repos\TextFiles\TextFiles\bin\Debug\netcoreapp3.1\matrix.txt");

            {

                while(!s.EndOfStream)

                {

                    var line = s.ReadLine();

                    var elements = line.Split(new char[] { '\t' });

                    var i = int.Parse(elements[0]);

                    var k = int.Parse(elements[1]);

                    var value = int.Parse(elements[3]);

                    matrix[i - 1, k - 1] = value;

                }

            }

        }

        static void PrintMatrix(double[,] matrix)

        {

            for (int row = 0; row < matrix.GetLength(0); row++)

            {

                for (int col = 0; col < matrix.GetLength(1); col++)

                {

                    Console.WriteLine(matrix[row, col]);

                }

                Console.WriteLine();

            }

        }



        static void FindSums(int[,] matrix)

        {

            int oddsum = 0;

            int evensum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)

            {

                for (int k = 0; k < matrix.GetLength(1); k++)

                {

                    if (matrix[i,k]%2==0)

                    {

                       evensum += matrix[i, k];

                    }

                    else

                    {

                        oddsum += matrix[i, k];

                    }

                }



            }

        }

        static void FindSumLinesAndRows( int [,] matrix)

        {

            int rowsum = 0;

            int colsum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)

            {

                if((i%2)!=0)

                {

                    for (int k = 0; k < matrix.GetLength(1); k++)

                    {

                        rowsum += matrix[i, k];

                    }

                }

            }

            for (int i = 0; i < matrix.GetLength(1); i++)

            {

                if((i%2)==0)

                  {

                         for (int k = 0; k < matrix.GetLength(0); k++)

                        {

                        colsum += matrix[k, i];

                         }

                  }

            }

        }

        static void Main(string[] args)

        {


        }

    }

}
