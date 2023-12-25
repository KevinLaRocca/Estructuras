using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pila
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Pila pila = new Pila();
            int i = 1;

            while (i <= 5)
            {
                pila.insertarElemento();
                i++;
            }

            pila.mostrarElementos();
            //pila.modificarElemento(5, 10);
            pila.eliminarElemento(5);
            pila.mostrarElementos();
            if (pila.longitud() > 0)
            {
                int x = pila.pop();
                Console.WriteLine("La cabeza de la pila es: " + x);
            }
            
            pila.mostrarElementos();
        }
    }
}
