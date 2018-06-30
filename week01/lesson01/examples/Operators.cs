namespace Lesson01
{
    class Operators
    {
        void ExampleMethod()
        {
            // a y c tendrán su valor default. Para enteros es cero
            int a, b = 1, c;

            // Operador de asignación
            a = 1;

            // Operadores aritméticos
            c = a + b;
            c = a - b;
            c = a / b;
            c = a * b;
            c = a % b;

            // Operadores de comparación
            bool greaterThan, lessThan, equals;

            greaterThan = a > b;
            lessThan = a < b;
            equals = a == b;

            // Operadores boleanos
            bool isTrueOrFalse;

            isTrueOrFalse = true && true;
            isTrueOrFalse = true && false;
            isTrueOrFalse = true || true;
            isTrueOrFalse = true || false;
            isTrueOrFalse = !true;
        }
    }
}
