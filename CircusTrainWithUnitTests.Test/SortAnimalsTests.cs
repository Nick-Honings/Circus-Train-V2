using FluentAssertions;
using System.Collections.Generic;
using Xunit;

namespace CircusTrainWithUnitTests.Test
{
    public class SortAnimalsTests
    {
        [Fact]
        public void BySizeAndFoodPreference_Should_Sort_With_Zero_Entries()
        {
            // Arrange            
            List<Animal> expected = new List<Animal>();
            List<Animal> result = new List<Animal>();

            SortAnimals sortAnimals = new SortAnimals();

            // Act
            result = sortAnimals.BySizeAndFoodPreference(expected);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void BySizeAndFoodPreference_Should_Sort_With_One_Entries()
        {
            List<Animal> expected = new List<Animal>()
            {
                new Animal(Size.Medium, FoodPreference.Herbivore)
            };

            List<Animal> result = new List<Animal>();
            SortAnimals sortAnimals = new SortAnimals();

            // Act
            result = sortAnimals.BySizeAndFoodPreference(expected);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void BySizeAndFoodPreference_Should_Sort_With_Multiple_Entries()
        {
            // Arrange
            List<Animal> expected = new List<Animal>()
            {
                new Animal(Size.Large,FoodPreference.Carnivore),
                new Animal(Size.Small, FoodPreference.Carnivore),
                new Animal(Size.Large, FoodPreference.Herbivore),
                new Animal(Size.Medium,FoodPreference.Herbivore)
            };

            List<Animal> result = new List<Animal>()
            {
                new Animal(Size.Small, FoodPreference.Carnivore),
                new Animal(Size.Large,FoodPreference.Herbivore),
                new Animal(Size.Medium, FoodPreference.Herbivore),
                new Animal(Size.Large,FoodPreference.Carnivore)
                
            };

            SortAnimals sortAnimals = new SortAnimals();

            // Act
            result = sortAnimals.BySizeAndFoodPreference(result);

            // Assert
            //Assert.Equal(expected, result);
            expected.Should().BeEquivalentTo(result);
        }
    }
}
