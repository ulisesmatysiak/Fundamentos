using System;

namespace ejercicios3
{
    class Program
    {
        static void Main(string[] args)
        {
            // parametros por valor y referencia

            int n1 = 0, n2 = 0, resultado;

            pedirDatos(ref n1, ref n2);

            resultado = sumar(n1, n2);

            Console.WriteLine("El resultado de la suma es " + resultado);
        }

        static int sumar (int a, int b){
            int r;
            r = a + b;
            return r;
        }

        static void pedirDatos(ref int j, ref int h){
            Console.WriteLine("Ingrese un numero ");
            j = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un numero ");
            h = int.Parse(Console.ReadLine());
        }
    }
}
