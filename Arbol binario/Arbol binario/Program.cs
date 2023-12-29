using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbol_binario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArbolBinario ejemplo = new ArbolBinario();
            int i = 0;

            while (i < 5)
            {
                Console.WriteLine("Digite el elemento a insertar en el arbol: ");
                int value = int.Parse(Console.ReadLine());
                ejemplo.insertarElemento(value);
                i++;
            }
            Console.WriteLine("Mostrar los elementos in Order");
            ejemplo.mostrarElementos(1);    Console.WriteLine("\n");
            Console.WriteLine("Mostrar los elementos Pre Order");
            ejemplo.mostrarElementos(2);    Console.WriteLine("\n");
            Console.WriteLine("Mostrar los elementos post Order");
            ejemplo.mostrarElementos(3);    Console.WriteLine("\n");

            Console.WriteLine(ejemplo.pertenece(3));
            ejemplo.eliminar(3);
            ejemplo.mostrarElementos(1);
        }
    }
}
