/*
 * Escribe un programa que dada una cadena identifique los caracteres del 5 al 10, ambos inclusive.
 */
using System;

namespace _07_Ejercicio_Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            //Introduce aquí tu código
            Console.WriteLine("Introduce un string: ");
            string nombre = Console.ReadLine();
            string subcadena = nombre.Substring(4, 6);
            Console.WriteLine(subcadena);
         
        }
    }
}
