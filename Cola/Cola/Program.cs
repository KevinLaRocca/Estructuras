using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cola cola = new Cola();
            int i = 0;

            while (i < 5)
            {
                cola.insertarElemento();
                i++;
            }

            cola.mostrarElementos();
            cola.eliminarElemento(1);
            cola.mostrarElementos();

            if (cola.longitud() > 0)
            {
                int x = cola.dequeue();
                Console.WriteLine("El primer elemento era: " + x);
            }
            cola.mostrarElementos();//La cabeza ya no aparecerá y aparecerá el resto de la cola.
        }
    }
}
