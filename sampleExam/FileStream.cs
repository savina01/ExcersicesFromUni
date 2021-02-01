using System;
using System.IO;


namespace upr
{
    class StartUp
    {
        static void Main()
        {
            using(FileStream f=File.Open(@"C:\Users\Raya\source\repos\ConsoleApp4\bin\Debug\netcoreapp3.1\text.txt",FileMode.Open))
            {
                using (var r = new StreamReader(f))
                {
                    int wordCount = 0;
                    int numberCount = 0;
                    char[] symbols;
                    string line;
                    int sumWordsAllLines = 0;
                    int sumNumbersAllLines = 0;                                    

                    while ((line = r.ReadLine()) != null)
                    {
                        if (line == "")
                            break;
                        symbols = new char[200];
                        for (int i = 0; i < line.Length; i++)
                            symbols[i] = line[i]; 
                        
                        wordCount = CountWords(line);
                        sumWordsAllLines += wordCount;

                        numberCount = NumbersCount(line);
                        sumNumbersAllLines = sumNumbersAllLines+numberCount;
                        Console.WriteLine(line);
                        
                    }
                                       
                    Console.WriteLine("The words in the text are {0}", sumWordsAllLines);

                    if(sumNumbersAllLines==0)
                        Console.WriteLine("There is no digits");
                    
                    else if(sumNumbersAllLines>0)
                        Console.WriteLine("Digits in text are {0}",sumNumbersAllLines);                 
                }                
            }
            LettersCount();
            Console.ReadLine();
        }

        public static int CountWords(string line)
        {
            var wordCount = 0;
            for (var i = 0; i < line.Length; i++)
                if (line[i] == ' ' || i == line.Length-1)
                    wordCount++;
            return wordCount;
        }
        public static int NumbersCount(string line)
        {
            var numbersCount = 0;          
            foreach (var digit in line)
            {
                if (digit >= '1' && digit <= '9')
                    ++numbersCount;                   
            }
            return numbersCount;
        }
    
        public static void LettersCount()
        {
            int[] c = new int[(int)char.MaxValue];
            string s = File.ReadAllText(@"C:\Users\Raya\source\repos\ConsoleApp4\bin\Debug\netcoreapp3.1\text.txt");
            foreach (char t in s)
            {
                c[(int)t]++;
            }
            for (int i = 0; i < (int)char.MaxValue; i++)
            {
                if (c[i] > 0 )
                    if(char.IsLetter((char)i))
                    {
                        Console.WriteLine("Letter: '{0}'  Frequency: {1}",(char)i, c[i]);
                    }
            }
        }
    }         

}
