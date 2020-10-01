using System;

// Універсальні шаблони. (Універсальний делегат)

namespace Generics
{
    // На 11-му рядку створюємо клас-делегата з іменем MyDelegate, параметризований двома параметрами типу - Т і R,
    // метод, на який буде посилатись даний клас-делегат, буде приймати один аргумент, типу - Т,
    // і повертати значення типу - R.

    delegate R MyDelegate<T, R>(T t);

    class Program
    {
        public static int Add(int i)
        {
            return ++i;
        }

        public static string Concatenation(string s)
        {
            return "Hello" + s + "!";
        }


        static void Main()
        {
            MyDelegate<int, int> myDelegate1 = new MyDelegate<int, int>(Add);
            int i = myDelegate1.Invoke(1);
            Console.WriteLine(i);

            MyDelegate<string, string> myDelegate2 = new MyDelegate<string, string>(Concatenation);
            string s = myDelegate2("Alex");
            Console.WriteLine(s);

            // Delay.
            Console.ReadKey();
        }
    }
}