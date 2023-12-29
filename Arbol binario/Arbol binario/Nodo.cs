using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbol_binario
{
    internal class Nodo
    {
        private int dato;
        private Nodo der;
        private Nodo izq;

        public int Dato
        {
            get { return dato; }
            set { dato = value; }
        }

        public Nodo Der
        {
            get { return der; }
            set { der = value; }
        }

        public Nodo Izq
        {
            get { return izq; }
            set { izq = value; }
        }
    }
}
