using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace fibonaci
{
    class Program
    {
        static void Main(string[] args)
        {
            int hey;


            try
            {
                Console.Write("por favor ingrese y le buscaremos " +
                    "los 5 fibonaci siguientes:");
                
                //Verificamos si se ha ingresado un numero
                if (int.TryParse(Console.ReadLine(), out hey))
                {
                    fibonaci5.print5fibonaci(hey);
                }
                else
                {

                    Console.WriteLine("numero invalido");

                }

            }
            catch (Exception E)
            {

                Console.WriteLine(" "+E.Message);
            }

            Console.ReadKey();

        }
    }
}
