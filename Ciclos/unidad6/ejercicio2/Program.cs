using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
           // 2. Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros. 
           // Se pide determinar e informar:
           // El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo.
           // Informar cuántos grupos están formados por todos números ordenados de mayor a menor.

           int n, conNum, conImp, grupoImpMax = 0, min, conOrd = 0;
           double porcentajeImp, porcentajeMax = -1;
           bool banderaOrdenados;

           

           for (int x = 0; x < 5; x++){

            conNum = 0;
            conImp = 0;
            banderaOrdenados = true;

            Console.WriteLine("Ingrese su lista de numeros enteros, cuando termine ingrese 0");

            n = int.Parse(Console.ReadLine());

            min = n;

            while (n != 0){

                conNum++;

                if (n % 2 != 0)

                    conImp++;
                    

               // punto b

                    if (n <= min)

                         min = n;
                    else 
                         banderaOrdenados = false;
                         

                n = int.Parse(Console.ReadLine()); 

             } // termina el while

             porcentajeImp = (conImp * 100) / conNum;

             if (porcentajeImp > porcentajeMax){

                porcentajeMax = porcentajeImp;
                grupoImpMax = x + 1;
                
                }

                // punto b

                if (banderaOrdenados == true)
                conOrd++;

          } // termina el for

          Console.WriteLine ("El grupo con mayor porcentaje de numeros impares es " + grupoImpMax);

          Console.WriteLine ( conOrd + " grupos estan formados por numeros ordenados de mayor a menor");



        }
    }
}
