using CarnivoreHierarchy;
using ContinentHierarchy;
using HerbivoreHierarchy;

namespace AnimalWorldClass
{
    public class AnimalWorld
    {
        private readonly Continent continent;

        private Herbivore[] herbArr = new Herbivore[10];
        private Carnivore[] carnArr = new Carnivore[10];

        public Continent Cont => continent;


        public AnimalWorld(Continent continent)
        {
            this.continent = continent;
            for(int i = 0; i < 10; i++)
            {
                herbArr[i] = Cont.CreateHerbivore();
                carnArr[i] = Cont.CreateCarnivore();
            }
        }

        public void HerbivoreMeal()
        {
            for(int i = 0;i<herbArr.Length;i++) {
                herbArr[i].EatGrass();
            }
        }

        public void CarnivoreMeal()
        {
            for (int i = 0; i < herbArr.Length; i++)
            {
                carnArr[i].Eat(herbArr[i]);
            }
        }


    }
}
