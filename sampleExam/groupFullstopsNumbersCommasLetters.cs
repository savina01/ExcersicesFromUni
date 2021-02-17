using System;
using System.IO;

namespace exam
{
    class Program
    {
        static void Main()
        {
            /*: Да се състави програма, която чете последователно от текстов файл знак по знак и прави статистика:  (   
            2.1. Колко са буквите и колко са цифрите    
            2.2. Колко са запетайките и колко са точките.   
            2.3. Преди да започне четенето, програмата пита потребителя за името на файла (пътя във файловата система, където се намира).   
            */
            Console.Write("Въведете пътя до файла: ");
            string path = Console.ReadLine();
            if(!File.Exists(path))
            {
                Console.WriteLine("Файлът не съществува.");
            }
            else
            {
                using (var f = File.OpenText(path))
                {
                    string text="";
                    int lettersCount = 0;
                    int digitsCount = 0;
                    int commas = 0;
                    int fullstops = 0;

                    while(!f.EndOfStream)
                    {
                        string line = f.ReadLine();
                        text += line;
                    }
                    foreach (var c in text)
                    {
                        if((c>='a' && c<='z') || (c>='A' && c<= 'Z'))
                            ++lettersCount;
                        if (c >= '1' && c <= '9')
                            ++digitsCount;
                        if (c == ',')
                            ++commas;
                        if (c == '.')
                            ++fullstops;

                    }
                    Console.Write("Статистика: ");
                    Console.WriteLine($"Букви: {lettersCount} , цифри: {digitsCount} , запетайки: {commas} , точки: {fullstops}");
                }
            }
            Console.ReadLine();

        }

    }
}
