using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tuto.Interfaces;

namespace tuto
{
    internal class Carnivore : Animal, IViande
    {
        public Carnivore(string name) : base(name)
        {
        }

        public void MangerViande()
        {
            Console.WriteLine("Miam du gibier");
        }
    }
}
