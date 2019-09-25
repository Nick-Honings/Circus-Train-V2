using System;
using System.Collections.Generic;

namespace CircusTrainWithUnitTests
{
    public class Platform
    {
        public Train Train { get; set; }


        public void AddTrain(Train _train)
        {
            if (Train == null)
            {
                Train = _train;
            }
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
            }
            return animals;
        }
    }
}
