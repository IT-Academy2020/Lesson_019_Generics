using System;

namespace NullableTypes
{
    class Program
    {
        static void Main()
        {
            // a - містить невідоме значення.
            int? a = null;
            int? b = -5; // b = -5

            // При порівнянні операндів один з яких = null - результатом порівняння завжди буде - false.
            // Отже, не можна розраховувати на істинність (правильність) результату.
            if (a >= b)
            {
                Console.WriteLine("a> = b");
            }
            else
            {
                Console.WriteLine("a <b");
            }

            // Порівнювати операнди (Nullable) є сенс тільки для перевірки - обидва чи містять null?
            // І якщо обидва операнда містять null, то результатом порівняння буде - true.

            b = null;

            if (a == b)
            {
                Console.WriteLine("a == b");
            }
            else
            {
                Console.WriteLine("a! = B");
            }

            // Delay.
            Console.ReadKey();
        }
    }
}