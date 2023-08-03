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
        private NodoInt_Pila cabeza, cabeza2, cabeza3;
        private int length, length2, length3;

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
                length++;
            }
            else
            {

                NodoInt_Pila nodoNuevo = new NodoInt_Pila(_valor);
                cabeza = nodoNuevo;
                length++;
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
                length--;
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

        public void Ejercicio4_Pila()
        {
            LLenar_Pila();
            Imprimir_Pila();
            Strand_Sort();
        }

        public void LLenar_Pila()
        {
            Random random = new Random();
            for (int i = 0; i < 20; i++)
            {
                Push(random.Next(1, 100));
            }
        }

        public void Strand_Sort()
        {
            Ordenar_Pila(cabeza, cabeza2, cabeza3);
            Imprimir_Pila_2();
        }

        public void Ordenar_Pila(NodoInt_Pila nodoActual1, NodoInt_Pila nodoActual2, NodoInt_Pila nodoActual3)
        {
            if(length > 0)
            {
                if (length2 ==0 || (nodoActual2!=null&&nodoActual1.Valor >= nodoActual2.Valor))
                {
                    Push_2(Pop().Valor);
                }
                else
                {
                    while (length2 > 0&& cabeza.Valor < cabeza2.Valor)
                    {
                        Push_3(Pop_2().Valor);
                    }
                    Push_2(Pop().Valor);
                    while (length3 > 0)
                    {
                        Push_2(Pop_3().Valor);
                    }
                }
                nodoActual1 = nodoActual1?.Siguiente;
                //Imprimir_Pila_2();
                Ordenar_Pila(nodoActual1, cabeza2, cabeza3);
            }
        }

        public bool Cabeza_No_Nula_2()
        {

            return cabeza2 != null;
        }

        public void Push_2(int _valor)
        {

            if (Cabeza_No_Nula_2())
            {

                NodoInt_Pila nodoNuevo = new NodoInt_Pila(_valor);

                nodoNuevo.Siguiente = cabeza2;
                cabeza2 = nodoNuevo;
                length2++;
            }
            else
            {

                NodoInt_Pila nodoNuevo = new NodoInt_Pila(_valor);
                cabeza2 = nodoNuevo;
                length2++;
            }

        }
        public NodoInt_Pila Pop_2()
        {

            NodoInt_Pila nodoRetorno = null;

            if (Cabeza_No_Nula_2())
            {
                //Nodo de referencia
                NodoInt_Pila nodoActual = cabeza2;
                nodoRetorno = nodoActual;
                nodoActual = nodoActual.Siguiente;
                cabeza2 = nodoActual;
                length2--;
            }

            return nodoRetorno;

        }

        public void Imprimir_Pila_2()
        {
            Console.WriteLine("+-+- Empieza Pila 2-+-+");

            if (Cabeza_No_Nula_2())
            {
                //Nodo referencia
                NodoInt_Pila nodoActual = cabeza2;

                //Recorrer la lista
                while (nodoActual != null)
                {
                    Console.WriteLine(nodoActual.Valor);

                    nodoActual = nodoActual.Siguiente;
                }

            }
            Console.WriteLine("+-+- Termina Pila 2-+-+");
        }

        public bool Cabeza_No_Nula_3()
        {

            return cabeza3 != null;
        }

        public void Push_3(int _valor)
        {

            if (Cabeza_No_Nula_3())
            {

                NodoInt_Pila nodoNuevo = new NodoInt_Pila(_valor);

                nodoNuevo.Siguiente = cabeza3;
                cabeza3 = nodoNuevo;
                length3++;
            }
            else
            {

                NodoInt_Pila nodoNuevo = new NodoInt_Pila(_valor);
                cabeza3 = nodoNuevo;
                length3++;
            }

        }
        public NodoInt_Pila Pop_3()
        {

            NodoInt_Pila nodoRetorno = null;

            if (Cabeza_No_Nula_3())
            {
                //Nodo de referencia
                NodoInt_Pila nodoActual = cabeza3;
                nodoRetorno = nodoActual;
                nodoActual = nodoActual.Siguiente;
                cabeza3 = nodoActual;
                length3--;
            }

            return nodoRetorno;

        }

        public void Imprimir_Pila_3()
        {
            Console.WriteLine("+-+- Empieza Pila 3-+-+");

            if (Cabeza_No_Nula_3())
            {
                //Nodo referencia
                NodoInt_Pila nodoActual = cabeza2;

                //Recorrer la lista
                while (nodoActual != null)
                {
                    Console.WriteLine(nodoActual.Valor);

                    nodoActual = nodoActual.Siguiente;
                }

            }
            Console.WriteLine("+-+- Termina Pila 3-+-+");
        }
    }
}
