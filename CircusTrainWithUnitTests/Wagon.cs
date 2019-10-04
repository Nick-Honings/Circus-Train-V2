using System.Collections.Generic;

namespace CircusTrainWithUnitTests
{
    public class Wagon
    {
        public int MaxCapacity { get; set; } = 10;
        public List<Animal> Animals { get; }

        public int Occupied { get; private set; } = 0;

        public Wagon()
        {
            Animals = new List<Animal>();
        }

        public bool IsAnimalAdded(Animal animal)
        {
            if (animal != null && DoesAnimalFit(animal))
            {
                if (DoesAnimalGetEaten(animal) == false)
                {
                    Animals.Add(animal);
                    Occupied += (int)animal.Size;
                    return true;
                }
            }
            return false;
        }

        private bool DoesAnimalFit(Animal animal)
        {
            if ((Occupied + (int)animal.Size) <= MaxCapacity)
            {
                return true;
            }
            return false;
        }

        private bool DoesAnimalGetEaten(Animal _animal)
        {
            int secondAnimalSize = (int)_animal.Size;
            foreach (Animal animal in Animals)
            {
                int firstAnimalSize = (int)animal.Size;
                
                if ((animal.FoodPreference == FoodPreference.Carnivore) && firstAnimalSize >= secondAnimalSize)
                {
                    return true;
                }
                else if (_animal.FoodPreference == FoodPreference.Carnivore && secondAnimalSize >= firstAnimalSize)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
