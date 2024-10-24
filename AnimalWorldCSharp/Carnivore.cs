using HerbivoreHierarchy;
using AnimalHierarchy;

namespace CarnivoreHierarchy
{
    public abstract class Carnivore: Animal
    {
        private int power;


        public int Power
        {
            get { return power; }
            set
            {
                try
                {
                    if (value > 0)
                        power = value;
                    else
                    {
                        power = 0;
                        IsAlive = false;
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }



        public Carnivore(int power)
        {
            Power = power;
            IsAlive = true;
        }

        public void Eat(Herbivore herb)
        {
            if(herb.IsAlive == false)
            {
                Console.WriteLine($"{Name} не может съесть мертвого {herb.Name}");
                return;
            }
            if (this.Power > herb.Weight)
            {
                this.Power += 10;
                Console.WriteLine($"{Name} покушало и теперь у него {Power} силы ");
                herb.IsAlive = false;
            }
            
            else if(this.Power < herb.Weight)
            {
                this.Power -= 10;
                this.IsAlive = false;
            }
        }
    }
}
