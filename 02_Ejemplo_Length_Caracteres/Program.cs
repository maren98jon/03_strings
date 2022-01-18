/*
 *En este ejemplo observamos como el programa que a primera vista se parece mucho al ejemplo anterior nos da 
 *un resultado un poco diferente, teniendo el nombre los mismos caracteres que el ejemplo anterior el resultado
 *nos indica que nombre está compuesto por 12 caracteres. 
 *
 *Esto es por que lo que nos devuelve Length es el número de caracteres donde se incluyen los espacios. 
 *Es algo que tenemos que tener en cuenta y con lo que tenemos que tener mucho cuidado.
 */
using System;

namespace _02_Ejemplo_Length_Caracteres
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = "   Elena    ";
            int numeroLetras = nombre.Length;
            Console.WriteLine("El nombre tiene " + numeroLetras + " caracteres");
        }
    }
}
