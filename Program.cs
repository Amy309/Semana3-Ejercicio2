// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ejercicio 2\n");

        string nombre = "AMY NOELIA";
        int longitud = nombre.Length;

        char[] arregloNombre = new char[longitud];

        for (int i = 0; i < longitud; i++)
        {
            arregloNombre[i] = nombre[i];
            Console.WriteLine("Valor en posición " + i + ": " + arregloNombre[i]);
        }

        Console.WriteLine("");

        Console.WriteLine("Tamaño del arreglo: " + longitud);
    }
}

