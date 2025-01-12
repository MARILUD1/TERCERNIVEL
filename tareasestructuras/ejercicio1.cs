using System;
using System.Collections.Generic;
using System.Threading;
List<string>Nombre= new List<string> { "Manuel", "Juan" };
Nombre.Add("Andres");
Nombre.Add("Maria");

 Console.WriteLine("MATERIAS ACTUALES");
 Console.WriteLine();
foreach (string contactos in Nombre)

{
  Console.WriteLine(contactos.ToUpper());
}

    
