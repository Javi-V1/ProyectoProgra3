using Capa_Modelo.Nodo;

namespace Capa_Modelo.LS
{
    public class NodoInt_LS: Nodo<int, NodoInt_LS>
    {
        public override int Valor { get; set; }
        public override NodoInt_LS Siguiente { get; set; }

        public NodoInt_LS(int _valor)
        {
            Valor = _valor;
            Siguiente = null;
        }
    }
}
