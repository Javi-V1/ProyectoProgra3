using Capa_Modelo.Cola;
using Capa_Modelo.Nodo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Modelo.Pila
{
    public class NodoInt_Pila : Nodo<int, NodoInt_Pila>
    {
        public override int Valor { get; set; }
        public override NodoInt_Pila Siguiente { get; set; }

        public NodoInt_Pila(int _valor)
        {
            Valor = _valor;
            Siguiente = null;
        }
    }
}
