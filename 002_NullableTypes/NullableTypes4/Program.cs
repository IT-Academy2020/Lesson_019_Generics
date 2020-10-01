using System;
using System.Text;

namespace NullableTypes
{
    // Значення за замовчуванням для NullableTypes == null.

    class Program
    {
        static int? i;

        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            if (i == null)
            {
                Console.WriteLine("null");
            }
            else if (i == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine("Інша ...");
            }

            // Delay.
            Console.ReadKey();
        }
    }
}