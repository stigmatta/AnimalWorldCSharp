
namespace HerbivoreHierarchy
{
    internal class Kangaroo : Herbivore
    {
        private static readonly string name = "Kangaroo";

        public override string Name => name;

        public Kangaroo() : base(random.Next(18, 45)) { }

        public Kangaroo(int weight) : base(weight) { }

    }
}
