using System.Linq;

namespace DeberArbol1
{
    class ContadorArbol
    {
        internal int ContadorHojas(Nodo nodo)
        {
            int acumulador = 0;
            foreach (Nodo actual in nodo.Hijos)
            {
                acumulador += actual.Valor.Count() + actual.Hijos.Count();
            }
            return acumulador;
        }

        internal int ContadorNodos(Nodo nodo)
        {
            int acumulador = 0;
            acumulador += nodo.nodoRaiz + nodo.Hijos.Count();
            foreach (Nodo actual in nodo.Hijos)
            {
                acumulador += actual.Hijos.Count();
            }
            return acumulador;
        }
        internal int ContadorNiveles(Nodo nodo)
        {
            int acumulador = 0;
            foreach (Nodo actual in nodo.Hijos)
            {
                acumulador += actual.Valor.Count();
            }
            return acumulador;
        }
    }
}
