using CarnivoreHierarchy;
using HerbivoreHierarchy;

namespace ContinentHierarchy
{
    internal class NorthAmerica : Continent
    {
        private readonly string name = "North America";
        public override string Name => name;

        public override Carnivore CreateCarnivore()
        {
            return new Wolf();
        }

        public override Herbivore CreateHerbivore()
        {
            return new Bison();
        }
    }
}

