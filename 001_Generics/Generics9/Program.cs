using System;

// Контрваріантність узагальнень.
// Контрваріантність узагальнень в C # 4.0 обмежена делегатами.

namespace Generics
{
    class Animal { }
    class Cat : Animal { }

    class Program
    {
        delegate void MyDelegate<in T>(T a); // in - Для аргументу.

        public static void CatUser(Animal animal)
        {
            Console.WriteLine(animal.GetType().Name);
        }

        static void Main()
        {

            MyDelegate<Animal> delegateAnimal = new MyDelegate<Animal>(CatUser);
            MyDelegate<Cat> delegateCat = delegateAnimal; // Від базового до похідного.

            delegateAnimal(new Animal());
            delegateCat(new Cat());

            // delegateCat (new Animal ()); // Неможливо.

            // Delay.
            Console.ReadKey();
        }
    }
}