using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animals
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Dog d1 = new Dog();
            Cat c1 = new Cat();
            Bird b1 = new Bird();

            d1.Sound();
            c1.Sound();
            b1.Sound();
            Console.ReadLine();
        }
    }
    public class Animal
    {
        public string Name { get; set; }

        public virtual void Sound()
        {
            Console.WriteLine("Animal makes a sound.");
        }
    }

    public class Dog : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Dog says Woof");
        }
    }

    public class Cat : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Cat says Meow");
        }
    }

    public class Bird : Animal
    {     
        public override void Sound()
        {
            Console.WriteLine("Bird says Chirp");
        }
    }

    
}


