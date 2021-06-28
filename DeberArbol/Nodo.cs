using System.Collections.Generic;


namespace DeberArbol1
{
    class Nodo
    {
        public int Id { get; set; }

        public string Valor { get; set; }

        public List<Nodo> Hijos { get; set; } = new List<Nodo>();

        public int Nivel { get; set; }

        public int nodoRaiz = 1;
    }
}