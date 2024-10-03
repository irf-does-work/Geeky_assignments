using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsUsingAbstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 =  new Dog("Levi","WOOF");
            Cat cat1 = new  Cat("Cookies","MEOW");
            Bird bird1 = new Bird("Crow","KAWWWW");

            dog1.MakeSound();
            cat1.MakeSound();
            bird1.MakeSound();
        }
    }

    abstract class Animal
    {
        public abstract string Name { get; set; }
        public abstract string Sound { get; set; }

        public abstract void MakeSound();

    }

    class Dog : Animal
    {
        public override string Name {  get; set; }
        public override string Sound {  get; set; }
        public Dog(string name,string sound)
        {
            this.Name=name;
            this.Sound=sound;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Doggy " +Name + " says " +Sound); 
        }
    }
    class Cat : Animal
    {
        public override string Name { get; set; }
        public override string Sound { get; set; }
        public Cat(string name, string sound)
        {
            this.Name = name;
            this.Sound = sound;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Catto " + Name + " says " + Sound);
        }
    }
    class Bird : Animal
    {
        public override string Name { get; set; }
        public override string Sound { get; set; }
        public Bird(string name, string sound)
        {
            this.Name = name;
            this.Sound = sound;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Bird " + Name + " says " + Sound);
        }
    }

}
