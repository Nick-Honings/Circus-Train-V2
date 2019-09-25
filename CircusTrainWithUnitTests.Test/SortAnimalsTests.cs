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
                new Animal(3, 0)
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
                new Animal(5,1),
                new Animal(5, 0),
                new Animal(3, 0),
                new Animal(1,1)
            };

            List<Animal> result = new List<Animal>()
            {
                new Animal(5, 0),
                new Animal(1,1),
                new Animal(5,1),
                new Animal(3, 0)
            };

            SortAnimals sortAnimals = new SortAnimals();

            // Act
            result = sortAnimals.BySizeAndFoodPreference(expected);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
