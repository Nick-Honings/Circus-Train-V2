using System;
using System.Collections.Generic;
using System.Text;

namespace CircusTrainWithUnitTests
{
    public class Wagon
    {
        public int MaxCapacity { get; set; } = 10;
        public List<Animal> Animals { get; }

        private int occupied = 0;

        public Wagon()
        {
            Animals = new List<Animal>();
        }

        public void AddAnimal(Animal animal)
        {
            Animals.Add(animal);
        }
    }
}
