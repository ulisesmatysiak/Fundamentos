using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Hacer un programa para ingresar 10 números. El mismo debe analizar y mostrar por pantalla cuántos de esos números son primos.


            int n, con = 0;


            for (int x = 0; x < 10; x++)
            
            {
                Console.WriteLine("Ingrese un nro");
                n = int.Parse(Console.ReadLine()); 

                con = 0;

                for (int y = 1; y < n; y++)
                { 
                    if (n % y == 0)
                    {
                         con++;
                    }
                }
            }

            Console.WriteLine("Los numeros primos son: " + con);
        }
    }
}
