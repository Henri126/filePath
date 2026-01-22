using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace filePath
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kõik laulusõnad");

            //&DisplayThisFile();

            FindWord("Hallo");
        }

        public static void FindWord(string findThisWord)
        {
            using (StreamReader readFile = new StreamReader(
                "C:\\Users\\opilane\\Source\\Repos\\Henri126\\filePath\\filePath\\hh.txt"
              ))
            {
                int lnr = 0;
                while (readFile.EndOfStream == false)
                {
                    string line = readFile.ReadLine();
                    lnr++;
                    
                    if (line.Contains(findThisWord) == true)
                    {
                        Console.WriteLine(findThisWord + "leiti reast" + lnr);
                    }
                }
                readFile.Close();
            }
        }


        private static void DisplayThisFile()
        {
            string line = "";
            try
            {
                using (StreamReader readThisThing = new StreamReader
                    ("C:\\Users\\opilane\\Source\\Repos\\Henri126\\filePath\\filePath\\hh.txt") )
                {
                    int lineCount = 0;
                    while (readThisThing.EndOfStream == false)
                    {
                        lineCount++;    
                        line = readThisThing.ReadLine();
                        int pikkus = line.Length;
                        Console.WriteLine(lineCount + " " + line+" , Reapikkus on" + pikkus);
                    }
                    readThisThing.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Ei saa lugeda sest: " + e.Message);
                throw;
            }
        }
    }
}
