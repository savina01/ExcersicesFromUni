using System;
using System.IO;
using System.Text;


namespace upr
{
    class StartUp
    {
        static void Main()
        {

            /*: Задача 1. Да се състави програма, която: (30 т.)
            1. Прочита от файл, чието име се въвежда от клавиатурата, едномерен масив от цели числа,
            разделени с по един интервал (space), и проверява:                                           
	        2. Дали масивът е сортиран в низходящ ред. (дали всеки два съседни елемента са равни или следващият е по-малък от предишния) 					
	        3. Има ли в масива тройки елементи с равни стойности и колко са те.  

            */

            Console.Write("Enter file path: ");
            string path = Console.ReadLine();
            string[] arr;
            int[] numbers;


            using(var f = File.OpenText(path))
            {
                while(!f.EndOfStream)
                {
                    arr = f.ReadLine().Split(' ');
                    numbers = new int[arr.Length];
                    for (int i = 0; i < arr.Length; i++)
                    {
                        
                        numbers[i] = int.Parse(arr[i]);
                        Console.Write(numbers[i]+ " ");                                               
                    }
                    
                    CheckDescending(numbers);
                    TrepleSameElements(numbers);

                }              
            }           
        }
        public static bool CheckDescending(int[] a)
        {
            bool descending = false;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] >= a[i+1])
                {
                    descending = true;
                }
                else
                {
                    break;                 
                } 
            }
            Console.WriteLine();
            if (descending == false)
                Console.WriteLine("Array is not sorted in descending order.");
            else
                Console.WriteLine("Array is sorted in descending order.");

            return descending;
        }
        public static bool TrepleSameElements(int[] a)
        {
            // Има ли в масива тройки елементи с равни стойности и колко са те.  

            bool treple = false;
            for (int i = 0; i < a.Length; i++)
            {

                if ((a[i] == a[i + 1]) && (a[i + 1] == a[i + 2]))                  
                {                       
                            treple = true;
                            Console.WriteLine($"The same elements are on index: {i}, {i + 1} and {i + 2}.");
                            Console.WriteLine($"The values are {a[i]} , {a[i + 1]} and {a[i + 2]}.");                       
                }                                                 
            }
            Console.WriteLine();
            if (treple == false)
                Console.WriteLine("In this array there is no treple same elements.");
            else
                Console.WriteLine("In this array there is treple same elements. ");

            return treple;
        }
    }         
}
