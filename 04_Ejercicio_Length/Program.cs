/*
 * Escribe un programa que te calcule la largura de un string que pides por consola.
 */
using System;

namespace _04_Ejercicio_Length
{
    class Program
    {
        static void Main(string[] args)
        {
            //Introduce aquí tu código
            Console.WriteLine("Introduce un string:");
            string nombre;
            nombre = Console.ReadLine();
            string nombsinesp = nombre.Trim();
            int larg = nombsinesp.Length;
            Console.WriteLine("El string que has introducido sin espacios es de: " + larg + " carácteres de largo.");
        }
    }
}
