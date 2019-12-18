using FluentAssertions;
using System.Collections.Generic;
using Xunit;

namespace CircusTrainWithUnitTests.Test
{
    public class SortAnimalsTests
    {
        #region Setup
        List<Animal> expected;
        List<Animal> result;
        SortAnimals sortAnimals;

        public SortAnimalsTests()
        {
            expected = new List<Animal>();
            result = new List<Animal>();
            sortAnimals = new SortAnimals();
        }

        #endregion


        #region BySizeAndFoodPreference
        [Fact]
        public void BySizeAndFoodPreference_Should_Sort_With_Zero_Entries()
        {
            // Arrange        

            // Act
            result = sortAnimals.BySizeAndFoodPreference(expected);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void BySizeAndFoodPreference_Should_Sort_With_One_Entries()
        {
            // Arrange
            expected.Add(new Animal(Size.Medium, FoodPreference.Herbivore));

            // Act
            result = sortAnimals.BySizeAndFoodPreference(expected);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void BySizeAndFoodPreference_Should_Sort_With_Multiple_Entries()
        {
            // Arrange
            expected.Add(new Animal(Size.Large, FoodPreference.Carnivore));
            expected.Add(new Animal(Size.Small, FoodPreference.Carnivore));
            expected.Add(new Animal(Size.Large, FoodPreference.Herbivore));
            expected.Add(new Animal(Size.Medium, FoodPreference.Herbivore));

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
        #endregion
    }
}
