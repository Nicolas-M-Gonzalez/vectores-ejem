using System;

namespace ejercicio_vectores
{
    class Program
    {
        static void Main(string[] args)
        {
           int n,acu,prom;
           int [] numeros = new int [10];
          
           for (int x = 0; x < 10; x ++)
           {
             Console.WriteLine( "ingrese un numero..");
             n= int.Parse(Console.ReadLine());
             numeros[x] = n;    
                              
           } 
           
           acu = 0;

           for (int x = 0; x < 10; x++)
           {
            
            acu += numeros [ x ];
            Console.WriteLine( " el valor es:  " + numeros [ x ]);

           }

            prom = acu/10;
            Console.WriteLine(" el promedio es:" + prom);
           
           
           }
        }
    }

