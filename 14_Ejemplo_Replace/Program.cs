﻿/*
 * El método Replace, como su propio nombre indica, reemplaza un carácter o caracteres de una cadena por otros caracteres. 
 * El método toma dos parámetros. Son las cadenas que aparecen entre paréntesis. La primera cadena es el texto que se va a buscar. 
 * La segunda cadena es el texto por el que se va a reemplazar. 
*/
using System;

namespace _14_Ejemplo_Replace
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Primero declaramos una variable string a la cual le asignamos una cadena de texto, en este caso "elefante"*/
            string animal = "elefante";
            /*Después, declaramos una segunda variable string a la que le vamos a asignar el resultado de reemplazar en la cadena (animal) la letra
             "e" por la "a". Para ello utilizamos el método replace al cual le pasamos primero el carácter o caracteres que deseamos reemplazar, y segundo
            el caracter o caracteres por el que queremos reemplazar el anterior. 
            
             Debéis tener en cuenta, que al igual que con el método IndexOf(), las mayúsculas y minúsculas si importan, esto quiere decir que si 
            nosotros en la cadena "elefante" pusiéramos la primera "e" en mayúsculas "Elefante" el valor de (reemplazado) no sería el mismo. 
            En ese caso su valor sería "Elafanta", por que no identificaría como iguales la "e" de la "E". 
            En el caso actual en el que nuestros caracteres están todos en minúsculas el valor de reemplazo sería "alafanta". Podeís hacer cambios
            en el proyecto y ejecutarlo para ver y entender mejor este concepto*/
            string reemplazado = animal.Replace("e", "a");
            Console.WriteLine(reemplazado);
        }
    }
}
