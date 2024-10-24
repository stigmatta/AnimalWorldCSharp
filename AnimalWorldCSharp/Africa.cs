using CarnivoreHierarchy;
using HerbivoreHierarchy;

namespace ContinentHierarchy
{
    internal class Africa:Continent
    {
        private readonly string name = "Africa";
        public override string Name => name;

        public override Carnivore CreateCarnivore()
        {
            return new Lion();
        }

        public override Herbivore CreateHerbivore()
        {
            return new Wildebeest();
        }
    }
}

