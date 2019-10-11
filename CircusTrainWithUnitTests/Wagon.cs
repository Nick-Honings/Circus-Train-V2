using System.Collections.Generic;

namespace CircusTrainWithUnitTests
{
    public class Wagon
    {
        public int MaxCapacity { get; set; } = 10;
        public List<Animal> Animals { get;set; }

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

        /// <summary>
        /// NOT USED IN THIS PROJECT
        /// Reapproach: best fit instead of first fit.
        /// 
        /// 
        /// 1. Pre set number of bins, so there has to be a way to calculate bins.
        /// 2. All unfilled bins are left unopen.
        /// 3. It places the next item j in the bin whose current 
        ///    contents(SUM(AnimalSizes)) are the largest.
        ///    but do not exceed Capacity - qj(so the item fits).
        /// 4. If it fits, put it in. If not, open a new bin.
        /// 
        /// 
        /// INITIALIZATION
        /// Calculate lower bound
        /// ?? SUM(AnimalSizes)/capacity + NUM(C5) ??
        /// ?? NUM(C5) = number of big carnivores. ??
        /// 
        /// Given a list of item weights L = {Animal1, Animal2, ..., Animaln}
        /// Place Animal1 in Wagon1 and remove from L. Let j=2,m=1(First loop, second loop var)
        /// 
        /// Iterations:
        ///   1. Find wagon whose remaining capacity is minimum but greater than qj
        ///      and put it in. If j doesn't fit anywhere, open a new wagon, number it m+1.
        ///      Place j in m + 1 and let m = m + 1.
        ///   2. Remove animal j from L. Let j = j+1.
        ///   3. While animals remain in L, repeat from step 1. 
        /// 
        /// </summary>

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
                //Not put two big herbivores in one container
                else if(_animal.Size == Size.Large && animal.Size == Size.Large)
                {
                    return false;
                }
            }
            return false;
        }
    }
}
