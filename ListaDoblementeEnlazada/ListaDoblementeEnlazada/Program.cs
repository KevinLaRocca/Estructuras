using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_simplemente_enlazada
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ListaDoble elemento = new ListaDoble();
            int i = 0;

            while (i < 5)
            {
                elemento.insertarElemento();
                i++;
            }
            Console.WriteLine("MUESTRO SIN ELIMINAR");
            elemento.mostrarElementos();
            elemento.eliminarElemento(3);
            Console.WriteLine("MUESTRO ELIMINANDO ALGÚN ELEMENTO");
            elemento.mostrarElementos();
            if (elemento.longitud() > 0)
            {
                Console.WriteLine("MUESTRO EL PRIMERO Y EL ÚLTIMO");
                Console.WriteLine(elemento.chequearPrimero());
                Console.WriteLine(elemento.chequearUltimo());
            }


        }
    }
}
