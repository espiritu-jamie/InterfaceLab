using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLab
{
    /// <summary>
    /// Interface Lab
    /// </summary>
    /// <remarks>Author: Jamie Marie Espiritu </remarks>
    /// <remarks>Date: Feb 18, 2023</remarks>
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();

            Console.WriteLine("Enter the dog's name: ");
            string dogName = Console.ReadLine();

            Console.WriteLine("Enter the dog's height: ");
            double dogHeight = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the dog's colour: ");
            string dogColour = Console.ReadLine();

            Console.WriteLine("Enter the dog's age: ");
            int dogAge = int.Parse(Console.ReadLine());



            dog.Name = dogName;
            dog.Height = dogHeight;
            dog.Colour = dogColour;
            dog.Age = dogAge;

            dog.Eat();
            Console.WriteLine(dog.Cry());

            Cat cat = new Cat();

            Console.WriteLine("Enter the cat's name:");
            string catName = Console.ReadLine();

            Console.WriteLine("Enter the cat's height:");
            double catHeight = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the cat's colour:");
            string catColour = Console.ReadLine();

            Console.WriteLine("Enter the cat's age:");
            int catAge = int.Parse(Console.ReadLine());

            cat.Name = catName;
            cat.Height = catHeight;
            cat.Colour = catColour;
            cat.Age = catAge;

            cat.Eat();
            Console.WriteLine(cat.Cry());

            List<IAnimal> animals = new List<IAnimal>();

            animals.Add(dog);
            animals.Add(cat);

            Console.WriteLine("The names of the animals are: ");

            foreach (IAnimal animal in animals)
            {
                Console.WriteLine(animal.Name);   
            }

            


        }
    }
}
