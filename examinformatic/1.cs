using System;
using System.IO;

namespace ExamSolution
{
    class Program
    {
        static void Main()
        {
            string path = Console.ReadLine();
            var array = ReadArrayFromFile(path);
            ReverseInplace(array);
            MostCommonCount(array);
            /*Да се състави програма, която има следните функции: (общо 30 т.)
            1.Функция ReadArrayFromFile, която прочита от файл, чието име се въвежда от стандартния
            вход, едномерен масив от цели числа, разделени със запетаи, и връща този масив. (10 т.)
            2.Функция ReverseInplace, която обръща реда на елементите в масива, без да използва втори
            масив(например { 1, 2, 3, 4}
            става { 4, 3, 2, 1}) (10 т.)
            3.Функция MostCommonCount, която връща колко пъти се среща най - често срещаният елемент в
            масива.
            */

        }
        static int[] ReadArrayFromFile(string path)
        {

            string[] arr;
            int[] elements;
            var f = File.OpenText(path);
            arr = f.ReadLine().Split(',');
            elements = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                elements[i] = int.Parse(arr[i]);
                Console.Write(elements[i] + " ");
            }

            f.Close();
            return elements;
        }
        static void ReverseInplace(int[] numbers)
        {
            int length = numbers.Length;
            int[] reversed = new int[length];
            for (int i = 0; i < length; i++)
            {
                reversed[length - i - 1] = numbers[i];

            }
            Console.WriteLine();
            for (int i = 0; i < length; i++)
            {
                Console.Write(reversed[i] + " ");
            }
        }
        static int MostCommonCount(int[] arr)
        {
            int counter = 1; // Главен брояч
            for (int i = 0; i < arr.Length; i++)
            {
                int tempCounter = 1; // Временен брояч, който е за всеки случай - най-накрая ако е по-голям от главния, на главния се присвоява числото от временния
                for (int j = 0; j < arr.Length; j++)
                {
                    if (i != j)
                    {
                        if (arr[i] == arr[j]) // Проверява всеки елемент от масива дали има друг, който да е равен
                            tempCounter++;
                    }
                }
                if (tempCounter > counter)
                    counter = tempCounter;
            }
            return counter;
        }
    }
}
