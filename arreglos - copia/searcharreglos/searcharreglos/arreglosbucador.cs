using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace searcharreglos
{
   public static class arreglosbucador
    {
  

        public static void buscararreglo(List<int>[] arreglo)
        {
            try
            {
                int iterador = 0;
                int numeromayor = 0;
                int listamayor = 0;
                int numeroarreglo = 0;

                foreach (var item in arreglo)
                {
                    if (item.Count > listamayor)
                    {
                        listamayor = item.Count;
                        numeroarreglo = iterador;
                    

                    }

                    foreach (var item2 in item)
                    {
                        if (item2 > numeromayor)
                        {
                            numeromayor = item2;
                        }

                    }
                    iterador++;
                } 
                Console.Write($"El arreglo mas grande  tiene {listamayor} elemnentos y estos son: " ) ;
                Console.Write("\n {");
                foreach (var item in arreglo[numeroarreglo])
                {
                    Console.Write($" {item}");
                }
                Console.Write("} \n");
                Console.WriteLine($"  el mayor numero de todas las listas es {numeromayor} ");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
       

    }
}
