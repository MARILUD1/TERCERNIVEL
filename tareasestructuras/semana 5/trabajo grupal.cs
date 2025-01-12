
using System;
using System.Collections.Generic;

public class Agena

  //Crear una lista de contactos (nombre, numero de telefono)
{
    public static void Run()
    {
      List<Tuple<string, string>> contactos = new List<Tuple<string, string>>();//crear Agenda

      contactos.Add(Tuple.Create("Maria","0956321766"));
      contactos.Add(Tuple.Create("Leonel","09877644"));
      contactos.Add(Tuple.Create("Lucia","209754332"));
      contactos.Add(Tuple.Create("Jacinto","05646543"));
      contactos.Add(Tuple.Create("Eduardo","2300782"));

      //IMPRIMIR AGENDA
     
        Console.WriteLine("registrados");
        foreach (var registrados in contactos)
        
      {
          Console.WriteLine($"{registrados.Item1}:{registrados.Item2}");
      }
          
           Console.ReadKey();
   }
}