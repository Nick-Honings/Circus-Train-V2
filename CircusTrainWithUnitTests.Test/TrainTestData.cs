using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrainWithUnitTests.Test
{
    public class TrainTestData : IEnumerable<object[]>
    {
        #region Set 1
        //Set 1: H1x5, H3x3, H5x1, C1x0, C3x0, 

        List<Animal> set1 = new List<Animal>()
        {
            new Animal(Size.Small, FoodPreference.Herbivore),
            new Animal(Size.Small, FoodPreference.Herbivore),
            new Animal(Size.Small, FoodPreference.Herbivore),
            new Animal(Size.Small, FoodPreference.Herbivore),
            new Animal(Size.Small, FoodPreference.Herbivore),
            new Animal(Size.Medium, FoodPreference.Herbivore),
            new Animal(Size.Medium, FoodPreference.Herbivore),
            new Animal(Size.Medium, FoodPreference.Herbivore),
            new Animal(Size.Large, FoodPreference.Herbivore),
        };

        List<Wagon> expected1 = new List<Wagon>()
        {
            new Wagon()
            {
                Animals = new List<Animal>()
                {
                    new Animal(Size.Large, FoodPreference.Herbivore),
                    new Animal(Size.Medium, FoodPreference.Herbivore),
                    new Animal(Size.Small, FoodPreference.Herbivore),
                    new Animal(Size.Small, FoodPreference.Herbivore)                    
                }
            },
            new Wagon()
            {
                Animals = new List<Animal>()
                {
                    new Animal(Size.Medium, FoodPreference.Herbivore),
                    new Animal(Size.Medium, FoodPreference.Herbivore),
                    new Animal(Size.Small, FoodPreference.Herbivore),
                    new Animal(Size.Small, FoodPreference.Herbivore),
                    new Animal(Size.Small, FoodPreference.Herbivore)
                }
            }
        };

        #endregion

        #region Set 2
        // H5x3, C1x1, C3x3, C5x2

        List<Animal> set2 = new List<Animal>()
        {
            new Animal(Size.Large, FoodPreference.Herbivore),
            new Animal(Size.Large, FoodPreference.Herbivore),
            new Animal(Size.Large, FoodPreference.Herbivore),
            new Animal(Size.Small, FoodPreference.Carnivore),
            new Animal(Size.Medium, FoodPreference.Carnivore),
            new Animal(Size.Medium, FoodPreference.Carnivore),
            new Animal(Size.Medium, FoodPreference.Carnivore),
            new Animal(Size.Large, FoodPreference.Carnivore),
            new Animal(Size.Large, FoodPreference.Carnivore),
        };

        List<Wagon> expected2 = new List<Wagon>()
        {
            new Wagon()
            {
                Animals = new List<Animal>()
                {
                    new Animal(Size.Large, FoodPreference.Carnivore)
                }
            },
            new Wagon()
            {
                Animals = new List<Animal>()
                {
                    new Animal(Size.Large, FoodPreference.Carnivore)
                }
            },
            new Wagon()
            {
                Animals = new List<Animal>()
                {
                    new Animal(Size.Medium, FoodPreference.Carnivore),
                    new Animal(Size.Large, FoodPreference.Herbivore)
                }
            },
            new Wagon()
            {
                Animals = new List<Animal>()
                {
                    new Animal(Size.Medium, FoodPreference.Carnivore),
                    new Animal(Size.Large, FoodPreference.Herbivore)
                }
            },
            new Wagon()
            {
                Animals = new List<Animal>()
                {
                    new Animal(Size.Medium, FoodPreference.Carnivore),
                    new Animal(Size.Large, FoodPreference.Herbivore)
                }
            },
            new Wagon()
            {
                Animals = new List<Animal>()
                {
                    new Animal(Size.Small, FoodPreference.Carnivore)
                }
            }
        };



        #endregion

        #region Set 3
        // H1x5, H3x5, H5x5, C1x2, C3x3, C5x2

        List<Animal> set3 = new List<Animal>()
        {
            new Animal(Size.Small, FoodPreference.Herbivore),
            new Animal(Size.Small, FoodPreference.Herbivore),
            new Animal(Size.Small, FoodPreference.Herbivore),
            new Animal(Size.Small, FoodPreference.Herbivore),
            new Animal(Size.Small, FoodPreference.Herbivore),
            new Animal(Size.Medium, FoodPreference.Herbivore),
            new Animal(Size.Medium, FoodPreference.Herbivore),
            new Animal(Size.Medium, FoodPreference.Herbivore),
            new Animal(Size.Medium, FoodPreference.Herbivore),
            new Animal(Size.Medium, FoodPreference.Herbivore),
            new Animal(Size.Large, FoodPreference.Herbivore),
            new Animal(Size.Large, FoodPreference.Herbivore),
            new Animal(Size.Large, FoodPreference.Herbivore),
            new Animal(Size.Large, FoodPreference.Herbivore),
            new Animal(Size.Large, FoodPreference.Herbivore),
            new Animal(Size.Small, FoodPreference.Carnivore),
            new Animal(Size.Small, FoodPreference.Carnivore),
            new Animal(Size.Medium, FoodPreference.Carnivore),
            new Animal(Size.Medium, FoodPreference.Carnivore),
            new Animal(Size.Medium, FoodPreference.Carnivore),
            new Animal(Size.Large, FoodPreference.Carnivore),
            new Animal(Size.Large, FoodPreference.Carnivore)
        };


        #endregion

        #region Set 4
        // H1x1, H3x3, H5x2
        List<Animal> set4 = new List<Animal>()
        {
            new Animal(Size.Small, FoodPreference.Herbivore),
            new Animal(Size.Medium, FoodPreference.Herbivore),
            new Animal(Size.Medium, FoodPreference.Herbivore),
            new Animal(Size.Medium, FoodPreference.Herbivore),
            new Animal(Size.Large, FoodPreference.Herbivore),
            new Animal(Size.Large, FoodPreference.Herbivore)
        };


        #endregion

        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] {set1, expected1};
            yield return new object[] {set2, expected2};
            //yield return new object[] {set3, 8};
            //yield return new object[] {set4, 2};
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

}
