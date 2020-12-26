using System;
using WCA_Polymorphism_8.Models;

namespace WCA_Polymorphism_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Kind = "Danua";
            dog.Name = "çomar";

            Cat cat = new Cat();
            cat.Kind = "Munchkin";
            cat.Name = "pati";

            Bird bird = new Bird();
            bird.Kind = "Parrot";
            bird.Name = "bıcırık";

            Pig pig = new Pig();
            pig.Kind = "Peppa";
            pig.Name = "Peppa";


            Console.WriteLine($@"
Dog Sound   :{dog.AnimalSound()}
Cat Sound   :{cat.AnimalSound()}
Bird Sound  :{bird.AnimalSound()}
Pig Sound   :{pig.AnimalSound()}");
            
        }
    }
}
