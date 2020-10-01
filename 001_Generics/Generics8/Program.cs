using System;

// Коваріантність узагальнень.
// Коваріантність узагальнень в C # 4.0 обмежена інтерфейсами і делегатами.

namespace Generics
{
    class Animal { }
    class Cat : Animal { }

    class Program
    {
        delegate T MyDelegate<out T>(); // out - Для значення, що повертається.

        public static Cat CatCreator()
        {
            return new Cat();
        }

        static void Main()
        {
            MyDelegate<Cat> delegateCat = new MyDelegate<Cat>(CatCreator);
            MyDelegate<Animal> delegateAnimal = delegateCat; // Від похідного до базового.

            Animal animal = delegateAnimal.Invoke();

            Console.WriteLine(animal.GetType().Name);

            // Delay.
            Console.ReadKey();
        }
    }
}