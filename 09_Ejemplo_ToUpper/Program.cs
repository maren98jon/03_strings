/*Igual que podemos convertir los caracteres de un string a minúsculas, como en el ejemplo anterior, también podemos convertirlos
 a mayúsculas. Y, para ello, utilizamos el método ToUpper(). Veamos el ejemplo*/

using System;

namespace _09_Ejemplo_ToUpper
{
    class Program
    {
        static void Main(string[] args)
        {
           // En este caso asignamos a la variable (palabra) una cadena con los caracteres en minúscula.
            string palabra = "supercalifragilisticoespialidoso";
            //Después utilizamos el método ToUpper() para convertir los caracteres en mayúscula. 
            string palabraMayus = palabra.ToUpper();
            //Y por último, mostramos por consola el valor de la variable dónde almacenamos la cadena en mayúsculas.
            Console.WriteLine(palabraMayus);
        }
    }
}
