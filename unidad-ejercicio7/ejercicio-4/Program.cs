using System;

namespace ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
          int [] registro = new int [ 15 ] ;
          int [ ] articulo = new int [ 15];
          
          
          for (int x = 1; x < 16; x++)          
          {
            Console.WriteLine( " ingrese el tipo de articulo: ");
            articulo[ x ]= int.Parse ( Console.ReadLine());
             
          }

          
          

        }
    }
}
