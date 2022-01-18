/*
Siguiendo los ejemplos anteriores escribe un programa que cambie a minúsculas una frase en mayúsculas.
 */
using System;

namespace _10_Ejercicio_Tolower
{
    class Program
    {
        static void Main(string[] args)
        {
            //Introduce aquí tu código
            Console.WriteLine("Introduce una frase en mayusc:");
            string mayus = Console.ReadLine();
            string minus = mayus.ToLower();
            Console.WriteLine(minus);
      
        }
    }
}
