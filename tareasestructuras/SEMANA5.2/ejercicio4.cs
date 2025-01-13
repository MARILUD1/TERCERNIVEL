using System;
using System.Collections.Generic;


namespace LoteriaPrimitiva
{
    class Program
    {
        static void Run()
        {
            Console.WriteLine("Ingrese los números ganadores de la Lotería Primitiva (separados por coma):");

            // Obtener los números del usuario como una cadena
            string entrada = Console.ReadLine();

            // Dividir la cadena en un arreglo de números
            string[] numerosStr = entrada.Split(',');

            // Convertir los números de cadena a enteros y almacenarlos en una lista
            List<int> numerosGanadores = new List<int>();
            foreach (string numeroStr in numerosStr)
            {
                if (int.TryParse(numeroStr, out int numero))
                {
                    numerosGanadores.Add(numero);
                }
                else
                {
                    Console.WriteLine($"El valor '{numeroStr}' no es un número válido.");
                }
            }

            // Ordenar la lista de menor a mayor
            numerosGanadores.Sort();

            // Mostrar los números ordenados
            Console.WriteLine("Los números ganadores ordenados son:");
            foreach (int numero in numerosGanadores)
            {
                Console.WriteLine(numero);
            }
        }
    }
}