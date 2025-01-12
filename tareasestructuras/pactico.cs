using System;
using System.Collections.Generic;
using System.Threading;
List<string> Asignaturas = new List<string> { "Ciencias Naturales", "Matemáticas" };
Asignaturas.Add("Química");
Asignaturas.Add("Estudios Sociales");

 Console.WriteLine("MATERIAS ACTUALES");
 Console.WriteLine();
foreach (string materias in Asignaturas)

{
  Console.WriteLine(materias.ToUpper());
}

    

