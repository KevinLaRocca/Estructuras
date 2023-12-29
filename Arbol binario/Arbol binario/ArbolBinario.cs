using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbol_binario
{
    internal class ArbolBinario
    {
        private Nodo raiz;
        private int cardinal;

        public void arbolBinario()
        {
            raiz = null;
            cardinal = 0;
        }

        public int longitud()
        {
            return cardinal;
        }

        public void insertarElemento(int value)
        {
            raiz = AuxInsertar(value, raiz);
            cardinal++;
        }
        private Nodo AuxInsertar(int valor, Nodo elementoActual)
        {
            if (elementoActual == null)
            {
                Nodo aux = new Nodo();
                aux.Dato = valor;
                cardinal++;
                return aux;
            }
            else
            {
                if (valor < elementoActual.Dato)
                {
                    elementoActual.Izq = AuxInsertar(valor, elementoActual.Izq);
                }
                else
                {
                    elementoActual.Der = AuxInsertar(valor, elementoActual.Der);
                }
            }

            return elementoActual;
        }

        public void mostrarElementos(int value)
        {
            switch (value)
            {
                case 1: mostrarInOrder(raiz);
                    break;
                case 2:
                    mostrarPreOrder(raiz);
                    break;
                case 3:
                    MostrarPostOrden(raiz);
                    break;
                default:
                    Console.WriteLine("Número invalido.");
                    break;
            }
        }

        private void mostrarInOrder(Nodo elem)
        {
            if (elem != null)
            {
                mostrarInOrder(elem.Izq);
                Console.Write(elem.Dato + " ");
                mostrarInOrder(elem.Der);
            }
        }

        public void mostrarPreOrder(Nodo elem)
        {
            if (elem != null)
            {
                Console.Write(elem.Dato + " ");
                mostrarPreOrder(elem.Izq);
                mostrarPreOrder(elem.Der);
            }
        }

        static void MostrarPostOrden(Nodo raiz)
        {
            if (raiz != null)
            {
                MostrarPostOrden(raiz.Izq);
                MostrarPostOrden(raiz.Der);
                Console.Write(raiz.Dato + " ");
            }
        }

        public bool pertenece(int elem)
        {
            bool res;
            res = auxRecursionPertenece(raiz, elem);
            return res;
        }

        private bool auxRecursionPertenece(Nodo raiz, int elem)
        {
            if (raiz == null) return false;

            if (raiz.Dato == elem) return true;
            else if (raiz.Dato > elem) return auxRecursionPertenece(raiz.Izq, elem);
            else return auxRecursionPertenece(raiz.Der, elem);
        }


        public void eliminar(int elem)
        {
            raiz = eliminarRec(raiz, elem);
            cardinal--;
        }

        private Nodo eliminarRec(Nodo raiz, int elem)
        {
            if (raiz == null)
            {
                return raiz;
            }

            

            if (raiz.Dato > elem)
            {
                raiz.Izq = eliminarRec(raiz.Izq, elem);
            }
            else if (raiz.Dato < elem)
            {
                raiz.Der = eliminarRec(raiz.Der, elem);
            }
            else
            {
                if (raiz.Izq == null)
                {
                    return raiz.Der;
                }
                else if (raiz.Der == null)
                {
                    return raiz.Izq;
                }

                raiz.Dato = encontrarSucesorInmediato(raiz.Der);
                raiz.Der = eliminarRec(raiz.Der, raiz.Dato);
            }
            return raiz;
        }

        private int encontrarSucesorInmediato(Nodo raiz)
        {
            int minValor = raiz.Dato;
            while (raiz.Izq != null)
            {
                minValor = raiz.Izq.Dato;
                raiz = raiz.Izq;
            }
            return minValor;
        }


    }
}
