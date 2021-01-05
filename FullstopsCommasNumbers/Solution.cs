using System;
using System.IO;
using System.Text;


namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            /* Да се състави програма, която чете последователно текстов файл знак по знак и прави статистика:
            1. Колко са точките и колко са запетайките
             2. Колко са целите числа (цяло число е всяка поредица от една или повече цифри до срещането на който и да е друг знак или край на файла)
            3. Преди да започне четенето, програмата пита потребителя за името на файла (пътя във файловата система, където се намира). */

            Console.Write("Въведeте път до файла: ");
            string path = Console.ReadLine();

            int fullstops = 0;
            int commas = 0;
            int numbers = 0;

            using(var f=File.OpenText(path))
            {
                while(!f.EndOfStream)
                {
                    bool inNumber = false;

                    char ch = (char)f.Read();

                    if (ch == '.')
                        ++fullstops;

                    if (ch == ',')
                        ++commas;

                    if (ch >= '1' && ch <= '9')
                    {
                        if (!inNumber)
                        {
                            inNumber = true;
                            ++numbers;
                        }
                    }
                    else
                        inNumber = false;

                }
                Console.WriteLine($"Точките: {fullstops} Запетайките: {commas} Числата: {numbers}");
            }
        }


    }
}
