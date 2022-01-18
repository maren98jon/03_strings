/*
 * Escribe un programa que reemplace una cadena por otra (Por ejemplo “Hola Arrate” por “Hola Iker”).
 */
using System;

namespace _15_Ejercicio_Replace
{
    class Program
    {
        static void Main(string[] args)
        {
            //Introduce aquí tu código
            string inicial = "Hola Arrate";
            string cambiada = inicial.Replace("Arrate", "Iker");
            Console.WriteLine("Este es el string inicial          " + inicial);
            Console.WriteLine("Este es el string reemplazado      " + cambiada);
        }
    }
}
