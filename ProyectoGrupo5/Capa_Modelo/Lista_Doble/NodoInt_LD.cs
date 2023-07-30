using Capa_Modelo.Nodo;

namespace Capa_Modelo.LD
{
    public class NodoInt_LD : Nodo<int, NodoInt_LD>
    {
        public override int Valor { get; set; }
        public override NodoInt_LD Siguiente { get; set; }
        public NodoInt_LD Anterior { get; set; } 

        public NodoInt_LD(int _valor)
        {
            Valor = _valor;
            Siguiente = null;
            Anterior = null;
        }
    }
}
