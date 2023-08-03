using Capa_Modelo.Cola;
using Capa_Modelo.LD;
using Capa_Modelo.Pila;
using System.Runtime.Serialization.Formatters;

namespace Capa_Logica.Cola
{
    public class Orquestador_Cola
    {
        private NodoInt_Cola cabeza;
        private NodoInt_Cola refCabeza;
        private NodoInt_Cola cola;
        private int length=0;

        private bool Cabeza_No_Nula()
        {

            return cabeza != null ? true : false;

        }
        public void Enqueue(int _valor) {

            //Creación del nodo nuevo
            NodoInt_Cola nodoNuevo = new NodoInt_Cola(_valor);

            if (Cabeza_No_Nula())
            {
                //Nodo de referencia
                NodoInt_Cola nodoActual = cola;                

                //Agregar  referencia hacia adelante
                nodoActual.Siguiente = nodoNuevo;

                //Se define el nuevo cola
                cola = nodoNuevo;
            }
            else
            {
                cabeza = nodoNuevo;
                cola = nodoNuevo;
            }

            length++;
        }

        public NodoInt_Cola Dequeue() {

            NodoInt_Cola nodoDequeue = null;

            if (Cabeza_No_Nula())
            {
                //Nodo de referencia
                NodoInt_Cola nodoActual = cabeza;

                cabeza = nodoActual.Siguiente;

                nodoDequeue= nodoActual;
            }
            length--;

            return nodoDequeue;
        }

        public void Imprimir_Cola()
        {            
            if (Cabeza_No_Nula())
            {
                NodoInt_Cola nodoActual = cabeza;

                string cola = "";

                while (nodoActual != null)
                {
                    int valorActual = nodoActual.Valor;
                    cola = cola +" " + valorActual.ToString();
                    nodoActual = nodoActual.Siguiente;
                }
                Console.WriteLine("*-*-*-*Empieza Cola*-*-*-*");
                Console.WriteLine(cola);
                Console.WriteLine("*-*-*-*Termina Cola*-*-*-*");
            }           
        }

        public void Ejercicio3_Cola()
        {
            Llenar_Cola();
            Imprimir_Cola();
            Shell_Sort();
            //Imprimir_Cola();
        }

        public void Llenar_Cola()
        {
            Random random = new Random();
            for( int i = 0; i < 8; i++ ) 
            {
                Enqueue(random.Next(1,50));
            }
            refCabeza = cabeza;
        }

        public void Shell_Sort()
        {
            
            Controlador(refCabeza);
        }

        public void Controlador(NodoInt_Cola refCabeza)
        {
            int gap = length / 2;
            while (!Lista_Ordenada())
            {
                gap = length / 2;
                while (gap > 0)
                {
                    Recorrer_cola(refCabeza, gap);
                    gap /= 2;
                }
            }
            
        }

        public void Recorrer_cola(NodoInt_Cola nodoActual, int gap)
        {
            if(nodoActual.Siguiente!= null||!Lista_Ordenada())
            {
                Console.WriteLine("Gap: " + gap);
                int valor_1 = nodoActual.Valor;
                for (int i = 0; i < gap; i++)
                {
                    nodoActual = nodoActual.Siguiente;
                }
                int valor_2 = nodoActual.Valor;

                //Console.WriteLine("Valor 1: " + valor_1 + "/ Valor 2: " + valor_2);

                //Se realiza el intercambio de valores
                if (valor_1 > valor_2)
                {
                    nodoActual.Valor = valor_1;
                    for (int i = gap; i > 0; i--)
                    {
                        nodoActual = nodoActual.Siguiente;
                        Enqueue(Dequeue().Valor);
                    }
                    nodoActual.Valor = valor_2;
                    refCabeza = nodoActual;
                    Console.WriteLine("Se cambiaron valores");

                    //Se vuelve al mismo formato de antes de la lista
                    for (int i = gap; i > 0; i--)
                    {
                        nodoActual = nodoActual.Siguiente;
                        Enqueue(Dequeue().Valor);
                    }
                }

                Imprimir_Cola();
                //Console.WriteLine(refCabeza.Valor);
                nodoActual = refCabeza;

                //Se actualiza la cabeza por haberse encontrado el valor minimo, y para eventualmente ayudar a imprimir en orden la lista
                if (refCabeza.Valor < cabeza.Valor)
                {
                    cabeza = refCabeza;
                }
                //Console.WriteLine(nodoActual.Valor);

                nodoActual = nodoActual.Siguiente;
                refCabeza.Siguiente = nodoActual;
                //Console.WriteLine(nodoActual.Valor);
                Recorrer_cola(nodoActual, gap);
            }
        }

        public bool Lista_Ordenada()
        {
            NodoInt_Cola _nodoActual = cabeza;
            while (_nodoActual != null && _nodoActual.Siguiente != null)
            {
                if (_nodoActual.Valor > _nodoActual.Siguiente.Valor)
                {
                    return false;
                }
                _nodoActual = _nodoActual.Siguiente;
            }
            return true;
        }
    }
}
