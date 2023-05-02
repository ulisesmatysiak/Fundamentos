using System;

namespace ejemplos2
{
    class Program
    {
        static void Main(string[] args)
        {
            // CORTE DE CONTROL
            // legajo, edad, sueldo, codigo de equipo (numerico entre 1 y 50)
            int legajo, edad, codigoEquipo;
            float sueldo;
            int equipoActual;

            // codigos de equipos
            // Boca 1
            // independiente 2
            // racing 3

            Console.WriteLine("Ingrese el legajo");
            legajo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la edad");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el sueldo");
            sueldo = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el codigo de equipo");
            codigoEquipo = int.Parse(Console.ReadLine());

        
            while (sueldo > 0)
            {
                equipoActual = codigoEquipo;

                while (codigoEquipo == equipoActual)
                {
                    // aca procesamos

                    Console.WriteLine("Ingrese el legajo");
                    legajo = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la edad");
                    edad = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el sueldo");
                    sueldo = float.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el codigo de equipo");
                    codigoEquipo = int.Parse(Console.ReadLine());

                    // aca podemos mostrar algun resultado obtenido 

                }  

                // aca podemos mostrar algun resultado obtenido 

            }

            // aca podemos mostrar algun resultado obtenido 

        }
    }
}
