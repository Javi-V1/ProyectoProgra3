using Capa_Modelo.Cola;

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

        /// <summary>
        /// Desencole los nodos con valor par
        /// </summary>
        public void Dequeue_Pares() {

            if (Cabeza_No_Nula())
            {
                NodoInt_Cola nodoActual = cabeza;

                int tamanno = length;

                for (int i = 0; i < tamanno; i++)
                {
                    if (nodoActual.Valor % 2 == 0)
                    {
                        Dequeue();
                    }
                    else 
                    {
                        Enqueue(Dequeue().Valor);
                    }

                    nodoActual = cabeza;
                }
            }        
        }

        /// <summary>
        /// NO Encole una cola
        /// </summary>
        public void Enqueue_Queue() { 
        
        
        }

        /// <summary>
        /// Busque si el valor proporcionado existe
        /// </summary>
        /// <returns></returns>
        public bool Busque_Valor_En_Cola(int _valor) {

            NodoInt_Cola nodoActual = cabeza;
            int tamanno = length;
            bool resultado = false;

            for (int i = 0; i < tamanno; i++)
            {
                if (nodoActual.Valor == _valor)
                {
                    resultado = true;
                }
                nodoActual = cabeza;
            }

            return resultado;
        }

        /// <summary>
        /// Desencole la mitad de los elementos de la cola, si el número es impar,
        /// redondee hacia el número menor
        /// </summary>
        public void Dequeue_Mitad_Elementos() {

            int tamanno = 0;

            if (length % 2!=0 && length > 1)
            {
                tamanno = (length - 1 )/ 2 ;
            }
            if (length%2==0)
            {
                tamanno = length / 2;
            }

            for (int i = 0; i < tamanno; i++)
            {
                Dequeue();
            }
        }
    }
}
