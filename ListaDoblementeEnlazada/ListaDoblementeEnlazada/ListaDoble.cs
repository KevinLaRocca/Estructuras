using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Abajo de todo explico la diferencia entre esta y la lista circular doblemente enlazada
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
//A diferencia de esta, la lista circular doblemente enlazada es una lista que el último apunta al primero, y el primero apunta al último
//además de que el primero apunta a su correspondiente siguiente y el último a su correspondiente anterior.
//La manera de programarlo sería que cuando agregamos un nodo y modificamos el último, este tenga un "siguiente" al primero, y el primero apunte a este nuevo último
//Cuando eliminamos un nodo, lo que podríamos hacer es: Si eliminamos uno intermedio no pasa nada, si eliminamos el último por ejemplo, entonces el último pasa a ser "el anterior" al último y el siguiente de este apuntará al primero, además de que el "anterior" del primero apunte al último.
//Similar a eliminar el primero. Modificamos nuestro primero y el anterior de este será el último, el siguiente del último será este nuevo "primero" que tenemos actualmente.