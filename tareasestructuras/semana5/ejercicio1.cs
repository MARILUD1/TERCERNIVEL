using System;
using System.Runtime.CompilerServices;

class Programa{
    static void Main()
    //Lista de almacenamiento de asignaturas
    {
    List<string> asignaturas = new List<string> {"Matematicas", "Estudios Sociales", "Cie|ncias Naturales","quimica", "Lengua y Literatura" };
    //Imprimir asignaturas
    foreach (var Materias in asignaturas)
    {Console.WriteLine(Materias);
    }
    } 
}