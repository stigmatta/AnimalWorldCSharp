
namespace HerbivoreHierarchy
{
    internal class Bison:Herbivore
    {
        private readonly static string name = "Bison";
        public override string Name => name;

        public Bison() : base(random.Next(450,1200)) { }

        public Bison(int weight) : base(weight) { }
    }
}
