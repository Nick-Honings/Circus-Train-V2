using System;
using System.Collections.Generic;
using System.Text;

namespace CircusTrainWithUnitTests
{
    public class Train
    {
        public int NumberofWagons { get;private set; } = 0;

        public List<Wagon> Wagons { get; private set; }

        private SeperateBigCarnivores carnivores;

        
        public Train()
        {
            Wagons = new List<Wagon>();
            carnivores = new SeperateBigCarnivores();
        }
        
        public void AddWagon(Wagon wagon)
        {
            Wagons.Add(wagon);
            NumberofWagons++;
        }
    }
}
