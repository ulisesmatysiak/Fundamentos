using System;

namespace ejemplos2
{
    class Program
    {
        static void Main(string[] args)
        {
            // EJEMPLO SUMA

            int n1, n2, resultado;

            Console.WriteLine("Ingrese un numero ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un numero ");
            n2 = int.Parse(Console.ReadLine());

            // logica
            // resultado = n1 + n2;

            resultado = sumar(n1,n2);

            // fin logica

            Console.WriteLine("El resultado es " + resultado);

            // scope
        }

        static int sumar (int a, int b){
            int r;
            r = a + b;
            return r;
        }

    }
}
