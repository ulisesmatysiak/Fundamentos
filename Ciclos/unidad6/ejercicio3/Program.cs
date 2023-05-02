using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3. Hacer un programa para recibir listas de números positivos que están separadas entre sí por un cero. El fin de la carga se notifica con un número negativo. Luego mostrar cuántos números tiene cada lista.


            int n, con;

            Console.WriteLine("Comienzo del programa, ingrese un 0 para continuar");
            n = int.Parse(Console.ReadLine());

            while (n >= 0){

                Console.WriteLine("Ingrese el primer numero positivo de su primera lista, cuando termine todas las listas ingrese un numero negativo para terminar");

                n = int.Parse(Console.ReadLine());
                con = 0;

                while (n > 0){

                Console.WriteLine("Ingrese numeros positivos, termine la carga de esta lista con un 0");

                n = int.Parse(Console.ReadLine());
                con++;
                } // fin while chico

                Console.WriteLine("La cantidad de numeros de este grupo es " + con);
            } // fin while grande

            

        }
    }
}
