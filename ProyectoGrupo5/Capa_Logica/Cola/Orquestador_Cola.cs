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

        public void Ejercicio3_Cola()
        {
            Llenar_Cola();
            Imprimir_Cola();

            //Imprimir_Cola();
        }

        public void Llenar_Cola()
        {
            Random random = new Random();
            for( int i = 0; i < 5; i++ ) 
            {
                Enqueue(random.Next(1,50));
            }
        }
    }
}
