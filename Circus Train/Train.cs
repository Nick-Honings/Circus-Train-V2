using System;
using System.Collections.Generic;

namespace Circus_Train
{
    public class Train
    {
        public int NumberofWagons { get; private set; } = 0;

        public List<Wagon> Wagons { get; private set; }

        private CountBigCarnivores countBigCarnivores;

        public Train()
        {
            Wagons = new List<Wagon>();
            countBigCarnivores = new CountBigCarnivores();
        }

        private void AddWagon(Wagon wagon)
        {
            Wagons.Add(wagon);
            NumberofWagons += 1;
        }

        public void FillTrain(List<Animal> animals)
        {
            int bigCarnivores = countBigCarnivores.Count(animals);
            Console.WriteLine("Big carnivores: " + bigCarnivores);
            for (int i = 0; i < bigCarnivores; i++)
            {
                AddWagon(new Wagon());
                Wagons[i].DoesAnimalFit(animals[i]);
                animals.RemoveAt(i);
            }

            Console.WriteLine(animals.Count);

            for (int i = 0; i < animals.Count; i++)
            {
                int bestWagon = -1;
                for (int j = 0; j < Wagons.Count; j++)
                {
                    if (Wagons[j].DoesAnimalFit(animals[i]))
                    {
                        Console.WriteLine("Animal added");
                        break;
                    }
                    else
                    {
                        AddWagon(new Wagon());
                        //break;
                    }
                }


                if (bestWagon != -1)
                {
                    //Wagons[bestWagon].DoesAnimalFit(animals[i]);                    
                }
            }
            Console.WriteLine("Number of wagons: " + Wagons.Count);
        }
    }
}
