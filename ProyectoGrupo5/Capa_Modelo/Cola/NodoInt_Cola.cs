using Capa_Modelo.Nodo;

namespace Capa_Modelo.Cola
{
    public class NodoInt_Cola : Nodo<int, NodoInt_Cola>
    {
        public override int Valor { get; set; }
        public override NodoInt_Cola Siguiente { get; set; }

        public NodoInt_Cola(int _valor)
        {
            Valor = _valor;
            Siguiente = null;
        }
    }
}
