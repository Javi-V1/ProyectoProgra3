using Capa_Modelo.LS;
using System.ComponentModel.Design;
using System.Data.Common;

namespace Capa_Logica.Lista_Simple
{
    public class Orquestador_Lista_Simple
    {

        private NodoInt_LS cabeza;
        private int tamanno=0;

        private bool Cabeza_No_Nula()
        {

            if (cabeza != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Agregar_NodoInt_LS(int valor)
        {

            NodoInt_LS nodoNuevo = new NodoInt_LS(valor);

            if (!Cabeza_No_Nula())
            {
                cabeza = nodoNuevo;
                
            }
            else
            {
                NodoInt_LS nodoActual = cabeza;

                while (nodoActual.Siguiente != null)
                {
                    nodoActual = nodoActual.Siguiente;
                }

                nodoActual.Siguiente = nodoNuevo;
                
            }
            tamanno++;
        }

        public void Mostrar_Lista_Simple()
        {
           
            Console.WriteLine("*-*-*-*Empieza Lista*-*-*-*");
            if (Cabeza_No_Nula())
            {
                NodoInt_LS nodoActual = cabeza;

                while (nodoActual != null)
                {
                    int valorActual = nodoActual.Valor;
                    Console.WriteLine(valorActual.ToString());
                    nodoActual = nodoActual.Siguiente;
                }               
            }
            Console.WriteLine("*-*-*-*Termina Lista*-*-*-*");
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void Ejercicio1_LS()
        {
            Llenar_LS();
            Mostrar_Lista_Simple();
            Bubble_Sort();
            Mostrar_Lista_Simple();
        }

        public void Llenar_LS()
        {
            Random random = new Random();
            for (int i = 0; i<5; i++)
            {
                Agregar_NodoInt_LS(random.Next(1, 31));
            } 
        }
        public void Bubble_Sort()
        {
            NodoInt_LS nodoActual = cabeza;
            Reordenar_Lista_Recursivo(nodoActual, nodoActual.Siguiente);

        }
        public void Reordenar_Lista_Recursivo(NodoInt_LS nodoActual, NodoInt_LS nodoSiguiente)
        {
            if (Lista_Ordenada())
            {

            }
            else
            {
                int swap;
                if (NodoSiguiente_Nulo(nodoSiguiente))
                {
                    nodoSiguiente = cabeza;
                }

                while(!NodoSiguiente_Nulo(nodoSiguiente) && Numero_Mayor_Siguiente(nodoActual, nodoSiguiente))
                {
                    Intercambiar_Valores(nodoActual, nodoSiguiente);
                }

                nodoActual = nodoSiguiente;
                nodoSiguiente = nodoSiguiente.Siguiente;
                Reordenar_Lista_Recursivo(nodoActual, nodoSiguiente);
            }
        }
        public bool NodoSiguiente_Nulo(NodoInt_LS nodoSiguiente)
        {
            return (nodoSiguiente == null) ? true : false;
        }

        public bool Numero_Mayor_Siguiente(NodoInt_LS nodoActual, NodoInt_LS nodoSiguiente)
        {
            return (nodoActual.Valor > nodoSiguiente.Valor) ? true : false;
        }

        public void Intercambiar_Valores(NodoInt_LS nodoActual, NodoInt_LS nodoSiguiente)
        {
            int swap;
            swap = nodoActual.Valor;
            nodoActual.Valor = nodoSiguiente.Valor;
            nodoSiguiente.Valor = swap;
        }

        public bool Lista_Ordenada()
        {
            NodoInt_LS nodoActual = cabeza;
            while (nodoActual != null && nodoActual.Siguiente!=null)
            {
                if(nodoActual.Valor > nodoActual.Siguiente.Valor)
                {
                    return false;
                }
                nodoActual = nodoActual.Siguiente;
            }
            return true;
        }
    }
}
