using System;

namespace ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int [] numeros = new int [ 5 ];
            int acu = 0;
            float promedio;

            
            
            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine(" ingrese un numero: ");
                numeros [ x ] = int.Parse( Console.ReadLine());
                acu += numeros [ x];
                                
            }
            
            promedio = acu/5;
            Console.WriteLine(" el promedio es:" + promedio);
            
            for (int x = 0; x < 5; x++)
            {
                
                
                if ( numeros [ x] > promedio  )
                {
                    Console.WriteLine(  "este elemento es mayor al promedio: " + numeros[x] );
                }                
            }                       
          
                   
        }

    
        
    }
}

