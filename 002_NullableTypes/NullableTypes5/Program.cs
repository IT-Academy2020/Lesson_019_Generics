using System;

namespace NullableTypes
{
    class Program
    {
        static void Main()
        {
            Nullable<int> a = 1;

            if (a.HasValue == true)
            {
                Console.WriteLine("a is {0}.", a.Value);
            }

            // Коротка нотація Nullable типу - "?", Доступна тільки для C #.
            int? b = 1;

            if (b.HasValue == true)
            {
                Console.WriteLine("b is {0}", b.Value);
            }

            // Неявно типізована локальна змінна не може бути - Nullable.
            // var? c = null;

            // Delay.
            Console.ReadKey();
        }
    }
}