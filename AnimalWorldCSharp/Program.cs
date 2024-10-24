
using AnimalWorldClass;
using ContinentHierarchy;

Continent continent = new Australia();

AnimalWorld animalWorld = new AnimalWorld(continent);
animalWorld.HerbivoreMeal();
animalWorld.CarnivoreMeal();
animalWorld.CarnivoreMeal();
