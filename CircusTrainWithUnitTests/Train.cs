using BenchmarkDotNet.Attributes;
using System.Collections.Generic;
using System.Diagnostics;

namespace CircusTrainWithUnitTests
{
    public class Train
    {
        public int NumberofWagons { get; private set; } = 0;

        public List<Wagon> Wagons { get; private set; }        

        public Train()
        {
            Wagons = new List<Wagon>();
        }

        public void AddWagon(Wagon wagon)
        {
            if (wagon != null)
            {
                Wagons.Add(wagon);
                NumberofWagons++; 
            }
        }

        public void DistributeAnimals(List<Animal> animals)
        {
            AddWagon(new Wagon());
            for (int i = 0; i < animals.Count; i++)
            {
                for (int j = 0; j < Wagons.Count; j++)
                {
                    if (Wagons[j].IsAnimalAdded(animals[i]))
                    {
                        break;
                    }
                    if(Wagons.Count == j + 1)
                    {
                        AddWagon(new Wagon());
                    }                                  
                }
            }
        }


    }
}
