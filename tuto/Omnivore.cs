using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tuto.Interfaces;

namespace tuto
{
    internal class Omnivore : Animal, IViande, IVegetal
    {
        public Omnivore(string name) : base(name)
        {
        }

        public void MangerPlante()
        {
            Console.WriteLine("Miam du miel");
        }

        public void MangerViande()
        {
            Console.WriteLine("Miam du jambon");
        }
    }
}
