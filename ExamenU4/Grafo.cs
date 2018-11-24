using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ExamenU4
{
    class Grafo
    {
        //Atributos
        public int Ciudades { get; set; } 

        List<int>[] Lista; 

        //Constructor

        public Grafo(int elemento)
        {
            Ciudades = elemento; 
            Lista = new List<int>[elemento]; 
            for (int i = 0; i < elemento; i++) 
            {
                Lista[i] = new List<int>();
            }
        }


        //Metodos 
        public void AgregarALista(int i, int elemento) // Agrega a la lista
        {
            Lista[i].Add(elemento); 
        }



        public void BuscaCamino(int Elemento, int Variable) //Busca la ruta
        {
            
            List<string> Ciudad = new List<string>();
            if (Variable == 1 || Variable == 2)
            {
                Ciudad.Add("Boston");
                Ciudad.Add("Chicago");
                Ciudad.Add("Denver");
                Ciudad.Add("Los Angeles");
                Ciudad.Add("New York");
                Ciudad.Add("San Francisco");
                Ciudad.Add("Miami");
                Ciudad.Add("Atlanta");
            }
            if (Variable == 3)
            {
                Ciudad.Add("Atlanta");
                Ciudad.Add("Chicago");
                Ciudad.Add("San Francisco");
                Ciudad.Add("Boston");
                Ciudad.Add("Denver");
                Ciudad.Add("Los Angeles");
                Ciudad.Add("New York");
                Ciudad.Add("Miami");
            }
            if (Variable == 4)
            {
                Ciudad.Add("Denver");
                Ciudad.Add("Chicago");
                Ciudad.Add("New York");
                Ciudad.Add("Atlanta");
                Ciudad.Add("San Francisco");
                Ciudad.Add("Boston");
                Ciudad.Add("Los Angeles");
                Ciudad.Add("Miami");
            }

            bool[] Recorrido = new bool[Ciudades]; 
            Stack<int> Pila = new Stack<int>(); 
            Recorrido[Elemento] = true; 
            Pila.Push(Elemento); 
            Console.SetCursorPosition(0, 8);
            Console.WriteLine("La ruta es: ");          
            while (Pila.Count != 0)
            {
                Elemento = Pila.Pop(); 
                Console.Write("{0}.- ", Ciudad[Elemento]);                
                foreach (int i in Lista[Elemento]) 
                {
                    if (!Recorrido[i]) 
                    {
                        Recorrido[i] = true; 
                        Pila.Push(i); 
                    }
                }
            }
            Console.Write("Fin ");
        }
    }
}