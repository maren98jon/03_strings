/*
 Algo que nos puede resultar de gran utilidad a la hora de crear un programa es conocer la presencia de un caracter en concreto
dentro de una cadena de texto y, sobretodo la posición del mismo. Esto es lo que nos proporciona este método IndexOf();
A este método le pasamos (entre paréntesis) un string, compuesto por un carácter  y este nos devuelve la posición (int) del mismo.

Es importante recordar que las posiciones de una cadena de texto empiezan siempre por 0.
 */
using System;

namespace _12_Ejemplo_IndexOf
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Veamos pues un ejemplo, primero vamos a declarar una variable a la que le asignamos un string, el que queramos.
            */
            string nombre = "Elena";

            /*
             * Cómo hemos comentado anteriormente, IndexOf() nos devuelve una posición, es decir, un número. Por eso el valor que nos devuelve dicho
             * método tenemos que almacenarlo en una variable int.
             * 
             * En este caso, sólo tenemos que indicar el string o la cadena de texto de la que partimos (nombre), punto y el nombre del método
             * (IndexOf) y entre paréntesis indicar el caracter que queremos buscar. 
             */

            int posicion = nombre.IndexOf("l");

            /*En este punto la variable posicion almacenará un valor, un número, que se corresponde con la posición de la letra l dentro del 
             nombre Elena, con lo que si mostramos por consola su valor, este tendrá un valor de 1*/
            Console.WriteLine(posicion);
        }
    }
}
