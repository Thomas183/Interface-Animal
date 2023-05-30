using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tuto.Interfaces;

namespace tuto
{
    internal class Herbivore : Animal, IVegetal
    {
        public Herbivore(string name) : base(name)
        {
        }

        public void MangerPlante()
        {
            Console.WriteLine("Miam de l'herbe");
        }
    }
}
