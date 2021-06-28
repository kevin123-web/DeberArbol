using System;

namespace DeberArbol1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola eucalipto");
            Console.ReadLine();

            Nodo raiz = new Nodo
            {

                Valor = "*",
                Nivel = 0,
                Hijos =
                {
                    new Nodo
                    {
                        Valor="+",
                        Hijos=
                        {
                            new Nodo
                            {
                                Valor="1"
                            },
                            new Nodo
                            {
                                Valor ="0"
                            }
                        }
                    },
                    new Nodo
                    {
                        Valor = "-",
                        Hijos =
                        {
                            new Nodo
                            {
                                Valor="12"
                            },
                            new Nodo
                            {
                                Valor="10"
                            }
                        }
                    },
                    new Nodo
                    {
                        Valor="/",
                        Hijos=
                        {
                            new Nodo
                            {
                                Valor="9"
                            },
                            new Nodo
                            {
                                Valor="9"
                            }
                        }
                    }
                }
            };

            ContadorArbol controladorArbol = new ContadorArbol();
            Console.WriteLine("EL contador de hojas es : ");
            Console.WriteLine(controladorArbol.ContadorHojas(raiz));
            Console.ReadLine();
            Console.WriteLine("El contador de niveles es: ");
            Console.WriteLine(controladorArbol.ContadorNiveles(raiz));
            Console.ReadLine();
            Console.WriteLine("El contador de nodos es : ");
            Console.WriteLine(controladorArbol.ContadorNodos(raiz));
        }
    }
}
