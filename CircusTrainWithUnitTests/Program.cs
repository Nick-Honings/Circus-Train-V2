using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace CircusTrainWithUnitTests
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            Platform platform = new Platform();
            platform.AddTrain(new Train());
            List<Animal> animals = platform.Spawnanimals(10);

            platform.Train.DistributeAnimals(animals);

            DisplayWagons.Display(platform.Train.Wagons);

        }
    }
}
