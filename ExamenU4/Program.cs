using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenU4
{
    class Program
    {
        static void Main(string[] args)
        {
             INICIO:
            Console.WriteLine("¿Que numero de ejercicio?");
            Console.WriteLine("1.Grafo \n 2.Arbol \n 0.salir");//0 para que se realize la accion default que es salirse
            int numero = int.Parse(Console.ReadLine());

            switch (numero)
            {
                case 1:
                    Console.Clear();
                    Imprimir imprimir = new Imprimir();
                    imprimir.Desplegar();

                    Console.ReadKey();
                    goto INICIO;//regresa a inicio
                    
                case 2:
                    Console.Clear();
                    Arbol.ArbolBO a = new Arbol.ArbolBO();
                    a.MenuArboles();
                    Console.ReadKey();
                    goto INICIO;
                default:
                    Console.Clear();
                    Console.WriteLine("Adios");
                    break;
                   
            }

        }
    }
}
