using System;
using System.Collections.Generic;
using System.Linq;

namespace CircusTrainWithUnitTests
{
    public class SortAnimals
    {
        public List<Animal> BySizeAndFoodPreference(List<Animal> animals)
        {
            //List<Animal> SortedAnimals = animals.OrderByDescending(o => o.Size).ToList();
            List<Animal> SortedAnimals = animals.OrderBy(o => o.FoodPreference).ThenByDescending(o => o.Size).ToList();

            return SortedAnimals;
        }


    }
}
