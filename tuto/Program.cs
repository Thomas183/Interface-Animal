using tuto.Interfaces;
namespace tuto

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal jerry = new Carnivore("Jerry");
            Animal willi = new Omnivore("Willi");
            Animal logan = new Herbivore("Logan");
            List<Animal> animals = new List<Animal>();
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                int choix = rnd.Next(0, 3);
                Animal michel = null;
                switch (choix)
                {
                    case 0:
                        michel = new Carnivore("Michel");
                        break;
                    case 1:
                        michel = new Omnivore("Michel");
                        break;
                    case 2:
                        michel = new Herbivore("Michel");
                        break;
                }
                animals.Add(michel);
            }

            animals.Add(jerry);
            animals.Add(willi);
            animals.Add(logan);

            //IViande mangeurDeViande = (IViande)jerry;
            //mangeurDeViande.MangerViande();
            foreach(Animal animal in animals)
            {
                Console.Write($"{animal.Name} : ");
                Manger(animal);
            }
        }
        public static void Manger(Animal animal)
        {
            if(animal is IViande viandeAnimal)
            {
                viandeAnimal.MangerViande();
            }
            if(animal is IVegetal vegetalAnimal)
            {
                vegetalAnimal.MangerPlante();
            }
        }

    }
}