namespace AnimalHierarchy
{
    public abstract class Animal
    {
        private bool isAlive;

        protected static Random random = new Random();

        public bool IsAlive
        {
            get
            {
                if (!isAlive)
                    Console.WriteLine($"{Name} мертв(-а)");
                return isAlive;
            }
            set { isAlive = value; }
        }

        public abstract string Name { get; }
    }
}
