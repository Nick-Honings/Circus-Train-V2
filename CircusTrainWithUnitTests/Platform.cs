using System;
using System.Collections.Generic;

namespace CircusTrainWithUnitTests
{
    public class Platform
    {
        public Train Train { get; set; }
        private SortAnimals sortAnimals;


        public void AddTrain(Train _train)
        {
            if (Train == null)
            {
                Train = _train;
            }
        }

        public List<Animal> Spawnanimals(int number)
        {
            sortAnimals = new SortAnimals();
            List<Animal> animals = new List<Animal>();

            Array foodPreferences = Enum.GetValues(typeof(FoodPreference));
            Array sizes = Enum.GetValues(typeof(Size));

            Random rnd = new Random();

            for (int i = 0; i < number; i++)
            {                
                FoodPreference randomFoodPreference = (FoodPreference)foodPreferences.GetValue(rnd.Next(foodPreferences.Length));
                Size randomSize = (Size)sizes.GetValue(rnd.Next(sizes.Length));
                animals.Add(new Animal(randomSize, randomFoodPreference));
            }
            return sortAnimals.BySizeAndFoodPreference(animals);
        }
    }
}
