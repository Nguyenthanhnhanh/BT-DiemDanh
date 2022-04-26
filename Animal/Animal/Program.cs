using System;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class Animal
    {
        public void eat()
        { }
        public void makeSound()
        { }

    }
    class Cat: Animal
    {
        public void run()
        { }
    }
    class Bird: Animal
    {
        public void fly()
        { }
    }
}
