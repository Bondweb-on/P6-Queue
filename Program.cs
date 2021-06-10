using System;
using System.Collections.Generic;

namespace P6_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Clientes> fila = new Queue<Clientes>();

            Clientes pepe = new Clientes("Pepe", "Dr.Pepper");
            Clientes jotaro = new Clientes("Jotaro", "onigiri");
            Clientes joseph = new Clientes("Joseph", "Coca-Cola");

            string opcion = "";
            while (opcion != "9")
            {
                opcion = "";
                while (opcion != "1" && opcion != "2" && opcion != "3" && opcion != "4" && opcion != "5" && opcion != "6" && opcion != "9")
                {
                    Console.WriteLine("1) Formarse");
                    Console.WriteLine("2) ¿Cuántos clientes están formados?");
                    Console.WriteLine("3) ¿Quién sigue?");
                    Console.WriteLine("4) Atender");
                    Console.WriteLine("5) ¿Qué va a comprar cada cliente formado?");
                    Console.WriteLine("6) ¿Cuántos clientes en total se han atendido?");
                    Console.WriteLine("9) Salir");

                    Console.WriteLine("Por favor selecciona una opción:");
                    opcion = Console.ReadLine();

                    if (opcion != "1" && opcion != "2" && opcion != "3" && opcion != "4" && opcion != "5" && opcion != "6" && opcion != "9")
                    {
                        Console.WriteLine("La opción seleccionada no es correcta.");
                    }
                }

                if (opcion == "1")
                {
                    Console.WriteLine("Escribe el nombre del cliente:");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("Escribe el producto que el cliente va a comprar:");
                    string producto = Console.ReadLine();
                    fila.Enqueue(new Clientes(nombre, producto));
                }
                else if (opcion == "2")
                {
                    int clientesFormados = fila.ClientesEnFila();
                    Console.WriteLine(clientesFormados);
                }
            }
        }
    }
}
