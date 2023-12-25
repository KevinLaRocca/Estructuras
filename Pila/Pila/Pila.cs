using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Pila
{
    internal class Pila
    {
        private Nodo primero;

        public Pila()
        {
            primero = null;
        }

        public void insertarElemento()
        {
            Nodo nuevoNodo = new Nodo();
            Console.WriteLine("Digite su valor para el elemento: ");
            int value = int.Parse(Console.ReadLine());
            nuevoNodo.Dato = value;

            nuevoNodo.Siguiente = primero;
            primero = nuevoNodo;

            Console.WriteLine("El elemento: " + value + " ha sido insertado.");
        }

        public void mostrarElementos()
        {
            Nodo actual = new Nodo();
            actual = primero;

            while (actual != null)
            {
                Console.WriteLine("El elemento actual de la pila es: " + actual.Dato);
                actual = actual.Siguiente;
            }

            Console.WriteLine("Se han mostrado todos los elementos de la pila.");

        }

        public void modificarElemento(int elem, int newElem)
        {
            Nodo actual = primero;
            bool find = false;
            while (actual != null)
            {
                if (actual.Dato == elem)
                {
                    actual.Dato = newElem;
                    find = true;
                    //No le pongo break por que podríamos tener el elemento repetido, este código modificará todas las apariciones del elemento elem.
                }
                actual = actual.Siguiente;
            }

            if (find) Console.WriteLine("El elemento estaba en la pila y ha sido modificado");
            else Console.WriteLine("Su elemento no se encontraba en la pila.");
        }

        public void eliminarElemento(int elem)//Funcion para eliminar un elemento random
        {
            Nodo actual = primero;
            Nodo anterior = null;
            bool find = false;

            while (actual != null)
            {
                if (actual.Dato == elem)
                {
                    if (anterior != null)
                    {
                        anterior.Siguiente = actual.Siguiente;
                    }
                    else
                    {
                        primero = actual.Siguiente;
                    }
                    find = true;
                    break;
                }

                anterior = actual;
                actual = actual.Siguiente;
            }

            if (find) Console.WriteLine("Su elemento se encontraba y ha sido eliminado.");
            else Console.WriteLine("Su elemento no se encontraba en la pila.");
        }

        public int pop()//Esta funcion es la misma que cuando hacemos pila.pop, que elimina el primer elemento de la pila.
        {
            int value= primero.Dato;
            primero = primero.Siguiente;

            return value; 
        }

        public int longitud()
        {
            Nodo actual = primero;
            int len = 0;

            while( actual != null )
            {
                len++;
                actual = actual.Siguiente;
            }

            return len;
        }
    }
}
