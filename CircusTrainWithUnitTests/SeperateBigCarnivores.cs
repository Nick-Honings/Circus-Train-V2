using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrainWithUnitTests
{
    public class SeperateBigCarnivores
    {
        public List<Wagon> Seperate(List<Animal> animals)
        {
            List<Wagon> wagons = new List<Wagon>();
            int wagonCount = 0;
            for(int i = 0; i < animals.Count; i++)
            {
                if(animals[i].FoodPreference == 1 && animals[i].Size == 5)
                {
                    wagons.Add(new Wagon());
                    wagons[wagonCount].AddAnimal(animals[i]);
                    wagonCount++;
                }
            }
            return wagons;
        }
    }
}
