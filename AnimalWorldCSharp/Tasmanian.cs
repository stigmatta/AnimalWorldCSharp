namespace CarnivoreHierarchy
{
    internal class Tasmanian : Carnivore
    {
        private static readonly string name = "Tasmanian";
        public override string Name => name;

        public Tasmanian() :base(random.Next(30, 150)) { }

        public Tasmanian(int power) : base(power) { }
    }
}
