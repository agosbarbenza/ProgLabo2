using System;
using System.Drawing;

namespace Ejercicio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string numeroIngresado;
            double numero;
            double cuadrado;
            double cubo;

            Console.WriteLine("Ingrese un número:");
            numeroIngresado = Console.ReadLine();
            bool respuesta = double.TryParse(numeroIngresado, out numero);

            while (!respuesta || numero < 1)
            {
                Console.WriteLine("ERROR. ¡Reingresar número!");
                numeroIngresado = Console.ReadLine();

                respuesta = double.TryParse(numeroIngresado, out numero);
            }

            cuadrado = Math.Pow(numero, 2);
            cubo = Math.Pow(numero, 3);

            Console.WriteLine("Cuadrado de {0}: {1}\nCubo de {0}: {2}", numero, cuadrado, cubo);


        }
    }
}