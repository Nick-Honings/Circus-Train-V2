using FluentAssertions;
using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace CircusTrainWithUnitTests.Test
{
    public class WagonTests
    {
        public class OneAnimal
        {
            [Fact]
            public void AddAnimal_ShouldWork()
            {
                // Arrange
                int expected = 1;
                Wagon wagon = new Wagon();
                Animal animal = new Animal(Size.Large, FoodPreference.Carnivore);

                // Act
                wagon.IsAnimalAdded(animal);
                int result = wagon.Animals.Count;

                // Assert
                Assert.Equal(expected, result);
                Assert.Equal(animal, wagon.Animals[0]);
            }
        }

        public class MultipleAnimal
        {

            [Fact]
            public void AddAnimal_ShouldFailWithLargeCarnivore()
            {
                // Arrange
                int expected = 1;
                Wagon wagon = new Wagon();
                Animal bigCarnivore = new Animal(Size.Large, FoodPreference.Carnivore);
                Animal mediumHerbivore = new Animal(Size.Large, FoodPreference.Carnivore);


                // Act
                wagon.IsAnimalAdded(bigCarnivore);
                wagon.IsAnimalAdded(mediumHerbivore);
                int result = wagon.Animals.Count;

                // Assert
                Assert.Equal(expected, result);
                //bigCarnivore.Should().BeEquivalentTo(wagon.Animals[0]);
                Assert.Equal(bigCarnivore, wagon.Animals[0]);
            }

            [Theory]
            [InlineData(Size.Large, FoodPreference.Herbivore)]
            [InlineData(Size.Small, FoodPreference.Herbivore)]
            [InlineData(Size.Medium, FoodPreference.Carnivore)]
            public void AddAnimal_ShouldWork(Size size, FoodPreference foodPreference)
            {
                // Arrange
                int expected = 2;
                Wagon wagon = new Wagon();
                Animal bigCarnivore = new Animal(Size.Large, FoodPreference.Herbivore);
                Animal mediumHerbivore = new Animal(size, foodPreference);

                // Act
                wagon.IsAnimalAdded(bigCarnivore);
                wagon.IsAnimalAdded(mediumHerbivore);
                int result = wagon.Animals.Count;

                // Assert
                Assert.Equal(expected, result);
                Assert.Equal(bigCarnivore, wagon.Animals[0]);
            }

            [Theory]
            // if carnivore in wagon is bigger or equal in size of animal trying to add
            [InlineData(Size.Large, FoodPreference.Carnivore, Size.Large, FoodPreference.Carnivore)]
            [InlineData(Size.Large, FoodPreference.Carnivore, Size.Large, FoodPreference.Herbivore)]
            [InlineData(Size.Large, FoodPreference.Carnivore, Size.Small, FoodPreference.Carnivore)]
            [InlineData(Size.Large, FoodPreference.Carnivore, Size.Small, FoodPreference.Herbivore)]

            // if carnivore trying to add is bigger or equal in zie of animal in container
            [InlineData(Size.Small, FoodPreference.Herbivore, Size.Small, FoodPreference.Carnivore)]
            [InlineData(Size.Large, FoodPreference.Herbivore, Size.Large, FoodPreference.Carnivore)]
            [InlineData(Size.Small, FoodPreference.Carnivore, Size.Small, FoodPreference.Carnivore)]

            public void AddAnimal_ShouldFail(Size firstAnimalSize, FoodPreference firstFoodPreference, Size secAnimalSize, FoodPreference secFoodPreference)
            {
                // Arrange
                int expected = 1;
                Wagon wagon = new Wagon();
                Animal firstAnimal = new Animal(firstAnimalSize, firstFoodPreference);
                Animal secondAnimal = new Animal(secAnimalSize, secFoodPreference);

                // Act
                wagon.IsAnimalAdded(firstAnimal);
                wagon.IsAnimalAdded(secondAnimal);
                int result = wagon.Animals.Count;

                // Assert
                Assert.Equal(expected, result);
                Assert.Equal(firstAnimal, wagon.Animals[0]);
            }
        }

        //[Theory]
        //[InlineData(0, 5, true)]
        //[InlineData(5, 3, true)]
        //[InlineData(9, 1, true)]
        //public void DoesAnimalFit_ShouldReturnTrue(int occupied, int size, bool expected)
        //{
        //    // Arrange
        //    Wagon wagon = new Wagon
        //    {
        //        Occupied = occupied
        //    };
        //    Animal animal = new Animal(size, 1);

        //    // Act
        //    bool result = wagon.DoesAnimalFit(animal);

        //    // Assert
        //    Assert.Equal(expected, result);
        //}

        //[Theory]
        //[InlineData(10, 1, false)]
        //[InlineData(9, 3, false)]
        //public void DoesAnimalFit_ShouldReturnFalse(int occupied, int size, bool expected)
        //{
        //    // Arrange
        //    Wagon wagon = new Wagon
        //    {
        //        Occupied = occupied
        //    };
        //    Animal animal = new Animal(size, 1);

        //    // Act
        //    bool result = wagon.DoesAnimalFit(animal);

        //    // Assert
        //    Assert.Equal(expected, result);
        //}

        //[Theory]
        //[InlineData(5, 1)]
        //[InlineData(1, 1)]
        //[InlineData(5, 0)]
        //[InlineData(1, 0)]
        //public void DoesAnimalGetEaten_ShouldReturnTrue(int size, int foodpreference)
        //{
        //    // Arrange
        //    Wagon wagon = new Wagon();
        //    wagon.IsAnimalAdded(new Animal(5, 1));
        //    Animal animal = new Animal(size, foodpreference);

        //    // Act
        //    bool result = wagon.DoesAnimalGetEaten(animal);

        //    // Assert
        //    Assert.True(result);
        //}

        //[Theory]
        //[InlineData(5, 0)]
        //[InlineData(3, 0)]
        //public void DoesAnimalGetEaten_ShouldReturnFalse(int size, int foodpreference)
        //{
        //    // Arrange
        //    Wagon wagon = new Wagon();
        //    wagon.IsAnimalAdded(new Animal(1, 1));
        //    Animal animal = new Animal(size, foodpreference);

        //    // Act
        //    bool result = wagon.DoesAnimalGetEaten(animal);

        //    // Assert
        //    Assert.False(result);
        //}
    }
}