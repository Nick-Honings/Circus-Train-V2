using System.Collections.Generic;

namespace Circus_Train
{
    public class CountBigCarnivores
    {
        public int Count(List<Animal> animals)
        {
            int numbBigCarnivores = 0;
            foreach (Animal animal in animals)
            {
                if (animal.FoodPreference == 1 && animal.Size == 5)
                    numbBigCarnivores++;
            }
            return numbBigCarnivores;
        }

    }
}
