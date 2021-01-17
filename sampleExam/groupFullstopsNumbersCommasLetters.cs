using System;
using System.IO;
using System.Text;


namespace ConsoleApp4
{
    class StartUp
    {
        static void Main()
        {

            /*Да се състави програма, която чете последователно от текстов файл знак по знак и прави статистика:  (20 т.)
            2.1. Колко са буквите и колко са цифрите   (5 т.)
            2.2. Колко са запетайките и колко са точките. (5 т.)
            2.3. Преди да започне четенето, програмата пита потребителя за името на файла (пътя във файловата система, където се намира). (10 т.)

            */
            Console.Write("Моля въведете пътя до файла: ");
            string path = Console.ReadLine();
           
            int letters = 0;
            int numbers = 0;
            int commas = 0;
            int fullstops = 0;

            using(var f=File.OpenText(path))
            {
                while (!f.EndOfStream)
                {
                    bool inNumber = false;
                    char ch = (char)f.Read();
                    if (ch == '.')
                        ++fullstops;
                    if (ch == ',')
                        ++commas;
                    if(ch>='1'&& ch<='9')
                    {
                        if(!inNumber)
                        {
                            inNumber = true;
                            ++numbers;
                        }
                    }
                    else
                        inNumber = false;

                    if (ch >= 'a' && ch <= 'z')
                        ++letters;
                    
                }
                Console.WriteLine("Запетайки:{0}, Точки:{1}, Числа:{2}, Букви:{3}",commas,fullstops,numbers,letters);
            }

            Console.ReadLine();

        }
       
    }
}
