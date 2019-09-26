using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace CircusTrainWithUnitTests
{
    class Program
    {
        static void Main(string[] args)
        {
            Platform platform = new Platform();
            platform.AddTrain(new Train());
            List<Animal> animals = platform.Spawnanimals(5);

            platform.Train.DistributeAnimals(animals);

            DisplayWagons.Display(platform.Train.Wagons);
        }
    }
}
