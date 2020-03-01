using System;

namespace Calculator {
    class Program {
        static void Main(string[] args)
        {

            // Variables
            int num1 = 0;
            int num2 = 0;
            bool salir = false;
            int opcion;
            bool invop = false;
            
            while (!salir) {


                Console.Clear();

                Console.WriteLine("Welcome to the calculator");

                Console.WriteLine("");

                Console.WriteLine("Ingrese 2 numeros");

                num1 = Int32.Parse(Console.ReadLine());
                num2 = Int32.Parse(Console.ReadLine());

                
                Console.WriteLine("");

                Console.WriteLine("1 - Suma");

                Console.WriteLine("2 - Resta");

                Console.WriteLine("3 - Multiplicacion");

                Console.WriteLine("4 - Division");

                Console.WriteLine("0 - Salir");

                Console.WriteLine("");

                

                while (!invop) { 
                    opcion = Int32.Parse(Console.ReadLine());


                    switch (opcion) {

                        case 1:
                            Console.WriteLine(Math.Suma(num1, num2));
                            invop = true;
                            break;

                        case 2:
                            Console.WriteLine(Math.Resta(num1, num2));
                            invop = true;
                            break;

                        case 3:
                            Console.WriteLine(Math.Multiplicacion(num1, num2));
                            invop = true;
                            break;

                        case 4:
                            Console.WriteLine(Math.Division(num1, num2));
                            invop = true;
                            break;

                        case 0:
                            salir = true;
                            invop = true;
                            break;

                        default:
                            Console.WriteLine("Opcion invalida");
                            break;
                    }
                }

                Console.ReadLine();

            }

        }
    }
}
