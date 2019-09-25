using System;
using System.Collections.Generic;

namespace Circus_Train
{
    public class Platform
    {
        private Train train;
        private SortAnimals sortAnimals;

        public Platform()
        {
            sortAnimals = new SortAnimals();
        }

        public Train Train
        {
            get { return train; }
        }
        public void AddTrain(Train _train)
        {
            train = _train;
            Console.WriteLine("A Train entered the station");
        }

        public List<Animal> SpawnAnimals(int number)
        {
            List<Animal> animals = new List<Animal>();
            int[] size = { 1, 3, 5 };
            int[] foodPreference = { 0, 1 };
            Random rnd = new Random();

            for (int i = 0; i < number; i++)
            {
                animals.Add(new Animal(size[rnd.Next(size.Length)], foodPreference[rnd.Next(foodPreference.Length)]));
                Console.WriteLine("Size: " + animals[i].Size + "Food Preference: " + animals[i].FoodPreference);
            }
            return sortAnimals.BySizeAndFoodPreference(animals);
        }

    }
}
