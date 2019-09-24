using System;
using System.Collections.Generic;
using System.Text;

namespace CircusTrainWithUnitTests
{
    public class Animal
    {
        public Animal(int size, int foodPreference)
        {
            Size = size;
            FoodPreference = foodPreference;
        }
        public int Size { get; set; }

        //0: Herbivore
        //1: Carnivore
        public int FoodPreference { get; set; }
    }
}
