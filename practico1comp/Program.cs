using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace practico1comp
{
    class Program
    {
        static void Main(string[] args)
        {

            int numero;

            Console.WriteLine("Ingrese un numero de 3 cifras como maximo");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero.ToString().Length <= 3)
            {

                Console.WriteLine("El numero en string es: ");

               



            }

            else
            {

                Console.WriteLine("El numero debe tener 3 cifras como maximo.");


            }


            Console.ReadLine();

        }
    }
}
