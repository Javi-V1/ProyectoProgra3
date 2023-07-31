using Capa_Modelo.LS;
using System.ComponentModel;
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
        /// Unico metodo que se Ejecuta en Program.cs
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
            for (int i = 0; i<20; i++)
            {
                Agregar_NodoInt_LS(random.Next(1, 50));
            } 
        }
        public void Bubble_Sort()
        {
            NodoInt_LS nodoActual = cabeza;
            Ordenar_Lista_Recursivo(nodoActual);

        }

        public void Ordenar_Lista_Recursivo(NodoInt_LS nodoActual)
        {
            int swap;
            if (!Lista_Ordenada())
            {
                nodoActual = cabeza;

                Recorrer_Lista(nodoActual);

                if (nodoActual.Valor < cabeza.Valor)
                {
                    swap = nodoActual.Valor;
                    nodoActual.Valor = cabeza.Valor;
                    cabeza.Valor = swap;
                }

                Mostrar_Lista_Simple();

                Ordenar_Lista_Recursivo(nodoActual);
            }
        }

        public void Recorrer_Lista(NodoInt_LS nodoActual)
        {
            if (nodoActual.Siguiente != null)
            {
                int swap;
                if (nodoActual.Valor > nodoActual.Siguiente.Valor)
                {
                    swap = nodoActual.Valor;
                    nodoActual.Valor = nodoActual.Siguiente.Valor;
                    nodoActual.Siguiente.Valor = swap;
                }

                nodoActual = nodoActual.Siguiente;

                Recorrer_Lista(nodoActual);
            }
        }

        public bool Lista_Ordenada()
        {
            NodoInt_LS _nodoActual = cabeza;
            while (_nodoActual != null && _nodoActual.Siguiente!=null)
            {
                if(_nodoActual.Valor > _nodoActual.Siguiente.Valor)
                {
                    return false;
                }
                _nodoActual = _nodoActual.Siguiente;
            }
            return true;
        }

        /*public void prueba()
        {
            int swap;
            while (!Lista_Ordenada())
            {
                NodoInt_LS nodoActual = cabeza;
                while (nodoActual.Siguiente!=null)
                {
                    if (nodoActual.Valor> nodoActual.Siguiente.Valor)
                    {
                        swap = nodoActual.Valor;
                        nodoActual.Valor = nodoActual.Siguiente.Valor;
                        nodoActual.Siguiente.Valor = swap;
                    }
                    
                    nodoActual = nodoActual.Siguiente;
                }

                if (nodoActual.Valor < cabeza.Valor)
                {
                    swap = nodoActual.Valor;
                    nodoActual.Valor = cabeza.Valor;
                    cabeza.Valor = swap;
                }

                Mostrar_Lista_Simple();
            }
            
        }*/
    }
}
