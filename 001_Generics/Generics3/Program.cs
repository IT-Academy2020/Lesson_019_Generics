using System;
using System.Text;

// Універсальні шаблони. (Універсальний метод)

namespace Generics
{
    class MyClass
    {
        public void Method<T>(T argument)
        {
            T variable = argument;

            Console.WriteLine(variable);
        }
    }

    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            MyClass instance = new MyClass();

            instance.Method<string>("Hello world!");

            instance.Method("Привіт світ!");

            // Delay.
            Console.ReadKey();
        }
    }
}