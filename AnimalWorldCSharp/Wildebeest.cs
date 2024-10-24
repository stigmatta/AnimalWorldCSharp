
namespace HerbivoreHierarchy
{
    internal class Wildebeest : Herbivore
    {
        private static readonly string name = "Wildebeest"; 

        public override string Name => name; 

        public Wildebeest() : base(random.Next(150, 270)) { }

        public Wildebeest(int weight) : base(weight) { }

    }
}
