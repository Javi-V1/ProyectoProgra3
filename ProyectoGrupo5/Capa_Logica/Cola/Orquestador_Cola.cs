using Capa_Modelo.Cola;
using Capa_Modelo.LD;
using Capa_Modelo.Pila;
using System.Runtime.Serialization.Formatters;

namespace Capa_Logica.Cola
{
    public class Orquestador_Cola
    {
        private NodoInt_Cola cabeza;
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
            Imprimir_Cola();
        }

        public void Llenar_Cola()
        {
            Random random = new Random();
            for( int i = 0; i < 8; i++ ) 
            {
                Enqueue(random.Next(1,50));
            }
        }

        public void Shell_Sort()
        {
            //prueba(cabeza);
            Controlador(cabeza);
        }

        public void Controlador(NodoInt_Cola cabeza)
        {
            int gap = length / 2;
            while(gap > 0)
            {
                Recorrer_cola(cabeza, gap);
                gap/=2;
            }
        }

        public void Recorrer_cola(NodoInt_Cola nodoActual, int gap)
        {
            Console.WriteLine("gap : " + gap);


            int valor1 = nodoActual.Valor;
            for (int i = 0; i < gap; i++)
            {
                nodoActual = nodoActual.Siguiente;
            }
            int valor2 = nodoActual.Valor;

            if (valor1 > valor2)
            {
                //Enqueue(valor2);
                nodoActual.Valor = valor2;  

                for (int i = 0; i < length; i++)
                {
                    Enqueue(Dequeue().Valor);
                }

                // Enqueue(valor1);
                nodoActual.Valor= valor1;
                Console.WriteLine("Se cambiaron los valores " + valor1 + " por " + valor2);
                Imprimir_Cola();
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
