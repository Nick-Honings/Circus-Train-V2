using System;
using System.Collections.Generic;
using System.Linq;

namespace CircusTrainWithUnitTests
{
    public class SortAnimals
    {
        public List<Animal> BySizeAndFoodPreference(List<Animal> animals)
        {
            List<Animal> SortedAnimals = animals.OrderByDescending(o => o.FoodPreference).ToList();
            foreach (var animal in SortedAnimals)
            {
                Console.WriteLine("Food: " + animal.FoodPreference);
                Console.WriteLine("Size: " + animal.Size);
            }

            SortedAnimals = SortedAnimals.OrderByDescending(o => o.Size).ToList();

            Console.WriteLine("###########");

            foreach (var animal in SortedAnimals)
            {
                Console.WriteLine("Food: " + animal.FoodPreference);
                Console.WriteLine("Size: " + animal.Size);
            }
            return SortedAnimals;
        }


    }
}
