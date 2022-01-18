/*
 * Escribe un programa que recupere una subcadena de un string en otra variable usando una función.
 */
using System;

namespace _07_Ejercicio_Substring2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Introduce aquí tu código
            Console.WriteLine("Introduce una cadena de caracteres:");
            string cadena = Console.ReadLine();


            string cadena1 = cadena.Substring(2, 4);
            Console.WriteLine(cadena1);
        }
    }
}
