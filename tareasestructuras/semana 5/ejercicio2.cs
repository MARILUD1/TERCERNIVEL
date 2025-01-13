//Escribir un programa que almacene las asignaturas de un curso (por ejemplo Matemáticas, Física, Química, Historia y Lengua) en una lista y la muestre 
//por pantalla el mensaje Yo estudio <asignatura>, donde <asignatura> es cada una de las asignaturas de la lista.


using System;
using System.Collections.Generic;

public class Curso
{
    public static void Run()
    {
        List<string> materias = new List<string>
        {
            "Matemáticas",
            "Física",
            "Química",
            "Historia",
            "Lengua"
        };

        foreach (var asignatura in materias)
        {
            Console.WriteLine($"Yo estudio {asignatura}");
        }
    }
}            