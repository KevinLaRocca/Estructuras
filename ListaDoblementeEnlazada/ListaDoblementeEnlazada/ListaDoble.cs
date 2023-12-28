using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_simplemente_enlazada
{
    internal class ListaDoble
    {
        private Nodo primero;
        private Nodo ultimo;

        public void listaDoble()
        {
            primero = null;
            ultimo = null;
        }

        public void insertarElemento()
        {
            Nodo elemento = new Nodo();
            Console.WriteLine("Digite el elemento a introducir: ");
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
        }


        public void mostrarElementos()
        {
            Nodo aux = primero;

            while (aux != null)
            {

                Console.WriteLine(aux.Dato);

                aux = aux.Siguiente;
            }
        }


        public void eliminarElemento(int value)
        {
            Nodo actual = primero;
            Nodo anterior = null;

            while (actual != null)
            {
                if (actual.Dato == value)
                {
                    if (actual == primero)
                    {
                        primero = actual.Siguiente;
                        if (primero != null)
                        {
                            primero.Anterior = null;
                        }
                    }
                    else if (actual == ultimo)
                    {
                        anterior.Siguiente = null;
                        ultimo = anterior;
                    }
                    else
                    {
                        anterior.Siguiente = actual.Siguiente;
                        actual.Siguiente.Anterior = anterior;
                    }

                }
                else
                {
                    anterior = actual;
                }
                actual = actual.Siguiente;
            }
        }


        public int chequearUltimo()
        {
            return ultimo.Dato;
        }

        public int chequearPrimero()
        {
            return primero.Dato;
        }

        public int longitud()
        {
            Nodo actual = primero;
            int i = 0;
            while (actual != null)
            {
                i++;
                actual = actual.Siguiente;
            }
            return i;
        }
    }
}
