using CarnivoreHierarchy;
using HerbivoreHierarchy;

namespace ContinentHierarchy
{
    internal class Australia : Continent
    {
        private readonly string name = "Australia";
        public override string Name => name;

        public override Carnivore CreateCarnivore()
        {
            return new Tasmanian();
        }

        public override Herbivore CreateHerbivore()
        {
            return new Kangaroo();
        }
    }
}

