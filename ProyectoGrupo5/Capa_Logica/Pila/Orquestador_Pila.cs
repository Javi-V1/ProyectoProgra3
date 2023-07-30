using Capa_Modelo.Cola;
using Capa_Modelo.Pila;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Logica.Pila
{
    public class Orquestador_Pila
    {
        public NodoInt_Pila cabeza;


        public bool Cabeza_No_Nula()
        {

            return cabeza != null;
        }
        public void Push(int _valor)
        {

            if (Cabeza_No_Nula())
            {

                NodoInt_Pila nodoNuevo = new NodoInt_Pila(_valor);

                nodoNuevo.Siguiente = cabeza;
                cabeza = nodoNuevo;

            }
            else
            {

                NodoInt_Pila nodoNuevo = new NodoInt_Pila(_valor);
                cabeza = nodoNuevo;
            }

        }
        public NodoInt_Pila Pop()
        {

            NodoInt_Pila nodoRetorno = null;

            if (Cabeza_No_Nula())
            {
                //Nodo de referencia
                NodoInt_Pila nodoActual = cabeza;
                nodoRetorno = nodoActual;
                nodoActual = nodoActual.Siguiente;
                cabeza = nodoActual;
            }

            return nodoRetorno;

        }

        public void Imprimir_Pila()
        {
            Console.WriteLine("+-+- Empieza Pila-+-+");

            if (Cabeza_No_Nula())
            {
                //Nodo referencia
                NodoInt_Pila nodoActual = cabeza;

                //Recorrer la lista
                while (nodoActual != null)
                {
                    Console.WriteLine(nodoActual.Valor);

                    nodoActual = nodoActual.Siguiente;
                }

            }
            Console.WriteLine("+-+- Termina Pila-+-+");

        }
    }
}
