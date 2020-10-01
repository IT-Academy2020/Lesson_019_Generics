using System;

// Універсальні шаблони.

namespace Generics
{
    // На 9-му рядку створюємо клас з іменем MyClass, параметризованим параметром типу - T

    class MyClass<T>
    {
        public T field;

        public void Method()
        {
            Console.WriteLine(field.GetType());
        }
    }

    class Program
    {
        static void Main()
        {
            // Створюємо екземпляр класу MyClass і в якості параметра типу T передаємо тип int.
            MyClass<int> instance1 = new MyClass<int>();
            instance1.Method();

            // Створюємо екземпляр класу MyClass і в якості параметра типу T передаємо тип long.
            MyClass<long> instance2 = new MyClass<long>();
            instance2.Method();

            // Створюємо екземпляр класу MyClass і в якості параметра типу T передаємо тип string.
            MyClass<string> instance3 = new MyClass<string>();
            instance3.field = "ABC";
            instance3.Method();

            // Delay.
            Console.ReadKey();
        }
    }
}