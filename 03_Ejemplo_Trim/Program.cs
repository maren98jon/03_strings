/*
 * Podemos eliminar los espacios INICIALES y FINALES de una cadena de texto a través del método Trim.
 */
using System;

namespace _03_Ejemplo_Trim
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             * Primero declaramos la variable y le asignamos una cadena de texto con espacios al inicio y al final de la cadena
             */
            string nombre = "   Elena    ";
            /*
             * Después utilizamos el método Trim() que elimina esos espacios
             */
            string nombreSinEspacios = nombre.Trim();
            /*
             * Finalmente, utilizamos la propiedad Length que nos devuelve el número de caracteres que contiene el string almacenado en la
             * variable nombreSinEspacios que es donde tenemos almacenada la cadena sin los espacios
             */
            int numeroLetras = nombreSinEspacios.Length;
            /*
             * Por último mostramos por consola un mensaje con el número de caracteres de la cadena
             */
            Console.WriteLine("El nombre tiene " + numeroLetras + " caracteres");
        }
    }
}
