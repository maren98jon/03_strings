/*
 Hasta ahora hemos visto como podemos utilizar el método substring para recuperar 
una subcadena, pasándole al método PRIMERO la posición del caracter por el que queremos que empiece nuestra subcadena
y SEGUNDO  la cantidad de caracteres que debe coger desde dicha posición. 
Ahora veremos como podemos  recuperar una cadena desde la posición del caracter por el queu queremos que empiece nuestra
subcadena, hasta el final de la cadena de la que partimos*/
using System;

namespace _06_Ejemplo_Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Para eso partimos de un string inicial, el que será la cadena de texto de referencia. Para ello declaramos una variable 
            a la cual le asignamos un string, en este caso un nombre.Esta parte es la misma que en el ejemplo anterior */
            string nombre = "Jasone";
            /*A continuación declaramos una nueva variable a la que le vamos a asignar el valor que nos devuelva el método Substring. 
             Para ello utilizamos la misma sintaxis, la referencia a la variable que tiene almacenada el string del que queremos recuperar una subcadena,
            punto (.) y el nombre del método Substring. Cuando al método sólo le pasamos un número identifica que es el carácter por el que queremos 
            que empiece nuestra subcadena, y crea dicha subcadena desde ese carácter hasta el último carácter de la cadena desde la que partimos */
            string subcadena = nombre.Substring(2);
            /*Si mostramos por consola el valor de la variable subcadena, nos mostrará "sone"*/
            Console.WriteLine(subcadena);
        }
    }
}
