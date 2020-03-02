using System;
using System.IO;

/*
  A program that reads a file with words like:

    Dog
    amulet
    outside
    Arnold

  And it creates a file as result that shows how many words on he files starts with a vocal

    A = 2
    E = 0
    I = 0
    O = 1
    U = 1

*/

namespace AmountOfVocals {
    class Program {
        static void Main(string[] args)
        {
            // Location of the file
            string filename = "C:\\Words.txt";

            string line;
            string[] vocals = { "A", "E", "I", "O", "U" };
            int[] count = new int[5];
            bool read = false;

            try
            {
                // File to read
                System.IO.StreamReader file = new System.IO.StreamReader(filename);

                while ((line = file.ReadLine()) != null)
                {
                    read = false;
                    for (int i = 0; i < vocals.Length && !read; i++)
                    {
                        string letter = line[0].ToString();

                        if (letter.ToUpper() == vocals[i])
                        {
                            count[i]++;
                            read = true;
                        }
                    }
                }

                file.Close();
            }
            catch (System.IO.FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {

                //Result path
                string outputPath = "C:\\Users\\zblac\\Desktop";

                if (File.Exists(outputPath)) {
                    File.Delete(outputPath);
                }

                try
                {
                    using (StreamWriter outputFile = new StreamWriter(Path.Combine(outputPath, "Result.txt")))
                    {

                        for (int i = 0; i < count.Length; i++)
                        {
                            outputFile.WriteLine(vocals[i] + " = " + count[i]);
                        }
                        outputFile.Close();
                    }
                }
                catch (Exception e) {
                    Console.WriteLine(e.Message);
                }
            }

            
        }
    }
}
