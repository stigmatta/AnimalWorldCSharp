using CarnivoreHierarchy;
using HerbivoreHierarchy;

namespace ContinentHierarchy
{
    public abstract class Continent
    {
        public abstract string Name { get; }
        public abstract Herbivore CreateHerbivore();
        public abstract Carnivore CreateCarnivore();
    }
}
