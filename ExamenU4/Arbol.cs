using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenU4
{
    class Arbol
    {
        public class ArbolBO
        {
            public void Imprimir_1()
            {
                ArbolBin arbol = new ArbolBin();

                arbol.raiz = new Nodo("A");
                arbol.raiz.Izquierda = new Nodo("B");
                arbol.raiz.Medio = new Nodo("C");
                arbol.raiz.Derecha = new Nodo("D");
                arbol.raiz.Izquierda.Izquierda = new Nodo("E");
                arbol.raiz.Izquierda.Medio = new Nodo("F");
                arbol.raiz.Izquierda.Derecha = new Nodo("G");
                arbol.raiz.Derecha.Izquierda = new Nodo("H");
                arbol.raiz.Derecha.Medio = new Nodo("I");
                arbol.raiz.Derecha.Derecha = new Nodo("J");
                arbol.raiz.Izquierda.Izquierda.Izquierda = new Nodo("K");
                arbol.raiz.Izquierda.Izquierda.Medio = new Nodo("L");
                arbol.raiz.Izquierda.Izquierda.Derecha = new Nodo("M");
                arbol.raiz.Izquierda.Derecha.Medio = new Nodo("N");
                arbol.raiz.Derecha.Izquierda.Medio = new Nodo("O");
                arbol.raiz.Derecha.Derecha.Izquierda = new Nodo("P");
                arbol.raiz.Derecha.Derecha.Derecha = new Nodo("Q");
                arbol.raiz.Izquierda.Derecha.Medio.Izquierda = new Nodo("R");
                arbol.raiz.Izquierda.Derecha.Medio.Derecha = new Nodo("S");

                Console.WriteLine("Arbol A");
                Console.WriteLine("Preorden del arbol es ");
                arbol.PrintPreorder();
                Console.WriteLine();
                Console.WriteLine("\nPostorden del arbol es ");
                arbol.PrintPostorder();
                Console.WriteLine();
                Console.ReadKey();
            }
            public void Imprimir()
            {
                ArbolBin arbol = new ArbolBin(); // crea un objeto arbol de BinaryTree

                arbol.raiz = new Nodo("A");
                arbol.raiz.Izquierda = new Nodo("B");
                arbol.raiz.Derecha = new Nodo("E");
                arbol.raiz.Izquierda.Izquierda = new Nodo("C");
                arbol.raiz.Izquierda.Derecha = new Nodo("D");
                arbol.raiz.Derecha.Derecha = new Nodo("F");
                arbol.raiz.Derecha.Derecha.Izquierda = new Nodo("G");
                arbol.raiz.Derecha.Derecha.Derecha = new Nodo("H");

                Console.WriteLine("Arbol B");
                Console.WriteLine("Recorrido preorden " + "del arbol es ");
                arbol.PrintPreorder();
                Console.WriteLine();
                Console.WriteLine("\nRecorrido postorden " + "del arbol es ");
                arbol.PrintPostorder();
                Console.WriteLine();
                Console.ReadKey();
            }
            public class Nodo
            {
                public string x;
                public Nodo Izquierda, Derecha, Medio;

                public Nodo(string y)
                {
                    x = y;
                    Izquierda = Derecha = Medio = null;
                }
            }

            public class ArbolBin
            {
                public Nodo raiz;
                public ArbolBin()
                {
                    raiz = null;
                }
                public void PostOrden(Nodo node)
                {
                    if (node == null)
                        return;

                    PostOrden(node.Izquierda);

                    PostOrden(node.Medio);


                    PostOrden(node.Derecha);


                    Console.Write(node.x + " ");
                }
                public void PreOrden(Nodo node)
                {
                    if (node == null)
                        return;

                    Console.Write(node.x + " ");

                    PreOrden(node.Izquierda);

                    PreOrden(node.Medio);

                    PreOrden(node.Derecha);
                }
                public void PrintPostorder() { PostOrden(raiz); }
                public void PrintPreorder() { PreOrden(raiz); }
            }
            public void MenuArboles()
            {
                int Menu = 0;
                do
                {
                    Console.Clear();
                    Console.Write("Opciones: \n1.-Arbol A \n2.-Arbol B \n3.-Salir");
                    Menu = Convert.ToInt16(Console.ReadLine());
                    switch (Menu)
                    {
                        case 1:
                            Console.Clear();
                            Imprimir_1();
                            Console.ReadKey();
                            break;
                        case 2:
                            Console.Clear();
                            Imprimir();
                            Console.ReadKey();
                            break;
                        case 3:
                            Console.WriteLine("Adios");
                            Console.ReadKey();
                            break;
                    }
                } while (Menu != 3);
            }
        }
    }
}