using System.Collections.Generic;

namespace Circus_Train
{
    public class Wagon
    {
        public int MaxCapacity { get; set; } = 10;

        private int occupied = 0;

        public Wagon()
        {
            Animals = new List<Animal>();
        }

        public bool DoesAnimalFit(Animal _animal)
        {
            if (MaxCapacity - occupied >= _animal.Size)
            {
                if (_animal.Size == 5 && _animal.FoodPreference == 1 && Animals.Count > 0)
                {
                    return false;
                }
                else
                {
                    Animals.Add(_animal);
                    occupied += _animal.Size;
                    return true;
                }
            }
            return false;
        }

        //public bool AddAnimal(Animal _animal)
        //{
        //    int occupied = 0;
        //    foreach (Animal animal in animals)
        //    {
        //        occupied += animal.Size;
        //    }
        //    if (MaxCapacity - occupied >= 0)
        //    {
        //        animals.Add(_animal);
        //        return true;
        //    }

        //    return false;
        //}





        //public void AddAnimal(Animal _animal)
        //{
        //    int occupied = 0;
        //    foreach (Animal animal in animals)
        //    {
        //        occupied += animal.Size;
        //    }
        //    if(MaxCapacity - occupied >= _animal.Size)
        //    {
        //        animals.Add(_animal);
        //    }
        //}

        public int GetRemainingCapacity()
        {
            int occupied = 0;
            foreach (Animal animal in Animals)
            {
                occupied += animal.Size;
            }
            return MaxCapacity - occupied;
        }

        public List<Animal> Animals { get; }
    }

}
