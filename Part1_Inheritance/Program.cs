using System;

namespace OOP_Inheritance
{
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }

    class Snake : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Hiss");
        }
    }

    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal genericAnimal = new Animal();
            Snake snake = new Snake();
            Cat cat = new Cat();

            genericAnimal.MakeSound();
            snake.MakeSound();
            cat.MakeSound();
        }
    }
}
