using System;
using System.Collections.Generic;

namespace CircusTrainWithUnitTests
{
    public class CalculateLowerBound
    {
        //Not used in this project. Was trying some optimalization for the future.
        public int Calculate(List<Animal> animals)
        {
            double totalSize = 0;
            double bigCarnivores = 0;
            foreach (Animal a in animals)
            {
                totalSize += (int)a.Size;
                if (a.Size == Size.Large && a.FoodPreference == FoodPreference.Carnivore)
                {
                    bigCarnivores++;
                    totalSize -= 5;
                }
                
            }
            double totalWagons = (totalSize / 10) + bigCarnivores;

            return (int)Math.Ceiling(totalWagons);
        }

    }
}
