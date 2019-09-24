using System;
using System.Collections.Generic;
using System.Text;

namespace Circus_Train
{
    public class DisplayWagons
    {
        public static void Display(List<Wagon> wagons)
        {
            for (int i = 0; i < wagons.Count; i++)
            {
                Console.ReadLine();
                Console.WriteLine("Wagon: " +i);

                for (int j = 0; j < wagons[i].Animals.Count; j++)
                {
                    Console.WriteLine("Size:                 " + wagons[i].Animals[j].Size);
                    Console.WriteLine("Food Preference:      " + wagons[i].Animals[j].FoodPreference);
                }
                Console.WriteLine("RemainingCapacity:   "+wagons[i].GetRemainingCapacity());
                Console.WriteLine("################");
            }
        }
    }
}
