namespace Lesson01
{
    class Conditionals
    {
        public void ExampleMethod()
        {
            bool condition = true;

            // ---------------
            // EJEMPLO if
            if (condition)
            {
                // Si condition es verdadera, hacer algo aquí
            }

            // ---------------
            // EJEMPLO if-else
            if (condition)
            {
                // Si condition es verdadera, hacer algo aquí
            }
            else
            {
                // Si es falso, hacer algo aquí
            }

            // ---------------
            // EJEMPLO if-elseif
            int a = 1;
            if (a == 1)
            {
                // Si condition es verdadera, hacer algo aquí
            }
            else if (a == 2)
            {
                // else-if nos puede ayudar a evitar anidaciones de if-else
            }
            else if (a == 3)
            {
                // Y así sucesivamente...
            }

            // ---------------
            // EJEMPLO switch
            char option = 'a';
            switch (option)
            {
                case 'a':
                {
                    // Si option es 'a', se cumple este caso
                } break; // break es utilizado para "romper" el switch y no validar el resto de los case
                case 'b':
                {
                    // Si option es 'b', se cumple este caso
                } break;
                default:
                {
                        // El comportamiento por defecto se considera en el bloque default.
                        // Para este caso, cuando option no es 'a' ni es 'b'
                } break;
            }
        }
    }
}
