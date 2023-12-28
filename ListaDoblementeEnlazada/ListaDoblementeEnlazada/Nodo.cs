using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_simplemente_enlazada
{
    internal class Nodo
    {
        private int dato;
        private Nodo siguiente;
        private Nodo anterior;

        public int Dato
        {
            get { return dato; }
            set { dato = value; }
        }

        public Nodo Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }

        public Nodo Anterior
        {
            get { return anterior; }
            set { anterior = value; }
        }
    }
}
