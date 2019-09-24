using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CircusTrainWithUnitTests.Test
{
    public class WagonTests
    {
        [Fact]
        public void AddAnimal_ShouldAddOneAnimalToList()
        {
            // Arrange
            int expected = 1;
            Wagon wagon = new Wagon();
            Animal animal = new Animal(1, 5);

            // Act
            wagon.AddAnimal(animal);
            int result = wagon.Animals.Count;

            // Assert
            Assert.Equal(expected, result);
            Assert.Equal(animal, wagon.Animals[0]);
        }
    }
}
