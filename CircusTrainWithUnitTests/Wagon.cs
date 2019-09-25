using System.Collections.Generic;

namespace CircusTrainWithUnitTests
{
    public class Wagon
    {
        public int MaxCapacity { get; set; } = 10;
        public List<Animal> Animals { get; }

        public int Occupied { get; set; } = 0;

        public Wagon()
        {
            Animals = new List<Animal>();
        }

        public bool IsAnimalAdded(Animal animal)
        {
            if (DoesAnimalFit(animal))
            {
                if (DoesAnimalGetEaten(animal) == false)
                {
                    Animals.Add(animal);
                    Occupied += animal.Size;
                    return true;
                }
            }
            return false;
        }


        private bool DoesAnimalFit(Animal animal)
        {
            if ((Occupied + animal.Size) <= MaxCapacity)
            {
                return true;
            }
            return false;
        }

        private bool DoesAnimalGetEaten(Animal _animal)
        {
            foreach (Animal animal in Animals)
            {
                // Every carnivore bigger than the other animal
                if ((animal.FoodPreference == 1) && animal.Size >= _animal.Size)
                {
                    return true;
                }
                else if (_animal.FoodPreference == 1 && _animal.Size >= animal.Size)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
