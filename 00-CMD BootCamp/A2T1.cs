using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2
{
    internal class A2T1

    {
        class Animal
        {
            string name;
            string species;
            int age;

            public Animal(string name, int age, string species) {
                this.name = name;
                this.species = species;
                this.age = age;
            }

            public virtual void eat() {
                Console.WriteLine("{0} is eating.", name);
            }
            public string getName() { return name; }
            public int getAge() { return age; }
            public string getSpecies() { return species;}
        }

        class Dog : Animal
        {
            public Dog(string name, int age, string species) : base(name, age, species)
            {
            }

            public override void eat()
            {
                Console.WriteLine("The {0} is licking bone.", getName());
            }

            public void Bark()
            {
                Console.WriteLine("Dog is barking.");
            }
        }
        class Lion : Animal
        {
            public Lion(string name, int age, string species) : base(name, age, species)
            {
            }
            public override void eat()
            {
                Console.WriteLine("The {0} is eating deer.", getName());
            }
            public void Roar()
            {
                Console.WriteLine("Lion is roaring.");
            }
        }
        class Elephant : Animal
        {
            public Elephant(string name, int age, string species) : base(name, age, species)
            {
            }
            public override void eat()
            {
                Console.WriteLine("The {0} is eating peanuts.", getName());
            }
            public void Trumpet()
            {
                Console.WriteLine("Elephant Trumpets.");
            }
        }
        class Zoo
        {
            List<Animal> animals;

            public Zoo(List<Animal> animals)
            {
                this.animals = animals;
            }

            public Zoo()
            {
                this.animals = new List<Animal>();
            }

            public void AddAnimal(Animal animal)
            {
                animals.Add(animal);
            }

            public void FeedAllAnimal()
            {
                foreach (Animal animal in animals)
                {
                    animal.eat();
                }
            }

        }


        static void Main(string[] args)
        {
            Zoo myZoo = new Zoo();
            Dog myDog = new Dog("Scooby", 3, "abc");
            Elephant myElephant = new Elephant("Hathi", 3, "abc");
            Lion myLion = new Lion("Mufasa", 3, "abc");

            myDog.Bark();
            myElephant.Trumpet();
            myLion.Roar();

            myZoo.AddAnimal(myDog);
            myZoo.AddAnimal(myElephant);
            myZoo.AddAnimal(myLion);
            myZoo.FeedAllAnimal();
        }
    }
}
