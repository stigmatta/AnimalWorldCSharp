
namespace CarnivoreHierarchy
{
    internal class Lion:Carnivore
    {
        private static readonly string name = "Lion";
        public override string Name => name;

        public Lion() : base(random.Next(300, 800)) { }

        public Lion(int power) : base(power) { }

    }
}
