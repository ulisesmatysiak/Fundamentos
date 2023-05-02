using System;

namespace ejemplos_while
{
    class Program
    {
        static void Main(string[] args)
        {
            // CICLO WHILE 
            // mientras
            // while (true)...

            //mientras ( n sea distinto de 0)


            int n, con = 0;

            Console.WriteLine("Ingrese un nro: ");
            n = int.Parse(Console.ReadLine());
            while(n != 0){
                con++;
                Console.WriteLine("Ingrese un nro: ");
                n = int.Parse(Console.ReadLine());   
            }

            Console.WriteLine("Ingrsaste: " + n + " numeros");

        }
    }
}
