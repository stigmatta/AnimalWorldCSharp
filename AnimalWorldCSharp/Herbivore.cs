using AnimalHierarchy;

namespace HerbivoreHierarchy
{
    public abstract class Herbivore:Animal
    {
        private int weight;

        public int Weight
        {
            get { return weight; }
            set
            {
                if (value > 0)
                {
                    weight = value;
                }
                else
                {
                    Weight = 0;
                    IsAlive = false;
                }
            }
        }

        public Herbivore(int weight)
        {
            Weight = weight;
            IsAlive = true;
        }

        public void EatGrass()
        {
            if (IsAlive)
            {
                Weight += 10;
                Console.WriteLine($"{Name} покушало и теперь весит {Weight} кг.");
            }
            else
            {
                Console.WriteLine("Травоядное не может есть, так как мертво.");
            }
        }
    }
}
