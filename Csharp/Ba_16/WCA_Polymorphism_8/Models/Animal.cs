using System;
using System.Collections.Generic;
using System.Text;

namespace WCA_Polymorphism_8.Models
{
    public class Animal
    {
        public string Kind { get; set; }
        public string Name { get; set; }
        public virtual string AnimalSound() 
        {
            return "Base animal sound";
        }
        
        //private string _color; //ctrl +r +e to encapsulate
    }
    public class Bird : Animal
    {
        public bool CanFly { get; set; }
        public bool CanRun { get; set; }
        public override string AnimalSound()
        {
            
            return "chirp chirp!!";
        }

    }

    public class Dog : Animal
    {
        public override string AnimalSound()
        {

            return "Bark Bark!!";
        }
    }
    public class Cat : Animal
    {
        public bool Domestic { get; set; }
        public override string AnimalSound()
        {

            return "meow meow!!";
        }
    }
    public class Pig : Animal
    {
        public override string AnimalSound()
        {

            return "Oink Oink!!";
        }
        public bool Edible { get; set; }
    }
}
