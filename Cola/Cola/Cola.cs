using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cola
{
    internal class Cola
    {
        private Nodo primero;
        private Nodo ultimo;

        public Cola()
        {
            primero = null;
            ultimo = null;
        }

        public void insertarElemento()
        {
            Nodo elemento = new Nodo();
            Console.WriteLine("Digite el elemento a insertar: ");
            elemento.Dato = int.Parse(Console.ReadLine());

            if (primero == null)
            {
                primero = elemento;
                ultimo = elemento;
            }
            else
            {
                ultimo.Siguiente = elemento;
                ultimo = elemento;
            }

            Console.WriteLine("El elemento " + elemento.Dato + " ha sido insertado correctamente.");

        }

        public void mostrarElementos()
        {
            Nodo actual = primero;

            while (actual != null)
            {
                Console.WriteLine("El elemento actual es: " + actual.Dato + ".");
                actual = actual.Siguiente;
            }

            Console.WriteLine("Se han mostrado todos los elementos.");
        }

        public void modificarElemento(int elem, int newElem)//Modificar todos los valores que sean iguales. Es lo mismo que pila
        {
            bool find = false;
            Nodo actual = primero;

            while (actual != null)
            {
                if (actual.Dato == elem)
                {
                    actual.Dato = newElem;
                    find = true;
                }
                actual = actual.Siguiente;
            }

            if (find) Console.WriteLine("El o los elementos han sido modificados.");
            else Console.WriteLine("El elemento que quiere modificar no se encuentra, todo queda igual.");

        }

        public void eliminarElemento(int elem)
        {
            Nodo actual = primero;
            Nodo anterior = null;
            bool encontrado = false;

            while (actual != null && !encontrado)
            {
                if (actual.Dato == elem)
                {
                    if (actual == primero)
                    {
                        primero = actual.Siguiente;
                        if (primero == null) ultimo = null;
                    }
                    else
                    {
                        anterior.Siguiente = actual.Siguiente;
                        if (actual == ultimo) ultimo = anterior;
                    }

                    encontrado = true;
                }

                anterior = actual;
                actual = actual.Siguiente;
            }

        }

        public int dequeue()
        {
            int value = primero.Dato;
            primero = primero.Siguiente;

            return value;
        }

        public int longitud()
        {
            Nodo actual = primero;
            int len = 0;

            while (actual != null)
            {
                len++;
                actual = actual.Siguiente;
            }

            return len;
        }
    }
}
