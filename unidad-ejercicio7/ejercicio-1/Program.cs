using System;

namespace ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
           int [] numeros = new int [10];
           int max = numeros [0];
           int pos = 1;

           for (int x = 0; x < 10; x++)
           {
            Console.WriteLine(" ingrese un numero:");
            numeros [x] = int.Parse (Console.ReadLine());
            
           }

           for (int x = 0; x < 10; x++)
           {
            
            if ( numeros [x] > max )
            {
                max = numeros [x];
                pos = x + 1 ;
            }
            
           }  
           Console.WriteLine( " el maximo es:" + max);
           Console.WriteLine ( " su indice es: " + pos);
         
        }

    }
}
