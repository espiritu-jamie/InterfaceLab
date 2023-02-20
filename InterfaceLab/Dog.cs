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
    internal class Dog : IAnimal
    {
        private string name;
        private string colour;
        private double height;
        private int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Colour
        {
            get { return colour; }
            set { colour = value; }
        }
        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public void Eat()
        {
            Console.WriteLine("Dogs eat meat.");
        }

        public string Cry()
        {
            return "Woof!";
        }

    }
}
