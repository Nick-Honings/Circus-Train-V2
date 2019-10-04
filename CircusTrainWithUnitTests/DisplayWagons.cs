using System;
using System.Collections.Generic;

namespace CircusTrainWithUnitTests
{
    public class Display
    {
        public static void DisplayWagons(List<Wagon> wagons)
        {
            for (int i = 0; i < wagons.Count; i++)
            {
                Console.WriteLine("_____________________________________________________________________");
                Console.WriteLine("Wagon: " + i);

                for (int j = 0; j < wagons[i].Animals.Count; j++)
                {
                    Console.WriteLine("Size:                 " + wagons[i].Animals[j].Size);
                    Console.WriteLine("Food Preference:      " + wagons[i].Animals[j].FoodPreference);
                }
                Console.WriteLine("Occupied space:   " + wagons[i].Occupied);
                Console.WriteLine("################");
            }
            Console.ReadLine();
        }

    }
}
