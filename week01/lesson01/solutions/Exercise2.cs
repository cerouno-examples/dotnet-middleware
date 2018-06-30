using System;

namespace Exercise2
{
    class Program
    {
        // 1.- Escribe un programa y pide al usuario que ingrese un número.
        // El número debe estar entre 1 y 100. Si el usuario ingresa un número válido, muestre "Válido" en la consola.
        // De lo contrario, muestre "Inválido".
        static void Main(string[] args)
        {
            Console.Write("Teclea un número:");
            string numeroEnCadena = Console.ReadLine();

            int numero = int.Parse(numeroEnCadena);

            if (numero >= 1 && numero <= 100)
            {
                Console.WriteLine("Número válido");
            }
            else
            {
                Console.WriteLine("Número inválido");
            }

            Console.ReadKey();
        }
    }
}
