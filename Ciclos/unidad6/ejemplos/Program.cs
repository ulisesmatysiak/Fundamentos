using System;

namespace ejemplos
{
    class Program
    {
        static void Main(string[] args)
        {
            int prom, acu, n;

            //FOR CON FOR
            // for (int y = 0; y < 10; y++)
            // {
            //     acu = 0;
            //     for (int x = 0; x < 20; x++)
            //     {
            //         Console.WriteLine("Ingrese la edad de: ");
            //         n = int.Parse(Console.ReadLine());
            //         acu += n;
            //     }
            //     prom = acu/20;
            //     Console.WriteLine("El promedio es: " + prom);
            // }

            //FOR CON WHILE
            // for (int x = 0; x < 10; x++)
            // { 
            //     Console.WriteLine("Ingrese la edad: ");
            //     n = int.Parse(Console.ReadLine());
            //     acu = 0;
            //     con = 0;
            //     while (n != 0) {
            //         acu += n;
            //         con++;
            //         Console.WriteLine("Ingrese la edad");
            //         n = int.Parse(Console.ReadLine());
            //     }
            //     prom = acu/con;
            //     Console.WriteLine("El promedio es: " + prom);
            // }

            //WHILE CON FOR
            // Console.WriteLine("ingrese 1 para comenzar a procesar o 0 para terminar");
            // n = int.Parse(Console.ReadLine());
            // while (n != 0){
            //     acu = 0;
            //     for (int x = 0; x < 20; x++)
            //     {
            //         Console.WriteLine("Ingrese la edad: ");
            //         n = int.Parse(Console.ReadLine());
            //         acu += n;    
            //     }

            //     prom = acu/20;
            //     Console.WriteLine("El promedio es: " + prom);

            //     Console.WriteLine("ingrese 1 para comenzar a procesar o 0 para terminar");
            //     n = int.Parse(Console.ReadLine());
            // }

            // WHILE CON WHILE
            Console.WriteLine("Ingrese la edad: ");
            n = int.Parse(Console.ReadLine());
            while (n > 0){

                acu = 0;
                con = 0;
                while (n 1= 0){
                    acu += n;
                    con++;
                    Console.WriteLine("Ingrese la edad: ");
                    n = int.Parse(Console.ReadLine());
                }
                prom = acu/con;
                Console.WriteLine("El promedio es: " + prom);

                Console.WriteLine("Ingrese la edad para continuar o un numero negativo para cortar");
                n = int.Parse(Console.ReadLine());
            }
        }
    }
}
