/*
 * Escribe un programa que convierta a mayúsculas una frase que pides al usuario por consola. 
 */
using System;

namespace _11_Ejercicio_ToUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            //Introduce aquí tu código
            Console.WriteLine("Introduce una frase en minus:");
            string minus = Console.ReadLine();
            string mayus = minus.ToUpper();
            Console.WriteLine(mayus);
        }
    }
}
