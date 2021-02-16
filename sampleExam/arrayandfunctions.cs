using System;
using System.IO;

namespace exam
{
    class Program
    {
        static void Main()
        {
            /*: Задача 1. Да се състави програма, която: (30 т.)
            1. Прочита от файл, чието име се въвежда от клавиатурата, едномерен масив от цели числа,
            разделени с по един интервал (space), и проверява:                                           
	        2. Дали масивът е сортиран в низходящ ред. (дали всеки два съседни елемента са равни или следващият е по-малък от предишния) 					
	        3. Има ли в масива тройки елементи с равни стойности и колко са те.  
            */

            Console.Write("Въведете пътя на файла:");
            string path = Console.ReadLine();
            int[] arr;
            var f = File.OpenText(path);           
            bool descdending = false;
            do
            {
                string[] line = f.ReadLine().Split(" ");
                arr = new int[line.Length];
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = int.Parse(line[i]);
                }              
            }
            while(!f.EndOfStream);

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] >= arr[i -1] )
                    descdending = true;
                else
                    descdending = false;
            }
            Console.WriteLine($"Масивът е сортиран низходящо: {descdending} ");

            bool triple = false;

            for (int i = 2; i < arr.Length; i++)
            {
                if ((arr[i] == arr[i - 1]) && (arr[i - 1] == arr[i - 2]))
                {
                    triple = true;
                    Console.WriteLine($"Тройка равни елементи се състоят от числото: {arr[i]}. ");
                }
            }
            if(triple==false)
                Console.WriteLine($"Няма тройка равни елементи");
            f.Close();
	}
    }
}
