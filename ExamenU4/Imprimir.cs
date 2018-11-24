using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenU4
{
    class Imprimir
    {
        public void Desplegar()
        {
            Seleccion:
            Console.Clear();
            Console.WriteLine("Seleccione la Ruta deseada:\n1) Boston->LA\n2)NewYork->San Francisco\n3)Atlanta->San Francisco\n4)Denver->NewYork\n5)Salir");
            int numero = int.Parse(Console.ReadLine());
            if (numero == 1)
            {
                Grafo grafo = new Grafo(5);
                grafo.AgregarALista(0, 1);
                grafo.AgregarALista(1, 2);
                grafo.AgregarALista(2, 3);
                grafo.BuscaCamino(0, 1);
                Console.ReadKey();
                goto Seleccion;
            }

            if (numero == 2)
            {
                Grafo grafo = new Grafo(7);
                grafo.AgregarALista(0, 1);
                grafo.AgregarALista(1, 2);
                grafo.AgregarALista(2, 3);
                grafo.AgregarALista(4, 5);
                grafo.BuscaCamino(4, 2);
                Console.ReadKey();
                goto Seleccion;
            }

            if (numero == 3)
            {
                Grafo grafo = new Grafo(4);
                grafo.AgregarALista(0, 1);
                grafo.AgregarALista(1, 2);
                grafo.BuscaCamino(0, 3);
                Console.ReadKey();
                goto Seleccion;
            }

            if (numero == 4)
            {
                Grafo grafo = new Grafo(4);
                grafo.AgregarALista(0, 1);
                grafo.AgregarALista(1, 2);
                grafo.BuscaCamino(0, 4);
                Console.ReadKey();
                goto Seleccion;
            }
            if (numero == 5)
            {
                Console.Clear();
                Console.WriteLine("Adios");
                Console.ReadKey();
            }
        }
    }
}
    

