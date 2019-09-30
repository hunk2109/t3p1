using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nodo
{
    class Program
    {
        static void Main(string[] args)
        {
            cola cla = new cola();
            Console.WriteLine("Coloque 5 elementos");
            cla.encolar(3);
            cla.encolar(2);
            cla.encolar(2);
            cla.encolar(2);            
            cla.mostrar();

            Console.WriteLine("Retirar 2 elementos");
            cla.desencolar();
            cla.mostrar();
            cla.desencolar();
            cla.mostrar();

            Console.WriteLine("Retirar un nodo mas de {0}",cla.desencolarvalor());
            Console.ReadLine();
        }
    }
}
