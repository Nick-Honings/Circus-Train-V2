using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CircusTrainWithUnitTests;
using Xunit;

namespace CircusTrainWithUnitTests.Test
{
    
    public class PlatformTests
    {
        

        [Fact]
        public void SpawnAnimals_ShouldSpawnZeroAnimals()
        {
            // Arrange
            int expected = 0;
            Platform platform = new Platform();           

            // Act
            int actual = platform.Spawnanimals(0).Count;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SpawnAnimals_ShouldSpawnOneAnimals()
        {
            // Arrange
            int expected = 1;
            Platform platform = new Platform();

            // Act
            int actual = platform.Spawnanimals(1).Count;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SpawnAnimals_ShouldSpawnMultipleAnimals()
        {
            // Arrange
            int expected = 5;
            Platform platform = new Platform();

            // Act
            int actual = platform.Spawnanimals(5).Count;

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
