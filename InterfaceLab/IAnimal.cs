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
    internal interface IAnimal
    {
        string Name { get; set; }
        string Colour { get; set; } 
        double Height { get; set; }
        int Age { get; set; }

        void Eat();
        string Cry();
    }
}
