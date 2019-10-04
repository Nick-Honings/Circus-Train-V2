using FluentAssertions;
using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace CircusTrainWithUnitTests.Test
{
    public class WagonTests
    {
        #region AddAnimal Tests


        public class OneAnimal
        {
            #region Setup
            Wagon wagon;
            Animal emptyAnimal;

            public OneAnimal()
            {
                wagon = new Wagon();                
            }

            #endregion

            [Fact]
            public void AddAnimal_ShouldWorkAndReturnTrue()
            {
                // Arrange
                int expected = 1;
                Wagon wagon = new Wagon();
                Animal animal = new Animal(Size.Large, FoodPreference.Carnivore);

                // Act
                bool isAdded = wagon.IsAnimalAdded(animal);
                int result = wagon.Animals.Count;

                // Assert
                Assert.Equal(expected, result);
                Assert.Equal(animal, wagon.Animals[0]);
                Assert.True(isAdded);
            }

            [Fact]
            public void AddAnimal_ShouldNotAddEmptyClassAndReturnFalse()
            {
                // Arrange
                int expected = 0;
                
                // Act
                bool isAdded = wagon.IsAnimalAdded(emptyAnimal);
                int result = wagon.Animals.Count;

                // Assert
                Assert.Equal(expected, result);
                Assert.False(isAdded);
            }
        }
        public class MultipleAnimal
        {
            #region LargeCarnivore
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
                Assert.Equal(bigCarnivore, wagon.Animals[0]);
            }
            #endregion

            #region Big Herbivore
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

            #endregion


            #region Multiple combinations
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
            #endregion

        }
        #endregion
    }
}