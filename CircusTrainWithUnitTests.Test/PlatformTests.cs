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

        [Fact]
        public void AddTrain_ShouldAddTrain()
        {
            // Arrange            
            Platform platform = new Platform();
            Train expected = new Train();

            // Act
            platform.AddTrain(expected);

            // Assert
            Assert.NotNull(platform.Train);
            Assert.Equal(expected, platform.Train);
        }

        [Fact]
        public void AddTrain_ShouldNotAddTrain()
        {
            // Arrange
            Platform platform = new Platform();
            Train expected = new Train();
            Train train2 = new Train();
            platform.AddTrain(expected);

            // Act
            platform.AddTrain(train2);

            // Assert
            Assert.Equal(expected, platform.Train);
        }
    }
}
