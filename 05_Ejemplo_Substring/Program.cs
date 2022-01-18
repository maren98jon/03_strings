﻿/*
 Aparte de obtener la longitud de un string, también podemos recuperar una subcadena 
de una cadena texto dada. Para eso utilizamos el método substring. 
 */
using System;

namespace _05_Ejemplo_Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Primero necesitamos un string del que partir, el que será la cadena de texto de referencia. Para ello declaramos una variable 
            a la cual le asignamos un string, en este caso un nombre. 
             */
            string nombre = "Jasone";
          /*
           Una vez tenemos el string del que queremos partir, utilizamos el método substring para obtener una subcadena. La 
          sintaxis es siempre la misma primero indicamos la cadena inicial , en este caso 'nombre', y después utilizamos el método substring al que le 
          pasamos dos valores. 

          El primero, corresponde con la posición del caracter por el que queremos que empiece nuestra subcadena y el segundo con la cantidad de 
          caracteres que debe coger desde el primero. Hay que destacar que el primer caracter de un string ocupa la posición 0, por eso, Jasone por ejemplo
          que es un string compuesto por 6 caracteres, realmente en cuanto a posición se refiere  va de 0 a 5, la 'J' ocupa la posición 0  del string
          la 'a' la 1, la 's' la 2... así hasta la 'e' que ocuparía la posición 5. 
          
           */
            string subcadena = nombre.Substring(0, 3);
            /*
             El método Substring nos devuelve una cadena de texto también, esto significa que en la variable 'subcadena' vamos a almacenar un string compuesto por 3 
            caracteres, concretamente los 3 primeros del string 'nombre' por que al método subtstring le hemos indicado que queremos 
            recuperar una subcadena partiendo de la cadena 'nombre', y que dicha subcadena debía contener los caracteres desde el 0 
            (primer caracter del string 'nombre') y coger 3 caracteres. Esta nueva subcadena se alacena en la variable string subcadena.
            Con lo que si ejecutamos el programa veremos que subcadena 
            es igual a 'Jas'
             */
            Console.WriteLine(subcadena);
        }
    }
}
