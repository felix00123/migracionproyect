using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace searcharreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int>[] listadearreglos = new List<int>[5];
            listadearreglos[0] = new List<int> { 1, 2, 3 };
            listadearreglos[1] = new List<int> { 1, 2, 3,2 };
            listadearreglos[2] = new List<int> { 1, 2, 3, 2 };
            listadearreglos[3] = new List<int> { 1, 2, 3, 2 };
            listadearreglos[4] = new List<int> { 1, 2, 3, 2,5,2 };
            arreglosbucador.buscararreglo(listadearreglos);

        }


    }
}
