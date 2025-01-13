using System;
using System.Collections.Generic;



namespace NumerosInversos
{
    class Program
    {
        static void Run()
        {
            // Crear una lista para almacenar los números
            List<int> numeros = new List<int>();

            // Agregar los números del 1 al 10 a la lista
            for (int i = 1; i <= 10; i++)
            {
                numeros.Add(i);
            }

            // Invertir el orden de los números en la lista
            numeros.Reverse();

            // Mostrar los números por pantalla, separados por comas
            Console.Write("Los números en orden inverso son: ");
            for (int i = 0; i < numeros.Count; i++)
            {
                Console.Write(numeros[i]);
                if (i < numeros.Count - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }
    }
}
