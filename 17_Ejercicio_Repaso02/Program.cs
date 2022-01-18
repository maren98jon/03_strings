/*
 * Escriba un programa que pida al usuario una suma y que te devuelva por consola los números que forman parte de la operación. 
 * Por ejemplo: 23+56 → el programa devolverá 23 y 56.
 * Pistas:
 * 1. Debes utilizar al menos 2 de los métodos que hemos visto anteriormente
 * 2. Primero necesitas localizar en que posición se encuentra el carácter (+) 
 * 3. Una vez sepas que posición ocupa dicho carácter, puedes recuperar una subcadena que devuelva el primer número 
 * y otra subcadena que contenga el segundo número
 */
using System;

namespace _17_Ejercicio_Repaso02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Introduce aquí tu código
            Console.WriteLine("Introduce una suma:");
            string suma = Console.ReadLine();
            int posi = suma.IndexOf("+");
            string num1 = suma.Substring(0, posi).Trim();
            string num2 = suma.Substring(posi + 1).Trim();
            Console.WriteLine("Has sumado: " + num1 + " y " + num2);

        }
    }
}
