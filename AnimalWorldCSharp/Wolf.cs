namespace CarnivoreHierarchy
{
    internal class Wolf:Carnivore
    {
        private static readonly string name = "Wolf";
        public override string Name => name;

        public Wolf() : base(random.Next(100, 500)) { }

        public Wolf(int power) : base(power) { }
    }
}
