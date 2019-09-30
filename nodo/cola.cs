using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nodo
{
    class cola
    {
        public nodo primero;
        public nodo ultimo;

        public cola()
        {
            primero = ultimo = null;
        }


        public void encolar(int valor)
        {
            nodo aux = new nodo();
            aux.info = valor;
            if(primero == null)
            {
                primero = ultimo = aux;
                aux.sgte = null;
            }

            else
            {
                ultimo.sgte = aux;
                aux.sgte = null;
                ultimo = aux;
            }
        }

        public void desencolar()
        {
            if(primero == null)
            {
                Console.WriteLine("Cola Vacia");
            }

            else
            {
                primero = primero.sgte;
            }


            
        }

        public int desencolarvalor()
        {
            int valor = 0;
            if (primero == null)
            {
                Console.WriteLine("Cola Vacia");
            }

            else
            {
                valor = primero.info;
                primero = primero.sgte;
            }

            return valor;
        }

        public void mostrar()
        {
            if (primero == null)
            {
                Console.WriteLine("Cola Vacia");

            }

            else
            {
                nodo puntero;
                puntero = primero;

                do
                {
                    Console.Write("{0}\t", puntero.info);
                    puntero = puntero.sgte;
                }

                while (puntero != null);
            }

            Console.WriteLine("\n");
        }
    }

}
