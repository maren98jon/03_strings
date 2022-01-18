/*
 * En el ejemplo anterior hemos visto como podemos obtener la posición de un carácter dentro de una cadena de texto. Pero,  ¿Qué pasa si lo que
 * queremos es buscar una cadena en sí? Es decir, en vez de un sólo caracter una cadena. 
 * 
 * En este caso la sintaxis sería la misma, lo único diferente es que el valor que nos devuelve el método se corresponde 
 * con la posición del primer carácter de la cadena que estamos buscando.
 */
using System;

namespace _13_Ejemplo_IndexOf
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Primero vamos a declarar una variable a la que le asignamos un cadena de texto, la que queramos.
             */

            string nombre = "Elena";

            /*
             * Después,  utilizamos el método IndexOf() al cual le pasamos entre paréntesis la cadena de texto de la que queremos conocer su posición "elen". 
             * En este caso el método nos devolverá la posición donde se encuentra el primer carácter de la cadena, es decir, la primera "e". 
             */
            int posicion = nombre.IndexOf("Elen");

            //Por lo tanto, si mostramos por consola el valor de la variable posicion veremos que es igual a 0. 

            Console.WriteLine(posicion);

            /*Es importante saber que la cadena de texto que le pasamos debe estar exactamente como se encuentra en la cadena inicial
             * en cuanto a mayúsculas y minúsculas se refiere. Si intentamos buscar "elen" en vez de "Elen" como se encuentra en la cadena
             * principal, el método nos devolverá -1, que es lo que el método devuelve cuando no encuentra lo que le hemos pasado entre paréntesis
             *¿Por qué -1? Por que es la única posición que no puede contener ningún string, recordad que los caracteres de un string van de 0 a su 
            *longitud menos 1*/

            posicion = nombre.IndexOf("elen");

            /*Si mostramos ahora el valor de posición veremos que es igual a -1*/
            Console.WriteLine(posicion);

        }
    }
}
