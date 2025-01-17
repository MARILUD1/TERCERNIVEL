using System;
using System.Collections.Generic;

class Nodo
{
    public int Valor;
    public Nodo Siguiente;

    public Nodo(int valor)
    {
        Valor = valor;
        Siguiente = null;
    }
}

class ListaEnlazada
{
    public Nodo Cabeza;

    public void Agregar(int valor)
    {
        Nodo nuevoNodo = new Nodo(valor);
        if (Cabeza == null)
        {
            Cabeza = nuevoNodo;
        }
        else
        {
            Nodo actual = Cabeza;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = nuevoNodo;
        }
    }

    public void EliminarFueraDeRango(int min, int max)
    {
        while (Cabeza != null && (Cabeza.Valor < min || Cabeza.Valor > max))
        {
            Cabeza = Cabeza.Siguiente;
        }

        Nodo actual = Cabeza;
        while (actual != null && actual.Siguiente != null)
        {
            if (actual.Siguiente.Valor < min || actual.Siguiente.Valor > max)
            {
                actual.Siguiente = actual.Siguiente.Siguiente;
            }
            else
            {
                actual = actual.Siguiente;
            }
        }
    }

    public void Mostrar()
    {
        Nodo actual = Cabeza;
        while (actual != null)
        {
            Console.Write(actual.Valor + " ");
            actual = actual.Siguiente;
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        ListaEnlazada lista = new ListaEnlazada();

        // Generar 50 números aleatorios
        for (int i = 0; i < 50; i++)
        {
            lista.Agregar(random.Next(1, 1000));
        }

        Console.WriteLine("Lista original:");
        lista.Mostrar();

        // Leer rango de valores
        Console.WriteLine("Ingrese el valor mínimo del rango:");
        int min = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el valor máximo del rango:");
        int max = int.Parse(Console.ReadLine());

        // Eliminar nodos fuera del rango
        lista.EliminarFueraDeRango(min, max);

        Console.WriteLine("Lista después de eliminar nodos fuera del rango:");
        lista.Mostrar();
    }
}