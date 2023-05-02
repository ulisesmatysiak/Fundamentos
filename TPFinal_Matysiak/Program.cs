using System;

namespace TPFinal_Matysiak
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que permita ingresar una lista de números que corta cuando se ingresa un cero. A partir de dichos datos informar:

            // a. El mayor de los números pares.
            // b. La cantidad de números impares.
            // c. El menor de los números primos.
            // Nota: evaluar el uso de una función que analice si un número dado es primo o no y que devuelva true o false según corresponda.

            int n, conPar = 0, maxPar = 0, conImp = 0; 
            int conPrimos = 0, minPrimos = 0;

            Console.WriteLine("Ingrese un -1 para dar comienzo al programa");
            n = int.Parse(Console.ReadLine());

            while (n != 0)
            {
                Console.WriteLine("Ingrese otro nro para continuar o 0 para cortar ");
                n = int.Parse(Console.ReadLine());

                if (n % 2 == 0)
                {
                    conPar++;
                    if (conPar == 1){
                        maxPar = n; 
                    }
                    else if (n > maxPar) {
                        maxPar = n;
                    }    
                }
                else 
                {
                    conImp++;
                }

                if(primo(n)){
                    conPrimos++;
                    if (conPrimos == 1){
                        minPrimos = n;
                    }
                    else if (n < minPrimos){
                        minPrimos = n;
                    }
                }
                
            }

            Console.WriteLine("Fin del programa");
            Console.WriteLine("El mayor de los números pares ingresados es " + maxPar);
            Console.WriteLine("La cantidad ingresada de números impares es " + conImp);
            Console.WriteLine("El menor de los numeros primos es " + minPrimos);
        }

        static bool primo (int a){
            int con = 0;
            for (int x = 1; x <= a; x++)
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
