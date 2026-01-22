using System.ComponentModel.DataAnnotations;

namespace filePath
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kõik laulusõnad");

            DisplayThisFile();
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
