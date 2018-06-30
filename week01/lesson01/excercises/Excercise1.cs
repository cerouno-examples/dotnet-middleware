using System;

namespace Excercise1
{
    class Program
    {
        // Escribe un programa en C# que realice las siguientes operaciones con dos números (considera a=5 y b =7):
        // - Imprimir la suma de a y b
        // - Imprimir un incremento de a con el operador “++”
        // - Residuo de 7 dividido por 5
        // - Comparar si el residuo del paso anterior es mayor que a.Imprimir su representación lógica.
        static void Main(string[] args)
        {
            int a = 5;
            int b = 7;

            int sum = a + b;

            // Suma de a y b
            Console.WriteLine(sum);

            // Incremento
            Console.Write(a++); // post-incremento
            Console.WriteLine(++a); // pre-incremento

            // Residuo
            Console.WriteLine(a % b);

            // Comparar
            Console.WriteLine((a % b) > a);

            Console.ReadKey();
        }
    }
}
