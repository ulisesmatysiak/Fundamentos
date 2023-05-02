using System;

namespace ejercicios3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3. Hacer una función llamada “primo” que reciba un número entero y devuelva 1 si el número es primo o cero si no lo es. Hacer un programa para ingresar números. El lote corta cuando se ingresa un número cero. Informar el promedio teniendo en cuenta sólo los números primos.

            int n, acuPrimos = 0, conPrimos = 0, prom;

            Console.WriteLine("Ingrese un nro ");
            n = int.Parse(Console.ReadLine());

            while (n != 0)
            {
                if (primo(n)){
                    acuPrimos+= n;
                    conPrimos++;
                }

                Console.WriteLine("Ingrese otro nro ");
                n = int.Parse(Console.ReadLine());
            }

            prom = acuPrimos / conPrimos;

            Console.WriteLine("El promedio de numeros primos es " + prom);
        }

        static bool primo (int a, int con = 0){
            for (int x = 1; x < a; x++)
            {
                if (a % x == 0)
                con++;
            }
            if (con == 2)
            return true; 
            else
            return false;      
        }
    }
}
