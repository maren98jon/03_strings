/*
 * Podemos obtener la longitud de una cadena mediante Length. 
 * Length es una propiedad de una cadena que devuelve el número de caracteres que esta contiene
 */
using System;

namespace _01_Ejemplo_Length
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Primero declaramos una variable que almacena una cadena de texto, este será el string de referencia, del que queremos conocer 
            el número de caracteres que contiene*/
            string nombre = "Elena";

            /*A continuación, utilizando como referencia dicha variable string obtenemos el número de caracteres que componen la cadena de 
             * texto, y lo hacemos a través de la propiedad  .Length que nos devuelve el número (int) de caracteres, por eso almacenamos el resultado 
             * en una variable de tipo int. 
             * La sintaxis es la siguiente --> nombre de la variable que almacena el string de referencia, punto (. ) y el nombre de la 
             * propiedad Length, que nos devuelve el número de caracteres que contiene ese string en concreto
             */

            int numeroLetras = nombre.Length;

            Console.WriteLine("El nombre tiene " + numeroLetras + " caracteres");
        }
    }
}
