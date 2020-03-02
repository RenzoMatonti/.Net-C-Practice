using System;

namespace ReadFile {
    class Program {
        public static void Main(string[] args)
        {
            int cantidad = 0;
            string linea;

            // Location of the file to read
            string filename = "C:\\test.txt";

            // Read the file and display it line by line

            System.IO.StreamReader file = new System.IO.StreamReader(filename);

            while ((linea = file.ReadLine()) != null) {

                Console.WriteLine(cantidad + 1 + ". " + linea);
                cantidad++;
            }

            file.Close();
            Console.WriteLine();
        }
    }
}
