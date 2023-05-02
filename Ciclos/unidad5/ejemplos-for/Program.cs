using System;

namespace ejemplos
{
    class Program
    {
        static void Main(string[] args)
        {
            // CICLO FOR
            // for ( inicializacion condicion incremento) 
            // declara, evalua condicion si es verdadero entra y ejecuta, repite
            
            // for (int x = 0; x < 5; x++)
            // { Console.WriteLine("Hola mundo");}

            // for (x = 0 ; pregunto x menor a 5 ? true; entonces x ++ suma 1) repite y ahora x=1 menor a 5? true entonces x++ suma 1 repite 
            // se detiene cuando la condicion de falso

            int n = 0, promedio, suma = 0;

            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine("Ingrese la nota");
                n = int.Parse(Console.ReadLine());
                suma += n;
                
            }

            promedio = suma/5;

            Console.WriteLine("El promedio de las notas es: " + promedio);

            


        }
    }
}
