using System;
using System.Collections.Generic;
using System.Text;

namespace CircusTrainWithUnitTests
{
    public class Platform
    {
        private Train train;


        public Platform()
        {

        }

        public Train Train
        {
            get { return train; }
        }

        public List<Animal> Spawnanimals(int number)
        {
            List<Animal> animals = new List<Animal>();
            int[] size = { 1, 3, 5 };
            int[] foodpreference = { 0, 1 };
            Random rnd = new Random();

            for (int i = 0; i < number; i++)
            {
                animals.Add(new Animal(size[rnd.Next(size.Length)], foodpreference[rnd.Next(foodpreference.Length)]));
                Console.WriteLine("size: " + animals[i].Size + "food preference: " + animals[i].FoodPreference);
            }
            return animals;
        }

    }
}
