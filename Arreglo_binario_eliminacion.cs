using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Arbol_binario_eliminacion
{
    class Arbol_binario_eliminacion
    {

        private Nodo raiz; 
        private Nodo trabajo;

        private int i = 0;
        public Arbol_binario_eliminacion()
        {
            raiz = null;
        }
        internal Nodo Raiz { get => raiz; set => raiz = value; }


        //insertar
        public Nodo Insertar(int pDato, Nodo pNodo)
        {
            Nodo temp = null;

            //si no hay a quien insertar entonces creamos el nodo
            if (pNodo == null)
            {
                temp = new Nodo();
                temp.Dato = pDato;

                return temp;
            }
            if (pDato < pNodo.Dato)
            {
                pNodo.Izq = Insertar(pDato, pNodo.Izq);
            }
            if (pDato > pNodo.Dato)
            {
                pNodo.Der = Insertar(pDato, pNodo.Der);
            }
            return pNodo;
        }

        //Transversa 
        public void Transversa(Nodo pNodo)
        {
            if (pNodo == null)
                return;

            // Me proceseo primero a mi 
            for (int n = 0; n < 1; n++)
                Console.Write("  ");

            Console.WriteLine(pNodo.Dato);

            // Si tengo izquierda, proceso a la izquierda 
            if (pNodo.Izq != null)
            {
                i++;
                Console.Write("I");
                Transversa(pNodo.Izq);
                i--;
            }
            // Si tengo dertecha, proceso a la derecha 
            if (pNodo.Der != null)
            {
                i++;
                Console.Write("D");
                Transversa(pNodo.Der);
                i--;
            }
        }
        public int EncuentraMinimo(Nodo pNodo)
        {

            if (pNodo == null)
                return 0;

            trabajo = pNodo;
            int minimo = trabajo.Dato;
            while (trabajo.Izq != null)
            {
                trabajo = trabajo.Izq;
                minimo = trabajo.Dato;
            }

            return minimo;
        }
        public int EncuentraMaximo(Nodo pNodo)
        {
            if (pNodo == null)
                return 0;

            trabajo = pNodo;
            int maximo = trabajo.Dato;

            while (trabajo.Der != null)
            {
                trabajo = trabajo.Der;
                maximo = trabajo.Dato;
            }
            return maximo;
        }

        public void TransversaOrdenada(Nodo pNodo)
        {
            if (pNodo == null)
                return;

            //Si la izquierda, proceso a la izquierda 
            if (pNodo.Izq != null)
            {
                i++;
                TransversaOrdenada(pNodo.Izq);
                i--;

            }
            Console.Write("{0}, ", pNodo.Dato);
            //Si la derecha, proceso a la derecha 

            if (pNodo.Der != null)
            {
                i++;
                TransversaOrdenada(pNodo.Der);
                i--;
            }
            //Console.WriteLine("{0},", pNodo.Dato);
        }
        //public Nodo EncuentraNodoMinimo(Nodo pNodo)
        //{
        //    if (pNodo == null)
        //        return null;

        //    trabajo = pNodo;
        //    int minimo = trabajo.Dato;

        //    while (trabajo.Izq != null)
        //    {
        //        trabajo = trabajo.Izq;
        //        minimo = trabajo.Dato;

        //    }
        //    return trabajo;

        public Nodo BuscarPadre(int pDato, Nodo pNodo)
        {
            Nodo temp = null;

            if (pNodo == null)
                return null;

            //Verifica si soy el padre 
            if (pNodo.Izq != null)
                if (pNodo.Izq.Dato == pDato)
                    return pNodo;

            if (pNodo.Izq != null)
                if (pNodo.Der.Dato == pDato)
                    return pNodo;


            //Si tengo izquierda , proceso a la izquierda
            if (pNodo.Izq != null && pDato < pNodo.Dato)
            {
                temp = BuscarPadre(pDato, pNodo.Izq);
            }

            //Si tengo derecha , proceso a la derecha
            if (pNodo.Der != null && pDato > pNodo.Dato)
            {
                temp = BuscarPadre(pDato, pNodo.Der);

            }
            return temp;
        }

    }
}
        
    


