﻿/*
 * Ahora veremos otro método que nos permite modificar las cadenas de texto.En este caso, utilizaremos el método ToLower() que nos permite 
 * pasar cada caracter de un string a minúsculas.
 */
using System;

namespace _08_Ejemplo_ToLower
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Primero declaramos una variable string a la cual vamos a asignar una palabra en mayúsculas. También podemos partir de una palabra
            con mayúsculas y minúsculas. Veremos los dos ejemplos.
             */
            string palabra = "SUPERCALIFRAGILISTICOESPIALIDOSO";
            /* Después, declaramos otra variable a la cual le asignamos el resultado de convertir todos los caracteres del string  almacenado en
             * la variable 'palabra' a minúsculas. Para ello, utilizamos el nombre de la variable donde almacenamos el string que queremos modificar
             * punto, y el nombre del método --> ToLower()*/
            string palabraMinuscula = palabra.ToLower();
            /*
             Por último, sólo queda mostrar el resultado por consola*/
            Console.WriteLine(palabraMinuscula);

            /*
             Ahora veremos también el resultado de convertir a miníusculas todos los caracteres de un string que tiene tanto minúsculas 
            como mayúsculas. Para eso reutilizamos la variable 'palabraMinuscula' donde almacenaremos el resultado de convertir el string 
            a minúsculas*/
            string palabraMedia = "SuperCALIfragiLISTIcoespiALIDOSO";
            palabraMinuscula = palabraMedia.ToLower(); /*Como ya hemos declarado anteriormente la variable (palabraMinuscula) no 
                                                        *  tenemos que volver a declararla, simplemente estamos asignándole un nuevo valor.*/

            /*
             Si mostramos el resultado por consola, comprobaréis que convierte a minúsculas todos los caracteres que previamente eran minúsculas
            pero los que ya se encontraban en minúsculas se conservan como tal*/
            Console.WriteLine(palabraMinuscula);


        }
    }
}
