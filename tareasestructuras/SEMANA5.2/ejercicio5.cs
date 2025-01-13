//Escribir un programa que almacene en una lista los números del 1 al 10 y los muestre por pantalla en orden inverso separados por comas.

using System;
using System.Collections.Generic;
using System.Linq;

class Sorteo
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

        // Ordenar los números de menor a mayor
        numeros.Sort();

        // Mostrar los números ordenados por pantalla
        Console.Write("Los números ordenados son: ");
        foreach (int numero in numeros)
        {
            Console.Write(numero + " ");
        }
        Console.WriteLine();
    }

    static void EjecutarPrograma(string[] args)
    {
        Run();
    }
}
    
