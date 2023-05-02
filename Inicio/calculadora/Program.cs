using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            // paso 0: declarar variables
            // tipo de dato: int float char bool
            int n1, n2, resultado;

            // paso 1: pedir valores
            Console.WriteLine("Ingrese un numero: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro: ");
            n2 = int.Parse(Console.ReadLine());

            // paso 2: realizar calculo
            // + - * / %
            resultado = n1 + n2;

            // paso 3: emitir resultado
            Console.WriteLine("El resultado es: " + resultado);
        }
    }
}
