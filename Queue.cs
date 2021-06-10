using System;
using System.Collections.Generic;

namespace P6_Queue
{
    class Queue
    {
        Queue<Clientes> fila = new Queue<Clientes>();

        public void Enqueue(string nombre, string producto)
        {
            this.fila.Enqueue(new Clientes(nombre, producto));
        }

        public Clientes Dequeue()
        {
            int clientesAtendidos = 0;
            if (this.fila.Count == 0)
            {
                return null;
            }

            Clientes value = this.fila.Dequeue();
            clientesAtendidos = (clientesAtendidos + 1);
            return value;
        }

        public int ClientesEnFila()
        {
            int count = this.fila.Count;
             if (count == 0)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("No hay personas formadas en la fila.");
                        Console.WriteLine("");
                    }
                    else if (count == 1)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Actualmente hay: " + count + " persona en la fila.");
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Actualmente hay: " + count + " personas en la fila.");
                        Console.WriteLine("");
                    }
            return count;
        }
    }    
}        